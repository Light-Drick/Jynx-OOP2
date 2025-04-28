namespace FoodWasteTracking
{
    partial class TRACKER
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpFoodDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DateTimePicker dtpWasteDate;
        private System.Windows.Forms.DataGridView dgvFoodWaste;
        private System.Windows.Forms.Button btnAddWaste;
        private System.Windows.Forms.Button btnEditWaste;
        private System.Windows.Forms.Button btnDeleteWaste;
        private System.Windows.Forms.Panel panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpFoodDetails = new GroupBox();
            txtAmount = new TextBox();
            txtReason = new TextBox();
            dtpWasteDate = new DateTimePicker();
            lblTitle = new Label();
            dgvFoodWaste = new DataGridView();
            panelButtons = new Panel();
            btnAddWaste = new Button();
            btnEditWaste = new Button();
            btnDeleteWaste = new Button();
            comboFoodType = new ComboBox();
            grpFoodDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodWaste).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpFoodDetails
            // 
            grpFoodDetails.Controls.Add(comboFoodType);
            grpFoodDetails.Controls.Add(txtAmount);
            grpFoodDetails.Controls.Add(txtReason);
            grpFoodDetails.Controls.Add(dtpWasteDate);
            grpFoodDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpFoodDetails.ForeColor = Color.DarkSlateGray;
            grpFoodDetails.Location = new Point(25, 50);
            grpFoodDetails.Name = "grpFoodDetails";
            grpFoodDetails.Padding = new Padding(10);
            grpFoodDetails.Size = new Size(600, 200);
            grpFoodDetails.TabIndex = 1;
            grpFoodDetails.TabStop = false;
            grpFoodDetails.Text = "Enter Waste Details";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(20, 80);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Amount (grams)";
            txtAmount.Size = new Size(250, 34);
            txtAmount.TabIndex = 1;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(300, 40);
            txtReason.Name = "txtReason";
            txtReason.PlaceholderText = "Reason for Waste";
            txtReason.Size = new Size(250, 34);
            txtReason.TabIndex = 2;
            // 
            // dtpWasteDate
            // 
            dtpWasteDate.Location = new Point(300, 80);
            dtpWasteDate.Name = "dtpWasteDate";
            dtpWasteDate.Size = new Size(250, 34);
            dtpWasteDate.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(200, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Food Waste Tracker";
            // 
            // dgvFoodWaste
            // 
            dgvFoodWaste.BackgroundColor = Color.White;
            dgvFoodWaste.BorderStyle = BorderStyle.Fixed3D;
            dgvFoodWaste.ColumnHeadersHeight = 29;
            dgvFoodWaste.Location = new Point(25, 270);
            dgvFoodWaste.Name = "dgvFoodWaste";
            dgvFoodWaste.RowHeadersWidth = 51;
            dgvFoodWaste.Size = new Size(600, 250);
            dgvFoodWaste.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Controls.Add(btnAddWaste);
            panelButtons.Controls.Add(btnEditWaste);
            panelButtons.Controls.Add(btnDeleteWaste);
            panelButtons.Location = new Point(25, 540);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(600, 50);
            panelButtons.TabIndex = 3;
            // 
            // btnAddWaste
            // 
            btnAddWaste.BackColor = Color.MediumSeaGreen;
            btnAddWaste.FlatStyle = FlatStyle.Flat;
            btnAddWaste.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddWaste.ForeColor = Color.White;
            btnAddWaste.Location = new Point(50, 5);
            btnAddWaste.Name = "btnAddWaste";
            btnAddWaste.Size = new Size(120, 35);
            btnAddWaste.TabIndex = 0;
            btnAddWaste.Text = "Add";
            btnAddWaste.UseVisualStyleBackColor = false;
            btnAddWaste.Click += btnAddWaste_Click;
            // 
            // btnEditWaste
            // 
            btnEditWaste.BackColor = Color.Goldenrod;
            btnEditWaste.FlatStyle = FlatStyle.Flat;
            btnEditWaste.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditWaste.ForeColor = Color.White;
            btnEditWaste.Location = new Point(230, 5);
            btnEditWaste.Name = "btnEditWaste";
            btnEditWaste.Size = new Size(120, 35);
            btnEditWaste.TabIndex = 1;
            btnEditWaste.Text = "Edit";
            btnEditWaste.UseVisualStyleBackColor = false;
            btnEditWaste.Click += btnEditWaste_Click;
            // 
            // btnDeleteWaste
            // 
            btnDeleteWaste.BackColor = Color.IndianRed;
            btnDeleteWaste.FlatStyle = FlatStyle.Flat;
            btnDeleteWaste.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteWaste.ForeColor = Color.White;
            btnDeleteWaste.Location = new Point(410, 5);
            btnDeleteWaste.Name = "btnDeleteWaste";
            btnDeleteWaste.Size = new Size(120, 35);
            btnDeleteWaste.TabIndex = 2;
            btnDeleteWaste.Text = "Delete";
            btnDeleteWaste.UseVisualStyleBackColor = false;
            btnDeleteWaste.Click += btnDeleteWaste_Click;
            // 
            // comboFoodType
            // 
            comboFoodType.ForeColor = Color.Gray;
            comboFoodType.FormattingEnabled = true;
            comboFoodType.Items.AddRange(new object[] { "Grain", "Veggies", "Fruits", "Meat" });
            comboFoodType.Location = new Point(20, 38);
            comboFoodType.Name = "comboFoodType";
            comboFoodType.Size = new Size(250, 36);
            comboFoodType.TabIndex = 4;
            comboFoodType.Text = "Food Type";
            comboFoodType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TRACKER
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(650, 600);
            Controls.Add(lblTitle);
            Controls.Add(grpFoodDetails);
            Controls.Add(dgvFoodWaste);
            Controls.Add(panelButtons);
            Font = new Font("Segoe UI", 10F);
            Name = "TRACKER";
            Text = "Food Waste Tracking System";
            grpFoodDetails.ResumeLayout(false);
            grpFoodDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoodWaste).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private ComboBox comboFoodType;
    }
}
