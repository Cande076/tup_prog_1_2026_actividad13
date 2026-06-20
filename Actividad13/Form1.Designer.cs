namespace Actividad13
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.btnBuscarYVerAlumno = new System.Windows.Forms.Button();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListadoOrdenado = new System.Windows.Forms.Button();
            this.rbBurbuja = new System.Windows.Forms.RadioButton();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMayoresAlPromedio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud datos alumno";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(47, 37);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(147, 34);
            this.btnRegistrarAlumno.TabIndex = 2;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBinaria);
            this.groupBox2.Controls.Add(this.rbSecuencial);
            this.groupBox2.Controls.Add(this.btnBuscarYVerAlumno);
            this.groupBox2.Controls.Add(this.tbLU);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salidas";
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(119, 65);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(70, 20);
            this.rbBinaria.TabIndex = 4;
            this.rbBinaria.TabStop = true;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Location = new System.Drawing.Point(9, 65);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(95, 20);
            this.rbSecuencial.TabIndex = 3;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // btnBuscarYVerAlumno
            // 
            this.btnBuscarYVerAlumno.Location = new System.Drawing.Point(119, 23);
            this.btnBuscarYVerAlumno.Name = "btnBuscarYVerAlumno";
            this.btnBuscarYVerAlumno.Size = new System.Drawing.Size(75, 30);
            this.btnBuscarYVerAlumno.TabIndex = 2;
            this.btnBuscarYVerAlumno.Text = "Buscar";
            this.btnBuscarYVerAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarYVerAlumno.Click += new System.EventHandler(this.btnBuscarYVerAlumno_Click);
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(39, 27);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(65, 22);
            this.tbLU.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LU:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbQuickSort);
            this.groupBox3.Controls.Add(this.rbBurbuja);
            this.groupBox3.Controls.Add(this.btnMostrarListadoOrdenado);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salidas";
            // 
            // btnMostrarListadoOrdenado
            // 
            this.btnMostrarListadoOrdenado.Location = new System.Drawing.Point(58, 21);
            this.btnMostrarListadoOrdenado.Name = "btnMostrarListadoOrdenado";
            this.btnMostrarListadoOrdenado.Size = new System.Drawing.Size(118, 31);
            this.btnMostrarListadoOrdenado.TabIndex = 0;
            this.btnMostrarListadoOrdenado.Text = "Mostrar Listado";
            this.btnMostrarListadoOrdenado.UseVisualStyleBackColor = true;
            this.btnMostrarListadoOrdenado.Click += new System.EventHandler(this.btnMostrarListadoOrdenado_Click);
            // 
            // rbBurbuja
            // 
            this.rbBurbuja.AutoSize = true;
            this.rbBurbuja.Location = new System.Drawing.Point(18, 58);
            this.rbBurbuja.Name = "rbBurbuja";
            this.rbBurbuja.Size = new System.Drawing.Size(74, 20);
            this.rbBurbuja.TabIndex = 1;
            this.rbBurbuja.TabStop = true;
            this.rbBurbuja.Text = "Burbuja";
            this.rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(136, 58);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(86, 20);
            this.rbQuickSort.TabIndex = 2;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMayoresAlPromedio);
            this.groupBox4.Location = new System.Drawing.Point(12, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salidas";
            // 
            // btnMayoresAlPromedio
            // 
            this.btnMayoresAlPromedio.Location = new System.Drawing.Point(47, 31);
            this.btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            this.btnMayoresAlPromedio.Size = new System.Drawing.Size(147, 46);
            this.btnMayoresAlPromedio.TabIndex = 0;
            this.btnMayoresAlPromedio.Text = "Mostrar Listado Mayores al promedio";
            this.btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            this.btnMayoresAlPromedio.Click += new System.EventHandler(this.btnMayoresAlPromedio_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad11";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbLU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.Button btnBuscarYVerAlumno;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbBurbuja;
        private System.Windows.Forms.Button btnMostrarListadoOrdenado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMayoresAlPromedio;
    }
}

