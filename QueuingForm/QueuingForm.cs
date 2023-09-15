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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            CashierWindowQueue CashierFrm = new CashierWindowQueue();
            CashierFrm.Show();
            InitializeComponent();
            cashier = new CashierClass();//cash
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }
    }
}
