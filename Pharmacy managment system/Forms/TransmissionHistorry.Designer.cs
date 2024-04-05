namespace Pharmacy_managment_system.Forms
{
    partial class TransmissionHistorry
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissonDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund = new System.Windows.Forms.Button();
            this.medicationIdCheck = new System.Windows.Forms.CheckBox();
            this.patientIDCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.brand,
            this.price,
            this.expirationDate,
            this.transmissonDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.Width = 80;
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.MinimumWidth = 8;
            this.brand.Name = "brand";
            this.brand.Width = 80;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 80;
            // 
            // expirationDate
            // 
            this.expirationDate.HeaderText = "Expiration Date";
            this.expirationDate.MinimumWidth = 8;
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Width = 150;
            // 
            // transmissonDate
            // 
            this.transmissonDate.HeaderText = "Transmisson Date";
            this.transmissonDate.MinimumWidth = 8;
            this.transmissonDate.Name = "transmissonDate";
            this.transmissonDate.Width = 150;
            // 
            // refund
            // 
            this.refund.Dock = System.Windows.Forms.DockStyle.Right;
            this.refund.Location = new System.Drawing.Point(901, 453);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(317, 219);
            this.refund.TabIndex = 29;
            this.refund.Text = "REFUND";
            this.refund.UseVisualStyleBackColor = true;
            this.refund.Click += new System.EventHandler(this.refund_Click);
            // 
            // medicationIdCheck
            // 
            this.medicationIdCheck.AutoSize = true;
            this.medicationIdCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationIdCheck.Location = new System.Drawing.Point(210, 607);
            this.medicationIdCheck.Name = "medicationIdCheck";
            this.medicationIdCheck.Size = new System.Drawing.Size(213, 36);
            this.medicationIdCheck.TabIndex = 28;
            this.medicationIdCheck.Text = "Medication ID";
            this.medicationIdCheck.UseVisualStyleBackColor = true;
            // 
            // patientIDCheck
            // 
            this.patientIDCheck.AutoSize = true;
            this.patientIDCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDCheck.Location = new System.Drawing.Point(21, 607);
            this.patientIDCheck.Name = "patientIDCheck";
            this.patientIDCheck.Size = new System.Drawing.Size(164, 36);
            this.patientIDCheck.TabIndex = 27;
            this.patientIDCheck.Text = "Patient ID";
            this.patientIDCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(7, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 85);
            this.label8.TabIndex = 26;
            this.label8.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(210, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 62);
            this.textBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 545);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TransmissionHistorry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1218, 672);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.refund);
            this.Controls.Add(this.medicationIdCheck);
            this.Controls.Add(this.patientIDCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TransmissionHistorry";
            this.Text = "TransmissionHistorry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refund;
        private System.Windows.Forms.CheckBox medicationIdCheck;
        private System.Windows.Forms.CheckBox patientIDCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissonDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}