using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace FormView_Bridge
{
    public partial class Main : Form
    {

        private TcpListener
            _listener;

        private Thread
            _listenerThread;

        private string
            _accessionNumber;

        private bool
            _alive;

        public Main()
        {
            InitializeComponent();
            _accessionNumber = string.Empty;
        }

        private void CreateListener()
        {
            if (_listener != null)
            {
                _listener.Stop();
                _listener.Dispose();
            }

            _alive = true;
            try
            {
                _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), (int)numericUpDown_port.Value);
                textBox_accessionNumber.ForeColor = Color.Black;

                var threadStart = new ThreadStart(ListenThread);
                _listenerThread = new Thread(threadStart);
                _listenerThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create listener on port. Please select a different port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_accessionNumber.ForeColor = Color.Red;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateListener();
        }

        private void numericUpDown_port_ValueChanged(object sender, EventArgs e)
        {
            CreateListener();
        }

        private void ListenThread()
        {
            _listener.Start();
            while (_alive)
            {
                var client = _listener.AcceptTcpClient();

                var threadInfo = new ParameterizedThreadStart(ClientThread);
                var clientThread = new Thread(threadInfo);
                clientThread.Start(client);
            }
        }

        private void ClientThread(object clientObject)
        {
            var client = clientObject as TcpClient;

            if (client == null)
            {
                return;
            }
            try
            {
                var stream = client.GetStream();
                var buffer = new byte[1024];
                var read = stream.Read(buffer, 0, buffer.Length);

                var body = _accessionNumber;
                var bodyBytes = Encoding.UTF8.GetBytes(body);
                var response =
                    "HTTP/1.1 200 OK\r\n" +
                    "Content-Type: text/plain; charset=utf-8\r\n" +
                    $"Content-Length: {bodyBytes.Length}\r\n" +
                    "Access-Control-Allow-Origin: *\r\n" +
                    "Connection: close\r\n" +
                    "\r\n";

                var headerBytes = Encoding.UTF8.GetBytes(response);

                stream.Write(headerBytes, 0, headerBytes.Length);
                stream.Write(bodyBytes, 0, bodyBytes.Length);
                stream.Flush();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                client.Close();
            }
        }

        private void textBox_accessionNumber_TextChanged(object sender, EventArgs e)
        {
            _accessionNumber = textBox_accessionNumber.Text;
        }
    }
}
