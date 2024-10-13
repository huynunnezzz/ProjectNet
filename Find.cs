using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_1
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (rdQuequan.Checked == true)
            {
                Sql_QLNS qlns = new Sql_QLNS();
                DataTable dT = qlns.ds_qlns("SELECT id as 'STT', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1 WHERE Quequan LIKE N'" + txtQuenquan.Text + "%'");
                drTimkiem.DataSource = dT;
            }
            if (rdDonvi.Checked == true)
            {
                Sql_QLNS qlns = new Sql_QLNS();
                DataTable dT = qlns.ds_qlns("SELECT id as 'STT', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1 WHERE Donvi LIKE N'" + txtDonvi.Text + "%'");
                drTimkiem.DataSource = dT;
            }
            if (rdHocham.Checked == true)
            {
                Sql_QLNS qlns = new Sql_QLNS();
                DataTable dT = qlns.ds_qlns("SELECT id as 'STT', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1 WHERE Hocham LIKE N'" + txtHocham.Text + "%'");
                drTimkiem.DataSource = dT;
            }
        }
    }

}
