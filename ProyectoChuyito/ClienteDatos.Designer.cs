namespace ProyectoChuyito
{
    partial class ClienteDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCurp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RdbCasado = new System.Windows.Forms.RadioButton();
            this.RdbSoltero = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.NupIngresosMen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NupHijos = new System.Windows.Forms.NumericUpDown();
            this.LblIngresos = new System.Windows.Forms.Label();
            this.LblPlanSug = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NupIngresosMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupHijos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CURP:";
            // 
            // TxtCurp
            // 
            this.TxtCurp.Location = new System.Drawing.Point(98, 82);
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(325, 20);
            this.TxtCurp.TabIndex = 0;
            this.TxtCurp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtCurp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCurp_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL CLIENTE:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(201, 108);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(222, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOMICILIO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(128, 134);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(295, 20);
            this.TxtDomicilio.TabIndex = 2;
            this.TxtDomicilio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ESTADO CIVIL:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // RdbCasado
            // 
            this.RdbCasado.AutoSize = true;
            this.RdbCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCasado.Location = new System.Drawing.Point(148, 165);
            this.RdbCasado.Name = "RdbCasado";
            this.RdbCasado.Size = new System.Drawing.Size(75, 17);
            this.RdbCasado.TabIndex = 3;
            this.RdbCasado.TabStop = true;
            this.RdbCasado.Text = "CASADO";
            this.RdbCasado.UseVisualStyleBackColor = true;
            this.RdbCasado.CheckedChanged += new System.EventHandler(this.RdbCasado_CheckedChanged);
            // 
            // RdbSoltero
            // 
            this.RdbSoltero.AutoSize = true;
            this.RdbSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSoltero.Location = new System.Drawing.Point(238, 165);
            this.RdbSoltero.Name = "RdbSoltero";
            this.RdbSoltero.Size = new System.Drawing.Size(83, 17);
            this.RdbSoltero.TabIndex = 4;
            this.RdbSoltero.TabStop = true;
            this.RdbSoltero.Text = "SOLTERO";
            this.RdbSoltero.UseVisualStyleBackColor = true;
            this.RdbSoltero.CheckedChanged += new System.EventHandler(this.RdbSoltero_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "INGRESOS MENSUALES:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // NupIngresosMen
            // 
            this.NupIngresosMen.DecimalPlaces = 2;
            this.NupIngresosMen.Location = new System.Drawing.Point(201, 218);
            this.NupIngresosMen.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NupIngresosMen.Name = "NupIngresosMen";
            this.NupIngresosMen.Size = new System.Drawing.Size(120, 20);
            this.NupIngresosMen.TabIndex = 6;
            this.NupIngresosMen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NupIngresosMen_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "HIJOS:";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // NupHijos
            // 
            this.NupHijos.Location = new System.Drawing.Point(94, 192);
            this.NupHijos.Name = "NupHijos";
            this.NupHijos.Size = new System.Drawing.Size(120, 20);
            this.NupHijos.TabIndex = 5;
            this.NupHijos.Visible = false;
            // 
            // LblIngresos
            // 
            this.LblIngresos.AutoSize = true;
            this.LblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngresos.Location = new System.Drawing.Point(52, 269);
            this.LblIngresos.Name = "LblIngresos";
            this.LblIngresos.Size = new System.Drawing.Size(173, 13);
            this.LblIngresos.TabIndex = 5;
            this.LblIngresos.Text = "INGRESOS ACUMULABLES: ";
            // 
            // LblPlanSug
            // 
            this.LblPlanSug.AutoSize = true;
            this.LblPlanSug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlanSug.Location = new System.Drawing.Point(52, 296);
            this.LblPlanSug.Name = "LblPlanSug";
            this.LblPlanSug.Size = new System.Drawing.Size(272, 13);
            this.LblPlanSug.TabIndex = 5;
            this.LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(55, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClienteDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPlanSug);
            this.Controls.Add(this.LblIngresos);
            this.Controls.Add(this.NupHijos);
            this.Controls.Add(this.NupIngresosMen);
            this.Controls.Add(this.RdbSoltero);
            this.Controls.Add(this.RdbCasado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCurp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteDatos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClienteDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NupIngresosMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupHijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCurp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RdbCasado;
        private System.Windows.Forms.RadioButton RdbSoltero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NupIngresosMen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NupHijos;
        private System.Windows.Forms.Label LblIngresos;
        private System.Windows.Forms.Label LblPlanSug;
        private System.Windows.Forms.Button button1;
    }
}