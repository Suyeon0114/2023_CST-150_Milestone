/* Suyeon Park
 * CST-150
 * 04/30/23
 * Milestone 7
 * This is all my own work except...
 * In class example - Activity 5, Dog Class, Dice Class, Activity 12
 * Alli Adam
 * Reference
 * https://stackoverflow.com/questions/14013999/use-a-custom-currency-symbol-for-a-datagridview-column
 */

using CST_150_Final_2._0.Models;
using CST_150_Final_2._0.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Globalization;

namespace CST_150_Final_2._0.BusinessLayer
{
    public class Inventory
    {
        // Class level variable
        // Enter the location of the file to open
        string txtFile = Application.StartupPath + "Data\\Inventory.txt";

        /// <summary>
        /// Utility that returns false if the parameter string is null, empty, or just contains whitte spaces
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns>bool</returns>
        public bool NotNull(string textToTest)
        {
            // Check if the string is empty, null, or contains only whitespace
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Test to determine if a valid double was entered. 
        /// If true, the string is converted to double and true is retrned. 
        /// If the string cannot be converted to double, 0 is returned as double and false for bool.
        /// This returnes a type called Tuple
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns>int, bool</returns>
        public (int intValue, bool isConverted) ValidInt(string valueToTest)
        {
            // Declare and Initialize
            int convertValue = 0;

            // Test to see if the string can be parsed to a double
            if (int.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            return (convertValue, false);
        }

        /// <summary>
        /// Test to determine if income was entered. 
        /// If true, the "Income" and true is retrned. 
        /// If the input is not income, empty set of string is returned and false for bool.
        /// </summary>
        /// <param name="comboBool"></param>
        /// <returns>string, bool</returns>
        public string ConvertToInOut(string comboBool)
        {
            // Declare and Initialize
            string inOutResult = "Spending";

            // Test to see if the string can be parsed to a bool
            if (comboBool == "+")
            {
                inOutResult = "Income";
                return inOutResult;
            }
            return inOutResult;
        }

        // Purpose of this class is to read the text file into a List
        // Then pass the list to the FrmInventory.cs. 

        /// <summary>
        /// Read the inventory txt file and return a list of type InvItems class
        /// </summary>
        /// <param name="InvItems"></param>
        /// <returns>List<InvItem></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            // Open the file with "using"
            // Then main goal to use "using" is to manage resources
            // and release all the resources automatically when done.(garbage collector)
            using (var str = File.OpenText(txtFile))
            {
                // Iterate through the txt file line by line
                foreach (string line in File.ReadLines(txtFile, Encoding.UTF8))
                {
                    // Split up the line at each comma
                    // don't forget to trim
                    string[] rowData = line.Split(",");

                    // Now we can add the line to out List<InvItem>
                    // which is out class model
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(), rowData[1].ToString().Trim(), 
                        rowData[2].ToString().Trim(), Convert.ToInt16(rowData[3]), rowData[4].ToString().Trim()));

                }
            }
            // Return the list
            return invItems;
        }

        /// <summary>
        /// Inc inventory in the List and then return the updated list
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> IncAmountValue(List<InvItem> invItems, int selectedRowIndex)
        {
            // Inc the qty value using the property name from the model
            int updateAmount = invItems[selectedRowIndex].Amount + 10;

            // Then put the value back into the List
            invItems[selectedRowIndex].Amount = updateAmount;

            // Then just return the updated List
            return invItems;
        }

        /// <summary>
        /// Dec inventory in the List and then return the updated list
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> DecAmountValue(List<InvItem> invItems, int selectedRowIndex)
        {
            // Inc the qty value using the property name from the model
            int updateAmount = invItems[selectedRowIndex].Amount - 10;

            // Then put the value back into the List
            invItems[selectedRowIndex].Amount = updateAmount;

            // Then just return the updated List
            return invItems;
        }

        /// <summary>
        /// Writes the updated file out to the txt file
        /// </summary>
        /// <param name="invItems"></param>
        public void FileWriteOut(List<InvItem> invItems, string fileName)
        {
            // Initialize the txt file path
            fileName = txtFile;

            // create a new List array to store the updated data that will be put into the txtFile
            List<string> lines = new List<string>();

            // iterate through each items in the mastery List
            foreach (InvItem item in invItems)
            {
                // format the added item 
                string line = $"{item.InOrOut},{item.Month},{item.Name},{item.Amount},{item.Category}";
                
                // add the formatted line to the List array
                lines.Add(line);
            }

            // Write the formatted List array out the file
            File.WriteAllLines(fileName, lines);
        }


        /// <summary>
        /// Rsturns List with search results
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="searchCriteria"></param>
        /// <param name="invSearch"></param>
        /// <returns></returns>
        public List<InvItem> SearchItem(List<InvItem> invItems, string searchCriteria, List<InvItem> invSearch)
        {
            // Make sure the invSearch List is cleared befroe we start
            invSearch.Clear();

            // Iterate over the Main inventory, and see if we can find any matches to the search criteria
            foreach (InvItem item in invItems)
            {
                // search by name
                if (item.Name.ToLower().Contains(searchCriteria.ToLower()))
                {
                    // If an item was found, add it to the list
                    invSearch.Add(item);
                }

                // search by category
                if (item.Category.ToLower().Contains(searchCriteria.ToLower()))
                {
                    // If an item was found, add it to the list
                    invSearch.Add(item);
                }
                
                // search by month
                if (item.Month.ToLower().Contains(searchCriteria.ToLower()))
                {
                    // If an item was found, add it to the list
                    invSearch.Add(item);
                }

                // search by transaction type
                if (item.InOrOut.ToLower().Contains(searchCriteria.ToLower()))
                {
                    // If an item was found, add it to the list
                    invSearch.Add(item);
                }
            }
            // Return the end results of the search
            return invSearch;
        }


        /// <summary>
        /// Populate data grid view column headers
        /// </summary>
        /// <param name="gvName"></param>
        public void PopulateColumnHeaders(DataGridView gvName)
        {
            // What if we do not like the names in the header of our Grid?
            // Iterate through the header one column at a time 
            // and change the header names plus format numaric column
            foreach (DataGridViewColumn column in gvName.Columns)
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
          
                // Switch statement to change header text
                // column.Index starts at 0 - end count.
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Description";
                        break;
                    case 1:
                        column.HeaderText = "Month";
                        break;
                    case 2:
                        column.HeaderText = "Amount";
                        // Number format to the nothing to the right of the decimal
                        column.DefaultCellStyle.Format = "${0}";
                        format.CurrencySymbol = "$";
                        gvName.Columns["Amount"].DefaultCellStyle.FormatProvider = format;
                        gvName.Columns["Amount"].DefaultCellStyle.Format = "c";
                        // All numbers should be right justified
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case 3:
                        column.HeaderText = "Type";
                        break;
                    case 4:
                        column.HeaderText = "Category";
                        break;
                    default:
                        // Show a message indicating something did not work correctly
                        MessageBox.Show("Invalid column was trying to be accessed.");
                        break;
                }
            }
        }


        /// <summary>
        /// Calculates and returns the total income, spendings, and the budget left
        /// Tuple
        /// </summary>
        /// <param name="mySearch"></param>
        /// <returns></returns>
        public (double income, double spending, double budget) GetBudgetLeft(List<InvItem> mySearch)
        {
            // Declare and Initialize
            double totalIncome = 0;
            double totalSpending = 0;
            double budgetLeft = 0;

            // Iterate through search results and find income,
            // and add the income, spending amounts to get the total
            foreach (InvItem item in mySearch)
            {
                if (item.InOrOut == "Spending")
                {
                    totalSpending = totalSpending + item.Amount;
                }
                else if (item.InOrOut == "Income")
                {
                    totalIncome = totalIncome + item.Amount;
                }
            }
            // calculate the budget left
            budgetLeft = totalIncome - totalSpending;

            // Return all three results
            return (totalIncome, totalSpending, budgetLeft);
        }
    }
}
