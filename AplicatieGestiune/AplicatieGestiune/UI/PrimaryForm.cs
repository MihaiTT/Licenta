using AplicatieGestiune.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieGestiune
{
    public partial class formPrimary : Form
    {
        public formPrimary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            
            formProduse p1 = new formProduse();
            p1.ShowDialog();
            
        }

        private void btnFurnizori_Click(object sender, EventArgs e)
        {
            formFurnizori f1 = new formFurnizori();
            f1.ShowDialog();
        }
    }
}
