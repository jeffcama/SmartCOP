using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCOP
{
    enum DrinkOpt:int
    {
        Invalid = -1,
        Beer,
        Juice,
        Soda
    };


    public partial class Form1 : Form
    {
        //List to maintain drinks
        public static List<Drink> drinks = new List<Drink>();

        public Form1()
        {
            InitializeComponent();

            //Add each of the default drinks to the drinks list
            drinks.Add(new Juice() { Name = "Orange Juice", Carbonated = false, Fruit = "Oranges" });
            drinks.Add(new Beer() { Name = "Budweiser", Carbonated = true, Abv = "5" });
            drinks.Add(new Soda() { Name = "Pepsi", Carbonated = true});

            //Add each of the default drinks to the list box
            foreach (Drink d in drinks)
            {
                lstDrinkList.Items.Add(d.Description);
                txtMainDisplay.Text += d.Description + " ";
            }
        }

        //Called when the "add" button is clicked to add a drink to the list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";

            //Check that the user selected a drink type
            if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Invalid)
            {
                message = "Please Select Valid Drink Type";
            }
            //Check that the user entered a drink name
            else if(txtName.TextLength == 0)
            {
                message = "Please Enter Drink Name";
            }
            //If the selected drink type is beer
            else if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Beer)
            {
                //Do not add a non-carbonated beer. Advise user...
                if (chkCarbonated.Checked == false)
                {
                    message = "Please Throw Away Flat Beer";
                }
                else
                {
                    string desc;

                    //If the user entered a '%' remove it to validate the ABV value
                    if (txtDetails.Text.EndsWith("%"))
                    {
                        desc = txtDetails.Text.Remove(txtDetails.Text.Length-1);
                    }
                    else
                    {
                        desc = txtDetails.Text;
                    }

                    //Ensure that the user entered a number between 1 and 2 digits
                    if (!desc.All(char.IsNumber) ||
                        (desc.Length < 1 || desc.Length > 2))
                    {
                        message = "Please Enter Valid ABV Number";
                    }
                }
            }
            //If the sleected drink type id Juice
            else if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Juice)
            {
                //Ensure that the user entered only letters
                //Currently only supports one fruit, sorry strawberry lemonade...
                if ((!txtDetails.Text.All(char.IsLetter)) ||
                    (txtDetails.Text.Length < 1))
                {
                    message = "Please Enter A Single Fruit The Juice Is Made With";
                }
            }

            //Display Error message if one was detected
            if (message.Length > 0)
            {
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            //No error was detected, so add the new drink
            else
            {
                //Add a Beer, Juice, or Soda to the drinks list depending on the user's drink type selection
                if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Beer)
                {
                    drinks.Add(new Beer() { Name = txtName.Text, Carbonated = chkCarbonated.Checked, Abv = txtDetails.Text });
                }
                else if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Juice)
                {
                    drinks.Add(new Juice() { Name = txtName.Text, Carbonated = chkCarbonated.Checked, Fruit = txtDetails.Text });
                }
                else //if (cbDrinkType.SelectedIndex == (int)DrinkOpt.Soda)
                {
                    drinks.Add(new Soda() { Name = txtName.Text, Carbonated = chkCarbonated.Checked });
                }

                //Add the new drink's description to the list box
                lstDrinkList.Items.Add(drinks.Last().Description);

                //Since there is at lead one drink, enable the 'delete' button
                btnDelete.Enabled = true;
            }
        }

        //Called when the 'delete' button is clicked to remote a drink from the list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //If a drink is selected, remove if from both the drinks list and the list box
            if (lstDrinkList.SelectedIndex != -1)
            {
                drinks.RemoveAt(lstDrinkList.SelectedIndex);
                lstDrinkList.Items.RemoveAt(lstDrinkList.SelectedIndex);
            }

            //If nore more drinks exist, disable the 'delete' button
            if(lstDrinkList.Items.Count == 0)
            {
                btnDelete.Enabled = false;
            }
        }

        //Called when the Drink Type combo box is changed
        private void cbDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If a valid drink type is selected enabled the fields to allow the user to enter a drink
            if(cboDrinkType.SelectedIndex != (int)DrinkOpt.Invalid)
            {
                txtName.Enabled = true;
                chkCarbonated.Enabled = true;
                txtDetails.Enabled = true;
                btnAdd.Enabled = true;
            }
            //Otherwise disable them
            else
            {
                txtName.Enabled = false;
                chkCarbonated.Enabled = false;
                txtDetails.Enabled = false;
                btnAdd.Enabled = false;
            }

            //Change the label's text based on which drink was selected
            if(cboDrinkType.SelectedIndex == (int)DrinkOpt.Beer)
            {
                lblDetails.Text = "ABV:";
                lblDrinkName.Text = "Beer Name:";                
            }
            else if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Juice)
            {
                lblDetails.Text = "Fruit Type:";
                lblDrinkName.Text = "Juice Name:";
            }
            if (cboDrinkType.SelectedIndex == (int)DrinkOpt.Soda)
            {
                lblDetails.Text = "Details:";
                lblDrinkName.Text = "Soda Name:";
                //No details can be added for Soda so clear and disable the text box
                txtDetails.Enabled = false;
                txtDetails.Clear();
            }
        }

        //Called when the mode button is clicked to switch between edit and display mode
        private void btnMode_Click(object sender, EventArgs e)
        {
            //If the app was in Display mode enter Edit mode
            if(btnMode.Text == "Display List")
            {
                btnMode.Text = "Edit List";
                //Hide all 'edit' fields
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                lblDrinkName.Visible = false;
                lblDetails.Visible = false;
                lblDrinkType.Visible = false;
                cboDrinkType.Visible = false;
                chkCarbonated.Visible = false;
                txtDetails.Visible = false;
                txtName.Visible = false;
                lstDrinkList.Visible = false;
                txtMainDisplay.Visible = true;
                //Resize the window
                this.Size = new Size(675, 235);

                //Clear the text that was in the main display text box
                //and add the desciption for each item in the list
                txtMainDisplay.Clear(); 
                foreach (Drink d in drinks)
                {
                    txtMainDisplay.Text += d.Description + " ";
                }
            }
            //The app was in Edit mode so enter Display mode
            else
            {
                btnMode.Text = "Display List";
                //Show all 'edit' fields
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                lblDrinkName.Visible = true;
                lblDetails.Visible = true;
                lblDrinkType.Visible = true;
                cboDrinkType.Visible = true;
                chkCarbonated.Visible = true;
                txtDetails.Visible = true;
                txtName.Visible = true;
                lstDrinkList.Visible = true;
                txtMainDisplay.Visible = false;
                //Resize the window to fit 'edit' fields
                this.Size = new Size(675, 300);
            }

        }
    }
}
