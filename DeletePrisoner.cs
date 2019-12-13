using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace PSM
{
    public partial class DeletePrisoner : Form
    {
        Thread th;
        DBAccess objdbAccess = new DBAccess();
        public DeletePrisoner()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtprisonerName.Text;
            string id = txtPrisonerID.Text;
            string q = "delete CriminalInfo where CriminalName = '" + name + "'And CriminalID = '" + id + "'";
            SqlCommand sqldelete = new SqlCommand(q);
            int row = objdbAccess.executeQuery(sqldelete);
            if (row == 1)
            {
                MessageBox.Show("Record Deleted Successfully.");
            }
            else
            {
                MessageBox.Show("Please Try Again Later. ");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backAdminMainPortal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void backAdminMainPortal(object obj)
        {
            Application.Run(new AdminMainPortal());
        }
    }
}
