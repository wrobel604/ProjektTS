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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Adress = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TextAdress = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.TextPort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Adress);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.TextAdress);
            this.panel1.Controls.Add(this.PortBox);
            this.panel1.Controls.Add(this.TextPort);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 77);
            this.panel1.TabIndex = 6;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(3, 16);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(100, 20);
            this.Adress.TabIndex = 1;
            this.Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(3, 43);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(170, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Połącz";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // TextAdress
            // 
            this.TextAdress.AutoSize = true;
            this.TextAdress.Location = new System.Drawing.Point(3, 0);
            this.TextAdress.Name = "TextAdress";
            this.TextAdress.Size = new System.Drawing.Size(47, 13);
            this.TextAdress.TabIndex = 0;
            this.TextAdress.Text = "Adres IP";
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(112, 16);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(64, 21);
            this.PortBox.TabIndex = 2;
            // 
            // TextPort
            // 
            this.TextPort.AutoSize = true;
            this.TextPort.Location = new System.Drawing.Point(109, 0);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(26, 13);
            this.TextPort.TabIndex = 3;
            this.TextPort.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 107);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label TextAdress;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label TextPort;
    }
}

