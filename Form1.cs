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
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openadminfacade);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //AdminFacade adfac = new AdminFacade();
            //adfac.Show();
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void openadminfacade(object obj)
        {
            Application.Run(new AdminFacade());
        }

        
    }
}
