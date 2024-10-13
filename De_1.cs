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
    public partial class De_1 : Form
    {
        public De_1()
        {
            
            InitializeComponent();
        }

        private void De_1_Load(object sender, EventArgs e)
        {
            Sql_QLNS qlns = new Sql_QLNS();
            DataTable dT = qlns.ds_qlns("SELECT ROW_NUMBER() OVER (ORDER BY id) STT,id as 'STT', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1");
            drQlns.DataSource = dT;
            drQlns.Columns[1].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sql_QLNS qlns = new Sql_QLNS();           
            int row = qlns.Change("INSERT INTO QLNS_D1 VALUES(N'"+txtHoten.Text+"',N'"+(rdNam.Checked == true ? "Nam" : "Nữ") + "',N'"+cbQuenquan.Text+"',N'"+cbDonvi.Text+"',N'"+cbHocham.Text+"')");
            DataTable dT = qlns.ds_qlns("SELECT ROW_NUMBER() OVER (ORDER BY id) STT, id as 'STT', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1");
            drQlns.DataSource = dT;
            drQlns.Columns[1].Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sql_QLNS qlns = new Sql_QLNS();
            int row = qlns.Change("DELETE FROM QLNS_D1 WHERE id = '"+Convert.ToInt32(drQlns.CurrentRow.Cells[1].Value)+"'");
            DataTable dT = qlns.ds_qlns("SELECT ROW_NUMBER() OVER (ORDER BY id) STT, id as 'STT1', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1");
            drQlns.DataSource = dT;
            drQlns.Columns[1].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sql_QLNS qlns = new Sql_QLNS();
            int row = qlns.Change("UPDATE QLNS_D1 SET Hoten = N'"+ txtHoten.Text + "', Gioitinh = N'"+(rdNam.Checked == true ? "Nam" : "Nữ") + "', Quequan = N'"+cbQuenquan.Text+ "', Donvi = N'"+cbDonvi.Text+ "', Hocham = N'"+cbHocham.Text+"' WHERE id = '"+Convert.ToInt32(drQlns.CurrentRow.Cells[1].Value)+"'");
            DataTable dT = qlns.ds_qlns("SELECT ROW_NUMBER() OVER (ORDER BY id) STT,id as 'STT', Hoten as 'Họ tên',Gioitinh as 'Giới tính',Quequan as 'Quê quán',Donvi as 'Đơn vị',Hocham as 'Học hàm/Học vị' FROM QLNS_D1");
            drQlns.DataSource = dT;
            drQlns.Columns[1].Visible = false;

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Find find = new Find();
            find.Show();
            
        }
    }
}
