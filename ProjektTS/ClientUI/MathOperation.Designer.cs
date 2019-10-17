namespace ClientUI
{
    partial class MathOperation
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
            this.NumberX = new System.Windows.Forms.TextBox();
            this.NumberY = new System.Windows.Forms.TextBox();
            this.OperacjaBox = new System.Windows.Forms.ComboBox();
            this.SendResult = new System.Windows.Forms.Button();
            this.StatusMenu = new System.Windows.Forms.StatusStrip();
            this.StatusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WynikBox = new System.Windows.Forms.TextBox();
            this.DataText = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberX
            // 
            this.NumberX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberX.Location = new System.Drawing.Point(12, 36);
            this.NumberX.Name = "NumberX";
            this.NumberX.Size = new System.Drawing.Size(80, 38);
            this.NumberX.TabIndex = 1;
            this.NumberX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberX.TextChanged += new System.EventHandler(this.NumberX_TextChanged);
            // 
            // NumberY
            // 
            this.NumberY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberY.Location = new System.Drawing.Point(184, 36);
            this.NumberY.Name = "NumberY";
            this.NumberY.Size = new System.Drawing.Size(80, 38);
            this.NumberY.TabIndex = 2;
            this.NumberY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberY.TextChanged += new System.EventHandler(this.NumberX_TextChanged);
            // 
            // OperacjaBox
            // 
            this.OperacjaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperacjaBox.FormattingEnabled = true;
            this.OperacjaBox.Items.AddRange(new object[] {
            "Dodaj",
            "Odejmij",
            "Mnożenie",
            "Dzielenie",
            "Potega x^y",
            "Perwiastek x^(1/y)",
            "log_x(y)",
            "Silnia x!"});
            this.OperacjaBox.Location = new System.Drawing.Point(98, 35);
            this.OperacjaBox.Name = "OperacjaBox";
            this.OperacjaBox.Size = new System.Drawing.Size(80, 39);
            this.OperacjaBox.TabIndex = 3;
            this.OperacjaBox.SelectedIndexChanged += new System.EventHandler(this.OperacjaBox_SelectedIndexChanged);
            // 
            // SendResult
            // 
            this.SendResult.Location = new System.Drawing.Point(12, 80);
            this.SendResult.Name = "SendResult";
            this.SendResult.Size = new System.Drawing.Size(357, 48);
            this.SendResult.TabIndex = 4;
            this.SendResult.Text = "Wynik";
            this.SendResult.UseVisualStyleBackColor = true;
            // 
            // StatusMenu
            // 
            this.StatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusTitle,
            this.StatusValue,
            this.DataText,
            this.Data});
            this.StatusMenu.Location = new System.Drawing.Point(0, 148);
            this.StatusMenu.Name = "StatusMenu";
            this.StatusMenu.ShowItemToolTips = true;
            this.StatusMenu.Size = new System.Drawing.Size(379, 22);
            this.StatusMenu.TabIndex = 19;
            this.StatusMenu.Text = "Status:  ";
            // 
            // StatusTitle
            // 
            this.StatusTitle.Name = "StatusTitle";
            this.StatusTitle.Size = new System.Drawing.Size(88, 17);
            this.StatusTitle.Text = "Status serwera: ";
            // 
            // StatusValue
            // 
            this.StatusValue.Name = "StatusValue";
            this.StatusValue.Size = new System.Drawing.Size(80, 17);
            this.StatusValue.Text = "Niepołączono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Operacja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "=";
            // 
            // WynikBox
            // 
            this.WynikBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WynikBox.Location = new System.Drawing.Point(289, 36);
            this.WynikBox.Name = "WynikBox";
            this.WynikBox.ReadOnly = true;
            this.WynikBox.Size = new System.Drawing.Size(80, 38);
            this.WynikBox.TabIndex = 24;
            this.WynikBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataText
            // 
            this.DataText.Name = "DataText";
            this.DataText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataText.Size = new System.Drawing.Size(128, 17);
            this.DataText.Spring = true;
            this.DataText.Text = "Czas:";
            this.DataText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Data
            // 
            this.Data.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(37, 17);
            this.Data.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Wynik";
            // 
            // MathOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 170);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WynikBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusMenu);
            this.Controls.Add(this.SendResult);
            this.Controls.Add(this.OperacjaBox);
            this.Controls.Add(this.NumberY);
            this.Controls.Add(this.NumberX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MathOperation";
            this.Text = "MathOperation";
            this.StatusMenu.ResumeLayout(false);
            this.StatusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberX;
        private System.Windows.Forms.TextBox NumberY;
        private System.Windows.Forms.ComboBox OperacjaBox;
        private System.Windows.Forms.Button SendResult;
        private System.Windows.Forms.StatusStrip StatusMenu;
        private System.Windows.Forms.ToolStripStatusLabel StatusTitle;
        private System.Windows.Forms.ToolStripStatusLabel StatusValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel DataText;
        private System.Windows.Forms.ToolStripStatusLabel Data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WynikBox;
        private System.Windows.Forms.Label label5;
    }
}