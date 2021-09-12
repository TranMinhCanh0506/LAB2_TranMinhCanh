using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_TranMinhCanh_1914899
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            this.cbbMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rbNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }
        
             
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
                s += int.Parse(lbTinHocA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                s += int.Parse(lbTinHocB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                s += int.Parse(lbTiengAnhA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s += int.Parse(lbTiengAnhB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";
        }
    }
}
