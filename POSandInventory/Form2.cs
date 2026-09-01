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
        public Form2()
        {
            InitializeComponent();
            for(int i = 0; i <= 10; ++i)
            {
                dataGridView1.Rows.Add(i, "1", "BRAND " + i);
            }
        }
    }
}
