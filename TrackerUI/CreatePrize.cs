using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        IPrizeRequester callingForm;
        public CreatePrize(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPriceBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValue.Text, placeNumValue.Text, 
                    priceAmountValue.Text, prizePercentageValue.Text);

                GlobalConfig.Connections.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
                //placeNameValue.Text = "";
                //placeNumValue.Text = "";
                //priceAmountValue.Text = "0";
                //prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("Prize form has invalid entries. Please correct.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                // TODO - Prompt error message to user
                output = false; 
            }

            if (placeNumber < 1)
            {
                output = false; 
            }
            if (placeNameValue.Text.Length == 0)
            {
                output = false; 
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(priceAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false; 
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false; 
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false; 
            }
            return output;
        }
    }
}
