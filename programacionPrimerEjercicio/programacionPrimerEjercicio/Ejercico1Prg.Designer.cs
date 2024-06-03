namespace programacionPrimerEjercicio
{
    partial class Ejercico1Prg
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
            label1 = new Label();
            btSalir = new Button();
            lbCodigo = new Label();
            lbDesc = new Label();
            lbStock = new Label();
            btCargar = new Button();
            txCodigo = new TextBox();
            txDescripcion = new TextBox();
            txStock = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btAceptar = new Button();
            RadioEngreso = new RadioButton();
            RadioIngreso = new RadioButton();
            txCantidad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(176, 44);
            label1.Name = "label1";
            label1.Size = new Size(451, 28);
            label1.TabIndex = 0;
            label1.Text = "Trabajo práctico Programación 2 - (Primer trabajo)";
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(723, 471);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 1;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(25, 33);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(58, 20);
            lbCodigo.TabIndex = 2;
            lbCodigo.Text = "Codigo";
            // 
            // lbDesc
            // 
            lbDesc.AutoSize = true;
            lbDesc.Location = new Point(22, 94);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(85, 20);
            lbDesc.TabIndex = 3;
            lbDesc.Text = "descripcion";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(25, 158);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(43, 20);
            lbStock.TabIndex = 4;
            lbStock.Text = "stock";
            // 
            // btCargar
            // 
            btCargar.Location = new Point(314, 158);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 5;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // txCodigo
            // 
            txCodigo.Location = new Point(145, 30);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(125, 27);
            txCodigo.TabIndex = 6;
            // 
            // txDescripcion
            // 
            txDescripcion.Location = new Point(145, 87);
            txDescripcion.Name = "txDescripcion";
            txDescripcion.Size = new Size(169, 27);
            txDescripcion.TabIndex = 7;
            // 
            // txStock
            // 
            txStock.Location = new Point(101, 155);
            txStock.Name = "txStock";
            txStock.Size = new Size(169, 27);
            txStock.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(30, 108);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(761, 339);
            tabControl1.TabIndex = 9;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btCargar);
            tabPage1.Controls.Add(txStock);
            tabPage1.Controls.Add(txCodigo);
            tabPage1.Controls.Add(lbStock);
            tabPage1.Controls.Add(txDescripcion);
            tabPage1.Controls.Add(lbCodigo);
            tabPage1.Controls.Add(lbDesc);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(753, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btAceptar);
            tabPage2.Controls.Add(RadioEngreso);
            tabPage2.Controls.Add(RadioIngreso);
            tabPage2.Controls.Add(txCantidad);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(753, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(558, 82);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(94, 29);
            btAceptar.TabIndex = 6;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            // 
            // RadioEngreso
            // 
            RadioEngreso.AutoSize = true;
            RadioEngreso.Location = new Point(375, 84);
            RadioEngreso.Name = "RadioEngreso";
            RadioEngreso.Size = new Size(75, 24);
            RadioEngreso.TabIndex = 5;
            RadioEngreso.TabStop = true;
            RadioEngreso.Text = "Egreso";
            RadioEngreso.UseVisualStyleBackColor = true;
            // 
            // RadioIngreso
            // 
            RadioIngreso.AutoSize = true;
            RadioIngreso.Location = new Point(375, 39);
            RadioIngreso.Name = "RadioIngreso";
            RadioIngreso.Size = new Size(79, 24);
            RadioIngreso.TabIndex = 4;
            RadioIngreso.TabStop = true;
            RadioIngreso.Text = "Ingreso";
            RadioIngreso.UseVisualStyleBackColor = true;
            // 
            // txCantidad
            // 
            txCantidad.Location = new Point(116, 97);
            txCantidad.Name = "txCantidad";
            txCantidad.Size = new Size(125, 27);
            txCantidad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 104);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 64);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 29);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Ejercico1Prg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 512);
            Controls.Add(tabControl1);
            Controls.Add(btSalir);
            Controls.Add(label1);
            Name = "Ejercico1Prg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercico1Prg";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btSalir;
        private Label lbCodigo;
        private Label lbDesc;
        private Label lbStock;
        private Button btCargar;
        private TextBox txCodigo;
        private TextBox txDescripcion;
        private TextBox txStock;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton RadioEngreso;
        private RadioButton RadioIngreso;
        private TextBox txCantidad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btAceptar;
    }
}