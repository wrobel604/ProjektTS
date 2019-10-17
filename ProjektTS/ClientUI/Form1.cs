using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Form1 : Form
    {
        Client.TcpClientCommunication tcpClientCommunication;
        
        public Form1()
        {
            InitializeComponent();
            tcpClientCommunication = new Client.TcpClientCommunication();
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Show();
            MathOperation mathOperation = new MathOperation();
            mathOperation.Show();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (tcpClientCommunication.isConnected)
            {
                tcpClientCommunication.send("exit");
                tcpClientCommunication.Close();
                ConnectButton.Text = "Połącz";
            }
            else
            {
                if (RegexTests.checkIP(Adress.Text) && RegexTests.isPortNumber(PortBox.Text))
                {
                    tcpClientCommunication.connect(System.Net.IPAddress.Parse(Adress.Text), int.Parse(PortBox.Text));
                    if (tcpClientCommunication.isConnected)
                    {
                        ConnectButton.Text = "Rozłącz";
                    }
                }
            }
        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {
            Adress.BackColor = (RegexTests.checkIP(Adress.Text)) ? Color.LightGreen : Color.Red;
        }
    }
}
