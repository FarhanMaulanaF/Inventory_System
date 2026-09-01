using Microsoft.Data.SqlClient;

namespace POSandInventory
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public Form1()
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            MessageBox.Show("Connected");
        }

        private void btn_manageBrand_Click(object sender, EventArgs e)
        {
            Form2 brandList = new Form2();
            brandList.TopLevel = false;
            panel3.Controls.Add(brandList);
            brandList.BringToFront();
            brandList.Show();
        }
    }
}
