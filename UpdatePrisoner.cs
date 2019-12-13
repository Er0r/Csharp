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
    public partial class UpdatePrisoner : Form
    {
        DBAccess objdbAccess = new DBAccess();
        Thread th;
        public UpdatePrisoner()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string username, prisonerid,duration;
            username = txtusername.Text;
            prisonerid = txtprisonerid.Text;
            //duration = txtduration.Text;
            if(username == "")
            {
                MessageBox.Show("Please Input the username.");
            }
            if(prisonerid == "")
            {
                MessageBox.Show("Please Input the prisonerID.");
            }
            else
            {
                
                //DateTime totalduration = InsertPrisoner.punishmentstart.AddMonths(Convert.ToInt32(duration));
                DateTime punishend = dttimepunishend.Value;
                string q = "Update CriminalInfo SET PunishmentEnd = '" + @punishend + "' where CriminalName = '" + username + "' And CriminalID = '" + prisonerid + "'";
                SqlCommand sqlupdate = new SqlCommand(q);
                sqlupdate.Parameters.AddWithValue("@punishend", punishend);
                //SqlCommand sqlupdate = new SqlCommand(q);
                
                int row = objdbAccess.executeQuery(sqlupdate);
                if(row == 1)
                {
                    MessageBox.Show("Information Updated.");
                }
                else
                {
                    MessageBox.Show("Please Try Again Later. ");
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
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
