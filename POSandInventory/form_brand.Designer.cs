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
            lbl_brandModule = new Label();
            lbl_brandName = new Label();
            tb_brandName = new TextBox();
            btn_save = new Button();
            btn_update = new Button();
            btn_cancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(lbl_brandModule);
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
            btn_close.Click += btn_close_Click;
            // 
            // lbl_brandModule
            // 
            lbl_brandModule.AutoSize = true;
            lbl_brandModule.BackColor = Color.Transparent;
            lbl_brandModule.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_brandModule.ForeColor = Color.White;
            lbl_brandModule.Location = new Point(7, 1);
            lbl_brandModule.Name = "lbl_brandModule";
            lbl_brandModule.Size = new Size(188, 42);
            lbl_brandModule.TabIndex = 2;
            lbl_brandModule.Text = "Brand Module";
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
            // tb_brandName
            // 
            tb_brandName.Location = new Point(139, 68);
            tb_brandName.Name = "tb_brandName";
            tb_brandName.Size = new Size(728, 34);
            tb_brandName.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(32, 32, 32);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(139, 131);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(32, 32, 32);
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(257, 131);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Silver;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.Black;
            btn_cancel.Location = new Point(375, 131);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(112, 34);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // form_brand
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 192);
            ControlBox = false;
            Controls.Add(btn_cancel);
            Controls.Add(btn_update);
            Controls.Add(btn_save);
            Controls.Add(tb_brandName);
            Controls.Add(lbl_brandName);
            Controls.Add(panel1);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "form_brand";
            StartPosition = FormStartPosition.CenterScreen;
            Load += form_brand_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_brandModule;
        private Button btn_close;
        private Label lbl_brandName;
        private TextBox tb_brandName;
        private Button btn_save;
        private Button btn_update;
        private Button btn_cancel;
    }
}