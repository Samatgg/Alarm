using System;
using System.Windows.Forms;

namespace Budilnik
{
    public partial class AddAlarmForm : Form
    {
     
        private void AlarmForm_Load(object sender, EventArgs e)
        {
            comboBoxPeriodicity.Items.Add("Ежедневно");
            comboBoxPeriodicity.Items.Add("Еженедельно");
            comboBoxPeriodicity.Items.Add("Ежемесячно");
        }
        public AddAlarmForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDate.Value; 
            DateTime selectedTime = dateTimePickerTime.Value; 
            string alarmName = txtAlarmName.Text; 
            string periodicity = comboBoxPeriodicity.Text; 
            bool isActive = checkBoxActive.Checked;
            if (string.IsNullOrEmpty(alarmName))
            {
                MessageBox.Show("Название будильника не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxPeriodicity.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите периодичность для будильника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            else
            {
                string alarmDetails = $"{selectedDate.ToShortDateString()} {selectedTime.ToShortTimeString()} - {alarmName} ({periodicity}) - {(isActive ? "Активен" : "Неактивен")}";

                AlarmForm mainForm = Application.OpenForms["AlarmForm"] as AlarmForm;
                mainForm.AddAlarmToListBox(alarmDetails);

                this.Close();
            }
        }

        private void btnCancel_Click_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите отменить действия?", "Подтверждение отмены", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}
