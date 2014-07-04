using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass2Sirbajan
{
    public partial class frmInput : Form
   
    {
        public frmOutput Out;
        public int MainNumber;
        public frmInput()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
      
        {
            int num = Convert.ToInt32(textBox1.Text);
            MainNumber = Convert.ToInt32(Out.btnOutput.Text);
            Out.btnOutput.Text = ((num + MainNumber).ToString());
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
