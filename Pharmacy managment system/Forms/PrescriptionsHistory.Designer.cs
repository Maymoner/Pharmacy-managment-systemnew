namespace Pharmacy_managment_system.Forms
{
    partial class PrescriptionsHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrescriptionHistoryDataView = new System.Windows.Forms.DataGridView();
            this.prescription_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medication_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.patientIDCheck = new System.Windows.Forms.CheckBox();
            this.medicationIdCheck = new System.Windows.Forms.CheckBox();
            this.refund = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionHistoryDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrescriptionHistoryDataView
            // 
            this.PrescriptionHistoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionHistoryDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescription_id,
            this.patient_id,
            this.medication_id,
            this.prescribingDate,
            this.dosage,
            this.frequency,
            this.duration,
            this.notes});
            this.PrescriptionHistoryDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrescriptionHistoryDataView.Location = new System.Drawing.Point(0, 0);
            this.PrescriptionHistoryDataView.Name = "PrescriptionHistoryDataView";
            this.PrescriptionHistoryDataView.RowHeadersWidth = 62;
            this.PrescriptionHistoryDataView.RowTemplate.Height = 28;
            this.PrescriptionHistoryDataView.Size = new System.Drawing.Size(1323, 685);
            this.PrescriptionHistoryDataView.TabIndex = 0;
            // 
            // prescription_id
            // 
            this.prescription_id.HeaderText = "Prescription ID";
            this.prescription_id.MinimumWidth = 8;
            this.prescription_id.Name = "prescription_id";
            this.prescription_id.Width = 70;
            // 
            // patient_id
            // 
            this.patient_id.HeaderText = "Patient ID";
            this.patient_id.MinimumWidth = 8;
            this.patient_id.Name = "patient_id";
            this.patient_id.Width = 70;
            // 
            // medication_id
            // 
            this.medication_id.HeaderText = "Medication ID";
            this.medication_id.MinimumWidth = 8;
            this.medication_id.Name = "medication_id";
            this.medication_id.Width = 70;
            // 
            // prescribingDate
            // 
            this.prescribingDate.HeaderText = "Prescribing Date ";
            this.prescribingDate.MinimumWidth = 8;
            this.prescribingDate.Name = "prescribingDate";
            this.prescribingDate.Width = 200;
            // 
            // dosage
            // 
            this.dosage.HeaderText = "Dosage";
            this.dosage.MinimumWidth = 8;
            this.dosage.Name = "dosage";
            this.dosage.Width = 60;
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Frequency";
            this.frequency.MinimumWidth = 8;
            this.frequency.Name = "frequency";
            this.frequency.Width = 110;
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration ";
            this.duration.MinimumWidth = 8;
            this.duration.Name = "duration";
            this.duration.Width = 70;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.MinimumWidth = 8;
            this.notes.Name = "notes";
            this.notes.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 759);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(-2, 756);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 85);
            this.label8.TabIndex = 21;
            this.label8.Text = "Search";
            // 
            // patientIDCheck
            // 
            this.patientIDCheck.AutoSize = true;
            this.patientIDCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDCheck.Location = new System.Drawing.Point(453, 805);
            this.patientIDCheck.Name = "patientIDCheck";
            this.patientIDCheck.Size = new System.Drawing.Size(164, 36);
            this.patientIDCheck.TabIndex = 22;
            this.patientIDCheck.Text = "Patient ID";
            this.patientIDCheck.UseVisualStyleBackColor = true;
            // 
            // medicationIdCheck
            // 
            this.medicationIdCheck.AutoSize = true;
            this.medicationIdCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationIdCheck.Location = new System.Drawing.Point(642, 805);
            this.medicationIdCheck.Name = "medicationIdCheck";
            this.medicationIdCheck.Size = new System.Drawing.Size(213, 36);
            this.medicationIdCheck.TabIndex = 23;
            this.medicationIdCheck.Text = "Medication ID";
            this.medicationIdCheck.UseVisualStyleBackColor = true;
            // 
            // refund
            // 
            this.refund.Dock = System.Windows.Forms.DockStyle.Right;
            this.refund.Location = new System.Drawing.Point(1006, 685);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(317, 207);
            this.refund.TabIndex = 24;
            this.refund.Text = "REFUND";
            this.refund.UseVisualStyleBackColor = true;
            this.refund.Click += new System.EventHandler(this.refund_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 756);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 39);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PrescriptionsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1323, 892);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.refund);
            this.Controls.Add(this.medicationIdCheck);
            this.Controls.Add(this.patientIDCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrescriptionHistoryDataView);
            this.Name = "PrescriptionsHistory";
            this.Text = "PrescriptionsHistory";
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionHistoryDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrescriptionHistoryDataView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox patientIDCheck;
        private System.Windows.Forms.CheckBox medicationIdCheck;
        private System.Windows.Forms.Button refund;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medication_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}