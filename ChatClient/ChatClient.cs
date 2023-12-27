using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using AppChat;

namespace ChatClient
{
    public partial class ChatClient : Form
    {
        Socket client;
        int port = 2023;
        IPAddress ia;
        IPEndPoint ie;
        private EmojiForm emojiForm;
        public ChatClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            emojiForm = new EmojiForm(txtSend);
            KhoiTao();
            MyReceive();
        }

        private void KhoiTao()
        {
            client = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            ia = IPAddress.Parse("127.0.0.1");
            ie = new IPEndPoint(ia, port);
            try
            {
                client.Connect(ie);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private byte[] MaHoa(String s)
        {
            byte[] data = new byte[1024 * 5000];
            data = Encoding.Unicode.GetBytes(s);
            return data;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSend.Text != String.Empty)
                {
                    client.Send(MaHoa(txtSend.Text));
                    txtSend.Clear();
                }
            }
            catch
            {
                CloseClient();
            }
        }
        private void CloseClient()
        {
            client.Close();
        }

        private string GiaiMa(byte[] data)
        {
            return Encoding.Unicode.GetString(data);
        }

        private void MyReceive()
        {
            Thread tReceive = new Thread(new ThreadStart(() =>
            {
                try
                {
                    while (true)
                    {
                        byte[] data = new byte[1024 * 5000];
                        client.Receive(data);
                        String timestamp = DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm");
                        if (listViewMessage.Text != String.Empty)
                        {
                            listViewMessage.Text += "\n";
                        }
                        listViewMessage.Text += timestamp + " - " + GiaiMa(data);
                    }
                }
                catch
                {
                    CloseClient();
                }
            }));
            tReceive.Start();
        }

        private void ChatClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseClient();
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend_Click(sender, e);
            }
        }

        private void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            listViewMessage.Clear();
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            emojiForm.StartPosition = FormStartPosition.CenterParent;
            emojiForm.ShowDialog();
        }

        private void MyReceiveImage()
        {
            
        }

        private void AddImage()
        {

        }
    }
}
