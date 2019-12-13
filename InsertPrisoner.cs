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
using System.Data.SqlClient;

namespace PSM
{
    public partial class InsertPrisoner : Form
    {
        public static string name, address, gender, nationality, id;
        public static DateTime punishmentstart,punishmentend;
        Thread th;
        public static int duration;

        DBAccess objdbAccess = new DBAccess();

        public InsertPrisoner()
        {
            InitializeComponent();
        }

       

        private void cmbcrimnation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationality = cmbcrimnation.Text;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            name = txtcrimname.Text;
            address = txtcrimadd.Text;
            
            if(rbtnfemale.Checked)
            {
                gender = "Female";
            }
            else if(rbtnmale.Checked)
            {
                gender = "Male";
            }
            nationality = cmbcrimnation.Text;
            id = txtcrimid.Text;
            duration = Convert.ToInt32(txtpanishdue.Text);
            punishmentstart = dtpuninshstart.Value;
            punishmentend = dtpuninshstart.Value.AddMonths(duration);

            if (name == "")
            {
                MessageBox.Show("Please Input the Name.");
            }

            else if(address == "")
            {
                MessageBox.Show("Please Input the address.");
            }

            else if(gender == "")
            {
                MessageBox.Show("Please Input the gender.");
            }

            else if (nationality == "Choose the Region:")
            {
                MessageBox.Show("Please Choose the Region.");
            }

            else 
            {
                SqlCommand insertCommand = new SqlCommand("insert into CriminalInfo(CriminalID,CriminalName,CriminalAddress,CriminalGender,CriminalNationality,PunishmentStart,PunishmentEnd) values (@id,@name,@address,@gender,@nationality,@punishmentstart,@punishmentend)");
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@address", address);
                insertCommand.Parameters.AddWithValue("@gender", gender);
                insertCommand.Parameters.AddWithValue("@nationality", nationality);
                insertCommand.Parameters.AddWithValue("@punishmentstart", punishmentstart);
                insertCommand.Parameters.AddWithValue("@punishmentend", punishmentend);
                int row = objdbAccess.executeQuery(insertCommand);
                if(row == 1)
                {
                    MessageBox.Show("Data Inserted Successfully.");
                }

                else
                {
                    MessageBox.Show("Error ! Please Try Again Later. ");
                }
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
