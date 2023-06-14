/* Suyeon Park
 * CST-150
 * 04/30/23
 * Milestone 7
 * This is all my own work except...
 * In class example - Activity 5, Dog Class, Dice Class, Activity 12
 */

using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;

namespace CST_150_Final_2._0.Models
{
    public class InvItem
    {
        // Define the Properties
        public string Name { get; set; }
        public string Month { get; set; }
        public int Amount { get; set; }
        public string InOrOut { get; set; }
        public string Category { get; set; }


        /// <summary>
        /// Default Constructor
        /// </summary>
        public InvItem()
        {
            // Initialize Properties
            Name = "";
            Month = "";
            Amount = 0;
            InOrOut = "";
            Category = "";
        }

        /// <summary>
        /// Parameterized Construtor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="month"></param>
        /// <param name="amount"></param>
        /// <param name="inOrOut"></param>
        /// <param name="category"></param>
        public InvItem(string inOrOut, string month, string name, int amount, string category)
        {
            Name = name;
            Month = month;
            Amount = amount;
            InOrOut = inOrOut;
            Category = category;
        }

    }
}
