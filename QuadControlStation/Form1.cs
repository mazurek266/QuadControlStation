using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Input;
using System.Net;
using System.Net.Sockets;
using RunJoyStickOnLocalMachine;


namespace QuadControlStation
{
    public partial class QuadControlStation : Form
    {

        string serverIP = "192.168.4.1";
        int Port = 333;
        int Connected = 0;
        int ConnectedChannels = 0;
        UInt16 cnt = 0;
        int[] SpacingTable = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] RecvBuffer =new byte[140];
        string ControlVector;
        NetworkStream stream;
        TcpClient client;
        private Joystick joystick;
        private bool[] joystickButtons;
        


        public QuadControlStation()
        {
            InitializeComponent();           
        }

        
        private void connectToJoystick(Joystick joystick)
        {
            while (true)
            {
                string sticks = joystick.FindJoysticks();
                if (sticks != null)
                {
                    if (joystick.AcquireJoystick(sticks))
                    {
                        enableTimer();
                        break;
                    }
                }
            }
        }

        private void enableTimer()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new ThreadStart(delegate ()
                {
                    joystickTimer.Enabled = true;
                }));
            }
            else
                joystickTimer.Enabled = true;
        }



        public void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectedChannels++;
                if (ConnectedChannels < 2)
                {
                    client = new TcpClient(serverIP, Port);
                    stream = client.GetStream();
                    Connected = 1;
                    
                    

                    
                }
                else
                    MessageBox.Show("To many channels");
            }
            catch
             {
                ConnectedChannels--;
                MessageBox.Show("Can not connect");
                Connected = 0;
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectedChannels = 0;
                Connected = 0;
                stream.Close();
                client.Close();
            }
            catch
            {
                MessageBox.Show("No connections to close");
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Connected == 1)
            {
                if (stream.DataAvailable == true )
                {


                     stream.Read(RecvBuffer, 0, RecvBuffer.Length);

                    for (int i = 0; i < RecvBuffer.Length; i++)
                    {
                        
                        if (RecvBuffer[i] == ';')
                        {
                            SpacingTable[cnt] = i;
                            cnt++;
                        }
                        if (cnt == 15)
                            break;
                        
                    }
                    cnt = 0;
                    
                   


                    XAcceleration.Text =    Encoding.ASCII.GetString(RecvBuffer,                     0,                    (SpacingTable[0]) - 1 );//0-4
                    YAcceleration.Text =    Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[0]) + 1, (SpacingTable[1]) - (SpacingTable[0]) - 1);//6-10
                    ZAcceleration.Text =    Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[1]) + 1, (SpacingTable[2]) - (SpacingTable[1]) - 1);//12-16
                    PitchSpeed.Text =       Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[2]) + 1, (SpacingTable[3]) - (SpacingTable[2]) - 1);//18-24
                    RollSpeed.Text =        Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[3]) + 1, (SpacingTable[4]) - (SpacingTable[3]) - 1);//26-32
                    YawSpeed.Text =         Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[4]) + 1, (SpacingTable[5]) - (SpacingTable[4]) - 1);//34-40
                    TemperatureValue.Text = Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[5]) + 1, (SpacingTable[6]) - (SpacingTable[5]) - 1);//42-46
                    PitchAngle.Text =       Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[6]) + 1, (SpacingTable[7]) - (SpacingTable[6]) - 1);//48-52
                    RollAngle.Text =        Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[7]) + 1, (SpacingTable[8]) - (SpacingTable[7]) - 1);//54-58
                    YawAngle.Text =         Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[8]) + 1, (SpacingTable[9]) - (SpacingTable[8]) - 1);// (SpacingTable[9]) - (SpacingTable[8]) - 1);//60-64
                    MagX.Text =             Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[9]) + 1, (SpacingTable[10]) - (SpacingTable[9])- 1);
                    MagY.Text =             Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[10]) + 1,(SpacingTable[11]) - (SpacingTable[10])- 1);
                    MagZ.Text =             Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[11]) + 1,(SpacingTable[12]) - (SpacingTable[11]) - 1);
                    Pressure.Text =         Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[12]) + 1, (SpacingTable[13]) - (SpacingTable[12]) - 1);
                    Alltitude.Text =        Encoding.ASCII.GetString(RecvBuffer, (SpacingTable[13]) + 1, 5);//5

                    for (int i = 0; i < 15; i++)
                    { SpacingTable[i]=0;}
                    for (int i = 0; i < RecvBuffer.Length; i++)
                    { RecvBuffer[i] = 0; }

                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            switch (e.KeyValue)
            {
                case (char)Keys.W:
                    //PitchLabel.Text = e.KeyData.ToString();
                    break;

                case (char)Keys.A:
                    //PitchLabel.Text = e.KeyData.ToString();
                    break;

                case (char)Keys.S:
                   // PitchLabel.Text = e.KeyData.ToString();
                    break;

                case (char)Keys.D:
                   // PitchLabel.Text = e.KeyData.ToString();
                    break;


                default:
                    break;
            }
        }
        // label35.Text = ( (((joystick.Xaxis / 327.67) - 100) / 100) * (40 - PitchScrollBar.Value) ).ToString();
        //label36.Text = ( (((joystick.Yaxis / 327.67) - 100) / 100) * (40 - RollScrollBar.Value)).ToString();
        //label37.Text = ( (((joystick.RXaxis / 327.67) - 100) / 100) * (40 - YawScrollBar.Value)).ToString();
        //label38.Text = ( (((joystick.RYaxis / 327.67) - 100) / 100) * (40 - PitchScrollBar.Value)).ToString();
        /* for (int i = 0; i < joystickButtons.Length; i++)
                     {
                         if (joystickButtons[i] == true)
                         OutputBox.Text += "Button " + i + " Pressed\n";
                     }*/
        private void joystickTimer_Tick(object sender, EventArgs e)
        {

            try
            {
                
              joystick.UpdateStatus();
              joystickButtons = joystick.buttons;

              

                ControlVector = String.Format(";{0};{1};{2};{3};\r",
                 Math.Round(    ((((joystick.RYaxis / 327.67) - 100) / 100) * (40 - PitchScrollBar.Value)), 2),
                 Math.Round(    ((((joystick.RXaxis / 327.67) - 100) / 100) * (40 - RollScrollBar.Value)), 2),
                 Math.Round(    ((((joystick.Xaxis / 327.67) - 100) / 100) *  (40 - YawScrollBar.Value)), 2),    
                 Math.Round(    ((((joystick.Yaxis / 327.67) - 100) / 100) *  (40 - HeightScrollBar.Value)), 2));
                 label39.Text = ControlVector;


                if (Connected == 1)
                {
                    int byteCount = Encoding.ASCII.GetByteCount(ControlVector);
                    byte[] sendData = new byte[byteCount];
                    sendData = Encoding.ASCII.GetBytes(ControlVector);
                    stream.Write(sendData, 0, sendData.Length);
                    ControlVector = "";
                }
                


                    
            }
            catch
            {
                joystickTimer.Enabled = false;
                connectToJoystick(joystick);
            }
            
        }

        

        private void QuadControl_Load(object sender, EventArgs e)
        {
            try
            {
                joystick = new Joystick((IntPtr)this.Handle);
            }
            catch { MessageBox.Show("1"); }

            try
            {
                connectToJoystick(joystick);
            }
            catch { MessageBox.Show("2"); }
        }

        private void PitchScrollBar_ValueChanged(object sender, EventArgs e)
        {
            PitchGain.Text = (40 - PitchScrollBar.Value).ToString();
        }

        private void RollScrollBar_ValueChanged(object sender, EventArgs e)
        {
            RollGain.Text = (40 - RollScrollBar.Value).ToString();
        }

        private void YawScrollBar_ValueChanged(object sender, EventArgs e)
        {
            YawGain.Text = (40 - YawScrollBar.Value).ToString();
        }

        private void HeightScrollBar_ValueChanged(object sender, EventArgs e)
        {
            HeightGain.Text = (40 - HeightScrollBar.Value).ToString();
        }
    }
}
