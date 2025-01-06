using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace MedicationOrderSystem
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, int> medicationStock = new Dictionary<string, int>
        {
            {"Paracetamol", 50 },
            {"Ibuprofen", 30 },
            {"Ampxicillin", 20 },
            {"Ciprofloxacin", 15 },
            {"Doxycycline", 40 },
            {"Jubilia", 13 },
            {"Juverdem", 25 },
            {"Juvexin", 10 },
            {"Juvilin", 5 }
        };
        public Form1()
        {
            InitializeComponent();
            lblMedicationStatus = new Label();
        }

        private void txtMedication_TextChanged(object sender, EventArgs e)
        {
            string entredMedication = tbMedicationName.Text.Trim();


            if (string.IsNullOrWhiteSpace(entredMedication))
            {
                lblMedicationStatus.Text = string.Empty;
                return;
            }
            var matchingMedications = medicationStock.Keys
               .Where(med => med.StartsWith(entredMedication, StringComparison.OrdinalIgnoreCase))
               .ToList();

            if (matchingMedications.Count == 1 && medicationStock.ContainsKey(matchingMedications[0]))
            {
                int availableBalance = medicationStock[matchingMedications[0]];
                lblMedicationStatus.Text = $"Available Quantity: {availableBalance}";
            }
            else if (matchingMedications.Count > 1)
            {
                lblMedicationStatus.Text = "Multiple matches found: " + string.Join(", ", matchingMedications);
            }
            else
            {
                lblMedicationStatus.Text = "Medication not available";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear TextBox Fields
                tbMedicationName.Clear();

                // Reset NumericUpDown
                qtQuantity.Value = 0;

                // Reset ComboBox
                tbMedicationType.SelectedIndex = -1;

                // Uncheck RadioButtons
                rbCofarma.Checked = false;
                rbEmpsephar.Checked = false;
                rbCemefar.Checked = false;

                // Uncheck CheckBoxes
                chkMainBranch.Checked = false;
                chkSecondaryBranch.Checked = false;

                // Reset Label or Status Display
                lblMedicationStatus.Text = "";

                // Reset Focus to the First Field
                tbMedicationName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing fields: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Label lblMedicationStatus;

        private void qtQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
