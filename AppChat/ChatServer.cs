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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace AppChat
{
    public partial class ChatServer : Form
    {
        Socket server;
        int port = 2023;
        IPAddress ia;
        IPEndPoint ie;
        List<Socket> clientList;
        private EmojiForm emojiForm;
        private OpenFileDialog openFileDialog;
        public ChatServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            KhoiTao();
            emojiForm = new EmojiForm(txtSend);
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";
        }

        private void KhoiTao()
        {
            server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            ia = IPAddress.Parse("127.0.0.1");
            ie = new IPEndPoint(ia, port);
            clientList = new List<Socket>();
            server.Bind(ie);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        AddClientToListClient(client);
                        MyReceive(client);
                    }
                }
                catch
                {
                    server = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                    ia = IPAddress.Parse("127.0.0.1");
                }
            });
            Listen.Start();
        }

        private void AddClientToListClient(Socket client)
        {
            try
            {
                listClient.Items.Add(client.RemoteEndPoint.ToString());
            }
            catch {
                MessageBox.Show("Có lỗi khi thêm vào danh sách", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveClientFromListClient(Socket client)
        {
            try
            {
                listClient.Items.Remove(client.RemoteEndPoint.ToString());
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa khỏi danh sách", "Lỗi",
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
            String timestamp = DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm");
            if (txtSend.Text != String.Empty)
            {
                if (listClient.CheckedIndices.Count == 0)
                {
                    foreach (Socket client in clientList)
                    {
                        try
                        {
                            client.Send(MaHoa(txtSend.Text));
                        }
                        catch
                        {
                            CloseClient(client);
                        }
                    }
                }
                else
                {
                    foreach (int index in listClient.CheckedIndices)
                    {
                        try
                        {
                            Socket client = clientList[index];
                            client.Send(MaHoa(txtSend.Text));
                        }
                        catch
                        {
                            MessageBox.Show("Có lỗi trong quá trình gửi tin nhắn", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if(listViewMessage.Text != String.Empty)
                {
                    listViewMessage.Text += "\n";
                }
                listViewMessage.Text += timestamp + " - " + txtSend.Text;
                txtSend.Clear();
            }
        }

        private void CloseClient(Socket client)
        {
            RemoveClientFromListClient(client);
            clientList.Remove(client);
            client.Close();
        }

        private string GiaiMa(byte[] data)
        {
            return Encoding.Unicode.GetString(data);
        }

        private void MyReceive(Socket client)
        {
            Thread tReceive = new Thread(new ThreadStart(() =>
            {
                try
                {
                    while (client.Connected)
                    {
                        byte[] data = new byte[1024 * 5000];
                        client.Receive(data);
                        String s = GiaiMa(data);
                        String timestamp = DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm");
                        if (listViewMessage.Text != String.Empty)
                        {
                            listViewMessage.Text += "\n";
                        }
                        listViewMessage.Text += timestamp + " - " + s;
                        foreach (Socket clientConnect in clientList)
                        {
                            if (clientConnect.Connected)
                            {
                                clientConnect.Send(MaHoa(s));
                            }
                            else
                            {
                                CloseClient(clientConnect);
                            }
                        }
                    }
                }
                catch
                {
                    CloseClient(client);
                }
            }));
            tReceive.Start();
        }

        private void CloseServer()
        {
            server.Close();
        }

        private void ChatServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseServer();
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listClient.Items.Count; i++)
                {
                    listClient.SetItemChecked(i, true);
                }
            }
            catch {
                MessageBox.Show("Có lỗi khi click select all", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listClient.Items.Count; i++)
                {
                    listClient.SetItemChecked(i, false);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi click cancel", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
