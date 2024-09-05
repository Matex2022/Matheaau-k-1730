using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exb1
{
    public partial class FormInvoiceTotal : Form
    {
        public FormInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = this.txtSubtotal.Text;
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
