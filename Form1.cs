using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSharp_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SoDuCan, SoDuChi, Nam;
            Nam = int.Parse(txtDUONGLICH.Text);
            string Can;
            Can = " ";
            SoDuCan = (Nam) % 10;
            switch( SoDuCan )
            {
                case 0:
                    Can = "Canh"; break;
                case 1:
                    Can = "Tân"; break;
                case 2: 
                    Can = "Nhâm"; break;
                case 3: 
                    Can = "Quý"; break;
                case 4:
                    Can = "Giáp"; break;
                case 5: 
                    Can = "Ất"; break;
                case 6:
                    Can = "Bính"; break;
                case 7:
                    Can = "Đinh"; break;
                case 8:
                    Can = "Mậu"; break;
                case 9:
                    Can = "Kỳ"; break;
            }
            string Chi;
            Chi = " ";
            SoDuChi = (Nam-3) % 12;
            switch( SoDuChi )
            {
                case 0: 
                    Chi = "Hợi"; break;
                case 1:
                    Chi = "Tý"; break;
                case 2:
                    Chi = "Sửu"; break;
                case 3:
                    Chi = "Dần"; break;
                case 4:
                    Chi = "Mão"; break;
                case 5:
                    Chi = "Thìn"; break;
                case 6:
                    Chi = "Tỵ"; break;
                case 7:
                    Chi = "Ngọ"; break;
                case 8:
                    Chi = "Mùi"; break;
                case 9:
                    Chi = "Thân"; break;
                case 10:
                    Chi = "Dậu"; break;
                case 11:
                    Chi = "Tuất"; break;
            }
            txtAMLICH.Text = Can+  " " + Chi;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCAN_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
