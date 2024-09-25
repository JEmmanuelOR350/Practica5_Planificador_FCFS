namespace Practica5_Planificador_FCFS
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
            labelTitulo = new Label();
            botonEjecutar = new Button();
            labelNProcesos = new Label();
            cajaValorRegistros = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cajaValorRegistros).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("MS Reference Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(66, 34);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(459, 29);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Formulario de ingreso de Procesos";
            // 
            // botonEjecutar
            // 
            botonEjecutar.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonEjecutar.Location = new Point(375, 182);
            botonEjecutar.Margin = new Padding(2);
            botonEjecutar.Name = "botonEjecutar";
            botonEjecutar.Size = new Size(150, 34);
            botonEjecutar.TabIndex = 5;
            botonEjecutar.Text = "Ejecutar Procesos";
            botonEjecutar.UseVisualStyleBackColor = true;
            botonEjecutar.Click += botonEjecutar_Click;
            // 
            // labelNProcesos
            // 
            labelNProcesos.AutoSize = true;
            labelNProcesos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNProcesos.Location = new Point(44, 124);
            labelNProcesos.Margin = new Padding(2, 0, 2, 0);
            labelNProcesos.Name = "labelNProcesos";
            labelNProcesos.Size = new Size(296, 28);
            labelNProcesos.TabIndex = 2;
            labelNProcesos.Text = "Número de procesos a registrar: ";
            // 
            // cajaValorRegistros
            // 
            cajaValorRegistros.Location = new Point(375, 129);
            cajaValorRegistros.Name = "cajaValorRegistros";
            cajaValorRegistros.Size = new Size(150, 27);
            cajaValorRegistros.TabIndex = 6;
            cajaValorRegistros.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(666, 434);
            Controls.Add(cajaValorRegistros);
            Controls.Add(botonEjecutar);
            Controls.Add(labelNProcesos);
            Controls.Add(labelTitulo);
            Margin = new Padding(2);
            MaximumSize = new Size(684, 481);
            MinimumSize = new Size(684, 481);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cajaValorRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button botonEjecutar;
        private Label labelNProcesos;
        private NumericUpDown cajaValorRegistros;
    }
}
