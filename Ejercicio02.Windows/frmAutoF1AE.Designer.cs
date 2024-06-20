namespace Ejercicio02.Windows
{
    partial class frmAutoF1AE
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
            errorProvider1 = new ErrorProvider(components);
            btnCancel = new Button();
            btnOk = new Button();
            txtEscuderia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nudNumeroAutoF1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumeroAutoF1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(151, 104);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 50);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(28, 104);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 50);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtEscuderia
            // 
            txtEscuderia.Location = new Point(28, 67);
            txtEscuderia.MaxLength = 200;
            txtEscuderia.Name = "txtEscuderia";
            txtEscuderia.Size = new Size(225, 23);
            txtEscuderia.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(227, 15);
            label2.TabIndex = 9;
            label2.Text = "-----------------Escuderia-----------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Numeracion";
            // 
            // nudNumeroAutoF1
            // 
            nudNumeroAutoF1.Location = new Point(133, 23);
            nudNumeroAutoF1.Name = "nudNumeroAutoF1";
            nudNumeroAutoF1.Size = new Size(120, 23);
            nudNumeroAutoF1.TabIndex = 13;
            // 
            // frmAutoF1AE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 177);
            Controls.Add(nudNumeroAutoF1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtEscuderia);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(301, 216);
            MinimumSize = new Size(301, 216);
            Name = "frmAutoF1AE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAutoF1AE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumeroAutoF1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnCancel;
        private Button btnOk;
        private TextBox txtEscuderia;
        private Label label2;
        private Label label1;
        private NumericUpDown nudNumeroAutoF1;
    }
}