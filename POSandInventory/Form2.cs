using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POSandInventory
{
    public partial class Form2 : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public Form2()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            loadBrand();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_brand brandForm = new form_brand(this);
            brandForm.ShowDialog();
        }

        public void loadBrand()
        {
            int i = 0;
            dgv_brandList.Rows.Clear();
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM tblBrand order by brand", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_brandList.Rows.Add(i, dr["id"].ToString()!, dr["brand"].ToString()!);

            }
            dr.Close();
            cn.Close();
        }
    }
}
