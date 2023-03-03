using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolFG
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            ShowSuppliers();
        }
        Functions Fx = new Functions();
        private void ShowSuppliers()
        {
            string Query = "select * from SupplierTbl";
            DataSet ds = Fx.ShowData(Query);
            SuppliersList.DataSource = ds.Tables[0];
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || SupNameTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                string Supplier = SupNameTb.Text;
                string Phone = PhoneTb.Text;
                string Address = AddressTb.Text;
                try
                {
                    string Query = "insert into SupplierTbl values('" + Supplier + "','" + Phone + "','" + Address + "')";
                    Fx.SetData(Query, "Supplier inserted!!!");
                    ShowSuppliers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AddressTb.Text == "" || PhoneTb.Text == "" || SupNameTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                string Supplier = SupNameTb.Text;
                string Phone = PhoneTb.Text;
                string Address = AddressTb.Text;
                try
                {
                    string Query = "update SupplierTbl set SupName='" + Supplier + "',SupPhone='" + Phone + "',SupAdd='" + Address + "'where SupId=" + key + "'";
                    Fx.SetData(Query, "Supplier Updated!!!");
                    ShowSuppliers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void SuppliersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SupNameTb.Text = SuppliersList.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = SuppliersList.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = SuppliersList.SelectedRows[0].Cells[3].Value.ToString();
            if (SupNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SuppliersList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
