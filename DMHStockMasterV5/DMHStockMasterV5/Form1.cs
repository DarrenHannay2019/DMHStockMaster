using System;
using System.Windows.Forms;

namespace DMHStockMasterV5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridForm objForm = new GridForm
            {
                MdiParent = this
            };
            objForm.LoadData("Warehouses");
            
            splitContainer1.Panel2.Controls.Add(objForm);
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            objForm.BringToFront();
        }

        private void ShopsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WHAdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WHTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShopAdjustToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShopTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AllReportsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MovementTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();     // Exit the application
        }
    }
}
