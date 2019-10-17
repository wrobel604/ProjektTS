namespace ClientUI
{
    partial class Kalkulator
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
            this.TextResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSilnia = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusMenu = new System.Windows.Forms.StatusStrip();
            this.StatusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataText = new System.Windows.Forms.ToolStripStatusLabel();
            this.Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.StatusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextResult
            // 
            this.TextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextResult.Location = new System.Drawing.Point(12, 12);
            this.TextResult.Name = "TextResult";
            this.TextResult.ReadOnly = true;
            this.TextResult.Size = new System.Drawing.Size(311, 38);
            this.TextResult.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSilnia);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.buttonRoot);
            this.panel1.Controls.Add(this.buttonSquare);
            this.panel1.Controls.Add(this.buttonDivide);
            this.panel1.Controls.Add(this.buttonMultiply);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonResult);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonDot);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 247);
            this.panel1.TabIndex = 17;
            // 
            // buttonSilnia
            // 
            this.buttonSilnia.Location = new System.Drawing.Point(247, 186);
            this.buttonSilnia.Name = "buttonSilnia";
            this.buttonSilnia.Size = new System.Drawing.Size(55, 55);
            this.buttonSilnia.TabIndex = 36;
            this.buttonSilnia.Text = "x!";
            this.buttonSilnia.UseVisualStyleBackColor = true;
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(247, 125);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(55, 55);
            this.buttonLog.TabIndex = 35;
            this.buttonLog.Text = "log_x(y)";
            this.buttonLog.UseVisualStyleBackColor = true;
            // 
            // buttonRoot
            // 
            this.buttonRoot.Location = new System.Drawing.Point(247, 64);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(55, 55);
            this.buttonRoot.TabIndex = 34;
            this.buttonRoot.Text = "x^(1/y)";
            this.buttonRoot.UseVisualStyleBackColor = true;
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(247, 3);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(55, 55);
            this.buttonSquare.TabIndex = 33;
            this.buttonSquare.Text = "x^y";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(186, 186);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(55, 55);
            this.buttonDivide.TabIndex = 32;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(186, 125);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(55, 55);
            this.buttonMultiply.TabIndex = 31;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(186, 64);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(55, 55);
            this.buttonMinus.TabIndex = 30;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(186, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(55, 55);
            this.buttonPlus.TabIndex = 29;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(125, 186);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(55, 55);
            this.buttonResult.TabIndex = 28;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(3, 186);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(55, 55);
            this.button0.TabIndex = 27;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(64, 186);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(55, 55);
            this.buttonDot.TabIndex = 26;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(125, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 25;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(64, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 24;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 23;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(125, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 22;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 21;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 20;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusMenu
            // 
            this.StatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusTitle,
            this.StatusValue,
            this.DataText,
            this.Data});
            this.StatusMenu.Location = new System.Drawing.Point(0, 310);
            this.StatusMenu.Name = "StatusMenu";
            this.StatusMenu.ShowItemToolTips = true;
            this.StatusMenu.Size = new System.Drawing.Size(344, 22);
            this.StatusMenu.TabIndex = 20;
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
            // DataText
            // 
            this.DataText.Name = "DataText";
            this.DataText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataText.Size = new System.Drawing.Size(124, 17);
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
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 332);
            this.Controls.Add(this.StatusMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextResult);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.panel1.ResumeLayout(false);
            this.StatusMenu.ResumeLayout(false);
            this.StatusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSilnia;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip StatusMenu;
        private System.Windows.Forms.ToolStripStatusLabel StatusTitle;
        private System.Windows.Forms.ToolStripStatusLabel StatusValue;
        private System.Windows.Forms.ToolStripStatusLabel DataText;
        private System.Windows.Forms.ToolStripStatusLabel Data;
    }
}