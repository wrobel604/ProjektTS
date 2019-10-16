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
        ReceivedData rec;
        public bool checkIP(string ip)
        {
            string to255Range = @"((((([0-9]{1})|([1-9][0-9]))|(1[0-9]{2}))|(2[0-4][0-9]))|(25[0-5]))";
            Regex regex = new Regex($@"^{to255Range}\.{to255Range}\.{to255Range}\.{to255Range}$");
            return regex.Match(Adress.Text).Success;
        }
        public bool isPortNumber(string port)
        {
            Regex regex = new Regex("^[1-9][0-9]*$");
            return regex.Match(port).Success;
        }
        public Form1()
        {
            InitializeComponent();
            tcpClientCommunication = new Client.TcpClientCommunication();
            rec = new ReceivedData();
            rec.textBox = Logi;
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
                if (checkIP(Adress.Text) && isPortNumber(PortBox.Text))
                {
                    tcpClientCommunication.connect(System.Net.IPAddress.Parse(Adress.Text), int.Parse(PortBox.Text));
                    if (tcpClientCommunication.isConnected)
                    {
                        tcpClientCommunication.ReadStream = rec;
                        tcpClientCommunication.listening();
                        Logi.Text += "Połączono do servera " + Adress.Text + " na porcie " + PortBox.Text + "\n";
                        ConnectButton.Text = "Rozłącz";
                    }
                }
            }
        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {
            Adress.BackColor = (checkIP(Adress.Text)) ? Color.LightGreen : Color.Red;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (tcpClientCommunication.isConnected)
            {
                tcpClientCommunication.send(Polecenie.Text);
            }
        }
    }
}
