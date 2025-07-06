using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GroceryAppOrtiz
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
            LoadGroceryList();
        }

        private void LoadGroceryList()
        {
            string filePath = "shoppinglist.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<string> items = JsonConvert.DeserializeObject<List<string>>(json);

                ListSavedItems.Items.Clear();

                foreach (string item in items)
                {
                    ListSavedItems.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No saved grocery list found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Optional: any logic you want
        }

        private void lstSavedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: any logic when listbox selection changes
        }
    }
}
