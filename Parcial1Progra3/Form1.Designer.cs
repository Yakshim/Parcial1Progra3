
namespace Parcial1Progra3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DGWprestamos = new System.Windows.Forms.DataGridView();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.DTPdevolucion = new System.Windows.Forms.DateTimePicker();
            this.DTPprestamo = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCodigo = new System.Windows.Forms.ComboBox();
            this.comboBoxCarnet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRDev = new System.Windows.Forms.Label();
            this.labelRPrestamo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGWprestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(516, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(165, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingreso de Datos";
            // 
            // DGWprestamos
            // 
            this.DGWprestamos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGWprestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWprestamos.Location = new System.Drawing.Point(338, 79);
            this.DGWprestamos.Name = "DGWprestamos";
            this.DGWprestamos.RowTemplate.Height = 25;
            this.DGWprestamos.Size = new System.Drawing.Size(441, 173);
            this.DGWprestamos.TabIndex = 9;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIngresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIngresar.ForeColor = System.Drawing.Color.Red;
            this.buttonIngresar.Location = new System.Drawing.Point(165, 283);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(99, 34);
            this.buttonIngresar.TabIndex = 8;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // DTPdevolucion
            // 
            this.DTPdevolucion.Location = new System.Drawing.Point(155, 213);
            this.DTPdevolucion.Name = "DTPdevolucion";
            this.DTPdevolucion.Size = new System.Drawing.Size(121, 23);
            this.DTPdevolucion.TabIndex = 7;
            // 
            // DTPprestamo
            // 
            this.DTPprestamo.Location = new System.Drawing.Point(155, 171);
            this.DTPprestamo.Name = "DTPprestamo";
            this.DTPprestamo.Size = new System.Drawing.Size(121, 23);
            this.DTPprestamo.TabIndex = 6;
            // 
            // comboBoxCodigo
            // 
            this.comboBoxCodigo.FormattingEnabled = true;
            this.comboBoxCodigo.Location = new System.Drawing.Point(155, 124);
            this.comboBoxCodigo.Name = "comboBoxCodigo";
            this.comboBoxCodigo.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCodigo.TabIndex = 5;
            // 
            // comboBoxCarnet
            // 
            this.comboBoxCarnet.FormattingEnabled = true;
            this.comboBoxCarnet.Location = new System.Drawing.Point(155, 79);
            this.comboBoxCarnet.Name = "comboBoxCarnet";
            this.comboBoxCarnet.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCarnet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(29, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Devolucion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(100, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(104, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(338, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Libros aun no devueltos:";
            // 
            // labelRDev
            // 
            this.labelRDev.AutoSize = true;
            this.labelRDev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRDev.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRDev.Location = new System.Drawing.Point(496, 354);
            this.labelRDev.Name = "labelRDev";
            this.labelRDev.Size = new System.Drawing.Size(0, 17);
            this.labelRDev.TabIndex = 14;
            // 
            // labelRPrestamo
            // 
            this.labelRPrestamo.AutoSize = true;
            this.labelRPrestamo.ForeColor = System.Drawing.Color.Red;
            this.labelRPrestamo.Location = new System.Drawing.Point(155, 262);
            this.labelRPrestamo.Name = "labelRPrestamo";
            this.labelRPrestamo.Size = new System.Drawing.Size(0, 15);
            this.labelRPrestamo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 479);
            this.Controls.Add(this.labelRPrestamo);
            this.Controls.Add(this.labelRDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGWprestamos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPdevolucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPprestamo);
            this.Controls.Add(this.comboBoxCarnet);
            this.Controls.Add(this.comboBoxCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWprestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.DateTimePicker DTPdevolucion;
        private System.Windows.Forms.DateTimePicker DTPprestamo;
        private System.Windows.Forms.ComboBox comboBoxCodigo;
        private System.Windows.Forms.ComboBox comboBoxCarnet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGWprestamos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRDev;
        private System.Windows.Forms.Label labelRPrestamo;
    }
}

