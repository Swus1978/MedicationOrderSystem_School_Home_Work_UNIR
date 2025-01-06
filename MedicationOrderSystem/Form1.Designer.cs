using DocumentFormat.OpenXml.Bibliography;

namespace MedicationOrderSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            chkMainBranch = new CheckBox();
            chkSecondaryBranch = new CheckBox();
            tbMedicationName = new TextBox();
            rbCofarma = new RadioButton();
            rbEmpsephar = new RadioButton();
            rbCemefar = new RadioButton();
            qtQuantity = new NumericUpDown();
            tbMedicationType = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            grpDistributors = new Label();
            btnClear = new Button();
            btnSubmit = new Button();
            lblMedicationStatus = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)qtQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(198, 9);
            label1.Name = "label1";
            label1.Size = new Size(694, 65);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Medication Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(198, 96);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Medication Name:";
            // 
            // chkMainBranch
            // 
            chkMainBranch.AutoSize = true;
            chkMainBranch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkMainBranch.Location = new Point(198, 291);
            chkMainBranch.Name = "chkMainBranch";
            chkMainBranch.Size = new Size(95, 19);
            chkMainBranch.TabIndex = 11;
            chkMainBranch.Text = "Main Branch";
            // 
            // chkSecondaryBranch
            // 
            chkSecondaryBranch.AutoSize = true;
            chkSecondaryBranch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkSecondaryBranch.Location = new Point(198, 316);
            chkSecondaryBranch.Name = "chkSecondaryBranch";
            chkSecondaryBranch.Size = new Size(126, 19);
            chkSecondaryBranch.TabIndex = 12;
            chkSecondaryBranch.Text = "Secondary Branch";
            // 
            // tbMedicationName
            // 
            tbMedicationName.Location = new Point(198, 114);
            tbMedicationName.Name = "tbMedicationName";
            tbMedicationName.Size = new Size(272, 23);
            tbMedicationName.TabIndex = 2;
            // 
            // rbCofarma
            // 
            rbCofarma.AutoSize = true;
            rbCofarma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCofarma.Location = new Point(617, 195);
            rbCofarma.Name = "rbCofarma";
            rbCofarma.Size = new Size(72, 19);
            rbCofarma.TabIndex = 8;
            rbCofarma.TabStop = true;
            rbCofarma.Text = "Cofarma";
            // 
            // rbEmpsephar
            // 
            rbEmpsephar.AutoSize = true;
            rbEmpsephar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbEmpsephar.Location = new Point(717, 195);
            rbEmpsephar.Name = "rbEmpsephar";
            rbEmpsephar.Size = new Size(86, 19);
            rbEmpsephar.TabIndex = 9;
            rbEmpsephar.TabStop = true;
            rbEmpsephar.Text = "Empsephar";
            // 
            // rbCemefar
            // 
            rbCemefar.AutoSize = true;
            rbCemefar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCemefar.Location = new Point(817, 195);
            rbCemefar.Name = "rbCemefar";
            rbCemefar.Size = new Size(73, 19);
            rbCemefar.TabIndex = 10;
            rbCemefar.TabStop = true;
            rbCemefar.Text = "Cemefar";
            // 
            // qtQuantity
            // 
            qtQuantity.Location = new Point(198, 191);
            qtQuantity.Name = "qtQuantity";
            qtQuantity.Size = new Size(272, 23);
            qtQuantity.TabIndex = 4;
            // 
            // tbMedicationType
            // 
            tbMedicationType.FormattingEnabled = true;
            tbMedicationType.Items.AddRange(new object[] { "Analgesic", "Analeptic", "Anesthetic", "Antacid", "Antidepressant", "Antibiotic", "Jubilia" });
            tbMedicationType.Location = new Point(617, 114);
            tbMedicationType.Name = "tbMedicationType";
            tbMedicationType.Size = new Size(275, 23);
            tbMedicationType.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(617, 96);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 5;
            label4.Text = "Medication Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(198, 173);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Quantity:";
            // 
            // grpDistributors
            // 
            grpDistributors.AutoSize = true;
            grpDistributors.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDistributors.Location = new Point(617, 173);
            grpDistributors.Name = "grpDistributors";
            grpDistributors.Size = new Size(71, 15);
            grpDistributors.TabIndex = 7;
            grpDistributors.Text = "Distributor:";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(198, 383);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(815, 383);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMedicationStatus
            // 
            lblMedicationStatus.AutoSize = true;
            lblMedicationStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblMedicationStatus.ForeColor = Color.Green;
            lblMedicationStatus.Location = new Point(200, 150);
            lblMedicationStatus.Name = "lblMedicationStatus";
            lblMedicationStatus.Size = new Size(0, 15);
            lblMedicationStatus.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(200, 273);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 16;
            label3.Text = "Pharmacy Branch:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(label3);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(chkSecondaryBranch);
            Controls.Add(chkMainBranch);
            Controls.Add(rbCemefar);
            Controls.Add(rbEmpsephar);
            Controls.Add(rbCofarma);
            Controls.Add(grpDistributors);
            Controls.Add(tbMedicationType);
            Controls.Add(label4);
            Controls.Add(qtQuantity);
            Controls.Add(label5);
            Controls.Add(tbMedicationName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMedicationStatus);
            Name = "Form1";
            Text = "Pharmacy Order System";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)qtQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbMedicationName;
        private Label label5;
        private NumericUpDown qtQuantity;
        private ComboBox tbMedicationType;
        private Label label4;
        private Label grpDistributors;
        private RadioButton rbCofarma;
        private RadioButton rbEmpsephar;
        private RadioButton rbCemefar;
        private CheckBox chkMainBranch;
        private CheckBox chkSecondaryBranch;
        private Button btnClear;
        private Button btnSubmit;

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMedicationName.Clear();
            qtQuantity.Value = 0;
            tbMedicationType.SelectedIndex = -1;
            rbCofarma.Checked = false;
            rbEmpsephar.Checked = false;
            rbCemefar.Checked = false;
            chkMainBranch.Checked = false;
            chkSecondaryBranch.Checked = false;
            lblMedicationStatus.Text = string.Empty;
            tbMedicationName.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                string userName = "Juan"; 
                int birthDay = 13;            
                int birthMonth = 7;     

                
                char initialLetter = char.ToUpper(userName[0]);
                string medication = medicationStock.Keys
                    .FirstOrDefault(key => char.ToUpper(key[0]) == initialLetter);

                if (medication == null)
                {
                    medication = $"{initialLetter}InventedMed"; 
                }

               
                int quantity = birthDay;

              
                string distributor = birthMonth switch
                {
                    >= 1 and <= 4 => "Cofarma",
                    >= 5 and <= 8 => "Empsephar",
                    >= 9 and <= 12 => "Cemefar",
                    _ => throw new InvalidOperationException("Invalid birth month")
                };

               
                bool isMainBranch = false;
                bool isSecondaryBranch = false;
                char lastChar = userName[userName.Length - 1];
                if ("AEIOUaeiou".Contains(lastChar))
                {
                    isSecondaryBranch = true;
                }
                else
                {
                    isMainBranch = true;
                    isSecondaryBranch = true; 
                }

                // Case-insensitive medication lookup
                string medicationKey = medicationStock.Keys
                    .FirstOrDefault(key => string.Equals(key, medication, StringComparison.OrdinalIgnoreCase));

                if (medicationKey == null)
                {
                    MessageBox.Show($"The medication '{medication}' does not exist in stock.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check stock availability
                if (quantity > medicationStock[medicationKey])
                {
                    MessageBox.Show($"The requested quantity ({quantity}) exceeds the available stock ({medicationStock[medicationKey]} units) for '{medicationKey}'.",
                                    "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Branch Address
                string branchAddress = string.Empty;
                if (isMainBranch)
                    branchAddress += "Main Branch: Calle de la Rosa núm. 28\n";
                if (isSecondaryBranch)
                    branchAddress += "Secondary Branch: Calle Alcazabilla núm. 3\n";

                // Create Order Summary
                string orderSummary = $"{quantity} units of medications {medicationKey}\n\n" +
                                      $"Distribuidor: {distributor}\n" +
                                      $"Send to:\n{branchAddress}";

                // Display Order Summary
                Form orderSummaryForm = new Form
                {
                    Text = $"Order to {distributor}",
                    Size = new System.Drawing.Size(400, 300),
                    StartPosition = FormStartPosition.CenterParent
                };

                Label lblSummary = new Label
                {
                    Text = orderSummary,
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Regular)
                };

                Button btnConfirm = new Button
                {
                    Text = "Confirm",
                    Dock = DockStyle.Bottom,
                    Height = 40,
                    DialogResult = DialogResult.OK
                };

                orderSummaryForm.Controls.Add(lblSummary);
                orderSummaryForm.Controls.Add(btnConfirm);

                if (orderSummaryForm.ShowDialog() == DialogResult.OK)
                {
                    // Update stock after confirmation
                    medicationStock[medicationKey] -= quantity;
                    MessageBox.Show("Order confirmed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private Label label3;
    }
 }

