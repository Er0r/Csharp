using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PSM
{
    
    public partial class AdminFacade : Form
    {
        Thread th;
        public static string useremail, userpassword;
        DBAccess objdbaccess = new DBAccess();
        DataTable dtusers = new DataTable();
        public AdminFacade()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            useremail = txtadminemail.Text;
            userpassword = txtadminpass.Text;
            
            if(useremail == "")
            {
                MessageBox.Show("Please Enter your Email.");
            }
            if(userpassword == "")
            {
                MessageBox.Show("Please Enter your Password");
            }
            else
            {
                string query = "Select * from AdminTable where AdminEmail= '" + useremail + "' AND AdminPassword = '" + userpassword + "'";
                objdbaccess.readDatathroughAdapter(query, dtusers);
                if(dtusers.Rows.Count == 1)
                {
                    MessageBox.Show("You Logged In Successfully...");
                    this.Close();
                    th = new Thread(openAdminMainPortal);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("Error ! Please Try Again Later. ");
                }
            }
        }
        private void openAdminMainPortal(object obj)
        {
            Application.Run(new AdminMainPortal());
        }
    }
}
