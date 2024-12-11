namespace _12_EF_linq_category
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
            lblLastName = new Label();
            lblFirstName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDescripcionCateg = new TextBox();
            txtNombreCateg = new TextBox();
            dgvCategories = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 248);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(72, 15);
            lblLastName.TabIndex = 26;
            lblLastName.Text = "Descripción:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 219);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(61, 15);
            lblFirstName.TabIndex = 25;
            lblFirstName.Text = "Categoría:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(264, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 28);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(264, 249);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 28);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(264, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 28);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescripcionCateg
            // 
            txtDescripcionCateg.Location = new Point(90, 245);
            txtDescripcionCateg.Name = "txtDescripcionCateg";
            txtDescripcionCateg.Size = new Size(132, 23);
            txtDescripcionCateg.TabIndex = 21;
            // 
            // txtNombreCateg
            // 
            txtNombreCateg.Location = new Point(90, 217);
            txtNombreCateg.Name = "txtNombreCateg";
            txtNombreCateg.Size = new Size(132, 23);
            txtNombreCateg.TabIndex = 20;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(12, 12);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(394, 188);
            dgvCategories.TabIndex = 19;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // button1
            // 
            button1.Location = new Point(465, 27);
            button1.Name = "button1";
            button1.Size = new Size(137, 28);
            button1.TabIndex = 27;
            button1.Text = "LINQ where";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(465, 75);
            button2.Name = "button2";
            button2.Size = new Size(137, 28);
            button2.TabIndex = 28;
            button2.Text = "LINQ select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDescripcionCateg);
            Controls.Add(txtNombreCateg);
            Controls.Add(dgvCategories);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLastName;
        private Label lblFirstName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtDescripcionCateg;
        private TextBox txtNombreCateg;
        private DataGridView dgvCategories;
        private Button button1;
        private Button button2;
    }
}
