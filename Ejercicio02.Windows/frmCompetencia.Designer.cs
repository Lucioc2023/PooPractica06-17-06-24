namespace Ejercicio02.Windows
{
    partial class frmCompetencia
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            nudCantidadVueltas = new NumericUpDown();
            btnSalir = new Button();
            btnAgregarAutoF1 = new Button();
            btnCrear = new Button();
            nudCantidadCompetidores = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colAutoF1 = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadVueltas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadCompetidores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(nudCantidadVueltas);
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnAgregarAutoF1);
            splitContainer1.Panel1.Controls.Add(btnCrear);
            splitContainer1.Panel1.Controls.Add(nudCantidadCompetidores);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDatos);
            splitContainer1.Size = new Size(478, 436);
            splitContainer1.SplitterDistance = 148;
            splitContainer1.TabIndex = 0;
            // 
            // nudCantidadVueltas
            // 
            nudCantidadVueltas.Location = new Point(189, 32);
            nudCantidadVueltas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidadVueltas.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudCantidadVueltas.Name = "nudCantidadVueltas";
            nudCantidadVueltas.Size = new Size(120, 23);
            nudCantidadVueltas.TabIndex = 13;
            nudCantidadVueltas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Coral;
            btnSalir.Location = new Point(402, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 119);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarAutoF1
            // 
            btnAgregarAutoF1.BackColor = SystemColors.ScrollBar;
            btnAgregarAutoF1.Enabled = false;
            btnAgregarAutoF1.Location = new Point(38, 106);
            btnAgregarAutoF1.Name = "btnAgregarAutoF1";
            btnAgregarAutoF1.Size = new Size(358, 30);
            btnAgregarAutoF1.TabIndex = 11;
            btnAgregarAutoF1.Text = "Agregar Auto F1";
            btnAgregarAutoF1.UseVisualStyleBackColor = false;
            btnAgregarAutoF1.Click += btnAgregarAutoF1_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Blue;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(328, 61);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(68, 39);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // nudCantidadCompetidores
            // 
            nudCantidadCompetidores.Location = new Point(189, 71);
            nudCantidadCompetidores.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidadCompetidores.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudCantidadCompetidores.Name = "nudCantidadCompetidores";
            nudCantidadCompetidores.Size = new Size(120, 23);
            nudCantidadCompetidores.TabIndex = 9;
            nudCantidadCompetidores.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 79);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 8;
            label2.Text = "Cantidad de Competidores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 6;
            label1.Text = "Cantidad de Vueltas";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colAutoF1 });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(478, 284);
            dgvDatos.TabIndex = 1;
            // 
            // colAutoF1
            // 
            colAutoF1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutoF1.HeaderText = "Auto F1";
            colAutoF1.Name = "colAutoF1";
            colAutoF1.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCompetencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 436);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(494, 475);
            MinimumSize = new Size(494, 475);
            Name = "frmCompetencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCompetencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidadVueltas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadCompetidores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregarAutoF1;
        private Button btnCrear;
        private NumericUpDown nudCantidadCompetidores;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private DataGridView dgvDatos;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn colAutoF1;
        private NumericUpDown nudCantidadVueltas;
    }
}