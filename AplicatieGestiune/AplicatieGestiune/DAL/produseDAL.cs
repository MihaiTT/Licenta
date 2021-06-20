using AplicatieGestiune.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AplicatieGestiune.DAL
{
    class produseDAL
    {
        //static string method for db connection string
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select method
        public DataTable Select()
        {
            //creating db connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //sql query 
                string sql = "SELECT * FROM Produse";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                //open db connection
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert method
        public bool Insert(produseBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Produse (QR_code, nume_produs, id_furnizor, pret_fara_TVA, procent_TVA, cantitate_stoc, unitate_masura) VALUES (@QR_code, @nume_produs, @id_furnizor, @pret_fara_TVA, @procent_TVA, @cantitate_stoc, @unitate_masura)";
                //sql command to pass values 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //through params
                cmd.Parameters.AddWithValue("@QR_code", p.QR_code);
                cmd.Parameters.AddWithValue("@nume_produs", p.nume_produs);
                cmd.Parameters.AddWithValue("@id_furnizor", p.id_furnizor);
                cmd.Parameters.AddWithValue("@pret_fara_TVA", p.pret_fara_TVA);
                cmd.Parameters.AddWithValue("@procent_TVA", p.procent_TVA);
                cmd.Parameters.AddWithValue("@cantitate_stoc", p.cantitate_stoc);
                cmd.Parameters.AddWithValue("@unitate_masura", p.unitate_masura);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //success
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Update method
        public bool Update(produseBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE Produse SET QR_code=@QR_code, nume_produs=@nume_produs, id_furnizor=@id_furnizor, pret_fara_TVA=@pret_fara_TVA, procent_TVA=@procent_TVA, cantitate_stoc=@cantitate_stoc, unitate_masura=@unitate_masura WHERE QR_code=@QR_code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@QR_code", p.QR_code);
                cmd.Parameters.AddWithValue("@nume_produs", p.nume_produs);
                cmd.Parameters.AddWithValue("@id_furnizor", p.id_furnizor);
                cmd.Parameters.AddWithValue("@pret_fara_TVA", p.pret_fara_TVA);
                cmd.Parameters.AddWithValue("@procent_TVA", p.procent_TVA);
                cmd.Parameters.AddWithValue("@cantitate_stoc", p.cantitate_stoc);
                cmd.Parameters.AddWithValue("@unitate_masura", p.unitate_masura);

                //open db connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Delete method
        public bool Delete(produseBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //query to delete from DB
                string sql = "DELETE FROM Produse WHERE QR_code=@QR_code";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@QR_code", p.QR_code);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
