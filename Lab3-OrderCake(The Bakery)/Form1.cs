using CakeClasses;
using System;
using System.Windows.Forms;


namespace Lab3_OrderCake_The_Bakery_
{
    public partial class frmOrderCake : Form
    {
        string flavour, occasion, design;
        double size, numOfLayers;

        Order order = new Order();
        Cake cake;

        public frmOrderCake()
        {
            InitializeComponent();
            lstCharCake.Items.Add("Minion Cake $40");
            lstCharCake.Items.Add("SuperHero Cake $35");
            lstCharCake.Items.Add("SuperGirl Cake $35");
            lstCharCake.Items.Add("MotherGoose Cake $30");


            radCustomCake.Checked = true;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (order.ListOfCakes.Count == 0)
                MessageBox.Show("No cake selected!");
            else
                MessageBox.Show(order.ToString());

        }

        private void radCustomCake_CheckedChanged(object sender, EventArgs e)
        {
            grpOccasion.Enabled = true;
            grpSize.Enabled = true;
            grpDesign.Enabled = true;
            lstCharCake.Enabled = false;
        }

        private void radCharacterCake_CheckedChanged(object sender, EventArgs e)
        {
            grpOccasion.Enabled = false;
            grpSize.Enabled = false;
            grpDesign.Enabled = false;
            lstCharCake.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radChocolate.Checked = true;
            radAnniversary.Checked = true;
            rad6inch.Checked = true;
            rad1layer.Checked = true;
            radPolka.Checked = true;
            radCustomCake.Checked = true;

            txtFName.Text = " ";
            txtLName.Text = " ";

            lstCharCake.ClearSelected();

            txtFName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // order.ListOfCakes = new List<Cake>();

            order.Customer.FirstName = txtFName.Text;
            order.Customer.LastName = txtLName.Text;

            //Getting the flavour
            if (radChocolate.Checked)
            {
                flavour = "Chocolate";
            }
            else if (radBanana.Checked)
            {
                flavour = "Banana";
            }
            else if (radLemonBerry.Checked)
            {
                flavour = "Lemon Berry";
            }
            else if (radVanilla.Checked)
            {
                flavour = "Vanilla";
            }
            //-----------------------------------------

            //Getting the number of Layers

            //-----------------------------------
            if (rad1layer.Checked)
            {
                numOfLayers = 1.0;
            }
            else if (rad2layers.Checked)
            {
                numOfLayers = 2.0;
            }
            else if (rad3layers.Checked)
            {
                numOfLayers = 3.0;
            }
            else if (rad4layers.Checked)
            {
                numOfLayers = 4.0;
            }
            //--------------------------

            //Getting the Occasion

            //--------------------------

            if (radAnniversary.Checked)
            {
                occasion = "Anniversary";
            }
            else if (radBirthday.Checked)
            {
                occasion = "Birthday";
            }
            else if (radRetirement.Checked)
            {
                occasion = "Retirement";
            }
            else if (radWedding.Checked)
            {
                occasion = "Wedding";
            }

            //--------------------------

            //Getting the Size of the cake

            //---------------------------

            if (rad6inch.Checked)
            {
                size = 6.0;
            }
            else if (rad8inch.Checked)
            {
                size = 8.0;
            }
            else if (rad10inch.Checked)
            {
                size = 10.0;
            }
            else if (rad12inch.Checked)
            {
                size = 12.0;
            }

            //------------------------

            //Getting the cake's Design

            //-----------------------

            if (radPolka.Checked)
            {
                design = "Polka Dots";
            }
            else if (radEdible.Checked)
            {
                design = "Edible Images";
            }
            else if (radBow.Checked)
            {
                design = "Fondant Bow";
            }
            else if (rad3D.Checked)
            {
                design = "3D Figures";
            }
            //----------------------------------------------------

            // Selecting the type of Cake, Customized or Characterized (themes)

            //----------------------------------------------------



            if (radCustomCake.Checked)
            /*if the client choose the custom cake, the program are going to instantiate an Order object taking as async parameter an
                object of the type CustomCake*/

            {
                cake = new CustomCake(flavour, numOfLayers, occasion, size, design);
                order.AddCake((CustomCake)cake);

            }

            else if (radCharacterCake.Checked)
            /*if the client choose the custom cake, the program are going to instantiate an Order object taking as parameter an
            object of the type CharacterCake*/
            {
                for (int i = 0; i < lstCharCake.SelectedItems.Count; i++)
                {
                    cake = new CharacterCake(flavour, numOfLayers, lstCharCake.SelectedItems[i].ToString());
                    order.AddCake((CharacterCake)cake);

                }

            }

            btnReset.Focus();

        }
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            order.ClearList();

        }

    }
}
