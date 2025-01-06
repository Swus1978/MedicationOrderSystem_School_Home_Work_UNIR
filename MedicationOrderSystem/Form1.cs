namespace MedicationOrderSystem
{
    public partial class Form1 : Form
    {
        //private TextBox tbUserName;
        private DateTimePicker dtpBirthDate;
        private Label lblMedicationStatus;



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

        private void tbMedicationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Get the selected medication type
                string medicationType = tbMedicationType.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(medicationType))
                {
                    tbMedicationName.PlaceholderText = "Select a medication type";
                    return;
                }

                // Step 2: Determine the first letter of the medication type
                char initialLetter = char.ToUpper(medicationType[0]);

                // Step 3: Find a medication that starts with the same letter
                string medication = medicationStock.Keys.FirstOrDefault(key => string.Equals(key[0].ToString(), initialLetter.ToString(), StringComparison.OrdinalIgnoreCase)) ?? $"{initialLetter}InventedMed";
                // Step 4: If no match exists, invent a medication name
                if (medication == null)
                {
                    medication = $"{initialLetter}InventedMed"; // Placeholder medication
                }

                // Step 5: Set as placeholder text in the Medication Name field
                tbMedicationName.PlaceholderText = medication;

                // Optional: Logically prefill the text box if required (uncomment if needed)
                // tbMedicationName.Text = medication;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}



