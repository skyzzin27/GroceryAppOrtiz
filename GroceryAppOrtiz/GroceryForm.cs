using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryAppOrtiz
{
    public partial class Form1 : Form
    {
        private List<string> groceryList = new List<string>();
        private const int MaxItems = 5;

        public Form1()
        {
            InitializeComponent();
            btnAddItem.MouseEnter += btnAddItem_MouseEnter;
            btnAddItem.MouseLeave += btnAddItem_MouseLeave;
        }

        private void txtGrocery_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (groceryList.Count >= MaxItems)
            {
                MessageBox.Show("Maximum of 5 items only.");
                return;
            }

            string item = txtGrocery.Text.Trim();

            if (!string.IsNullOrEmpty(item))
            {
                groceryList.Add(item);
                LIstGroceries.Items.Add(item);
                txtGrocery.Clear();
            }
        }


        private void lstGroceries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = "shoppinglist.json";
            string json = JsonConvert.SerializeObject(groceryList, Formatting.Indented);
            File.WriteAllText(filePath, json);
            MessageBox.Show("List saved to shoppinglist.json!");
        }

        private void btnViewSaved_Click(object sender, EventArgs e)
        {
            DisplayForm display = new DisplayForm();
            display.ShowDialog();
        }

        private void btnAddItem_MouseEnter(object sender, EventArgs e)
        {
            btnAddItem.BackColor = Color.DeepSkyBlue;
        }

        private void btnAddItem_MouseLeave(object sender, EventArgs e)
        {
            btnAddItem.BackColor = Color.LightSkyBlue;
        }

        private void PictureLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
