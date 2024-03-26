namespace RestaurantReservation.Forms
{
    partial class FrmReservationCreate
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
            cmbCustomer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerDate = new DateTimePicker();
            textNotes = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(61, 56);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(250, 28);
            cmbCustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 195);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Notes";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(61, 131);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(250, 27);
            dateTimePickerDate.TabIndex = 2;
            dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
            // 
            // textNotes
            // 
            textNotes.Location = new Point(61, 218);
            textNotes.Name = "textNotes";
            textNotes.Size = new Size(250, 27);
            textNotes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 108);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 1;
            label3.Text = "Date";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(217, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FrmReservationCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(textNotes);
            Controls.Add(dateTimePickerDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCustomer);
            Name = "FrmReservationCreate";
            Text = "FrmReservationCreate";
            Load += FrmReservationCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomer;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerDate;
        private TextBox textNotes;
        private Label label3;
        private Button btnAdd;
    }
}