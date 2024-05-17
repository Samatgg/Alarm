namespace Budilnik
{
    partial class AlarmForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.btnEdit_Click = new System.Windows.Forms.Button();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            this.textBoxEditAlarm = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.BackColor = System.Drawing.Color.GreenYellow;
            this.listBoxAlarms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 16;
            this.listBoxAlarms.Location = new System.Drawing.Point(12, 57);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(392, 274);
            this.listBoxAlarms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Будильник";
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAlarm.Location = new System.Drawing.Point(410, 57);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(125, 42);
            this.btnAddAlarm.TabIndex = 2;
            this.btnAddAlarm.Text = "Добавить будильник";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // btnEdit_Click
            // 
            this.btnEdit_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit_Click.Location = new System.Drawing.Point(410, 105);
            this.btnEdit_Click.Name = "btnEdit_Click";
            this.btnEdit_Click.Size = new System.Drawing.Size(125, 42);
            this.btnEdit_Click.TabIndex = 3;
            this.btnEdit_Click.Text = "Редактировать";
            this.btnEdit_Click.UseVisualStyleBackColor = true;
            this.btnEdit_Click.Click += new System.EventHandler(this.btnEdit_Click_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete_Click.Location = new System.Drawing.Point(410, 153);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Size = new System.Drawing.Size(125, 42);
            this.btnDelete_Click.TabIndex = 4;
            this.btnDelete_Click.Text = "Удалить";
            this.btnDelete_Click.UseVisualStyleBackColor = true;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // textBoxEditAlarm
            // 
            this.textBoxEditAlarm.Location = new System.Drawing.Point(541, 308);
            this.textBoxEditAlarm.Multiline = true;
            this.textBoxEditAlarm.Name = "textBoxEditAlarm";
            this.textBoxEditAlarm.Size = new System.Drawing.Size(246, 79);
            this.textBoxEditAlarm.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(611, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(799, 527);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxEditAlarm);
            this.Controls.Add(this.btnDelete_Click);
            this.Controls.Add(this.btnEdit_Click);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAlarms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmForm";
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.Button btnEdit_Click;
        private System.Windows.Forms.Button btnDelete_Click;
        private System.Windows.Forms.TextBox textBoxEditAlarm;
        private System.Windows.Forms.Button btnUpdate;
    }
}

