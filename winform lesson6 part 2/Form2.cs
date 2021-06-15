using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_lesson6_part_2
{
    public partial class Form2 : Form
    {
        public string MyText { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string name,string country,int cost   )
        {
            InitializeComponent();
            
        }
       // public DialogResult ShowDialog(Product Product)
       // {
       ////     listbx1.Text = $"username{user.Username },password{user.Password }";
       //     return ShowDialog();


       // }
        private void OkBtn_Click(object sender, EventArgs e)
        {
           

            MyText=

        }
    }
}
