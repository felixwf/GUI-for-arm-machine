using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arm_machine
{
    public partial class Form1 : Form
    {
        public SerialPort coom = new SerialPort();

        private Byte motionMode = 0x00;
        private double target_x;
        private double target_y;
        private double target_t;
        private double target_d;

        // canvas and coordinate
        private UInt16 height = 1000;
        private UInt16 width = 1500;

        private Pen mypen_r = new Pen(Color.Red);
        private Pen mypen_b = new Pen(Color.Black);

        private Graphics g = null;

        static int center_x, center_y;



        // config for the lora module
        // cmd array will be like this:
        // addr_h, addr_l, channel, data[0], data[1], ......
        private const Byte lora_target_addr_h = 0;
        private const Byte lora_target_addr_l = 1;
        private const Byte lora_target_channel = 15;

        // serial data for lora transport--wireless
        private Byte[] loraDataCmd = new Byte[53];

        // serial data for TTL serial transport--with cable connect to the machine
        public Byte[] dataCmd = new Byte[50];

        public Form1()
        {
            InitializeComponent();

            serial_check(); // refresh the avalible ports
            this.baudrate.Text = "115200"; // baudrate
            this.targetX.Text = "100"; // mm
            this.targetY.Text = "100"; // mm

            this.target_distance.Text = "100"; // mm
            this.target_theta.Text = "0"; // deg

            

        }

        private void serial_check()
        {
            // 检查是否有串口
            // check the serial port
            string[] str = SerialPort.GetPortNames();

            if (str == null)
            {
                MessageBox.Show("本机没有串口！\r No serial port detected", "Error");
                return;
            }

            // 添加串口项目 List all the avalible ports
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {// 获取有多少个COM口
                if (!serialport.Items.Contains(s))
                {
                    serialport.Items.Add(s);
                }
            }

            //串口设置默认选择项 set the default port
            serialport.SelectedIndex = 0;         //设置cbSerial的默认选项
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (coom.IsOpen)
            {
                coom.Close();
                // disable_buttons();
            }
            else
            {
                coom.PortName = this.serialport.Text;
                coom.BaudRate = int.Parse(this.baudrate.Text);
                coom.Parity = Parity.None;
                coom.DataBits = 8;
                coom.StopBits = StopBits.One;
                Console.WriteLine(coom.BaudRate);

                try
                {
                    coom.Open();
//                  MessageBox.Show("连接成功");
//                  enable_buttons();
                }
                catch (Exception ex)
                {
                    coom = new SerialPort();
                    MessageBox.Show(ex.Message);
                }
            }

            this.button1.Text = coom.IsOpen ? "Disconnect" : "Connect";
            this.button1.BackColor = coom.IsOpen ? Color.Green : Color.Gray;

            // now you can enable the send button
        }

        private void serialport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            serial_check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double target_X = double.Parse(this.targetX.Text);
            double target_Y = double.Parse(this.targetY.Text);

            if(check_coordinate(target_X, target_Y, 1))
            {
                motionMode = 0x00;
                target_x = target_X;
                target_y = target_Y;
                dataCmd[0] = 0x55;
                dataCmd[1] = 0xaa;
                dataCmd[2] = (Byte)motionMode;
                if (dataCmd[2] == 0x00)
                {
                    UInt32 x = (UInt32)(target_x * 1000); // 单位:mm * 1000 ==> um
                    UInt32 y = (UInt32)(target_y * 1000);
                    dataCmd[3] = (Byte)(x >> 24 & 0xff);
                    dataCmd[4] = (Byte)(x >> 16 & 0xff);
                    dataCmd[5] = (Byte)(x >> 8 & 0xff);
                    dataCmd[6] = (Byte)(x >> 0 & 0xff);
                    dataCmd[7] = (Byte)(y >> 24 & 0xff);
                    dataCmd[8] = (Byte)(y >> 16 & 0xff);
                    dataCmd[9] = (Byte)(y >> 8 & 0xff);
                    dataCmd[10] = (Byte)(y >> 0 & 0xff);
                }
                dataCmd[11] = 0x00;
                dataCmd[12] = 0x00;
                dataCmd[13] = 0x0d;
                dataCmd[14] = 0x0a;

                sendDataToMachine(dataCmd, 15);

            }
            else
            {
                MessageBox.Show("Not in the range, please check!", "Error");
            }
        }

        private void targetX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double target_Theta = double.Parse(this.target_theta.Text);
            double target_Distance = double.Parse(this.target_distance.Text);

            if (check_coordinate(target_Theta, target_Distance, 2))
            {

                motionMode = 0x01;
                target_t = target_Theta;
                target_d = target_Distance;

                dataCmd[0] = 0x55;
                dataCmd[1] = 0xaa;
                dataCmd[2] = (Byte)motionMode;
                if (dataCmd[2] == 0x01)
                {
                    UInt32 theta = (UInt32)(target_t * 1000);
                    UInt32 distance = (UInt32)(target_d * 1000);
                    dataCmd[3] = (Byte)(theta >> 24& 0xff);
                    dataCmd[4] = (Byte)(theta >> 16 & 0xff);
                    dataCmd[5] = (Byte)(theta >> 8 & 0xff);
                    dataCmd[6] = (Byte)(theta >> 0 & 0xff);
                    dataCmd[7] = (Byte)(distance >> 24 & 0xff);
                    dataCmd[8] = (Byte)(distance >> 16 & 0xff);
                    dataCmd[9] = (Byte)(distance >> 8 & 0xff);
                    dataCmd[10] = (Byte)(distance >> 0 & 0xff);
                }
                dataCmd[11] = 0x00;
                dataCmd[12] = 0x00;
                dataCmd[13] = 0x0d;
                dataCmd[14] = 0x0a;
                sendDataToMachine(dataCmd, 15);
            }
            else
            {
                MessageBox.Show("Not in the range, please check!", "Error");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataCmd[0] = 0x55;
            dataCmd[1] = 0xaa;
            dataCmd[2] = 0x03;
            dataCmd[3] = 0x01;
            dataCmd[4] = 0x00;
            dataCmd[5] = 0x00;
            dataCmd[6] = 0x0d;
            dataCmd[7] = 0x0a;
            sendDataToMachine(dataCmd, 8);
        }

        private void dropdown_Click(object sender, EventArgs e)
        {
            dataCmd[0] = 0x55;
            dataCmd[1] = 0xaa;
            dataCmd[2] = 0x02;
            dataCmd[3] = 0x01;
            dataCmd[4] = 0x00;
            dataCmd[5] = 0x00;
            dataCmd[6] = 0x0d;
            dataCmd[7] = 0x0a;
            sendDataToMachine(dataCmd, 8);
        }

        private void liftup_Click(object sender, EventArgs e)
        {
            dataCmd[0] = 0x55;
            dataCmd[1] = 0xaa;
            dataCmd[2] = 0x02;
            dataCmd[3] = 0x0f;
            dataCmd[4] = 0x00;
            dataCmd[5] = 0x00;
            dataCmd[6] = 0x0d;
            dataCmd[7] = 0x0a;
            sendDataToMachine(dataCmd, 8);

        }

        private void deactivateSucker_Click(object sender, EventArgs e)
        {
            dataCmd[0] = 0x55;
            dataCmd[1] = 0xaa;
            dataCmd[2] = 0x03;
            dataCmd[3] = 0x0f;
            dataCmd[4] = 0x00;
            dataCmd[5] = 0x00;
            dataCmd[6] = 0x0d;
            dataCmd[7] = 0x0a;
            sendDataToMachine(dataCmd, 8);

        }


        private bool check_coordinate(double a, double b, Int16 type)
        {
            double x, y, theta = 0, distance = 0;
            double theta_thre_max = 180.0; // deg
            double theta_thre_min = 0.0;
            double distance_thre_max = 300; // mm
            double distance_thre_min = 100;

            switch (type)
            {
                case 1: // (x, y)
                    x = a;
                    y = b;
                    distance = Math.Sqrt(x * x + y * y); // mm
                    theta = Math.Atan2(y, x) * 180 / Math.PI; // deg
                    break;
                case 2: // (theta, distance)
                    theta = a;
                    distance = b;
                    break;
            }

            if(theta <= theta_thre_max && theta >= theta_thre_min && distance <= distance_thre_max && distance >= distance_thre_min)
            {
                return true;
            }

            return false;
        }

        private void sendDataToMachine(Byte[] data, UInt16 len)
        {
            if (radioButton_wc.Checked)
            {
                coom.Write(dataCmd, 0, len);
                Console.WriteLine("with cable\n");
            }
            else if (radioButton_wl.Checked)
            {
                loraDataCmd[0] = lora_target_addr_h;
                loraDataCmd[1] = lora_target_addr_l;
                loraDataCmd[2] = lora_target_channel;
                dataCmd.CopyTo(loraDataCmd, 3);
                coom.Write(loraDataCmd, 0, len + 3);
                Console.WriteLine("wireless\n");
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
