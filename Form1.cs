namespace MedicationOrderSystem
{
    partial class Form1
    {
        // ... existing code ...

        private void InitializeComponent()
        {
            // ... existing code ...

            // btnConfirm
            btnConfirm.BackColor = SystemColors.ActiveCaption;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = SystemColors.ControlLightLight;
            btnConfirm.Location = new Point(817, 377);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += BtnConfirm_Click_1;

            // ... existing code ...
        }

        // ... existing code ...

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            // Confirm button click event handler code
        }
    }
}
