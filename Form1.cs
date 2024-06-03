using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhdiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txttoan.Text == "" || txtvan.Text == "")
            {
                MessageBox.Show("Phải nhập tên, toán, văn");
                return;
            }
            Double toan, van, trungbinh;
            toan = Convert.ToDouble(txttoan.Text);
            van = Convert.ToDouble(txtvan.Text);
            trungbinh = (toan + van) / 2;
            txttrungbinh.Text = trungbinh.ToString();
            if (trungbinh < 5)
            {
                txtxeploai.Text = "yếu";
            }
            else if (trungbinh < 6)
            {
                txtxeploai.Text = "Trung bình";
            }
            else if (trungbinh < 8)
            {
                txtxeploai.Text = "Khá";
            }
            else
            {
                txtxeploai.Text = "Giỏi";
            }
        }

        private void btntinhtrungbinh_Click(object sender, EventArgs e)
        {

        }
    }
    }

