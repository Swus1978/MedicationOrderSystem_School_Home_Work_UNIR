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
            dptBirthDate = new DateTimePicker();
            label6 = new Label();
            tbUserName = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)qtQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(694, 65);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Medication Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(188, 206);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Medication Name:";
            //label2.Click += label2_Click;
            // 
            // chkMainBranch
            // 
            chkMainBranch.AutoSize = true;
            chkMainBranch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkMainBranch.Location = new Point(188, 291);
            chkMainBranch.Name = "chkMainBranch";
            chkMainBranch.Size = new Size(95, 19);
            chkMainBranch.TabIndex = 11;
            chkMainBranch.Text = "Main Branch";
           // chkMainBranch.CheckedChanged += chkMainBranch_CheckedChanged;
            // 
            // chkSecondaryBranch
            // 
            chkSecondaryBranch.AutoSize = true;
            chkSecondaryBranch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkSecondaryBranch.Location = new Point(188, 316);
            chkSecondaryBranch.Name = "chkSecondaryBranch";
            chkSecondaryBranch.Size = new Size(126, 19);
            chkSecondaryBranch.TabIndex = 12;
            chkSecondaryBranch.Text = "Secondary Branch";
            //chkSecondaryBranch.CheckedChanged += chkSecondaryBranch_CheckedChanged;
            // 
            // tbMedicationName
            // 
            tbMedicationName.Location = new Point(188, 219);
            tbMedicationName.Name = "tbMedicationName";
            tbMedicationName.Size = new Size(272, 23);
            tbMedicationName.TabIndex = 2;
            //tbMedicationName.TextChanged += tbMedicationName_TextChanged;
            // 
            // rbCofarma
            // 
            rbCofarma.AutoSize = true;
            rbCofarma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCofarma.Location = new Point(607, 313);
            rbCofarma.Name = "rbCofarma";
            rbCofarma.Size = new Size(72, 19);
            rbCofarma.TabIndex = 8;
            rbCofarma.TabStop = true;
            rbCofarma.Text = "Cofarma";
            //rbCofarma.CheckedChanged += rbCofarma_CheckedChanged;
            // 
            // rbEmpsephar
            // 
            rbEmpsephar.AutoSize = true;
            rbEmpsephar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbEmpsephar.Location = new Point(700, 312);
            rbEmpsephar.Name = "rbEmpsephar";
            rbEmpsephar.Size = new Size(86, 19);
            rbEmpsephar.TabIndex = 9;
            rbEmpsephar.TabStop = true;
            rbEmpsephar.Text = "Empsephar";
            //rbEmpsephar.CheckedChanged += rbEmpsephar_CheckedChanged;
            // 
            // rbCemefar
            // 
            rbCemefar.AutoSize = true;
            rbCemefar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbCemefar.Location = new Point(809, 312);
            rbCemefar.Name = "rbCemefar";
            rbCemefar.Size = new Size(73, 19);
            rbCemefar.TabIndex = 10;
            rbCemefar.TabStop = true;
            rbCemefar.Text = "Cemefar";
//rbCemefar.CheckedChanged += rbCemefar_CheckedChanged;
            // 
            // qtQuantity
            // 
            qtQuantity.Location = new Point(610, 124);
            qtQuantity.Name = "qtQuantity";
            qtQuantity.Size = new Size(272, 23);
            qtQuantity.TabIndex = 4;
            //qtQuantity.ValueChanged += qtQuantity_ValueChanged;
            // 
            // tbMedicationType
            // 
            tbMedicationType.FormattingEnabled = true;
            tbMedicationType.Items.AddRange(new object[] { "Analgesic", "Analeptic", "Anesthetic", "Antacid", "Antidepressant", "Antibiotic", "Jubilia" });
            tbMedicationType.Location = new Point(610, 219);
            tbMedicationType.Name = "tbMedicationType";
            tbMedicationType.Size = new Size(275, 23);
            tbMedicationType.TabIndex = 6;
            //tbMedicationType.SelectedIndexChanged += tbMedicationType_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(607, 201);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 5;
            label4.Text = "Medication Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(610, 106);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Quantity:";
           // label5.Click += label5_Click;
            // 
            // grpDistributors
            // 
            grpDistributors.AutoSize = true;
            grpDistributors.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDistributors.Location = new Point(607, 295);
            grpDistributors.Name = "grpDistributors";
            grpDistributors.Size = new Size(71, 15);
            grpDistributors.TabIndex = 7;
            grpDistributors.Text = "Distributor:";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(188, 383);
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
            btnSubmit.Location = new Point(807, 383);
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
            label3.Location = new Point(188, 273);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 16;
            label3.Text = "Pharmacy Branch:";
            // 
            // dptBirthDate
            // 
            dptBirthDate.Location = new Point(188, 168);
            dptBirthDate.Name = "dptBirthDate";
            dptBirthDate.Size = new Size(272, 23);
            dptBirthDate.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(190, 152);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 18;
            label6.Text = "DOB:";
            //label6.Click += label6_Click;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(190, 123);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(272, 23);
            tbUserName.TabIndex = 19;
            //tbUserName.TextChanged += this.textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(190, 106);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 20;
            label7.Text = "User Name";
            //label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(label7);
            Controls.Add(tbUserName);
            Controls.Add(label6);
            Controls.Add(dptBirthDate);
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
           // Load += Form1_Load;
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
                // Validate Inputs
                string medicationName = tbMedicationName.Text.Trim();
                int quantity = (int)qtQuantity.Value;
                string medicationType = tbMedicationType.SelectedItem?.ToString();
                string distributor = rbCofarma.Checked ? "Cofarma" :
                                     rbEmpsephar.Checked ? "Empsephar" :
                                     rbCemefar.Checked ? "Cemefar" : string.Empty;

                if (string.IsNullOrWhiteSpace(medicationName) || quantity <= 0 ||
                    string.IsNullOrEmpty(medicationType) || string.IsNullOrEmpty(distributor))
                {
                    MessageBox.Show("Please complete all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Stock
                if (!medicationStock.TryGetValue(medicationName, out int stock) || stock < quantity)
                {
                    MessageBox.Show($"Insufficient stock for '{medicationName}'. Available: {stock}",
                                    "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determine Pharmacy Address
                string address = chkMainBranch.Checked && chkSecondaryBranch.Checked
                                 ? "Both Branches"
                                 : chkMainBranch.Checked
                                 ? "Calle de la Rosa núm. 28 (Main Branch)"
                                 : chkSecondaryBranch.Checked
                                 ? "Calle Alcazabilla núm. 3 (Secondary Branch)"
                                 : "No Branch Selected";

                if (address == "No Branch Selected")
                {
                    MessageBox.Show("Please select a branch to deliver the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Deduct Stock
                medicationStock[medicationName] -= quantity;

                // Create Order Details
                string orderDetails = $"{quantity} unidades del {medicationType.ToLower()} {medicationName}";
                string pharmacyDetails = $"Para la farmacia situada en {address}";

                // Show Order Summary in a Popup
                string summaryTitle = $"Pedido al distribuidor {distributor}";
                string summaryContent = $"{orderDetails}\n\n{pharmacyDetails}";

                // Create a new form for displaying the summary
                Form orderSummaryForm = new Form
                {
                    Text = summaryTitle,
                    Size = new Size(400, 250),
                    StartPosition = FormStartPosition.CenterParent
                };

                // Label for the order summary content
                Label lblSummary = new Label
                {
                    Text = summaryContent,
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Regular)
                };

                // Confirm Button
                Button btnConfirm = new Button
                {
                    Text = "Confirm",
                    Dock = DockStyle.Bottom,
                    Height = 40,
                    DialogResult = DialogResult.OK
                };

                orderSummaryForm.Controls.Add(lblSummary);
                orderSummaryForm.Controls.Add(btnConfirm);

                // Show the form and handle confirmation
                if (orderSummaryForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Order confirmed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private Label label3;
        private DateTimePicker dptBirthDate;
        private Label label6;
        private TextBox tbUserName;
        private Label label7;
    }
 }

