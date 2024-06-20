namespace Ejercicio01.Windows
{
    partial class frmEquipo
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
            btnSalir = new Button();
            btnAgregarJugador = new Button();
            btnCrear = new Button();
            nudCantidad = new NumericUpDown();
            label2 = new Label();
            txtEquipo = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colJugador = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnAgregarJugador);
            splitContainer1.Panel1.Controls.Add(btnCrear);
            splitContainer1.Panel1.Controls.Add(nudCantidad);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtEquipo);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDatos);
            splitContainer1.Size = new Size(570, 468);
            splitContainer1.SplitterDistance = 171;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Coral;
            btnSalir.Location = new Point(509, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 119);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Exit";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Enabled = false;
            btnAgregarJugador.Location = new Point(14, 107);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(376, 33);
            btnAgregarJugador.TabIndex = 5;
            btnAgregarJugador.Text = "Agregar Jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(408, 21);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(87, 119);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(178, 72);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad De Jugadores";
            // 
            // txtEquipo
            // 
            txtEquipo.Location = new Point(111, 21);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.Size = new Size(279, 23);
            txtEquipo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Equipo";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colJugador });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(570, 293);
            dgvDatos.TabIndex = 0;
            // 
            // colJugador
            // 
            colJugador.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colJugador.HeaderText = "Jugador";
            colJugador.Name = "colJugador";
            colJugador.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 468);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(586, 507);
            MinimumSize = new Size(586, 507);
            Name = "frmEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEquipo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private NumericUpDown nudCantidad;
        private Label label2;
        private TextBox txtEquipo;
        private Button btnAgregarJugador;
        private Button btnCrear;
        private ErrorProvider errorProvider1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colJugador;
        private Button btnSalir;
    }
}