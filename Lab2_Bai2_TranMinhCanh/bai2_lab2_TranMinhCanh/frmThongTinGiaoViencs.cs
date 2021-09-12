
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bai2_lab2_TranMinhCanh
{
    public partial class frmThongTinGiaoViencs : Form
    {
        QuanLyGiaoVien QLGV = new QuanLyGiaoVien();
        public frmThongTinGiaoViencs()
        {
            InitializeComponent();
        }
        public frmThongTinGiaoViencs(QuanLyGiaoVien QLGV) : this()
        {
            this.QLGV = QLGV;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var type = QuanLyGiaoVien.KieuTim.TheoHoTen;
            
            if(rbMa.Checked)
            {
                type = QuanLyGiaoVien.KieuTim.TheoMa;
              
            }
            else if (rbName.Checked)
            {
                type = QuanLyGiaoVien.KieuTim.TheoHoTen;
                
            }
            else if (rbSDT.Checked)
            {
                type = QuanLyGiaoVien.KieuTim.TheoSDT;
          
            }
            var gv = QLGV.Tim(txtTimTheo.Text, type);
            if (gv is null)
            {
                MessageBox.Show("Không tìm thấy thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmTBGiaoVien = new frmTBGiaoVien();
                frmTBGiaoVien.SetText(gv.ToString());
                frmTBGiaoVien.ShowDialog();
            }


        }
        


        private void rbMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMa.Checked)
            {
                lbTimTheo.Text = rbMa.Text;
                txtTimTheo.Text = "";

            }

        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            lbTimTheo.Text = rbName.Text;
            txtTimTheo.Text = "";
        }

        private void rbSDT_CheckedChanged(object sender, EventArgs e)
        {
            lbTimTheo.Text = rbSDT.Text;
            txtTimTheo.Text = "";
        }
    }
}
