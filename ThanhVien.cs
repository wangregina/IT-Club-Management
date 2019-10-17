using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMQL.Bussiness;
namespace PMQL
{
    public partial class ThanhVien : DevExpress.XtraEditors.XtraForm
    {
        Bussinesslogic bs = new Bussinesslogic();
        public ThanhVien()
        {
            InitializeComponent();
        }

        private void BtnLocTV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ThanhVien_Load(object sender, EventArgs e)
        {
            dataGridViewTV.DataSource = bs.getThanhVien();
        }
    }
}