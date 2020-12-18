using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14__Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Tolong isi textBox dulu");
            }
            else
            {
                string mauReverse = textBox.Text;
                char[] goReverse = mauReverse.ToCharArray(); 
                string reverse = "";
                for (int i = goReverse.Length - 1; i > -1; i--) 
                {
                    reverse = reverse + goReverse[i]; 
                }
                labelOutput.Text = reverse;
            }
        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Tolong isi textBox dulu");
            }
            else
            {
                string mauUrut = textBox.Text;
                char[] goUrut = mauUrut.ToCharArray();
                Array.Sort(goUrut);
                
                string urut = "";

                string final = "";
                string lowerCase = "";
                string upperCase = "";
                string number = "";
                string mark = "";
                for (int j = 0; j < goUrut.Length; j++)
                {
                    urut = urut + goUrut[j];




                    //if (char.IsUpper(goUrut[j]))
                    //{
                    //    lowerCase = lowerCase + Convert.ToString(goUrut[j]);
                    //}
                    //if (char.IsLower(goUrut[j]))
                    //{
                    //    upperCase = upperCase + Convert.ToString(goUrut[j]);
                    //}
                    //if(char.IsNumber(goUrut[j]))
                    //{
                    //    number = number + Convert.ToString(goUrut[j]);
                    //}
                    //else
                    //{
                    //    mark = mark + Convert.ToString(goUrut[j]);
                    //}
                    //final = final + lowerCase + upperCase + number + mark;
                }
                labelOutput.Text = urut;
            }
        }

    }
}
