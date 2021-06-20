using AplicatieGestiune.BLL;
using AplicatieGestiune.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicatieGestiune.UI
{
    public partial class formFurnizori : Form
    {
        public formFurnizori()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvFurnizori.DataSource = dt;
        }

        private void lblIdFurnizor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        private void btnAdaugaFurnizori_Click(object sender, EventArgs e)
        {
            //luam DATA din UI
            u.nume_furnizor = txtNumeFurnizor.Text;
            u.locatie_furnizor = txtLocatieFurnizor.Text;
            //Inserting Data
            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("Furnizor adaugat cu succes.");
                clear();
            }
            else
            {
                MessageBox.Show("Adaugarea a fost un esec.");

            }
            //refreshing DataGridView
            DataTable dt = dal.Select();
            dgvFurnizori.DataSource = dt;


        }
        private void clear()
        {
            txtNumeFurnizor.Text = "";
            txtLocatieFurnizor.Text = "";

        }

        private void dgvFurnizori_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of the particular row
            int rowIndex = e.RowIndex;
            txtIdFurnizor.Text = dgvFurnizori.Rows[rowIndex].Cells[0].Value.ToString();
            txtNumeFurnizor.Text = dgvFurnizori.Rows[rowIndex].Cells[1].Value.ToString();
            txtLocatieFurnizor.Text = dgvFurnizori.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void btnUpdateFurnizori_Click(object sender, EventArgs e)
        {
            //get values from UI
            u.id_furnizor = Convert.ToInt32(txtIdFurnizor.Text);
            u.nume_furnizor = txtNumeFurnizor.Text;
            u.locatie_furnizor = txtLocatieFurnizor.Text;
            //updating data into DB

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("Furnizor updatat cu succes.");
            }
            else
            {
                MessageBox.Show("Modificarea furnizorului a esuat.");
            }
            //refreshing dgv
            DataTable dt = dal.Select();
            dgvFurnizori.DataSource = dt;
        }

        private void btnStergeFurnizori_Click(object sender, EventArgs e)
        {
            //getting ID from UI
            u.id_furnizor = Convert.ToInt32(txtIdFurnizor.Text);
            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("Furnizor sters cu succes.");
                clear();
            }
            else
            {
                MessageBox.Show("Stergerea furnizorului a esuat.");
            }
            //refreshing dgv
            DataTable dt = dal.Select();
            dgvFurnizori.DataSource = dt;
        }

        private void txtSearchFurnizor_textChanged(object sender, EventArgs e)
        {
            //get keyword from UI
            string keywords = txtSearchFurnizori.Text;
            if (keywords != null)
            {
                //afisam furnizorul dupa keywords
                DataTable dt = dal.Search(keywords);
                dgvFurnizori.DataSource = dt;

            }
            else
            {
                //afisam toti furnizorii
                DataTable dt = dal.Select();
                dgvFurnizori.DataSource = dt;
            }
        }
    }
}
