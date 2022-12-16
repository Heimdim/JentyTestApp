using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JentyTestApp
{
    public partial class FieldSizeForm : Form
    {
       
        public FieldSizeForm()
        {
            InitializeComponent();
        }

        private void setSizeButton_Click(object sender, EventArgs e)
        {
            GameForm mainForm =  Owner as GameForm;
            if (mainForm != null)
            {
                mainForm.FieldWidth = (int)this.setWidthNumericUpDown.Value;
                mainForm.FieldHeight = (int)this.setHeightNumericUpDown.Value;
                this.Close();
            }
            else MessageBox.Show("main form is abscent");
        }
    }
}
