using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Desjardins
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> materialList = new List<KeyValuePair<string, string>>();
            Array materials = Enum.GetValues(typeof(DesktopMaterial));
            foreach (DesktopMaterial material in materials)
            {
                materialList.Add(new KeyValuePair<string, string>(material.ToString(), ((int)material).ToString()));
            }
            materialBox.DataSource = materialList;
            materialBox.DisplayMember = "Key";
            materialBox.ValueMember = "Value";
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }

        private void DeskDepth_TextChanged(object sender, EventArgs e)
        {
            if (DeskDepth.Text != "")
            {
                int depth = int.Parse(DeskDepth.Text);
                if (depth < 12 || depth > 48)
                {
                    depthError.Visible = true;
                }
                else
                {
                    depthError.Visible = false;
                }
            }
        }

        private void deskWidth_TextChanged(object sender, EventArgs e)
        {
            if (deskWidth.Text != "")
            {
                int width = int.Parse(deskWidth.Text);
                if (width < 24 || width > 96)
                {
                    widthError.Visible = true;
                }
                else
                {
                    widthError.Visible = false;
                }
            }
        }
        private void CustomerName_TextChanged(object sender, EventArgs e)
        {
            if (CustomerName.Text == "")
            {
                nameError.Visible = true;
            }
            else
            {
                nameError.Visible = false;
            }
        }

        private void drawers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drawers.SelectedIndex < 0)
            {
                drawerError.Visible = true;
            }
            else
            {
                drawerError.Visible = false;
            }
        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialBox.SelectedIndex < 0)
            {
                materialError.Visible = true;
            }
            else
            {
                materialError.Visible = false;
            }
        }

        private void shipping_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shipping.SelectedIndex < 0)
            {
                shippingError.Visible = true;
            }
            else
            {
                shippingError.Visible = false;
            }
        }

        private void getQuote_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (CustomerName.Text == "")
            {
                isValid = false;
                nameError.Visible = true;
            }

            if (DeskDepth.Text != "")
            {
                int depth = int.Parse(DeskDepth.Text);
                if (depth < 12 || depth > 48)
                {
                    depthError.Visible = true;
                    isValid = false;
                }
            }

            if (DeskDepth.Text == "")
            {
                depthError.Visible = true;
                isValid = false;
            }

            if (deskWidth.Text != "")
            {
                int width = int.Parse(deskWidth.Text);
                if (width < 24 || width > 96)
                {
                    widthError.Visible = true;
                    isValid = false;
                }
            }

            if (deskWidth.Text == "")
            {
                widthError.Visible = true;
                isValid = false;
            }

            if (drawers.SelectedIndex < 0)
            {
                drawerError.Visible = true;
                isValid = false;
            }

            if (materialBox.SelectedIndex < 0)
            {
                materialError.Visible = true;
                isValid = false;
            }

            if (shipping.SelectedIndex < 0)
            {
                shippingError.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                //String qName = CustomerName.Text;
                int qDepth = int.Parse(DeskDepth.Text);
                int qWidth = int.Parse(deskWidth.Text);
                int qDrawer = drawers.SelectedIndex;
                DesktopMaterial qMaterial = (DesktopMaterial)materialBox.SelectedIndex;

                String qName = CustomerName.Text;
                Desk qDesk = new Desk(qDepth, qWidth, qDrawer, qMaterial);
                int qShipping = 0;


                switch (shipping.SelectedIndex)
                {
                    case 0:
                        qShipping = 14;
                        break;
                    case 1:
                        qShipping = 7;
                        break;
                    case 2:
                        qShipping = 5;
                        break;
                    case 3:
                        qShipping = 3;
                        break;
                    default:
                        break;
                }

                DeskQuote deskQuote = new DeskQuote(qName, qDesk, qShipping);

                AddQuote addQuote = new AddQuote();
                addQuote.Tag = this;
                addQuote.Show(this);
                this.Close();
            }
        }
    }
}
