using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class Form1 : Form
    {
        public static string q = "";
        Random _random = new Random();
        Queue _queue = new Queue(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            q = "";
            RandomNum();
            lbl_q.Text = q;
        }

        public void RandomNum()
        {
            int d1 = _random.Next(1, 7);
            int d2 = _random.Next(1, 7);

            if (ValidNum(d1 + d2))
            {
                lbl_d1.Text = d1.ToString();
                lbl_d2.Text = d2.ToString();
            }
            else
            {
                RandomNum();
            }
        }

        public bool ValidNum(int x)
        {

            if (_queue.CheckQ(x))
            {
                _queue.Insert(x);
                _queue.PrintQ();
                return true;
            }
            return false;
        }
    }
}
