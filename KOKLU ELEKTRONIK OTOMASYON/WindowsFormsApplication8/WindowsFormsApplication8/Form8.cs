using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elektronikDataSet.alim' table. You can move, or remove it, as needed.
            this.alimTableAdapter.Fill(this.elektronikDataSet.alim);

            this.reportViewer1.RefreshReport();
        }
    }
}
