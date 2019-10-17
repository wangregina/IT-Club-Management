using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMQL
{
    public partial class TrangChu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void BtnQLThanhVien_Click(object sender, EventArgs e)
        {
            ThanhVien formTV = new ThanhVien();
            formTV.TopLevel = false;
            panelThongTin.Controls.Add(formTV);
            formTV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formTV.Dock = DockStyle.Fill;
            formTV.Show();
        }

        private void BtnThemTV_Click(object sender, EventArgs e)
        {
            popupThemTV popupt = new popupThemTV();
            popupt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            popupt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            popupt.Show();
        }
    }
}
