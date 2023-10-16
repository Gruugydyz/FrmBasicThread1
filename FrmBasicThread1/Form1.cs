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

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Thread ThreadA, ThreadB;
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(MyThreadClass.Thread1);
           
            ThreadA =  new Thread(start);
            ThreadB = new Thread(start);

            Console.WriteLine(label1.Text.ToString());


            ThreadA.Name = "Thread A Process ";
            ThreadB.Name = "Thread B Process ";

            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());


        }
    }
}
