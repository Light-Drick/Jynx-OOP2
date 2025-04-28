using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FoodWasteTracking
{
    public partial class TRACKER : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private List<FoodWaste> foodWasteList = new List<FoodWaste>();

        public TRACKER()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        // --- Initialize DataGridView with Columns ---
        private void InitializeDataGridView()
        {
            dgvFoodWaste.ColumnCount = 4;
            dgvFoodWaste.Columns[0].Name = "Food Type";
            dgvFoodWaste.Columns[1].Name = "Amount (grams)";
            dgvFoodWaste.Columns[2].Name = "Reason";
            dgvFoodWaste.Columns[3].Name = "Waste Date";

            dgvFoodWaste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodWaste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // --- Add Food Waste Entry ---
        private void btnAddWaste_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                FoodWaste newWaste = new FoodWaste(
                    txtFoodType.Text.Trim(),
                    Convert.ToInt32(txtAmount.Text.Trim()),
                    txtReason.Text.Trim(),
                    dtpWasteDate.Value
                );

                foodWasteList.Add(newWaste);
                UpdateDataGridView();
                ClearInputs();
            }
        }

        // --- Edit Selected Entry ---
        private void btnEditWaste_Click(object sender, EventArgs e)
        {
            if (dgvFoodWaste.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.", "Edit Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvFoodWaste.SelectedRows[0].Index;

            if (ValidateInputs())
            {
                foodWasteList[selectedIndex] = new FoodWaste(
                    txtFoodType.Text.Trim(),
                    Convert.ToInt32(txtAmount.Text.Trim()),
                    txtReason.Text.Trim(),
                    dtpWasteDate.Value
                );

                UpdateDataGridView();
                ClearInputs();
            }
        }

        // --- Delete Selected Entry ---
        private void btnDeleteWaste_Click(object sender, EventArgs e)
        {
            if (dgvFoodWaste.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvFoodWaste.SelectedRows[0].Index;
            foodWasteList.RemoveAt(selectedIndex);
            UpdateDataGridView();
        }

        // --- Validate Input Fields ---
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFoodType.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Amount must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // --- Update DataGridView with New Data ---
        private void UpdateDataGridView()
        {
            dgvFoodWaste.Rows.Clear();

            foreach (var waste in foodWasteList)
            {
                dgvFoodWaste.Rows.Add(waste.FoodType, waste.Amount, waste.Reason, waste.WasteDate.ToShortDateString());
            }
        }

        // --- Clear Input Fields ---
        private void ClearInputs()
        {
            txtFoodType.Clear();
            txtAmount.Clear();
            txtReason.Clear();
            dtpWasteDate.Value = DateTime.Now;
        }

        // --- Select Record to Edit ---
        private void dgvFoodWaste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFoodType.Text = dgvFoodWaste.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAmount.Text = dgvFoodWaste.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtReason.Text = dgvFoodWaste.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpWasteDate.Value = Convert.ToDateTime(dgvFoodWaste.Rows[e.RowIndex].Cells[3].Value);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class FoodWaste
    {
        public string FoodType { get; set; }
        public int Amount { get; set; }
        public string Reason { get; set; }
        public DateTime WasteDate { get; set; }

        public FoodWaste(string foodType, int amount, string reason, DateTime wasteDate)
        {
            FoodType = foodType;
            Amount = amount;
            Reason = reason;
            WasteDate = wasteDate;
        }
    }
}
