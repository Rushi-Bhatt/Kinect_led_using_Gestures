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

namespace vol_led
{
    public partial class Form1 : Form
    {
        //byte[] b = {1};
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM11";
            serialPort1.BaudRate = 9600;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {

            Y: Thread.Sleep(500);
                    try
                 {
                TextReader tw = new StreamReader("C:/sem7_inno/har.txt");

                if (!tw.Equals(null))
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                       // Console.Write(tw.ReadLine());
                        String ip = tw.ReadLine();
                        char[] IP=ip.ToCharArray();
                        String ip1="", ip2="";
                        ip1 += IP[0];
                        ip2 += IP[1];
                      //  Console.Write(ip2);
                        serialPort1.Write(ip);
                     //   serialPort1.Write(ip2);
                        //serialPort1.WriteLine(ip);
                    }
                    serialPort1.Close();

                    tw.Close();
                }
                else
                {
                    Console.Write("N");
                    Console.Write("N");
                }
                }
                catch (Exception e1)
                {
                  goto Y;
                }
            }

        }
    }
}
