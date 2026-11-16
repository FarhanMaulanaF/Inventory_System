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
    public partial class form_brandList : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public form_brandList()
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

        private void dgv_brandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_brandList.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                if (e.RowIndex < 0) return;

                form_brand brandForm = new form_brand(this);
                brandForm.tb_brandName.Text = dgv_brandList.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                brandForm.ShowDialog(); 
            }
        }
    }
}
