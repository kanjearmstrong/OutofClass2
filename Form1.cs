using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Location = "C:\\Users\\cst117\\photos\\" + listBox1.SelectedItem + ".png";
            pictureBox1.Image = Image.FromFile(Location);
            if (radioButton1.Checked)
            {
                label2.Text = "Water";
            }
            if (radioButton2.Checked)
            {
                label2.Text = "Juice";
            }


            if (checkBox1.CheckState == CheckState.Checked)
            {
                label3.Text = "Yogurt";
            }
            else if (checkBox2.CheckState == CheckState.Checked)
            {
                label3.Text = "Salad";
            }
            else
            {
                label3.Text = "No side selected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            pictureBox1.Image = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
