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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("1");
            string data = serialPort1.ReadLine();
            
            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Efficiency";

            this.label5.Text = "Panel";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("2");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Power";

            this.label5.Text = "DC Load";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("3");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Power";

            this.label5.Text = "Converter";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("4");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Charge";

            this.label5.Text = "Battery";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("5");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Power";

            this.label5.Text = "Buck 1";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("6");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Power";

            this.label5.Text = "Buck 2";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("7");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Efficiency";

            this.label5.Text = "Stopped";
            this.label6.Text = "0";
            this.label7.Text = "0";
            this.label8.Text = "0";
            serialPort1.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("8");
            string data = serialPort1.ReadLine();

            this.label1.Text = "System";
            this.label2.Text = "Voltage";
            this.label3.Text = "Current";
            this.label4.Text = "Efficiency";
    
            this.label5.Text = "Overview";
            this.label6.Text = data.Substring(0, 4);
            this.label7.Text = data.Substring(4, 4);
            this.label8.Text = data.Substring(8, 4);
            serialPort1.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("1");
           
            this.label5.Text = serialPort1.ReadLine();
            serialPort1.Close();

        }
        
    }
}
