using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add remove edit 
namespace winform_lesson6_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            var result = form2.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                form2.Close();
                this.Show();
            }
         
            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox1 .Text = form2.MyText;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
