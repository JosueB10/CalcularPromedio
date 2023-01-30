namespace CalcularPromedio
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablaDeRegistro = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Español = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matematicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEspañol = new System.Windows.Forms.Label();
            this.lblMatematicas = new System.Windows.Forms.Label();
            this.lblFisica = new System.Windows.Forms.Label();
            this.lblIngles = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspañol = new System.Windows.Forms.TextBox();
            this.txtMatematicas = new System.Windows.Forms.TextBox();
            this.txtFisica = new System.Windows.Forms.TextBox();
            this.txtIngles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAOR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaDeRegistro
            // 
            this.TablaDeRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Español,
            this.Matematicas,
            this.Fisica,
            this.Ingles});
            this.TablaDeRegistro.Location = new System.Drawing.Point(90, 265);
            this.TablaDeRegistro.Name = "TablaDeRegistro";
            this.TablaDeRegistro.Size = new System.Drawing.Size(542, 173);
            this.TablaDeRegistro.TabIndex = 0;
            this.TablaDeRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Español
            // 
            this.Español.HeaderText = "Español";
            this.Español.Name = "Español";
            // 
            // Matematicas
            // 
            this.Matematicas.HeaderText = "Matematicas";
            this.Matematicas.Name = "Matematicas";
            // 
            // Fisica
            // 
            this.Fisica.HeaderText = "Fisica";
            this.Fisica.Name = "Fisica";
            // 
            // Ingles
            // 
            this.Ingles.HeaderText = "Ingles";
            this.Ingles.Name = "Ingles";
            // 
            // lblEspañol
            // 
            this.lblEspañol.AutoSize = true;
            this.lblEspañol.Location = new System.Drawing.Point(12, 125);
            this.lblEspañol.Name = "lblEspañol";
            this.lblEspañol.Size = new System.Drawing.Size(139, 13);
            this.lblEspañol.TabIndex = 1;
            this.lblEspañol.Text = "Ingrese la nota de Español: ";
            // 
            // lblMatematicas
            // 
            this.lblMatematicas.AutoSize = true;
            this.lblMatematicas.Location = new System.Drawing.Point(12, 165);
            this.lblMatematicas.Name = "lblMatematicas";
            this.lblMatematicas.Size = new System.Drawing.Size(161, 13);
            this.lblMatematicas.TabIndex = 2;
            this.lblMatematicas.Text = "Ingrese la nota de Matematicas: ";
            // 
            // lblFisica
            // 
            this.lblFisica.AutoSize = true;
            this.lblFisica.Location = new System.Drawing.Point(12, 198);
            this.lblFisica.Name = "lblFisica";
            this.lblFisica.Size = new System.Drawing.Size(128, 13);
            this.lblFisica.TabIndex = 3;
            this.lblFisica.Text = "Ingrese la nota de Fisica: ";
            // 
            // lblIngles
            // 
            this.lblIngles.AutoSize = true;
            this.lblIngles.Location = new System.Drawing.Point(11, 239);
            this.lblIngles.Name = "lblIngles";
            this.lblIngles.Size = new System.Drawing.Size(129, 13);
            this.lblIngles.TabIndex = 4;
            this.lblIngles.Text = "Ingrese la nota de Ingles: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Ingrese el nombre del alumno: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEspañol
            // 
            this.txtEspañol.Location = new System.Drawing.Point(169, 122);
            this.txtEspañol.Name = "txtEspañol";
            this.txtEspañol.Size = new System.Drawing.Size(170, 20);
            this.txtEspañol.TabIndex = 7;
            this.txtEspañol.TextChanged += new System.EventHandler(this.txtEspañol_TextChanged);
            // 
            // txtMatematicas
            // 
            this.txtMatematicas.Location = new System.Drawing.Point(169, 158);
            this.txtMatematicas.Name = "txtMatematicas";
            this.txtMatematicas.Size = new System.Drawing.Size(170, 20);
            this.txtMatematicas.TabIndex = 8;
            this.txtMatematicas.TextChanged += new System.EventHandler(this.txtMatematicas_TextChanged);
            // 
            // txtFisica
            // 
            this.txtFisica.Location = new System.Drawing.Point(169, 198);
            this.txtFisica.Name = "txtFisica";
            this.txtFisica.Size = new System.Drawing.Size(170, 20);
            this.txtFisica.TabIndex = 9;
            this.txtFisica.TextChanged += new System.EventHandler(this.txtFisica_TextChanged);
            // 
            // txtIngles
            // 
            this.txtIngles.Location = new System.Drawing.Point(169, 236);
            this.txtIngles.Name = "txtIngles";
            this.txtIngles.Size = new System.Drawing.Size(169, 20);
            this.txtIngles.TabIndex = 10;
            this.txtIngles.TextChanged += new System.EventHandler(this.txtIngles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Notas en linea";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(599, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 26);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(600, 165);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(88, 26);
            this.Eliminar.TabIndex = 13;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(494, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(95, 13);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Total Estudiantes: ";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(607, 44);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total de las notas:";
            // 
            // lblTn
            // 
            this.lblTn.AutoSize = true;
            this.lblTn.Location = new System.Drawing.Point(607, 78);
            this.lblTn.Name = "lblTn";
            this.lblTn.Size = new System.Drawing.Size(0, 13);
            this.lblTn.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estas: ";
            // 
            // LblAOR
            // 
            this.LblAOR.AutoSize = true;
            this.LblAOR.Location = new System.Drawing.Point(548, 219);
            this.LblAOR.Name = "LblAOR";
            this.LblAOR.Size = new System.Drawing.Size(0, 13);
            this.LblAOR.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nota max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nota min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "promedio";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(752, 274);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(10, 13);
            this.lblMax.TabIndex = 25;
            this.lblMax.Text = ".";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(752, 311);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(10, 13);
            this.lblmin.TabIndex = 26;
            this.lblmin.Text = ".";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Location = new System.Drawing.Point(752, 342);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(10, 13);
            this.lblpro.TabIndex = 27;
            this.lblpro.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblAOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngles);
            this.Controls.Add(this.txtFisica);
            this.Controls.Add(this.txtMatematicas);
            this.Controls.Add(this.txtEspañol);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIngles);
            this.Controls.Add(this.lblFisica);
            this.Controls.Add(this.lblMatematicas);
            this.Controls.Add(this.lblEspañol);
            this.Controls.Add(this.TablaDeRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaDeRegistro;
        private System.Windows.Forms.Label lblEspañol;
        private System.Windows.Forms.Label lblMatematicas;
        private System.Windows.Forms.Label lblFisica;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspañol;
        private System.Windows.Forms.TextBox txtMatematicas;
        private System.Windows.Forms.TextBox txtFisica;
        private System.Windows.Forms.TextBox txtIngles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Español;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matematicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblpro;
    }
}

