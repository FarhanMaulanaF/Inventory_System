using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace POSandInventory
{
    public partial class form_brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public form_brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void form_brand_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            btn_save.Enabled = true;
            btn_update.Enabled = true;
            tb_brandName.Clear();
            tb_brandName.Focus();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new SqlCommand("INSERT INTO tblBrand(brand)VALUES(@brand)", cn);
                    cmd.Parameters.AddWithValue("@brand", tb_brandName.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully saved.");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           
        }
    }
}
