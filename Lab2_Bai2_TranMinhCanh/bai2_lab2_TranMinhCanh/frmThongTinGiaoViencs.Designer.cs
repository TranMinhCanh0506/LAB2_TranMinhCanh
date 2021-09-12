
namespace bai2_lab2_TranMinhCanh
{
    partial class frmThongTinGiaoViencs
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.rbSDT = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbMa = new System.Windows.Forms.RadioButton();
            this.lbTimTheo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTimTheo = new System.Windows.Forms.TextBox();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.rbSDT);
            this.grbSearch.Controls.Add(this.rbName);
            this.grbSearch.Controls.Add(this.rbMa);
            this.grbSearch.Location = new System.Drawing.Point(53, 47);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(408, 81);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Tìm Theo";
            // 
            // rbSDT
            // 
            this.rbSDT.AutoSize = true;
            this.rbSDT.Location = new System.Drawing.Point(269, 37);
            this.rbSDT.Name = "rbSDT";
            this.rbSDT.Size = new System.Drawing.Size(118, 24);
            this.rbSDT.TabIndex = 2;
            this.rbSDT.TabStop = true;
            this.rbSDT.Text = "Số điện thoại";
            this.rbSDT.UseVisualStyleBackColor = true;
            this.rbSDT.CheckedChanged += new System.EventHandler(this.rbSDT_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(145, 37);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(77, 24);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "Họ Tên";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbMa
            // 
            this.rbMa.AutoSize = true;
            this.rbMa.Location = new System.Drawing.Point(23, 37);
            this.rbMa.Name = "rbMa";
            this.rbMa.Size = new System.Drawing.Size(116, 24);
            this.rbMa.TabIndex = 0;
            this.rbMa.TabStop = true;
            this.rbMa.Text = "Mã giáo viên";
            this.rbMa.UseVisualStyleBackColor = true;
            this.rbMa.CheckedChanged += new System.EventHandler(this.rbMa_CheckedChanged);
            // 
            // lbTimTheo
            // 
            this.lbTimTheo.AutoSize = true;
            this.lbTimTheo.Location = new System.Drawing.Point(24, 198);
            this.lbTimTheo.Name = "lbTimTheo";
            this.lbTimTheo.Size = new System.Drawing.Size(12, 20);
            this.lbTimTheo.TabIndex = 1;
            this.lbTimTheo.Text = ".";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(388, 191);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 29);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtTimTheo
            // 
            this.txtTimTheo.Location = new System.Drawing.Point(143, 193);
            this.txtTimTheo.Name = "txtTimTheo";
            this.txtTimTheo.Size = new System.Drawing.Size(206, 27);
            this.txtTimTheo.TabIndex = 3;
            // 
            // frmThongTinGiaoViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 244);
            this.Controls.Add(this.txtTimTheo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbTimTheo);
            this.Controls.Add(this.grbSearch);
            this.Name = "frmThongTinGiaoViencs";
            this.Text = "Tìm Thông Tin Giáo Viên";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.RadioButton rbSDT;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbMa;
        private System.Windows.Forms.Label lbTimTheo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTimTheo;
    }
}