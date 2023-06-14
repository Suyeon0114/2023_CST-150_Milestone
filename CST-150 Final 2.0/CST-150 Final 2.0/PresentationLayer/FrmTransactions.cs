/* Suyeon Park
 * CST-150
 * 04/30/23
 * Milestone 7
 * This is all my own work except...
 * In class example - Activity 5, Dog Class, Dice Class, Activity 12
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST_150_Final_2._0.BusinessLayer;
using CST_150_Final_2._0.Models;

namespace CST_150_Final_2._0.PresentationLayer
{
    public partial class FrmTransactions : Form
    {
        // Create the class level object
        // Inventory Reference Variables
        // Master inventory
        List<InvItem> invItems = new List<InvItem>();

        // List that will hold all items found for search
        List<InvItem> invSearch = new List<InvItem>();

        // txtFile directory path
        string txtFile = Application.StartupPath + "Data\\Inventory.txt";

        // Instantiate the business layer
        Inventory inventory = new Inventory();

        // Property
        private int SelectedGridIndex { get; set; }


        /// <summary>
        /// Class Constructor
        /// </summary>
        public FrmTransactions()
        {
            InitializeComponent();

            // Initicalize the open file dialog
            // Set the properties of this dialog
            // Step 1: Define the initial directory that is shown
            openFileDialog.InitialDirectory = Application.StartupPath + "Data";

            // Set the tile of open file dialog
            openFileDialog.Title = "Browse Txt Files";

            // Default Extension is only used when "All Files" is selected
            //  from the filter box and new extension is specified by the use.
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Make the error lable not visible
            lblErrorMsg.Visible = false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReadFile_ClickEventHandler(object sender, EventArgs e)
        {
            // Once the button is clicked - show the open file dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Instantiate the business class and get all the inv
                // items from the text file.
                invItems = inventory.ReadInventory(invItems);

                // After the the list have been populated, set the DataSource
                // property of the DataGrid control to the list
                gvIncome.DataSource = null;
                gvIncome.DataSource = invItems;

                // Populate column headers
                inventory.PopulateColumnHeaders(gvIncome);
            }
        }


        /// <summary>
        /// Click Event Handler to add a new transaction to the data grid view tool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddItem_ClickEventHandler(object sender, EventArgs e)
        {
            // Declare and Intialize
            // Flag that tracks that all entries are all valid
            bool isValidEntries = true;
            int intAmount = 0;

            // Flag to varify parsing double is true or false
            bool isValid = false;

            // Make sure the Error lable is not visible
            lblErrorMsg.Visible = false;

            // Instantiate our Uitlity class so we can use it.
            Inventory Inventory = new Inventory();

            //--------------------------------------------------------
            //        Verify all boxes have correct inputs
            //--------------------------------------------------------
            // We will be using a Utility / Helper Class to verify the inputs

            // Check if all the input data types are valid
            if (!Inventory.NotNull(txtName.Text) || !Inventory.NotNull(cmbMonth.Text) || !Inventory.NotNull(cmbInOrOut.Text) || !Inventory.NotNull(cmbCategory.Text))
            {
                isValidEntries = false;
            }

            // Now test the text box for vaild int amount
            // If valid the amount will convert the bool parse
            (intAmount, isValid) = Inventory.ValidInt(txtAmount.Text);
            if (!isValid)
            {
                isValidEntries = false;
            }

            //--------------------------------------------------------
            //     End - Verify all boxes have correct inputs
            //--------------------------------------------------------

            // If our isValidEntries is still true, we can populate the dataGridView with the entry
            // else display error message
            if (isValidEntries)
            {
                // Clear out the gridview for the new datas
                gvIncome.DataSource = null;

                // If we are here, we know we have valid entries
                // so lets populate the dataGridView
                Inventory inventory = new Inventory();
                InvItem transaction = new InvItem(Inventory.ConvertToInOut(cmbInOrOut.Text), cmbMonth.Text, txtName.Text, Convert.ToInt16(txtAmount.Text), cmbCategory.Text);
                invItems.Add(transaction);

                // Bind updated data to the gridview
                gvIncome.DataSource = invItems;

                // Populate column headers
                inventory.PopulateColumnHeaders(gvIncome);

                inventory.FileWriteOut(invItems, txtFile);
                // Write the added object back to the file
                // Now we can write to file
                //lineWrite = String.Format("{0}, {1}, {2}, {3}, {4}", transaction.InOrOut, transaction.Month, transaction.Name, transaction.Amount, transaction.Category);
                //File.WriteAllLines(txtFile, lineWrite);
            }
            else
            {
                // If we are here, there is a problem with an entry
                // Show the error message
                lblErrorMsg.Visible = true;
            }

            // Reset the text boxes before the next data entry
            txtName.Text = "";
            txtAmount.Text = "";
            cmbInOrOut.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
        }


        /// <summary>
        /// Event Handler to manage click event of Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            // Get the selected row
            SelectedGridIndex = gvIncome.CurrentRow.Index;
            // Now we also know the index of the List to get our information
        }


        /// <summary>
        /// Event Handler to inc inventory amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncAmount_ClickEventHandler(object sender, EventArgs e)
        {
            // Make sure the logic is not in the presentation layer
            // Inc Qty in Inventory class
            // Instantiate the Inventory class so we can use our IncQtyValue method
            // Create an instance of the Inventory class
            Inventory incAmount = new Inventory();

            // Invoke the method to inc qty, and get the master List back
            invItems = incAmount.IncAmountValue(invItems, SelectedGridIndex);

            // Write the added object back to the file
            inventory.FileWriteOut(invItems, txtFile);

            // Since the List contains the master inventory, 
            // Refresh the date in the Data Grid View.
            // Since we have already bound the List to the Data Grid View through DataSource...
            gvIncome.Refresh();

            // Populate column headers
            inventory.PopulateColumnHeaders(gvIncome);
        }


        /// <summary>
        /// Event Handler to dec inventory amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDecAmount_ClickEventHandler(object sender, EventArgs e)
        {
            // Make sure the logic is not in the presentation layer
            // Inc Qty in Inventory class
            // Instantiate the Inventory class so we can use our IncQtyValue method
            // Create an instance of the Inventory class
            Inventory decAmount = new Inventory();

            // Invoke the method to inc qty, and get the master List back
            invItems = decAmount.DecAmountValue(invItems, SelectedGridIndex);

            // Write the added object back to the file
            inventory.FileWriteOut(invItems, txtFile);

            // Since the List contains the master inventory, 
            // Refresh the date in the Data Grid View.
            // Since we have already bound the List to the Data Grid View through DataSource...
            gvIncome.Refresh();

            // Populate column headers
            inventory.PopulateColumnHeaders(gvIncome);
        }


        /// <summary>
        /// Delete an item from inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteItem_ClickEventHandler(object sender, EventArgs e)
        {
            // We already know the selected row is the index 
            // Make sure we remove the item from the mater inventory (List)
            invItems.RemoveAt(SelectedGridIndex);

            // We have to be careful when deleting items
            // since we might go out of range exception
            gvIncome.DataSource = null;

            // Last step is to bind the new data back to the new Data Grid View
            gvIncome.DataSource = invItems;
            // Key --> invItems still contains the mater inventory list!!!

            // Write the added object back to the file
            inventory.FileWriteOut(invItems, txtFile);

            // Since the List contains the master inventory, 
            // Refresh the date in the Data Grid View.
            // Since we have already bound the List to the Data Grid View through DataSource...
            gvIncome.Refresh();

            // Populate column headers
            inventory.PopulateColumnHeaders(gvIncome);
        }


        /// <summary>
        /// Search Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_ClickEventHandler(object sender, EventArgs e)
        {
            // Our goal is to read from the text box
            // and search the master list in the type column for a match.
            // If there is a match or multiple matches, then we show the matche(s)
            // in the data grid view on the secondary form.
            string searchFor = txtSearch.Text;

            // Since the searching is logic - we put the search in the business layer
            Inventory businessLayer = new Inventory();

            // Search for the matvh and put the results in the search list
            invSearch = businessLayer.SearchItem(invItems, searchFor, invSearch);

            // Send this invSearch over to the secondary form to be displayed 
            FrmBudget frmBudget = new FrmBudget(invSearch);

            // Now to show to the form 
            // Notice .Show() method shows the form in a non modal form
            // Which means you can click on the parent form.
            // .ShowDialog() method shows the form moalllody meaning
            // you cannot go to the parent form
            frmBudget.Show();
        }

    }
}
