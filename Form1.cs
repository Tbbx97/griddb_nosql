using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "\n Tên Khách Hàng:    " + tenkh.Text;
            ///tt += "\n Loại Phòng:";
            if (pd1.Checked == true)
                tt += "\n Loại Phòng:   Phòng Đơn:  " + "Đơn Gía:   " + dg1.Text + "Số Lượng:   " +sl1.Value;
                
            else
                tt += "\nLoại Phòng:    Phòng Đôi:  " + "Đơn Gía:   " + dg2.Text + "Số Lượng:   " + sl2.Value;
            tt += "\n Ngày Đến:   " + nd1.Value.ToShortDateString();
            tt += "\n Ngày Đi:   " + nd2.Value.ToShortDateString();
            tt += "\n Số Ngày Ở:  " + sno.Text;
            tt += "\n Tổng Tiền: " + tongtien.Text;

            richTextBox1.Text = tt;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sl1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
