namespace CRUD.Views
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBirthDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(10, 11);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(394, 188);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(88, 216);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(132, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(88, 244);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(132, 23);
            txtLastName.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(88, 272);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(132, 23);
            dtpBirthDate.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(262, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 28);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(262, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 28);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(262, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(10, 218);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(54, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(10, 247);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(54, 15);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Apellido:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(10, 275);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(41, 15);
            lblBirthDate.TabIndex = 9;
            lblBirthDate.Text = "Fecha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 320);
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
            Text = "Gestión de Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
    }
}