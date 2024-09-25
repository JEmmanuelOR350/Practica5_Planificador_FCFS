namespace Practica5_Planificador_FCFS
{
    partial class Formulario_Ejecuccion
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TablaProcesosListos = new DataGridView();
            TablaProcesosEjecutando = new DataGridView();
            nombreProceso = new DataGridViewTextBoxColumn();
            DatosRellenarProceso = new DataGridViewTextBoxColumn();
            tablaProcesosCompletados = new DataGridView();
            NIDEjecutados = new DataGridViewTextBoxColumn();
            OperacionEjecutada = new DataGridViewTextBoxColumn();
            ResultadoEjecutado = new DataGridViewTextBoxColumn();
            TiempoMaxEjecutado = new DataGridViewTextBoxColumn();
            columnaTiempoLlegada = new DataGridViewTextBoxColumn();
            columnaTiempoFinalizado = new DataGridViewTextBoxColumn();
            columnaTiempoEspera = new DataGridViewTextBoxColumn();
            TiempoEEjecutado = new DataGridViewTextBoxColumn();
            columnaTiempoRetorno = new DataGridViewTextBoxColumn();
            columnaTiempoRespuesta = new DataGridViewTextBoxColumn();
            botonIniciar = new Button();
            labelNLotesPendientes = new Label();
            cajaNProcListos = new TextBox();
            cajaTiempoGlobal = new TextBox();
            labelTemporizadorGlobal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cajaTiempoProceso = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            tablaProcesosBloqueados = new DataGridView();
            columnaBloqID = new DataGridViewTextBoxColumn();
            columnaBloqTiempoTranscurrido = new DataGridViewTextBoxColumn();
            NID = new DataGridViewTextBoxColumn();
            TiempoMax = new DataGridViewTextBoxColumn();
            columnaListosTrabajado = new DataGridViewTextBoxColumn();
            TiempoTrancurrido = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TablaProcesosListos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TablaProcesosEjecutando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaProcesosCompletados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProcesosBloqueados).BeginInit();
            SuspendLayout();
            // 
            // TablaProcesosListos
            // 
            TablaProcesosListos.AllowUserToAddRows = false;
            TablaProcesosListos.AllowUserToDeleteRows = false;
            TablaProcesosListos.AllowUserToResizeColumns = false;
            TablaProcesosListos.AllowUserToResizeRows = false;
            TablaProcesosListos.BackgroundColor = Color.WhiteSmoke;
            TablaProcesosListos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaProcesosListos.Columns.AddRange(new DataGridViewColumn[] { NID, TiempoMax, columnaListosTrabajado, TiempoTrancurrido });
            TablaProcesosListos.Location = new Point(42, 46);
            TablaProcesosListos.Margin = new Padding(2);
            TablaProcesosListos.MaximumSize = new Size(500, 250);
            TablaProcesosListos.MinimumSize = new Size(500, 250);
            TablaProcesosListos.MultiSelect = false;
            TablaProcesosListos.Name = "TablaProcesosListos";
            TablaProcesosListos.ReadOnly = true;
            TablaProcesosListos.RowHeadersVisible = false;
            TablaProcesosListos.RowHeadersWidth = 62;
            TablaProcesosListos.ScrollBars = ScrollBars.Vertical;
            TablaProcesosListos.ShowCellErrors = false;
            TablaProcesosListos.ShowCellToolTips = false;
            TablaProcesosListos.ShowEditingIcon = false;
            TablaProcesosListos.ShowRowErrors = false;
            TablaProcesosListos.Size = new Size(500, 250);
            TablaProcesosListos.TabIndex = 0;
            // 
            // TablaProcesosEjecutando
            // 
            TablaProcesosEjecutando.AllowUserToAddRows = false;
            TablaProcesosEjecutando.AllowUserToDeleteRows = false;
            TablaProcesosEjecutando.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TablaProcesosEjecutando.BackgroundColor = Color.WhiteSmoke;
            TablaProcesosEjecutando.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaProcesosEjecutando.ColumnHeadersVisible = false;
            TablaProcesosEjecutando.Columns.AddRange(new DataGridViewColumn[] { nombreProceso, DatosRellenarProceso });
            TablaProcesosEjecutando.Location = new Point(786, 69);
            TablaProcesosEjecutando.Margin = new Padding(2);
            TablaProcesosEjecutando.Name = "TablaProcesosEjecutando";
            TablaProcesosEjecutando.ReadOnly = true;
            TablaProcesosEjecutando.RowHeadersVisible = false;
            TablaProcesosEjecutando.RowHeadersWidth = 62;
            TablaProcesosEjecutando.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TablaProcesosEjecutando.Size = new Size(296, 209);
            TablaProcesosEjecutando.TabIndex = 1;
            // 
            // nombreProceso
            // 
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            nombreProceso.DefaultCellStyle = dataGridViewCellStyle3;
            nombreProceso.Frozen = true;
            nombreProceso.HeaderText = "";
            nombreProceso.MinimumWidth = 170;
            nombreProceso.Name = "nombreProceso";
            nombreProceso.ReadOnly = true;
            nombreProceso.Width = 170;
            // 
            // DatosRellenarProceso
            // 
            DatosRellenarProceso.Frozen = true;
            DatosRellenarProceso.HeaderText = "";
            DatosRellenarProceso.MinimumWidth = 200;
            DatosRellenarProceso.Name = "DatosRellenarProceso";
            DatosRellenarProceso.ReadOnly = true;
            DatosRellenarProceso.Width = 200;
            // 
            // tablaProcesosCompletados
            // 
            tablaProcesosCompletados.AllowUserToAddRows = false;
            tablaProcesosCompletados.AllowUserToDeleteRows = false;
            tablaProcesosCompletados.AllowUserToResizeColumns = false;
            tablaProcesosCompletados.AllowUserToResizeRows = false;
            tablaProcesosCompletados.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tablaProcesosCompletados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tablaProcesosCompletados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProcesosCompletados.Columns.AddRange(new DataGridViewColumn[] { NIDEjecutados, OperacionEjecutada, ResultadoEjecutado, TiempoMaxEjecutado, columnaTiempoLlegada, columnaTiempoFinalizado, columnaTiempoEspera, TiempoEEjecutado, columnaTiempoRetorno, columnaTiempoRespuesta });
            tablaProcesosCompletados.Location = new Point(20, 333);
            tablaProcesosCompletados.Margin = new Padding(2);
            tablaProcesosCompletados.MultiSelect = false;
            tablaProcesosCompletados.Name = "tablaProcesosCompletados";
            tablaProcesosCompletados.ReadOnly = true;
            tablaProcesosCompletados.RightToLeft = RightToLeft.No;
            tablaProcesosCompletados.RowHeadersVisible = false;
            tablaProcesosCompletados.RowHeadersWidth = 62;
            tablaProcesosCompletados.ScrollBars = ScrollBars.Vertical;
            tablaProcesosCompletados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            tablaProcesosCompletados.Size = new Size(1064, 262);
            tablaProcesosCompletados.TabIndex = 2;
            tablaProcesosCompletados.TabStop = false;
            // 
            // NIDEjecutados
            // 
            NIDEjecutados.Frozen = true;
            NIDEjecutados.HeaderText = "PID";
            NIDEjecutados.MinimumWidth = 8;
            NIDEjecutados.Name = "NIDEjecutados";
            NIDEjecutados.ReadOnly = true;
            NIDEjecutados.SortMode = DataGridViewColumnSortMode.NotSortable;
            NIDEjecutados.Width = 60;
            // 
            // OperacionEjecutada
            // 
            OperacionEjecutada.Frozen = true;
            OperacionEjecutada.HeaderText = "Operación";
            OperacionEjecutada.MinimumWidth = 8;
            OperacionEjecutada.Name = "OperacionEjecutada";
            OperacionEjecutada.ReadOnly = true;
            OperacionEjecutada.SortMode = DataGridViewColumnSortMode.NotSortable;
            OperacionEjecutada.Width = 110;
            // 
            // ResultadoEjecutado
            // 
            ResultadoEjecutado.Frozen = true;
            ResultadoEjecutado.HeaderText = "Resultado";
            ResultadoEjecutado.MinimumWidth = 8;
            ResultadoEjecutado.Name = "ResultadoEjecutado";
            ResultadoEjecutado.ReadOnly = true;
            ResultadoEjecutado.SortMode = DataGridViewColumnSortMode.NotSortable;
            ResultadoEjecutado.Width = 110;
            // 
            // TiempoMaxEjecutado
            // 
            TiempoMaxEjecutado.Frozen = true;
            TiempoMaxEjecutado.HeaderText = "Tiempo máximo (segundos)";
            TiempoMaxEjecutado.MinimumWidth = 8;
            TiempoMaxEjecutado.Name = "TiempoMaxEjecutado";
            TiempoMaxEjecutado.ReadOnly = true;
            TiempoMaxEjecutado.SortMode = DataGridViewColumnSortMode.NotSortable;
            TiempoMaxEjecutado.Width = 110;
            // 
            // columnaTiempoLlegada
            // 
            columnaTiempoLlegada.Frozen = true;
            columnaTiempoLlegada.HeaderText = "Tiempo Llegada";
            columnaTiempoLlegada.MinimumWidth = 6;
            columnaTiempoLlegada.Name = "columnaTiempoLlegada";
            columnaTiempoLlegada.ReadOnly = true;
            columnaTiempoLlegada.Width = 110;
            // 
            // columnaTiempoFinalizado
            // 
            columnaTiempoFinalizado.Frozen = true;
            columnaTiempoFinalizado.HeaderText = "Tiempo Finalizado";
            columnaTiempoFinalizado.MinimumWidth = 6;
            columnaTiempoFinalizado.Name = "columnaTiempoFinalizado";
            columnaTiempoFinalizado.ReadOnly = true;
            columnaTiempoFinalizado.Width = 110;
            // 
            // columnaTiempoEspera
            // 
            columnaTiempoEspera.Frozen = true;
            columnaTiempoEspera.HeaderText = "Tiempo de Espera";
            columnaTiempoEspera.MinimumWidth = 6;
            columnaTiempoEspera.Name = "columnaTiempoEspera";
            columnaTiempoEspera.ReadOnly = true;
            columnaTiempoEspera.Width = 110;
            // 
            // TiempoEEjecutado
            // 
            TiempoEEjecutado.Frozen = true;
            TiempoEEjecutado.HeaderText = "Tiempo Servicio";
            TiempoEEjecutado.MinimumWidth = 8;
            TiempoEEjecutado.Name = "TiempoEEjecutado";
            TiempoEEjecutado.ReadOnly = true;
            TiempoEEjecutado.SortMode = DataGridViewColumnSortMode.NotSortable;
            TiempoEEjecutado.Width = 110;
            // 
            // columnaTiempoRetorno
            // 
            columnaTiempoRetorno.Frozen = true;
            columnaTiempoRetorno.HeaderText = "Tiempo Retorno";
            columnaTiempoRetorno.MinimumWidth = 6;
            columnaTiempoRetorno.Name = "columnaTiempoRetorno";
            columnaTiempoRetorno.ReadOnly = true;
            columnaTiempoRetorno.Width = 110;
            // 
            // columnaTiempoRespuesta
            // 
            columnaTiempoRespuesta.HeaderText = "Tiempo Respuesta";
            columnaTiempoRespuesta.MinimumWidth = 6;
            columnaTiempoRespuesta.Name = "columnaTiempoRespuesta";
            columnaTiempoRespuesta.ReadOnly = true;
            columnaTiempoRespuesta.Width = 110;
            // 
            // botonIniciar
            // 
            botonIniciar.BackColor = Color.FromArgb(192, 255, 192);
            botonIniciar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            botonIniciar.FlatAppearance.BorderSize = 3;
            botonIniciar.Location = new Point(31, 193);
            botonIniciar.Margin = new Padding(2);
            botonIniciar.Name = "botonIniciar";
            botonIniciar.Size = new Size(263, 27);
            botonIniciar.TabIndex = 3;
            botonIniciar.Text = "Iniciar";
            botonIniciar.UseVisualStyleBackColor = false;
            botonIniciar.Click += botonIniciar_Click;
            // 
            // labelNLotesPendientes
            // 
            labelNLotesPendientes.AutoSize = true;
            labelNLotesPendientes.BackColor = Color.Transparent;
            labelNLotesPendientes.Location = new Point(31, 31);
            labelNLotesPendientes.Margin = new Padding(2, 0, 2, 0);
            labelNLotesPendientes.Name = "labelNLotesPendientes";
            labelNLotesPendientes.Size = new Size(266, 20);
            labelNLotesPendientes.TabIndex = 4;
            labelNLotesPendientes.Text = "Número de procesos en Estado Nuevo:";
            // 
            // cajaNProcListos
            // 
            cajaNProcListos.BorderStyle = BorderStyle.FixedSingle;
            cajaNProcListos.Location = new Point(174, 54);
            cajaNProcListos.Margin = new Padding(2);
            cajaNProcListos.Name = "cajaNProcListos";
            cajaNProcListos.Size = new Size(120, 27);
            cajaNProcListos.TabIndex = 5;
            // 
            // cajaTiempoGlobal
            // 
            cajaTiempoGlobal.BorderStyle = BorderStyle.FixedSingle;
            cajaTiempoGlobal.Location = new Point(174, 106);
            cajaTiempoGlobal.Margin = new Padding(2);
            cajaTiempoGlobal.Name = "cajaTiempoGlobal";
            cajaTiempoGlobal.Size = new Size(120, 27);
            cajaTiempoGlobal.TabIndex = 7;
            // 
            // labelTemporizadorGlobal
            // 
            labelTemporizadorGlobal.AutoSize = true;
            labelTemporizadorGlobal.BackColor = Color.Transparent;
            labelTemporizadorGlobal.Location = new Point(154, 83);
            labelTemporizadorGlobal.Margin = new Padding(2, 0, 2, 0);
            labelTemporizadorGlobal.Name = "labelTemporizadorGlobal";
            labelTemporizadorGlobal.Size = new Size(140, 20);
            labelTemporizadorGlobal.TabIndex = 6;
            labelTemporizadorGlobal.Text = "Cronómetro Global:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 298);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 8;
            label1.Text = "Procesos Terminados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 9;
            label2.Text = "Procesos Listos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(786, 40);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(224, 19);
            label3.TabIndex = 10;
            label3.Text = "Ejecucción de proceso actual";
            // 
            // cajaTiempoProceso
            // 
            cajaTiempoProceso.BorderStyle = BorderStyle.FixedSingle;
            cajaTiempoProceso.Location = new Point(174, 155);
            cajaTiempoProceso.Margin = new Padding(2);
            cajaTiempoProceso.Name = "cajaTiempoProceso";
            cajaTiempoProceso.Size = new Size(120, 27);
            cajaTiempoProceso.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(101, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 11;
            label4.Text = "Cronómetro proceso actual:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cajaTiempoGlobal);
            panel1.Controls.Add(cajaTiempoProceso);
            panel1.Controls.Add(labelNLotesPendientes);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(botonIniciar);
            panel1.Controls.Add(cajaNProcListos);
            panel1.Controls.Add(labelTemporizadorGlobal);
            panel1.Location = new Point(1112, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 238);
            panel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1099, 298);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 19);
            label5.TabIndex = 14;
            label5.Text = "Procesos Bloqueados";
            // 
            // tablaProcesosBloqueados
            // 
            tablaProcesosBloqueados.AllowUserToAddRows = false;
            tablaProcesosBloqueados.AllowUserToDeleteRows = false;
            tablaProcesosBloqueados.AllowUserToResizeColumns = false;
            tablaProcesosBloqueados.BackgroundColor = Color.WhiteSmoke;
            tablaProcesosBloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProcesosBloqueados.Columns.AddRange(new DataGridViewColumn[] { columnaBloqID, columnaBloqTiempoTranscurrido });
            tablaProcesosBloqueados.Location = new Point(1101, 333);
            tablaProcesosBloqueados.MultiSelect = false;
            tablaProcesosBloqueados.Name = "tablaProcesosBloqueados";
            tablaProcesosBloqueados.ReadOnly = true;
            tablaProcesosBloqueados.RowHeadersVisible = false;
            tablaProcesosBloqueados.RowHeadersWidth = 51;
            tablaProcesosBloqueados.Size = new Size(332, 261);
            tablaProcesosBloqueados.TabIndex = 15;
            // 
            // columnaBloqID
            // 
            columnaBloqID.Frozen = true;
            columnaBloqID.HeaderText = "PID";
            columnaBloqID.MinimumWidth = 166;
            columnaBloqID.Name = "columnaBloqID";
            columnaBloqID.ReadOnly = true;
            columnaBloqID.Resizable = DataGridViewTriState.False;
            columnaBloqID.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnaBloqID.Width = 166;
            // 
            // columnaBloqTiempoTranscurrido
            // 
            columnaBloqTiempoTranscurrido.Frozen = true;
            columnaBloqTiempoTranscurrido.HeaderText = "Tiempo (s) en Bloqueo";
            columnaBloqTiempoTranscurrido.MinimumWidth = 166;
            columnaBloqTiempoTranscurrido.Name = "columnaBloqTiempoTranscurrido";
            columnaBloqTiempoTranscurrido.ReadOnly = true;
            columnaBloqTiempoTranscurrido.Resizable = DataGridViewTriState.False;
            columnaBloqTiempoTranscurrido.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnaBloqTiempoTranscurrido.Width = 166;
            // 
            // NID
            // 
            NID.Frozen = true;
            NID.HeaderText = "N° ID";
            NID.MinimumWidth = 80;
            NID.Name = "NID";
            NID.ReadOnly = true;
            NID.Resizable = DataGridViewTriState.False;
            NID.SortMode = DataGridViewColumnSortMode.NotSortable;
            NID.Width = 80;
            // 
            // TiempoMax
            // 
            TiempoMax.Frozen = true;
            TiempoMax.HeaderText = "Tiempo Maximo Estimado";
            TiempoMax.MinimumWidth = 140;
            TiempoMax.Name = "TiempoMax";
            TiempoMax.ReadOnly = true;
            TiempoMax.Resizable = DataGridViewTriState.False;
            TiempoMax.SortMode = DataGridViewColumnSortMode.NotSortable;
            TiempoMax.Width = 140;
            // 
            // columnaListosTrabajado
            // 
            columnaListosTrabajado.HeaderText = "Tiempo Trabajado";
            columnaListosTrabajado.MinimumWidth = 140;
            columnaListosTrabajado.Name = "columnaListosTrabajado";
            columnaListosTrabajado.ReadOnly = true;
            columnaListosTrabajado.Width = 140;
            // 
            // TiempoTrancurrido
            // 
            TiempoTrancurrido.HeaderText = "Tiempo Trancurrido (s)";
            TiempoTrancurrido.MinimumWidth = 140;
            TiempoTrancurrido.Name = "TiempoTrancurrido";
            TiempoTrancurrido.ReadOnly = true;
            TiempoTrancurrido.Resizable = DataGridViewTriState.False;
            TiempoTrancurrido.SortMode = DataGridViewColumnSortMode.NotSortable;
            TiempoTrancurrido.Width = 140;
            // 
            // Formulario_Ejecuccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 606);
            Controls.Add(tablaProcesosBloqueados);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tablaProcesosCompletados);
            Controls.Add(TablaProcesosEjecutando);
            Controls.Add(TablaProcesosListos);
            KeyPreview = true;
            Margin = new Padding(2);
            Name = "Formulario_Ejecuccion";
            Text = "Ejecuccion";
            ((System.ComponentModel.ISupportInitialize)TablaProcesosListos).EndInit();
            ((System.ComponentModel.ISupportInitialize)TablaProcesosEjecutando).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaProcesosCompletados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProcesosBloqueados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TablaProcesosListos;
        private DataGridView TablaProcesosEjecutando;
        private DataGridView tablaProcesosCompletados;
        private Button botonIniciar;
        private DataGridViewTextBoxColumn nombreProceso;
        private DataGridViewTextBoxColumn DatosRellenarProceso;
        private Label labelNLotesPendientes;
        private TextBox cajaNProcListos;
        private TextBox cajaTiempoGlobal;
        private Label labelTemporizadorGlobal;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox cajaTiempoProceso;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private DataGridView tablaProcesosBloqueados;
        private DataGridViewTextBoxColumn columnaBloqID;
        private DataGridViewTextBoxColumn columnaBloqTiempoTranscurrido;
        private DataGridViewTextBoxColumn NIDEjecutados;
        private DataGridViewTextBoxColumn OperacionEjecutada;
        private DataGridViewTextBoxColumn ResultadoEjecutado;
        private DataGridViewTextBoxColumn TiempoMaxEjecutado;
        private DataGridViewTextBoxColumn columnaTiempoLlegada;
        private DataGridViewTextBoxColumn columnaTiempoFinalizado;
        private DataGridViewTextBoxColumn columnaTiempoEspera;
        private DataGridViewTextBoxColumn TiempoEEjecutado;
        private DataGridViewTextBoxColumn columnaTiempoRetorno;
        private DataGridViewTextBoxColumn columnaTiempoRespuesta;
        private DataGridViewTextBoxColumn NID;
        private DataGridViewTextBoxColumn TiempoMax;
        private DataGridViewTextBoxColumn columnaListosTrabajado;
        private DataGridViewTextBoxColumn TiempoTrancurrido;
    }
}