namespace POSandInventory
{
    partial class form_brand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_brand));
            panel1 = new Panel();
            btn_close = new Button();
            label1 = new Label();
            lbl_brandName = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 40);
            panel1.TabIndex = 1;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.MediumSeaGreen;
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Location = new Point(829, 1);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(38, 37);
            btn_close.TabIndex = 2;
            btn_close.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 2;
            label1.Text = "Brand Module";
            // 
            // lbl_brandName
            // 
            lbl_brandName.AutoSize = true;
            lbl_brandName.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_brandName.Location = new Point(12, 73);
            lbl_brandName.Name = "lbl_brandName";
            lbl_brandName.Size = new Size(112, 28);
            lbl_brandName.TabIndex = 2;
            lbl_brandName.Text = "Brand Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(729, 34);
            textBox1.TabIndex = 3;
            // 
            // form_brand
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 245);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(lbl_brandName);
            Controls.Add(panel1);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "form_brand";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_close;
        private Label lbl_brandName;
        private TextBox textBox1;
    }
}