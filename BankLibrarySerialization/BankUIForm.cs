using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrarySerialization
{
    public partial class BankUIForm : Form
    {
        protected int textBoxCount {get; set;} = 4;

        public enum TextBoxIndices { Account, FirstName, LastName, Balance }
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void clearTextBoxes()
        {
            foreach(Control guiControl in this.Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public void setTextValues(string[] values)
        {
            if(values.Length != this.textBoxCount)
            {
                throw new ArgumentException($"There must be {this.textBoxCount} strings in the array", nameof(values));
            } else
            {
                accountTextBox.Text = values[(int)TextBoxIndices.Account];
                firstNameTextBox.Text = values[(int)TextBoxIndices.FirstName];
                lastNameTextBox.Text = values[(int)TextBoxIndices.LastName];
                balanceTextBox.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        public string[] getTextBoxValues()
        {
            return new string[]
            {
                accountTextBox.Text,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                balanceTextBox.Text
            };
        }
    }
}
