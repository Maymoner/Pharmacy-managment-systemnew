namespace Pharmacy_managment_system.Forms
{
    partial class Prescription
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
            this.dataGridViewMed = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPat = new System.Windows.Forms.DataGridView();
            this.patid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdBox = new System.Windows.Forms.TextBox();
            this.medicationIdBox = new System.Windows.Forms.TextBox();
            this.dosageBox = new System.Windows.Forms.TextBox();
            this.frequencyBox = new System.Windows.Forms.TextBox();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.nn = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.searchMedication = new System.Windows.Forms.TextBox();
            this.searchPatient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricelable = new System.Windows.Forms.Label();
            this.quantitylable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SELL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMed
            // 
            this.dataGridViewMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.medName,
            this.price,
            this.quantity});
            this.dataGridViewMed.Location = new System.Drawing.Point(982, 66);
            this.dataGridViewMed.Name = "dataGridViewMed";
            this.dataGridViewMed.RowHeadersWidth = 62;
            this.dataGridViewMed.RowTemplate.Height = 28;
            this.dataGridViewMed.Size = new System.Drawing.Size(376, 728);
            this.dataGridViewMed.TabIndex = 0;
            this.dataGridViewMed.SelectionChanged += new System.EventHandler(this.dataGridViewMed_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Medication ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // medName
            // 
            this.medName.HeaderText = "Name";
            this.medName.MinimumWidth = 8;
            this.medName.Name = "medName";
            this.medName.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.Width = 150;
            // 
            // dataGridViewPat
            // 
            this.dataGridViewPat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patid,
            this.patName});
            this.dataGridViewPat.Location = new System.Drawing.Point(558, 65);
            this.dataGridViewPat.Name = "dataGridViewPat";
            this.dataGridViewPat.RowHeadersWidth = 62;
            this.dataGridViewPat.RowTemplate.Height = 28;
            this.dataGridViewPat.Size = new System.Drawing.Size(396, 728);
            this.dataGridViewPat.TabIndex = 1;
            this.dataGridViewPat.SelectionChanged += new System.EventHandler(this.dataGridViewPat_SelectionChanged);
            // 
            // patid
            // 
            this.patid.HeaderText = "Patients ID";
            this.patid.MinimumWidth = 8;
            this.patid.Name = "patid";
            this.patid.Width = 60;
            // 
            // patName
            // 
            this.patName.HeaderText = "Name";
            this.patName.MinimumWidth = 8;
            this.patName.Name = "patName";
            this.patName.Width = 150;
            // 
            // patientIdBox
            // 
            this.patientIdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.patientIdBox.Location = new System.Drawing.Point(181, 76);
            this.patientIdBox.Name = "patientIdBox";
            this.patientIdBox.Size = new System.Drawing.Size(191, 39);
            this.patientIdBox.TabIndex = 2;
            // 
            // medicationIdBox
            // 
            this.medicationIdBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.medicationIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.medicationIdBox.Location = new System.Drawing.Point(181, 128);
            this.medicationIdBox.Name = "medicationIdBox";
            this.medicationIdBox.Size = new System.Drawing.Size(191, 39);
            this.medicationIdBox.TabIndex = 3;
            // 
            // dosageBox
            // 
            this.dosageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dosageBox.Location = new System.Drawing.Point(181, 184);
            this.dosageBox.Name = "dosageBox";
            this.dosageBox.Size = new System.Drawing.Size(191, 39);
            this.dosageBox.TabIndex = 4;
            // 
            // frequencyBox
            // 
            this.frequencyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frequencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.frequencyBox.Location = new System.Drawing.Point(181, 239);
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(191, 39);
            this.frequencyBox.TabIndex = 5;
            // 
            // durationBox
            // 
            this.durationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationBox.Location = new System.Drawing.Point(181, 293);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(191, 39);
            this.durationBox.TabIndex = 6;
            // 
            // noteBox
            // 
            this.noteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noteBox.Location = new System.Drawing.Point(181, 378);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(191, 67);
            this.noteBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient ID";
            // 
            // s
            // 
            this.s.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.s.Location = new System.Drawing.Point(10, 128);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(169, 43);
            this.s.TabIndex = 9;
            this.s.Text = "Medication ID";
            // 
            // d
            // 
            this.d.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.d.Location = new System.Drawing.Point(10, 184);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(99, 43);
            this.d.TabIndex = 10;
            this.d.Text = "Dosage";
            // 
            // f
            // 
            this.f.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.f.Location = new System.Drawing.Point(10, 239);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(130, 43);
            this.f.TabIndex = 11;
            this.f.Text = "Frequency";
            // 
            // dd
            // 
            this.dd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.dd.Location = new System.Drawing.Point(13, 293);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(112, 43);
            this.dd.TabIndex = 12;
            this.dd.Text = "Duration";
            // 
            // nn
            // 
            this.nn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nn.AutoSize = true;
            this.nn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.nn.Location = new System.Drawing.Point(13, 372);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(82, 43);
            this.nn.TabIndex = 13;
            this.nn.Text = "Notes";
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(72, 594);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 93);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history.Location = new System.Drawing.Point(72, 724);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(356, 101);
            this.history.TabIndex = 16;
            this.history.Text = "PRESCRIPTIONS HISTORY";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // searchMedication
            // 
            this.searchMedication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchMedication.Location = new System.Drawing.Point(1031, 800);
            this.searchMedication.Name = "searchMedication";
            this.searchMedication.Size = new System.Drawing.Size(266, 26);
            this.searchMedication.TabIndex = 17;
            this.searchMedication.TextChanged += new System.EventHandler(this.searchMedication_TextChanged);
            // 
            // searchPatient
            // 
            this.searchPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchPatient.Location = new System.Drawing.Point(637, 799);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(266, 26);
            this.searchPatient.TabIndex = 18;
            this.searchPatient.TextChanged += new System.EventHandler(this.searchPatient_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(1106, 829);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 43);
            this.label7.TabIndex = 19;
            this.label7.Text = "Search";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(710, 829);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 43);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(669, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 56);
            this.label2.TabIndex = 21;
            this.label2.Text = "Patients";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(1060, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 56);
            this.label3.TabIndex = 22;
            this.label3.Text = "Medications";
            // 
            // pricelable
            // 
            this.pricelable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pricelable.AutoSize = true;
            this.pricelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelable.Location = new System.Drawing.Point(181, 478);
            this.pricelable.Name = "pricelable";
            this.pricelable.Size = new System.Drawing.Size(46, 32);
            this.pricelable.TabIndex = 23;
            this.pricelable.Text = "$0";
            // 
            // quantitylable
            // 
            this.quantitylable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitylable.AutoSize = true;
            this.quantitylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylable.Location = new System.Drawing.Point(185, 522);
            this.quantitylable.Name = "quantitylable";
            this.quantitylable.Size = new System.Drawing.Size(30, 32);
            this.quantitylable.TabIndex = 24;
            this.quantitylable.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Quantuty:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price:";
            // 
            // SELL
            // 
            this.SELL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SELL.Location = new System.Drawing.Point(268, 594);
            this.SELL.Name = "SELL";
            this.SELL.Size = new System.Drawing.Size(160, 93);
            this.SELL.TabIndex = 27;
            this.SELL.Text = "SELL";
            this.SELL.UseVisualStyleBackColor = true;
            this.SELL.Click += new System.EventHandler(this.SELL_Click);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1370, 892);
            this.Controls.Add(this.SELL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantitylable);
            this.Controls.Add(this.pricelable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchPatient);
            this.Controls.Add(this.searchMedication);
            this.Controls.Add(this.history);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nn);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.frequencyBox);
            this.Controls.Add(this.dosageBox);
            this.Controls.Add(this.medicationIdBox);
            this.Controls.Add(this.patientIdBox);
            this.Controls.Add(this.dataGridViewPat);
            this.Controls.Add(this.dataGridViewMed);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMed;
        private System.Windows.Forms.DataGridView dataGridViewPat;
        private System.Windows.Forms.TextBox patientIdBox;
        private System.Windows.Forms.TextBox medicationIdBox;
        private System.Windows.Forms.TextBox dosageBox;
        private System.Windows.Forms.TextBox frequencyBox;
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label nn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.TextBox searchMedication;
        private System.Windows.Forms.TextBox searchPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn patid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pricelable;
        private System.Windows.Forms.Label quantitylable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button SELL;
    }
}