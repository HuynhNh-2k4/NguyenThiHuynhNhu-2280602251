namespace HuynhNhu_2280602251
{
    partial class ListView2
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
            this.btnDongY = new System.Windows.Forms.Button();
            this.lbMSNV = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.lbTennv = new System.Windows.Forms.Label();
            this.lbLuongcoban = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(401, 194);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(106, 33);
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // lbMSNV
            // 
            this.lbMSNV.AutoSize = true;
            this.lbMSNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSNV.Location = new System.Drawing.Point(12, 9);
            this.lbMSNV.Name = "lbMSNV";
            this.lbMSNV.Size = new System.Drawing.Size(184, 25);
            this.lbMSNV.TabIndex = 1;
            this.lbMSNV.Text = "Mã số nhân viên:";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(202, 13);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(305, 22);
            this.txtMSNV.TabIndex = 2;
            // 
            // lbTennv
            // 
            this.lbTennv.AutoSize = true;
            this.lbTennv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTennv.Location = new System.Drawing.Point(12, 69);
            this.lbTennv.Name = "lbTennv";
            this.lbTennv.Size = new System.Drawing.Size(160, 25);
            this.lbTennv.TabIndex = 1;
            this.lbTennv.Text = "Tên nhân viên:";
            // 
            // lbLuongcoban
            // 
            this.lbLuongcoban.AutoSize = true;
            this.lbLuongcoban.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongcoban.Location = new System.Drawing.Point(12, 131);
            this.lbLuongcoban.Name = "lbLuongcoban";
            this.lbLuongcoban.Size = new System.Drawing.Size(167, 25);
            this.lbLuongcoban.TabIndex = 1;
            this.lbLuongcoban.Text = "Lương cơ bản: ";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(202, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(305, 22);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(202, 131);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(305, 22);
            this.txtLuongCB.TabIndex = 2;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(17, 194);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(106, 33);
            this.btnBoQua.TabIndex = 0;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // ListView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 254);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lbLuongcoban);
            this.Controls.Add(this.lbTennv);
            this.Controls.Add(this.lbMSNV);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Name = "ListView2";
            this.Text = "Nhân Viên";
            //this.Load += new System.EventHandler(this.ListView2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label lbMSNV;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.Label lbTennv;
        private System.Windows.Forms.Label lbLuongcoban;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnBoQua;
    }
}