using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace circularRotorControl
{
    public partial class theCircularRotorControl : UserControl
    {
        public theCircularRotorControl()
        {
            InitializeComponent();
        }

        public int maxim = 24;
        public int minim = 0;
        public int curentValue = 0;

        public void setMaxim(int x) { maxim = x; }
        public void setMinim(int x) { minim = x; }
        public void setCurent(int x) { curentValue = x; }

        public void update()
        {
            this.label1.Text = curentValue.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = curentValue.ToString();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Height / 2)
            {
               
                if (curentValue < maxim)
                {
                    curentValue += 1;
                }
                else
                {
                    curentValue = minim;
                }
            }
            else
            {
                Cursor = Cursors.PanSouth;
                if (curentValue > minim)
                {
                    curentValue -= 1;
                }
                else
                {
                    curentValue = maxim;
                }
            }
            this.label1.Text = curentValue.ToString();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Height / 2)
            {
                Cursor = Cursors.PanNorth;
            }
            else
            {
                Cursor = Cursors.PanSouth;
            }
        }

        private void theCircularRotorControl_Load(object sender, EventArgs e)
        {
            this.label1.Text = curentValue.ToString();
        }
    }
}
