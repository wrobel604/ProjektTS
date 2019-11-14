using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ConnectWindow : Form
    {
        public ConnectWindow()
        {
            InitializeComponent();
        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {
            Adress.BackColor = (RegexTests.checkIP(Adress.Text)) ? Color.LightGreen : Color.Red;
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (RegexTests.checkIP(Adress.Text) && RegexTests.isPortNumber(PortBox.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawny adres IP lub/i numer portu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortBox.BackColor = (!RegexTests.isNumber(PortBox.Text)) ? Color.Red : Color.White;
        }
    }
}
