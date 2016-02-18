using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_EventArgswithnodata_WinForm
{
    //public delegate void MyEventHandler(object sender, EventArgs e);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(add_Action);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.");
        }

        private void add_Action(Object sender, EventArgs e)
        {
            label1.Text = "button1.Click 이벤트 발생하면 같이 실행된다니까요";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
