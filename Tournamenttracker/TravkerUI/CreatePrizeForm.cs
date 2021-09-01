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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TravkerUI
{
    public partial class CreatePrizeForm : Form
    {


        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNamevalue.Text,
                    PlaceNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);
                foreach (IDataConnection db in GlobalConfig.connections)
                {
                    db.CreatePrize(model);
                }

                PlaceNamevalue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentageValue.Text = "0";
            }


            else
            {
                MessageBox.Show(" This form has invalid information.Plecse check it and try again.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool PlacenumberValidNumber = int.TryParse(PlaceNumberValue.Text, out  placeNumber);
            if (PlacenumberValidNumber == false)
            {
                output = false;

            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (PlaceNamevalue.Text.Length == 0)
            {
                output = false;

            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

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

        private void PrizeAmountValue_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
