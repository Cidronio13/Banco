namespace ProyectoChuyito
{
    partial class Simulador
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
            this.LblPlanSug = new System.Windows.Forms.Label();
            this.LblLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl12Mes = new System.Windows.Forms.Label();
            this.NupSaldoDeu = new System.Windows.Forms.NumericUpDown();
            this.Lbl6Mes = new System.Windows.Forms.Label();
            this.Lbl3Mes = new System.Windows.Forms.Label();
            this.Lbl1Mes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NupSaldoDeu)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPlanSug
            // 
            this.LblPlanSug.AutoSize = true;
            this.LblPlanSug.Location = new System.Drawing.Point(22, 58);
            this.LblPlanSug.Name = "LblPlanSug";
            this.LblPlanSug.Size = new System.Drawing.Size(98, 13);
            this.LblPlanSug.TabIndex = 0;
            this.LblPlanSug.Text = "PLAN SUGERIDO:";
            // 
            // LblLimit
            // 
            this.LblLimit.AutoSize = true;
            this.LblLimit.Location = new System.Drawing.Point(22, 83);
            this.LblLimit.Name = "LblLimit";
            this.LblLimit.Size = new System.Drawing.Size(114, 13);
            this.LblLimit.TabIndex = 0;
            this.LblLimit.Text = "LIMITE DE CREDITO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SIMULADOR DE EJECUCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SALDO DEUDOR:";
            // 
            // Lbl12Mes
            // 
            this.Lbl12Mes.AutoSize = true;
            this.Lbl12Mes.Location = new System.Drawing.Point(22, 189);
            this.Lbl12Mes.Name = "Lbl12Mes";
            this.Lbl12Mes.Size = new System.Drawing.Size(181, 13);
            this.Lbl12Mes.TabIndex = 0;
            this.Lbl12Mes.Text = "SI PAGA EN 12 MESES PAGARIA $";
            // 
            // NupSaldoDeu
            // 
            this.NupSaldoDeu.Location = new System.Drawing.Point(124, 165);
            this.NupSaldoDeu.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NupSaldoDeu.Name = "NupSaldoDeu";
            this.NupSaldoDeu.Size = new System.Drawing.Size(120, 20);
            this.NupSaldoDeu.TabIndex = 1;
            this.NupSaldoDeu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NupSaldoDeu_KeyDown);
            // 
            // Lbl6Mes
            // 
            this.Lbl6Mes.AutoSize = true;
            this.Lbl6Mes.Location = new System.Drawing.Point(22, 213);
            this.Lbl6Mes.Name = "Lbl6Mes";
            this.Lbl6Mes.Size = new System.Drawing.Size(175, 13);
            this.Lbl6Mes.TabIndex = 0;
            this.Lbl6Mes.Text = "SI PAGA EN 6 MESES PAGARIA $";
            // 
            // Lbl3Mes
            // 
            this.Lbl3Mes.AutoSize = true;
            this.Lbl3Mes.Location = new System.Drawing.Point(22, 235);
            this.Lbl3Mes.Name = "Lbl3Mes";
            this.Lbl3Mes.Size = new System.Drawing.Size(175, 13);
            this.Lbl3Mes.TabIndex = 0;
            this.Lbl3Mes.Text = "SI PAGA EN 3 MESES PAGARIA $";
            // 
            // Lbl1Mes
            // 
            this.Lbl1Mes.AutoSize = true;
            this.Lbl1Mes.Location = new System.Drawing.Point(22, 257);
            this.Lbl1Mes.Name = "Lbl1Mes";
            this.Lbl1Mes.Size = new System.Drawing.Size(168, 13);
            this.Lbl1Mes.TabIndex = 0;
            this.Lbl1Mes.Text = "SI PAGA EN 1 MESE PAGARIA $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pantalla Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NupSaldoDeu);
            this.Controls.Add(this.Lbl1Mes);
            this.Controls.Add(this.Lbl3Mes);
            this.Controls.Add(this.Lbl6Mes);
            this.Controls.Add(this.Lbl12Mes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblLimit);
            this.Controls.Add(this.LblPlanSug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Simulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Simulador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NupSaldoDeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlanSug;
        private System.Windows.Forms.Label LblLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl12Mes;
        private System.Windows.Forms.NumericUpDown NupSaldoDeu;
        private System.Windows.Forms.Label Lbl6Mes;
        private System.Windows.Forms.Label Lbl3Mes;
        private System.Windows.Forms.Label Lbl1Mes;
        private System.Windows.Forms.Button button1;
    }
}