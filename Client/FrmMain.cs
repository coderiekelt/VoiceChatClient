using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using Lidgren.Network;

namespace Client
{
    public partial class FrmMain : Form
    {
        private WaveOut WaveOut;
        private WaveIn WaveIn;
        private BufferedWaveProvider WaveProvider;

        private bool Connected;

        private NetPeerConfiguration ClientConfiguration;
        private NetClient Client;

        public FrmMain()
        {
            InitializeComponent();

            ClientConfiguration = new NetPeerConfiguration("Voice");
            Client = new NetClient(ClientConfiguration);
            Client.Start();

            Connected = false;

            this.WaveOut = new WaveOut();
            this.WaveIn = new WaveIn();

            this.WaveProvider = new BufferedWaveProvider(this.WaveIn.WaveFormat);

            WaveIn.DataAvailable += this.WaveAvailable;

            this.WaveOut.Init(this.WaveProvider);

            Client.RegisterReceivedCallback(this.MessageReceived);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int WaveInDevices = WaveIn.DeviceCount;
            for (int WaveInDevice = 0; WaveInDevice < WaveInDevices; WaveInDevice++)
            {
                WaveInCapabilities DeviceInfo = WaveIn.GetCapabilities(WaveInDevice);
                ListInput.Items.Add(String.Format("{0}", DeviceInfo.ProductName));
            }

            int WaveOutDevices = WaveOut.DeviceCount;
            for (int WaveOutDevice = 0; WaveOutDevice < WaveInDevices; WaveOutDevice++)
            {
                WaveOutCapabilities DeviceInfo = WaveOut.GetCapabilities(WaveOutDevice);
                ListOutput.Items.Add(String.Format("{0}", DeviceInfo.ProductName));
            }
        }

        private void WaveAvailable(object Sender, WaveInEventArgs Args)
        {
            NetOutgoingMessage Broadcast = Client.CreateMessage();
            Broadcast.Write(Args.Buffer);
            this.Client.SendMessage(Broadcast, NetDeliveryMethod.ReliableOrdered);
            this.Client.FlushSendQueue();
        }

        private void ReceiveBuffer(byte[] Buffer)
        {
            this.WaveProvider.AddSamples(Buffer, 0, Buffer.Length);
        }

        private void MessageReceived(object Peer)
        {
            NetIncomingMessage Message = Client.ReadMessage();

            if (Message.MessageType == NetIncomingMessageType.Data)
            {
                this.WaveProvider.AddSamples(Message.ReadBytes(Message.LengthBytes), 0, Message.LengthBytes);
            }
        }

        private void ListInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.WaveIn.StopRecording();
            this.WaveIn.DeviceNumber = ListInput.SelectedIndex;
            this.WaveIn.StartRecording();
        }

        private void ListOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.WaveOut.PlaybackState == PlaybackState.Playing)
            {
                this.WaveOut.Stop();
            }

            this.WaveOut.DeviceNumber = ListOutput.SelectedIndex;
            this.WaveOut.Play();
        }

        private void ButtonToggle_Click(object sender, EventArgs e)
        {
            if (!Connected)
            {
                this.ButtonToggle.Text = "Disconnect";
                this.Client.Connect(this.TextAddress.Text, 27000);
            }
            else
            {
                this.ButtonToggle.Text = "Connect";
                this.Client.Disconnect("Bye!");
            }

            this.Connected = !this.Connected;
        }
    }
}
