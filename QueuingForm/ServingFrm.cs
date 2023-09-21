using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class ServingFrm : Form
    {
        
        
        public ServingFrm()
        {
            InitializeComponent();
            
            
        }

        public void ServingNumber()
        {

            if (CashierClass.CashierQueue.Count > 0)
            {

                string srvngNumber = CashierClass.CashierQueue.Peek();

                lblServing.Text = srvngNumber;
            }

            else
            {
                lblServing.Text = " ";
            }
        }
    }
}
