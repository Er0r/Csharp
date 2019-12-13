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
    public partial class ShowPrisoner : Form
    {
        Thread th;
        string connectionstring = @"Data Source=DESKTOP-RCR24TI;Initial Catalog=PSM;Integrated Security=True";
        public ShowPrisoner()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionstring))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from CriminalInfo", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgridshowcrim.DataSource = dtbl;
                

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
