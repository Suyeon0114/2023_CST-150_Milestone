/* Suyeon Park
 * CST-150
 * 04/30/23
 * Milestone 7
 * This is all my own work except...
 * In class example - Activity 5, Dog Class, Dice Class, Activity 12
 */

using CST_150_Final_2._0.BusinessLayer;
using CST_150_Final_2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Final_2._0.PresentationLayer
{
    public partial class FrmBudget : Form
    {
        // Class Level List
        List<InvItem> mySearch = new List<InvItem>();

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public FrmBudget(List<InvItem> mySearch)
        {
            InitializeComponent();
            this.mySearch = mySearch;
        }


        /// <summary>
        /// When the form is loaded, populate the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBudget_LoadEventHandler(object sender, EventArgs e)
        {
            // Declare and Initialize
            double totalIncome = 0;
            double totalSpending = 0;
            double budgetLeft = 0;

            Inventory inventory = new Inventory();

            // Populate the data grid view
            gvSearchResults.DataSource = mySearch;

            // Populate column headers
            inventory.PopulateColumnHeaders(gvSearchResults);

            // Iterate through the search result and add up the income amounts,
            // then multiply the result by 0.8 to get the recommended budget.
            (totalIncome, totalSpending, budgetLeft) = inventory.GetBudgetLeft(mySearch);

            // Display it in the label
            lblTotalIncome.Text = string.Format("${0:#####}", totalIncome);
            lblTotalSpending.Text = string.Format("${0:#####}", totalSpending);
            lblBudgetLeft.Text = string.Format("${0:#####}", budgetLeft);
        }
    }
}
