namespace ClientUI
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TextPort = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.TextAdress = new System.Windows.Forms.Label();
            this.Logi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Polecenie = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ConnectButton);
            this.splitContainer1.Panel1.Controls.Add(this.TextPort);
            this.splitContainer1.Panel1.Controls.Add(this.PortBox);
            this.splitContainer1.Panel1.Controls.Add(this.Adress);
            this.splitContainer1.Panel1.Controls.Add(this.TextAdress);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Send);
            this.splitContainer1.Panel2.Controls.Add(this.Polecenie);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.Logi);
            this.splitContainer1.Size = new System.Drawing.Size(625, 305);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(15, 51);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(170, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Połącz";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TextPort
            // 
            this.TextPort.AutoSize = true;
            this.TextPort.Location = new System.Drawing.Point(118, 9);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(26, 13);
            this.TextPort.TabIndex = 3;
            this.TextPort.Text = "Port";
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(121, 24);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(64, 21);
            this.PortBox.TabIndex = 2;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(15, 25);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(100, 20);
            this.Adress.TabIndex = 1;
            this.Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Adress.TextChanged += new System.EventHandler(this.Adress_TextChanged);
            // 
            // TextAdress
            // 
            this.TextAdress.AutoSize = true;
            this.TextAdress.Location = new System.Drawing.Point(12, 9);
            this.TextAdress.Name = "TextAdress";
            this.TextAdress.Size = new System.Drawing.Size(47, 13);
            this.TextAdress.TabIndex = 0;
            this.TextAdress.Text = "Adres IP";
            // 
            // Logi
            // 
            this.Logi.Location = new System.Drawing.Point(3, 25);
            this.Logi.Multiline = true;
            this.Logi.Name = "Logi";
            this.Logi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Logi.Size = new System.Drawing.Size(398, 239);
            this.Logi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Komunikacja";
            // 
            // Polecenie
            // 
            this.Polecenie.Location = new System.Drawing.Point(6, 270);
            this.Polecenie.Name = "Polecenie";
            this.Polecenie.Size = new System.Drawing.Size(314, 20);
            this.Polecenie.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(326, 270);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 3;
            this.Send.Text = "Wyślij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 305);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label TextAdress;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label TextPort;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox Polecenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Logi;
    }
}

