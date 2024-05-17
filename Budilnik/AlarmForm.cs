using System;
using System.Windows.Forms;

namespace Budilnik
{
    public partial class AlarmForm : Form
    {
        
        public void AddAlarmToListBox(string alarmDetails)
        {
            listBoxAlarms.Items.Add(alarmDetails);
        }
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarmForm addAlarmForm = new AddAlarmForm();
            addAlarmForm.ShowDialog();
        }

        private void btnEdit_Click_Click(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedItem != null)
            {
                int selectedIndex = listBoxAlarms.SelectedIndex;
                string selectedAlarm = listBoxAlarms.SelectedItem.ToString();

                textBoxEditAlarm.Text = selectedAlarm;

                textBoxEditAlarm.Visible = true;
                btnUpdate.Visible = true;

                listBoxAlarms.Visible = false;
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите будильник для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedItem != null)
            {
                listBoxAlarms.Items.Remove(listBoxAlarms.SelectedItem);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите будильник для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEditAlarm.Text))
            {
                listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = textBoxEditAlarm.Text;

                textBoxEditAlarm.Text = "";
                textBoxEditAlarm.Visible = false;
                btnUpdate.Visible = false;

                listBoxAlarms.Visible = true;
                btnUpdate.Text = "Обновить";
            }
        }
    }
}
