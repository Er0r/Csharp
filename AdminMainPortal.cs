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
    public partial class AdminMainPortal : Form
    {
        Thread th;
        public AdminMainPortal()
        {
            InitializeComponent();
        }

        private void btninsertprisoner_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openinsertprisoner);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openshowprisoner);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnupdateprisoner_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openupdateprisoner);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btndeleteprisoner_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opendeleteprisoner);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openinsertprisoner(object obj)
        {
            Application.Run(new InsertPrisoner());
        }

        private void openshowprisoner(object obj)
        {
            Application.Run(new ShowPrisoner());
        }

        private void openupdateprisoner(object obj)
        {
            Application.Run(new UpdatePrisoner());
        }

        private void opendeleteprisoner(object obj)
        {
            Application.Run(new DeletePrisoner());
        }

    }

    
}
