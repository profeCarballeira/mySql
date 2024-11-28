namespace _10_CRUD_MVC_EF_auto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBirthDate = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dtpBirthDate = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            dgvEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(12, 276);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(41, 15);
            lblBirthDate.TabIndex = 19;
            lblBirthDate.Text = "Fecha:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 248);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(54, 15);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Apellido:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 219);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(54, 15);
            lblFirstName.TabIndex = 17;
            lblFirstName.Text = "Nombre:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(264, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 28);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(264, 249);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 28);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(264, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 28);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(90, 273);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(132, 23);
            dtpBirthDate.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(90, 245);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(90, 217);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 23);
            txtFirstName.TabIndex = 11;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 12);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(394, 188);
            dgvEmployees.TabIndex = 10;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 314);
            Controls.Add(lblBirthDate);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dgvEmployees);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBirthDate;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DateTimePicker dtpBirthDate;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private DataGridView dgvEmployees;
    }
}
