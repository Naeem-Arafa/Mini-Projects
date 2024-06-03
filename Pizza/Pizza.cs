using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        // Retrieves the price of the selected pizza size
        float GetSelectedSizePrice()
        {
            if (radButSmall.Checked)
                return Convert.ToSingle(radButSmall.Tag);

            else if (radButMedium.Checked)
                return Convert.ToSingle(radButMedium.Tag);

            else
                return Convert.ToSingle(radButLarge.Tag);
        }

        // Calculates the total price of selected toppings
        float CalculateToppingPrice()
        {
            float TotalToppingPrice = 0;
            if (chBoxCheese.Checked)
                TotalToppingPrice += Convert.ToSingle(chBoxCheese.Tag);

            if (chBoxOnion.Checked)
                TotalToppingPrice += Convert.ToSingle(chBoxOnion.Tag);

            if (chBoxMushrooms.Checked)
                TotalToppingPrice += Convert.ToSingle(chBoxMushrooms.Tag);

            if (chBoxOlives.Checked)
                TotalToppingPrice += Convert.ToSingle(chBoxOlives.Tag);

            if (chBoxPeppers.Checked)
                TotalToppingPrice += Convert.ToSingle(chBoxPeppers.Tag);

            if (chBoxTomatoes.Checked)
                TotalToppingPrice += Convert.ToSingle(chBoxTomatoes.Tag);

            return TotalToppingPrice;
        }

        // Retrieves the price of the selected crust type
        float GetSelectedCrutPrice()
        {
            if (radButThinCrust.Checked)
                return Convert.ToSingle(radButThinCrust.Tag);

            else
                return Convert.ToSingle(radButThickCrust.Tag);
        }

        // Calculates the total price of the pizza
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingPrice() + GetSelectedCrutPrice();
        }

        // Updates the total price displayed on the UI
        void UpdateTotalPrice()
        {
            labToTotalPrice.Text = '$' + CalculateTotalPrice().ToString();
        }

        // Updates the displayed pizza size and total price
        void UpdateSize()
        {
            UpdateTotalPrice();

            if (radButSmall.Checked)
            {
                labToSize.Text = "Small";
                return;
            }

            if (radButMedium.Checked)
            {
                labToSize.Text = "Medium";
                return;
            }

            if (radButLarge.Checked)
            {
                labToSize.Text = "Large";
                return;
            }
        }

        // Updates the displayed crust type and total price
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if(radButThinCrust.Checked)
            {
                labToCrust.Text = "Thin Crust";
                return;
            }

            if (radButThickCrust.Checked)
            {
                labToCrust.Text = "Thick Crust";
                return;
            }
        }

        // Updates the displayed toppings and total price
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string TotalToppings = "";
            if (chBoxCheese.Checked)
                TotalToppings += "Extra Cheese";

            if (chBoxMushrooms.Checked)
                TotalToppings += ", Mushrooms";
            
            if (chBoxPeppers.Checked)
                TotalToppings += ", Peppers";
            
            if (chBoxOnion.Checked)
                TotalToppings += ", Onion";
            
            if (chBoxOlives.Checked)
                TotalToppings += ", Olives";
            
            if (chBoxTomatoes.Checked)
                TotalToppings += ", Tomatoes";

            if (TotalToppings.StartsWith(","))
                TotalToppings = TotalToppings.Substring(1, TotalToppings.Length - 1).Trim();

            if (TotalToppings == "")
                TotalToppings = "No Toppings";

            labToToppings.Text = TotalToppings;
        }

        // Resets the form to its default state
        void ResetForm()
        {
            //Reset Group Boxes.
            groupBoxCrustType.Enabled = true;
            groupBoxSize.Enabled = true;
            groupBoxToppings.Enabled = true;
            groupBoxWhereToEat.Enabled = true;

            //Set Medium As Default.
            radButMedium.Checked = true;

            //Reset Toppings
            chBoxCheese.Checked = false;
            chBoxMushrooms.Checked = false;
            chBoxPeppers.Checked = false;
            chBoxOlives.Checked = false;
            chBoxOnion.Checked = false;
            chBoxTomatoes.Checked = false;

            //Set ThinCrust As Default.
            radButThinCrust.Checked = true;

            //Set EatIn As Default.
            radButEatIn.Checked = true;

            //Reset Order Button.
            btnOrder.Enabled = true;

        }

        // Updates the displayed location to eat
        void UpdateWhereToEat()
        {
            if (radButEatIn.Checked)
            {
                labToWhereEat.Text = "Eat In";
                return;
            }

            if (radButTakeAway.Checked)
            {
                labToWhereEat.Text = "Take Away";
                return;
            }
        }

        // Updates the entire order summary
        void UpdateOrderSummary()
        {
            ResetForm();
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        // Event handler for updating size
        private void UpdateSize(object sender, EventArgs e)
        {
            UpdateSize();
        }

        // Event handler for updating crust
        private void UpdateCrust(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        // Event handler for updating toppings
        private void UpdateToppings(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        // Event handler for updating where to eat
        private void UpdateWhereToEat(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        // Event handler for order button click
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnOrder.Enabled = false;
                groupBoxCrustType.Enabled = false;
                groupBoxSize.Enabled = false;
                groupBoxToppings.Enabled = false;
                groupBoxWhereToEat.Enabled = false;
            }

            else
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Event handler for reset button click
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Event handler for form load
        private void Pizza_Load_1(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        
    }
}
