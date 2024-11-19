namespace _04_OperacionesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmployeeID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtBirthDate = new TextBox();
            lstRsultados = new ListBox();
            btnInsertar = new Button();
            btnBorrar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 42);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 42);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 42);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 42);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha nacimiento";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(22, 60);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(100, 23);
            txtEmployeeID.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(174, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(329, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(519, 60);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.PlaceholderText = "dd/mm/aa";
            txtBirthDate.Size = new Size(100, 23);
            txtBirthDate.TabIndex = 7;
            // 
            // lstRsultados
            // 
            lstRsultados.FormattingEnabled = true;
            lstRsultados.HorizontalScrollbar = true;
            lstRsultados.ItemHeight = 15;
            lstRsultados.Location = new Point(144, 232);
            lstRsultados.Name = "lstRsultados";
            lstRsultados.Size = new Size(307, 124);
            lstRsultados.TabIndex = 8;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(159, 105);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(133, 37);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(318, 157);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(133, 37);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(318, 105);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(133, 37);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(159, 157);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 37);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(btnBorrar);
            Controls.Add(btnInsertar);
            Controls.Add(lstRsultados);
            Controls.Add(txtBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmployeeID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtBirthDate;
        private ListBox lstRsultados;
        private Button btnInsertar;
        private Button btnBorrar;
        private Button btnConsultar;
        private Button btnModificar;
    }
}
