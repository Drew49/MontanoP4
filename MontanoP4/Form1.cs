using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontanoP4
{
    public partial class Form1 : Form
    {
        private List<InventoryItem> inventory = new List<InventoryItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxInventory.Items.Count >= 1)
            {
                if (lbxInventory.SelectedValue != null)
                {
                    var items = (List<InventoryItem>)lbxInventory.DataSource;

                    var item = (InventoryItem)lbxInventory.SelectedValue;
                    lbxInventory.DataSource = null;
                    lbxInventory.Items.Clear();
                    items.Remove(item);
                    lbxInventory.DataSource = items;
                    System.Windows.Forms.MessageBox.Show("Item deleted");
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No items found");
            }
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            if (cbxTypeOFDep.Text == "Straight Line")
            {
                DepreciationStraightLine item = new DepreciationStraightLine();
                item.Title = txbTitle.Text;
                item.StartVal = decimal.Parse(txbStartVal.Text);
                item.EndVal = decimal.Parse(txbEndVal.Text);
                item.Lifetime = int.Parse(txbLifetime.Text);
                item.DateInInventory = dtpInInventory.Value.ToString("yyyy-MM-dd");
                item.DateOutOfInventory = dtpOutofInventory.Value.ToString("yyyy-MM-dd");
                inventory.Add(item);
                lbxInventory.DataSource = null;
                lbxInventory.DataSource = inventory;
                System.Windows.Forms.MessageBox.Show("Item added successfully");
            }
            else if (cbxTypeOFDep.Text == "Double Decline")
            {
                DoubleDepreciation itemDD = new DoubleDepreciation(txbTitle.Text, decimal.Parse(txbStartVal.Text),
                    decimal.Parse(txbEndVal.Text));
                itemDD.Lifetime = int.Parse(txbLifetime.Text);
                
                itemDD.DateInInventory = dtpInInventory.Value.ToString("yyyy-MM-dd");
                itemDD.DateOutOfInventory = dtpOutofInventory.Value.ToString("yyyy-MM-dd");
                inventory.Add(itemDD);
                lbxInventory.DataSource= null;
                lbxInventory.DataSource = inventory;
                System.Windows.Forms.MessageBox.Show("Item added successfully");
            }
                
                
                    
                
            
        }
    }
}
