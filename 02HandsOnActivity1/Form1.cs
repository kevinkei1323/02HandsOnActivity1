using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02HandsOnActivity1
{
    public partial class QueuingForm : Form
    {
        public QueuingForm()
        {
            InitializeComponent();
        }
        private CashierClass cashier = new CashierClass();


        private void btnNextForm_Click(object sender, EventArgs e)
        {
            CashierWindowQueue form2 = new CashierWindowQueue();
            form2.ShowDialog();
        }



        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

      


    }

}
