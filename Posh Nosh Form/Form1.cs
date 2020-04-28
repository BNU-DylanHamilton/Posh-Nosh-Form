using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posh_Nosh_Form
{
    public partial class Form1 : Form
    {
        private double starterCost, mainCost, dessertCost, totalCost;

        public Form1()
        {
            InitializeComponent();
        }

        private void dessertSelection(object sender, EventArgs e)
        {
            switch (dessertComboBox.Text)
            {
                case "Gulab Jamun": dessertCost = 5.00; break;
                case "Ice Cream": dessertCost = 3.50; break;
                case "Jam Roly Poly": dessertCost = 4.50; break;
                case "Treacle Tart": dessertCost = 4.00; break;
            }

            totalCost = starterCost + mainCost + dessertCost;
            totalLabel.Text = "£" + totalCost.ToString("0.00");
        }

        private void starterSelection(object sender, EventArgs e)
        {
            switch (starterListBox.Text)
            {
                case "Soup of the Day": starterCost = 4.00; break;
                case "Fish Cakes": starterCost = 5.00; break;
                case "Chilli Fish Cakes": starterCost = 5.50; break;
                case "Salad": starterCost = 4.00; break;
            }

            totalCost = starterCost + mainCost + dessertCost;
            totalLabel.Text = "£" + totalCost.ToString("0.00");
        } 
        
        private void mainSelection(object sender, EventArgs e)
        {
            switch (mainListBox.Text)
            {
                case "Steak and Chips": mainCost = 12.50; break;
                case "Fish and Chips": mainCost = 7.50; break;
                case "Vegetable Curry": mainCost = 8.00; break;
                case "Chicken Lasagne": mainCost = 7.25; break;
            }

            totalCost = starterCost + mainCost + dessertCost;
            totalLabel.Text = "£" + totalCost.ToString("0.00");
        }
        
        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
