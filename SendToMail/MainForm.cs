using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendToMail
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAvailablePorts(); 
        }

        SerialPort serialPort = new SerialPort();
        private void GetAvailablePorts()
        {
            var ports = SerialPort.GetPortNames().ToList();
            ports.Insert(0, "Select Port...");
            foreach (var port in ports)
            {
                cmbPorts.Items.Add(port);
            }
           /* cmbPorts.SelectedIndex = 0;*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbPorts.SelectedIndex > 0)
            {
                serialPort.BaudRate = 9600;
                serialPort.PortName = cmbPorts.Text;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();

            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = (SerialPort)sender;
            string recievedData = serial.ReadLine();
            lstSerialMonitor.Invoke((Action)(() =>lstSerialMonitor.Items.Add(recievedData)));
            txtStatus.Invoke((Action)(() => txtStatus.Text=recievedData));

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
      
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("dogukangoktas@outlook.com", "23082000e");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                message.To.Add("hakan.kayfeci@gmail.com");
                message.From = new MailAddress("dogukangoktas@outlook.com");
                message.Subject ="Otopark Hk.";
                message.Body = txtStatus.Text;
                client.Send(message);
                MessageBox.Show("Mailiniz Başarıyla Gönderildi","Başarılı",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            
          

        }
    }
}
