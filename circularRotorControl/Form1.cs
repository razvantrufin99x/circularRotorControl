using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace circularRotorControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //HH
            theCircularRotorControl1.setMaxim(23);
            theCircularRotorControl1.setMinim(0);
            theCircularRotorControl1.setCurent(3);
            //MM
            theCircularRotorControl2.setMaxim(59);
            theCircularRotorControl2.setMinim(0);
            theCircularRotorControl2.setCurent(4);
            //SEC
            theCircularRotorControl3.setMaxim(59);
            theCircularRotorControl3.setMinim(0);
            theCircularRotorControl3.setCurent(50);
            //MSEC
            theCircularRotorControl4.setMaxim(999);
            theCircularRotorControl4.setMinim(0);
            theCircularRotorControl4.setCurent(555);

            //YYYY
            theCircularRotorControl5.setMaxim(9999);
            theCircularRotorControl5.setMinim(0);
            theCircularRotorControl5.setCurent(2020);
            //MM
            theCircularRotorControl6.setMaxim(12);
            theCircularRotorControl6.setMinim(1);
            theCircularRotorControl6.setCurent(11);
            //WEEK
            theCircularRotorControl7.setMaxim(56);
            theCircularRotorControl7.setMinim(1);
            theCircularRotorControl7.setCurent(52);
            //DAY
            theCircularRotorControl8.setMaxim(366);
            theCircularRotorControl8.setMinim(1);
            theCircularRotorControl8.setCurent(310);

            theCircularRotorControl1.update();
            theCircularRotorControl2.update();
            theCircularRotorControl3.update();
            theCircularRotorControl4.update();
            theCircularRotorControl5.update();
            theCircularRotorControl6.update();
            theCircularRotorControl7.update();
            theCircularRotorControl8.update();
        }
    }
}
