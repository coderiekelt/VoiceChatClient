namespace Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonToggle = new System.Windows.Forms.Button();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListInput = new System.Windows.Forms.ListBox();
            this.ListOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonToggle
            // 
            this.ButtonToggle.Location = new System.Drawing.Point(396, 10);
            this.ButtonToggle.Name = "ButtonToggle";
            this.ButtonToggle.Size = new System.Drawing.Size(102, 23);
            this.ButtonToggle.TabIndex = 0;
            this.ButtonToggle.Text = "Connect";
            this.ButtonToggle.UseVisualStyleBackColor = true;
            this.ButtonToggle.Click += new System.EventHandler(this.ButtonToggle_Click);
            // 
            // TextAddress
            // 
            this.TextAddress.Location = new System.Drawing.Point(12, 12);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(378, 20);
            this.TextAddress.TabIndex = 1;
            this.TextAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the correct devices.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output device";
            // 
            // ListInput
            // 
            this.ListInput.FormattingEnabled = true;
            this.ListInput.Location = new System.Drawing.Point(12, 64);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(240, 290);
            this.ListInput.TabIndex = 5;
            this.ListInput.SelectedIndexChanged += new System.EventHandler(this.ListInput_SelectedIndexChanged);
            // 
            // ListOutput
            // 
            this.ListOutput.FormattingEnabled = true;
            this.ListOutput.Location = new System.Drawing.Point(258, 64);
            this.ListOutput.Name = "ListOutput";
            this.ListOutput.Size = new System.Drawing.Size(240, 290);
            this.ListOutput.TabIndex = 6;
            this.ListOutput.SelectedIndexChanged += new System.EventHandler(this.ListOutput_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 370);
            this.Controls.Add(this.ListOutput);
            this.Controls.Add(this.ListInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.ButtonToggle);
            this.Name = "FrmMain";
            this.Text = "Voice Chat Client";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonToggle;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListInput;
        private System.Windows.Forms.ListBox ListOutput;
    }
}

