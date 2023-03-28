using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSmockup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int totalAmount;
        private int amountChange;

        private void AddSidesAmount(object sender, EventArgs e)
        {
            Button? btnAsCastedObj = sender as Button;
            string castedObjId = btnAsCastedObj.Name;
            char tempCastId = castedObjId.Substring(castedObjId.Length - 1, 1)[0];

            switch (tempCastId)
            {
                case '1': textBoxAmountSides1.Text = addSidesAmount(int.Parse(textBoxAmountSides1.Text)).ToString(); break;
                case '2': textBoxAmountSides2.Text = addSidesAmount(int.Parse(textBoxAmountSides2.Text)).ToString(); break;
                case '3': textBoxAmountSides3.Text = addSidesAmount(int.Parse(textBoxAmountSides3.Text)).ToString(); break;
            }

            checkAmountUI(tempCastId);
        }

        private void SubtractSidesAmount(object sender, EventArgs e)
        {
            Button? btnAsCastedObj = sender as Button;
            string castedObjId = btnAsCastedObj.Name;
            char tempCastId = castedObjId.Substring(castedObjId.Length - 1, 1)[0];

            switch (tempCastId)
            {
                case '1': textBoxAmountSides1.Text = subtractSidesAmount(int.Parse(textBoxAmountSides1.Text)).ToString(); break;
                case '2': textBoxAmountSides2.Text = subtractSidesAmount(int.Parse(textBoxAmountSides2.Text)).ToString(); break;
                case '3': textBoxAmountSides3.Text = subtractSidesAmount(int.Parse(textBoxAmountSides3.Text)).ToString(); break;
            }

            checkAmountUI(tempCastId);
        }

        private int addSidesAmount(int initamount)
        {
            return initamount + 1;
        }

        private int subtractSidesAmount(int initAmount)
        {
            return initAmount > 0 ? initAmount - 1 : 0;
        }

        private void checkAmountUI(char objId)
        {
            switch (objId)
            {
                case '1': if (int.Parse(textBoxAmountSides1.Text) > 0) { buttonSubtractSides1.Enabled = true; } else { buttonSubtractSides1.Enabled = false; } break;
                case '2': if (int.Parse(textBoxAmountSides2.Text) > 0) { buttonSubtractSides2.Enabled = true; } else { buttonSubtractSides2.Enabled = false; } break;
                case '3': if (int.Parse(textBoxAmountSides3.Text) > 0) { buttonSubtractSides3.Enabled = true; } else { buttonSubtractSides3.Enabled = false; } break;
            }
        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            textBoxOrderAmount.Text = addSidesAmount(int.Parse(textBoxOrderAmount.Text)).ToString();
            if (int.Parse(textBoxOrderAmount.Text) > 0) { buttonItemSubtract.Enabled = true; } else { buttonItemSubtract.Enabled = false; }
        }

        private void buttonItemSubtract_Click(object sender, EventArgs e)
        {
            textBoxOrderAmount.Text = subtractSidesAmount(int.Parse(textBoxOrderAmount.Text)).ToString();
            if (int.Parse(textBoxOrderAmount.Text) > 0) { buttonItemSubtract.Enabled = true; } else { buttonItemSubtract.Enabled = false; }
        }

        private void filterNumerics(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void computeFunc(object sender, EventArgs e)
        {
            int temptotal, orderTotal, pizzaTotal, addonsTotal;

            temptotal = int.Parse(textBoxTotal.Text);


            pizzaTotal = getPizzaTotal();
            addonsTotal = getAddOnsTotal();

            orderTotal = pizzaTotal + addonsTotal;

            textBoxTotal.Text = orderTotal.ToString();
            textBoxChange.Text = (int.Parse(textBoxCash.Text) - temptotal).ToString();
            if (int.Parse(textBoxChange.Text) < 0) { buttonPrint.Enabled = false; } else { buttonPrint.Enabled = true; }

        }

        private int getPizzaTotal()
        {
            int selectedPizza, pizzaAmount;
            if (radioButtonSize1.Checked) { selectedPizza = int.Parse(textBoxItem1.Text); }
            else if (radioButtonSize2.Checked) { selectedPizza = int.Parse(textBoxItem2.Text); }
            else { selectedPizza = int.Parse(textBoxItem3.Text); }


            pizzaAmount = int.Parse(textBoxOrderAmount.Text);

            return selectedPizza * pizzaAmount;
        }

        private int getAddOnsTotal()
        {
            int friesTotal, icedTeaTotal, spagTotal, addOnsTotal;
            friesTotal = 0;
            icedTeaTotal = 0;
            spagTotal = 0;
            if (checkBoxSides1.Checked) { friesTotal = int.Parse(textBoxPriceSides1.Text) * int.Parse(textBoxAmountSides1.Text); }
            if (checkBoxSides1.Checked) { icedTeaTotal = int.Parse(textBoxPriceSides2.Text) * int.Parse(textBoxAmountSides2.Text); }
            if (checkBoxSides1.Checked) { spagTotal = int.Parse(textBoxPriceSides3.Text) * int.Parse(textBoxAmountSides3.Text); }

            addOnsTotal = friesTotal + icedTeaTotal + spagTotal;

            return addOnsTotal;
        }
    }
}
