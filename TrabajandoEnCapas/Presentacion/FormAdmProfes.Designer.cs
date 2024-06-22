namespace Presentacion
{
    partial class FormAdmProfes
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
            TxCodigo = new TextBox();
            TxNombre = new TextBox();
            btCargar = new Button();
            label1 = new Label();
            label2 = new Label();
            LbMensajeError = new Label();
            dgvProfesionales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).BeginInit();
            SuspendLayout();
            // 
            // TxCodigo
            // 
            TxCodigo.Location = new Point(62, 146);
            TxCodigo.Name = "TxCodigo";
            TxCodigo.Size = new Size(125, 27);
            TxCodigo.TabIndex = 0;
            // 
            // TxNombre
            // 
            TxNombre.Location = new Point(255, 146);
            TxNombre.Name = "TxNombre";
            TxNombre.Size = new Size(125, 27);
            TxNombre.TabIndex = 1;
            // 
            // btCargar
            // 
            btCargar.Location = new Point(427, 145);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 2;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 98);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 98);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // LbMensajeError
            // 
            LbMensajeError.AutoSize = true;
            LbMensajeError.Location = new Point(62, 241);
            LbMensajeError.Name = "LbMensajeError";
            LbMensajeError.Size = new Size(58, 20);
            LbMensajeError.TabIndex = 5;
            LbMensajeError.Text = "Código";
            // 
            // dgvProfesionales
            // 
            dgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesionales.Location = new Point(597, 12);
            dgvProfesionales.Name = "dgvProfesionales";
            dgvProfesionales.RowHeadersWidth = 51;
            dgvProfesionales.Size = new Size(483, 510);
            dgvProfesionales.TabIndex = 6;
            // 
            // FormAdmProfes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 534);
            Controls.Add(dgvProfesionales);
            Controls.Add(LbMensajeError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCargar);
            Controls.Add(TxNombre);
            Controls.Add(TxCodigo);
            Name = "FormAdmProfes";
            Text = "Adm Profesionales";
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxCodigo;
        private TextBox TxNombre;
        private Button btCargar;
        private Label label1;
        private Label label2;
        private Label LbMensajeError;
        private DataGridView dgvProfesionales;
    }
}
