using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZENON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float _Xtortila = 200;
        float _Ytortila = 350;
        float _Xchel = 0;
        float _Ychel = 170;
        float _XspeedtTortila;
        float _XSpeedChel ;
        float _time = 0;
        float _dtime;
        float _Ds;
private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out _XspeedtTortila);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox2.Text, out _XSpeedChel);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _dtime = (_Xchel-_Xtortila ) / (100 * _XspeedtTortila);
            _Ds = _Xtortila*_dtime-_Xtortila ;
            _time = _Ds / _Xtortila;
            if (_time < _dtime)
            {
                _dtime = _time / 100;
            }
            _Xtortila =_Xtortila - _XspeedtTortila * _time;
            _Xchel =_Xchel-_XSpeedChel*_time;
            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 00, 370, 1600, 370);
            e.Graphics.FillEllipse(Brushes.Green, _Xtortila, _Ytortila, 200, 20);
            e.Graphics.FillEllipse(Brushes.Pink, _Xchel, _Ychel, 50, 200);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval =1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Refresh();
        }
    }
}
