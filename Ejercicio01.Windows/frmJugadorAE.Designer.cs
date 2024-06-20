namespace Ejercicio01.Windows
{
    partial class frmJugadorAE
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
            txtDni = new TextBox();
            label1 = new Label();
            txtNombreJugador = new TextBox();
            label2 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(110, 22);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(133, 23);
            txtDni.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "------DNI------";
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(18, 66);
            txtNombreJugador.MaxLength = 200;
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(225, 23);
            txtNombreJugador.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 48);
            label2.Name = "label2";
            label2.Size = new Size(232, 15);
            label2.TabIndex = 4;
            label2.Text = "------------Nombre de Jugador------------";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(18, 103);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 50);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(141, 103);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmJugadorAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 176);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtNombreJugador);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label1);
            MaximumSize = new Size(283, 215);
            MinimumSize = new Size(283, 215);
            Name = "frmJugadorAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmJugadorAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private Label label1;
        private TextBox txtNombreJugador;
        private Label label2;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}