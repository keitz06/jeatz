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
    public partial class frmOutput : Form
    {
        private frmInput Mainnumber;
        public frmOutput()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Mainnumber = new frmInput();
            Mainnumber.Out = this;
            Mainnumber.Show();
            
        }

        public void TextsaButton(string inputtext)
        {
            this.btnOutput.Text = inputtext;
        }
    }
}
