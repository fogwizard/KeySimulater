using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;  

namespace KeySimulater
{
    public partial class FrmMain : Form
    {
        ManualResetEvent write_event = new ManualResetEvent(false);
        ManualResetEvent read_event  = new ManualResetEvent(false);
        bool is_connect = false;

        private StringBuilder builder = new StringBuilder();

        const int DATA_BASE_LEN = 3;
        const int UART1_RX_LEN_LEVEL1 = 1024;
      //  const int UART1_RX_LEN_LEVEL2 = 1024;
        const int HOLD_REGISTER_LEN = 256;

        readonly int[] bit_rate=new int[7]{2400,4800,9600,19200,38400,57600,115200};

        public static byte[] rxbuf = new byte[UART1_RX_LEN_LEVEL1];
        int comm1_new_receive_len = 0;

      //  public static byte[] rxbuf2 = new byte[UART1_RX_LEN_LEVEL2];
        int comm1_all_receive_len = 0;

        public static byte[] txbuf = new byte[32];/* txbuf default 32 byte */
        int comm1_send_len = 0;

       int recv_count = 0;
       int send_count = 0;

        DateTime last_now;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!is_connect)
            {
                if (!comm1.IsOpen)
                {
                    comm1.PortName = comboBox_comport_choose.Items[comboBox_comport_choose.SelectedIndex].ToString();
                    comm1.Open();
                }
                (sender as Button).Enabled = false;
                (sender as Button).Text = "关闭串口";
                start_avaid_repeat.Enabled = true;
                comboBox_comport_choose.Enabled = false;
                comboBox_comport_bitrate.Enabled = false;
                toolStripStatusLabel1.Text = (comm1.PortName.ToString() + "-" +
                        comm1.BaudRate.ToString());
                is_connect = true;
            }
            else
            {
                toolStripStatusLabel1.Text = "串口未连接";
                (sender as Button).Text = "打开串口";
                comboBox_comport_choose.Enabled = true;
                comboBox_comport_bitrate.Enabled = true;
                comm1.Close();
                is_connect = false;
            }
        }

        private void status1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            for (int i = 0; i < portList.Length; ++i)
            {
                string name = portList[i];
                comboBox_comport_choose.Items.Add(name);
            }
            for (int i = 0; i < bit_rate.Length; i++)
            {
                comboBox_comport_bitrate.Items.Add(bit_rate[i].ToString());
            }
            comboBox_comport_choose.SelectedIndex = 0;/* default value */
            comboBox_comport_bitrate.SelectedIndex = 2;/* default value*/
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = "";

            Thread t1 = new Thread(new ThreadStart(ReadThread));
            t1.IsBackground = true;
            t1.Start();
        }

        enum tag_receive_state
        {
            STATE_START,
            STATE_SEND_KEY,
            STATE_SEND_BATERRY,
            STATE_OP_CPL,
        }

        enum tag_pack_type
        {
            PACK_INVALID,
            PACK_KEY,
            PACK_BATERRY,
        }

        tag_pack_type send_type = tag_pack_type.PACK_KEY;
        public void ReadThread()
        {
            tag_receive_state s_state = tag_receive_state.STATE_START;
            while (true)
            {
                if (!is_connect)
                {
                    continue;
                }
                switch (s_state)
                {
                    case tag_receive_state.STATE_START:
                        if (write_event.WaitOne(10))
                        {
                            write_event.Reset();
                            if (send_type == tag_pack_type.PACK_KEY)
                            {
                                s_state = tag_receive_state.STATE_SEND_KEY;
                            }
                            else if(send_type == tag_pack_type.PACK_BATERRY) 
                            {
                                s_state = tag_receive_state.STATE_SEND_BATERRY;
                            }
                        }
                        if (read_event.WaitOne(10))
                        {
                            DateTime currentTime = DateTime.Now;
                            TimeSpan delta = currentTime - last_now;
                            if (delta.TotalMilliseconds > 20)/* default 20ms */
                            {/* we know this is two frame now */
                                comm1_all_receive_len = 0;
                            }

                            comm1_all_receive_len += comm1_new_receive_len;
                            last_now = currentTime;
                            read_event.Reset();
                        }
                        break;
                    case tag_receive_state.STATE_SEND_KEY:
                        if (comm1_send_len > 0)
                        {
                            if (comm1.IsOpen)
                            {
                                string str1 = String.Format("发送:[{0}] ", send_count++);
                                for (int i = 0; i < comm1_send_len; i++)
                                {
                                    str1 = str1 + String.Format("{0:X2}", txbuf[i]) + " ";
                                }
                                toolStripStatusLabel3.Text = str1;
                                comm1.Write(txbuf, 0, comm1_send_len);
                                comm1_send_len = 0;
                            }
                        }
                        s_state = tag_receive_state.STATE_START;
                        break;
                    case tag_receive_state.STATE_SEND_BATERRY:
                        if (comm1_send_len > 0)
                        {
                            if (comm1.IsOpen)
                            {
                                comm1.Write(txbuf, 0, comm1_send_len);
                                comm1_send_len = 0;
                            }
                        }
                        s_state = tag_receive_state.STATE_START;
                        break;
                }
            }
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x01;
            txbuf[2] = 0x0d;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x02;
            txbuf[2] = 0x0d;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x05;
            txbuf[2] = 0x0d;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x03;
            txbuf[2] = 0x52;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x04;
            txbuf[2] = 0x51;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_esc_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x06;
            txbuf[2] = 0x4F;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_clr_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x08;
            txbuf[2] = 0x4D;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void button_pwr_Click(object sender, EventArgs e)
        {
            txbuf[0] = 0xAA;
            txbuf[1] = 0x07;
            txbuf[2] = 0x4E;
            comm1_send_len = 3;
            send_type = tag_pack_type.PACK_KEY;
            write_event.Set();
        }

        private void comm1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            comm1_new_receive_len = comm1.BytesToRead;
            comm1.Read(rxbuf, 0, comm1.BytesToRead);
            //comm1.DiscardInBuffer();
            string str1 = String.Format("接收:[{0}] ", recv_count++);
            string str2 = "";
            /*for (int i = 0; i < comm1_new_receive_len; i++)
            {
                str1 = str1 + String.Format("{0:X2}", rxbuf[i]) + " ";
            }*/
            str2 = Encoding.ASCII.GetString(rxbuf);
            Array.Clear(rxbuf, 0, comm1_new_receive_len + 1);
       //     builder.Append(str1);
            this.log1.BeginInvoke((Action)delegate
            {
                toolStripStatusLabel2.Text = str1;
                this.log1.Text += str2;
            });
            read_event.Set();
        }

        private void button_savetofile_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            if (this.saveFileDialog1.FileName != "")
            {
                FileStream fs = new FileStream(this.saveFileDialog1.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string i in this.log1.Lines)
                {
                    sw.WriteLine(i);
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.log1.Clear();
        }
    }
}
