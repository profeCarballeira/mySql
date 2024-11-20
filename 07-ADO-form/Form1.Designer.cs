namespace _07_ADO_form
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
            btnModificar = new Button();
            btnConsultar = new Button();
            btnBorrar = new Button();
            btnInsertar = new Button();
            lstRsultados = new ListBox();
            txtBirthDate = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmployeeID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(224, 159);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(133, 37);
            btnModificar.TabIndex = 25;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(383, 107);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(133, 37);
            btnConsultar.TabIndex = 24;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(383, 159);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(133, 37);
            btnBorrar.TabIndex = 23;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(224, 107);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(133, 37);
            btnInsertar.TabIndex = 22;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstRsultados
            // 
            lstRsultados.FormattingEnabled = true;
            lstRsultados.HorizontalScrollbar = true;
            lstRsultados.ItemHeight = 15;
            lstRsultados.Location = new Point(209, 234);
            lstRsultados.Name = "lstRsultados";
            lstRsultados.Size = new Size(307, 124);
            lstRsultados.TabIndex = 21;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(584, 62);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.PlaceholderText = "dd/mm/aa";
            txtBirthDate.Size = new Size(100, 23);
            txtBirthDate.TabIndex = 20;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(394, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(239, 62);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 18;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(87, 62);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(100, 23);
            txtEmployeeID.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 44);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 16;
            label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 44);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 44);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 13;
            label1.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private Button btnModificar;
        private Button btnConsultar;
        private Button btnBorrar;
        private Button btnInsertar;
        private ListBox lstRsultados;
        private TextBox txtBirthDate;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmployeeID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
