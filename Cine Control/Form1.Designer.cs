namespace Cine_Control
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbPelicula = new ComboBox();
            cmbFuncion = new ComboBox();
            txtCliente = new TextBox();
            btnFacturar = new Button();
            btnLimpiar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnA4 = new Button();
            btnA5 = new Button();
            btnB5 = new Button();
            btnB4 = new Button();
            btnB3 = new Button();
            btnB2 = new Button();
            btnB1 = new Button();
            btnC5 = new Button();
            btnC4 = new Button();
            btnC3 = new Button();
            btnC2 = new Button();
            btnC1 = new Button();
            btnD5 = new Button();
            btnD4 = new Button();
            btnD3 = new Button();
            btnD2 = new Button();
            btnD1 = new Button();
            rtbFactura = new RichTextBox();
            lblCantidad = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 23);
            label1.TabIndex = 0;
            label1.Text = "Cine Control";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Pelicula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Funcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente";
            // 
            // cmbPelicula
            // 
            cmbPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPelicula.FormattingEnabled = true;
            cmbPelicula.Location = new Point(12, 55);
            cmbPelicula.Name = "cmbPelicula";
            cmbPelicula.Size = new Size(327, 23);
            cmbPelicula.TabIndex = 4;
            // 
            // cmbFuncion
            // 
            cmbFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncion.FormattingEnabled = true;
            cmbFuncion.Location = new Point(12, 107);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(327, 23);
            cmbFuncion.TabIndex = 5;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(12, 159);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(327, 23);
            txtCliente.TabIndex = 6;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.Maroon;
            btnFacturar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturar.ForeColor = SystemColors.ButtonHighlight;
            btnFacturar.Location = new Point(12, 306);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(327, 37);
            btnFacturar.TabIndex = 8;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Info;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(12, 349);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(327, 37);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(64, 64, 64);
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(369, 37);
            label5.Name = "label5";
            label5.Size = new Size(419, 23);
            label5.TabIndex = 10;
            label5.Text = "Pantalla";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 255, 255);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(369, 63);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 11;
            label6.Text = "Fila A y B generan $12.000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Info;
            label7.ForeColor = Color.Olive;
            label7.Location = new Point(528, 63);
            label7.Name = "label7";
            label7.Size = new Size(174, 15);
            label7.TabIndex = 12;
            label7.Text = "Fila C y D preferenciales $18.000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 102);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 13;
            label8.Text = "A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 154);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 14;
            label9.Text = "B";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 206);
            label10.Name = "label10";
            label10.Size = new Size(15, 15);
            label10.TabIndex = 15;
            label10.Text = "C";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(370, 253);
            label11.Name = "label11";
            label11.Size = new Size(15, 15);
            label11.TabIndex = 16;
            label11.Text = "D";
            // 
            // btnA1
            // 
            btnA1.BackColor = Color.FromArgb(0, 192, 0);
            btnA1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnA1.ForeColor = SystemColors.ButtonHighlight;
            btnA1.Location = new Point(390, 89);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(75, 41);
            btnA1.TabIndex = 17;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = false;
            btnA1.Click += btnA1_Click;
            // 
            // btnA2
            // 
            btnA2.BackColor = Color.FromArgb(0, 192, 0);
            btnA2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnA2.ForeColor = SystemColors.ButtonHighlight;
            btnA2.Location = new Point(471, 89);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(75, 41);
            btnA2.TabIndex = 18;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = false;
            btnA2.Click += btnA1_Click;
            // 
            // btnA3
            // 
            btnA3.BackColor = Color.FromArgb(0, 192, 0);
            btnA3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnA3.ForeColor = SystemColors.ButtonHighlight;
            btnA3.Location = new Point(552, 89);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(75, 41);
            btnA3.TabIndex = 19;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = false;
            btnA3.Click += btnA1_Click;
            // 
            // btnA4
            // 
            btnA4.BackColor = Color.FromArgb(0, 192, 0);
            btnA4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnA4.ForeColor = SystemColors.ButtonHighlight;
            btnA4.Location = new Point(633, 89);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(75, 41);
            btnA4.TabIndex = 20;
            btnA4.Text = "A4";
            btnA4.UseVisualStyleBackColor = false;
            btnA4.Click += btnA1_Click;
            // 
            // btnA5
            // 
            btnA5.BackColor = Color.FromArgb(0, 192, 0);
            btnA5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnA5.ForeColor = SystemColors.ButtonHighlight;
            btnA5.Location = new Point(714, 89);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(75, 41);
            btnA5.TabIndex = 21;
            btnA5.Text = "A5";
            btnA5.UseVisualStyleBackColor = false;
            btnA5.Click += btnA1_Click;
            // 
            // btnB5
            // 
            btnB5.BackColor = Color.FromArgb(0, 192, 0);
            btnB5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnB5.ForeColor = SystemColors.ButtonHighlight;
            btnB5.Location = new Point(714, 141);
            btnB5.Name = "btnB5";
            btnB5.Size = new Size(75, 41);
            btnB5.TabIndex = 26;
            btnB5.Text = "B5";
            btnB5.UseVisualStyleBackColor = false;
            btnB5.Click += btnA1_Click;
            // 
            // btnB4
            // 
            btnB4.BackColor = Color.FromArgb(0, 192, 0);
            btnB4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnB4.ForeColor = SystemColors.ButtonHighlight;
            btnB4.Location = new Point(633, 141);
            btnB4.Name = "btnB4";
            btnB4.Size = new Size(75, 41);
            btnB4.TabIndex = 25;
            btnB4.Text = "B4";
            btnB4.UseVisualStyleBackColor = false;
            btnB4.Click += btnA1_Click;
            // 
            // btnB3
            // 
            btnB3.BackColor = Color.FromArgb(0, 192, 0);
            btnB3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnB3.ForeColor = SystemColors.ButtonHighlight;
            btnB3.Location = new Point(552, 141);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(75, 41);
            btnB3.TabIndex = 24;
            btnB3.Text = "B3";
            btnB3.UseVisualStyleBackColor = false;
            btnB3.Click += btnA1_Click;
            // 
            // btnB2
            // 
            btnB2.BackColor = Color.FromArgb(0, 192, 0);
            btnB2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnB2.ForeColor = SystemColors.ButtonHighlight;
            btnB2.Location = new Point(471, 141);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(75, 41);
            btnB2.TabIndex = 23;
            btnB2.Text = "B2";
            btnB2.UseVisualStyleBackColor = false;
            btnB2.Click += btnA1_Click;
            // 
            // btnB1
            // 
            btnB1.BackColor = Color.FromArgb(0, 192, 0);
            btnB1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnB1.ForeColor = SystemColors.ButtonHighlight;
            btnB1.Location = new Point(390, 141);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(75, 41);
            btnB1.TabIndex = 22;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = false;
            btnB1.Click += btnA1_Click;
            // 
            // btnC5
            // 
            btnC5.BackColor = Color.FromArgb(0, 192, 0);
            btnC5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnC5.ForeColor = SystemColors.ButtonHighlight;
            btnC5.Location = new Point(714, 193);
            btnC5.Name = "btnC5";
            btnC5.Size = new Size(75, 41);
            btnC5.TabIndex = 31;
            btnC5.Text = "C5";
            btnC5.UseVisualStyleBackColor = false;
            btnC5.Click += btnA1_Click;
            // 
            // btnC4
            // 
            btnC4.BackColor = Color.FromArgb(0, 192, 0);
            btnC4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnC4.ForeColor = SystemColors.ButtonHighlight;
            btnC4.Location = new Point(633, 193);
            btnC4.Name = "btnC4";
            btnC4.Size = new Size(75, 41);
            btnC4.TabIndex = 30;
            btnC4.Text = "C4";
            btnC4.UseVisualStyleBackColor = false;
            btnC4.Click += btnA1_Click;
            // 
            // btnC3
            // 
            btnC3.BackColor = Color.FromArgb(0, 192, 0);
            btnC3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnC3.ForeColor = SystemColors.ButtonHighlight;
            btnC3.Location = new Point(552, 193);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(75, 41);
            btnC3.TabIndex = 29;
            btnC3.Text = "C3";
            btnC3.UseVisualStyleBackColor = false;
            btnC3.Click += btnA1_Click;
            // 
            // btnC2
            // 
            btnC2.BackColor = Color.FromArgb(0, 192, 0);
            btnC2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnC2.ForeColor = SystemColors.ButtonHighlight;
            btnC2.Location = new Point(471, 193);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(75, 41);
            btnC2.TabIndex = 28;
            btnC2.Text = "C2";
            btnC2.UseVisualStyleBackColor = false;
            btnC2.Click += btnA1_Click;
            // 
            // btnC1
            // 
            btnC1.BackColor = Color.FromArgb(0, 192, 0);
            btnC1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnC1.ForeColor = SystemColors.ButtonHighlight;
            btnC1.Location = new Point(390, 193);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(75, 41);
            btnC1.TabIndex = 27;
            btnC1.Text = "C1";
            btnC1.UseVisualStyleBackColor = false;
            btnC1.Click += btnA1_Click;
            // 
            // btnD5
            // 
            btnD5.BackColor = Color.FromArgb(0, 192, 0);
            btnD5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnD5.ForeColor = SystemColors.ButtonHighlight;
            btnD5.Location = new Point(714, 240);
            btnD5.Name = "btnD5";
            btnD5.Size = new Size(75, 41);
            btnD5.TabIndex = 36;
            btnD5.Text = "D5";
            btnD5.UseVisualStyleBackColor = false;
            btnD5.Click += btnA1_Click;
            // 
            // btnD4
            // 
            btnD4.BackColor = Color.FromArgb(0, 192, 0);
            btnD4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnD4.ForeColor = SystemColors.ButtonHighlight;
            btnD4.Location = new Point(633, 240);
            btnD4.Name = "btnD4";
            btnD4.Size = new Size(75, 41);
            btnD4.TabIndex = 35;
            btnD4.Text = "D4";
            btnD4.UseVisualStyleBackColor = false;
            btnD4.Click += btnA1_Click;
            // 
            // btnD3
            // 
            btnD3.BackColor = Color.FromArgb(0, 192, 0);
            btnD3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnD3.ForeColor = SystemColors.ButtonHighlight;
            btnD3.Location = new Point(552, 240);
            btnD3.Name = "btnD3";
            btnD3.Size = new Size(75, 41);
            btnD3.TabIndex = 34;
            btnD3.Text = "D3";
            btnD3.UseVisualStyleBackColor = false;
            btnD3.Click += btnA1_Click;
            // 
            // btnD2
            // 
            btnD2.BackColor = Color.FromArgb(0, 192, 0);
            btnD2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnD2.ForeColor = SystemColors.ButtonHighlight;
            btnD2.Location = new Point(471, 240);
            btnD2.Name = "btnD2";
            btnD2.Size = new Size(75, 41);
            btnD2.TabIndex = 33;
            btnD2.Text = "D2";
            btnD2.UseVisualStyleBackColor = false;
            btnD2.Click += btnA1_Click;
            // 
            // btnD1
            // 
            btnD1.BackColor = Color.FromArgb(0, 192, 0);
            btnD1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnD1.ForeColor = SystemColors.ButtonHighlight;
            btnD1.Location = new Point(390, 240);
            btnD1.Name = "btnD1";
            btnD1.Size = new Size(75, 41);
            btnD1.TabIndex = 32;
            btnD1.Text = "D1";
            btnD1.UseVisualStyleBackColor = false;
            btnD1.Click += btnA1_Click;
            // 
            // rtbFactura
            // 
            rtbFactura.Location = new Point(370, 315);
            rtbFactura.Name = "rtbFactura";
            rtbFactura.Size = new Size(419, 123);
            rtbFactura.TabIndex = 37;
            rtbFactura.Text = "";
            // 
            // lblCantidad
            // 
            lblCantidad.BackColor = SystemColors.ButtonHighlight;
            lblCantidad.Location = new Point(12, 202);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(327, 32);
            lblCantidad.TabIndex = 38;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(12, 249);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(327, 32);
            lblTotal.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(rtbFactura);
            Controls.Add(btnD5);
            Controls.Add(btnD4);
            Controls.Add(btnD3);
            Controls.Add(btnD2);
            Controls.Add(btnD1);
            Controls.Add(btnC5);
            Controls.Add(btnC4);
            Controls.Add(btnC3);
            Controls.Add(btnC2);
            Controls.Add(btnC1);
            Controls.Add(btnB5);
            Controls.Add(btnB4);
            Controls.Add(btnB3);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Controls.Add(btnA5);
            Controls.Add(btnA4);
            Controls.Add(btnA3);
            Controls.Add(btnA2);
            Controls.Add(btnA1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLimpiar);
            Controls.Add(btnFacturar);
            Controls.Add(txtCliente);
            Controls.Add(cmbFuncion);
            Controls.Add(cmbPelicula);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Click += btnA1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbPelicula;
        private ComboBox cmbFuncion;
        private TextBox txtCliente;
        private ListBox listBox1;
        private Button btnFacturar;
        private Button btnLimpiar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnA4;
        private Button btnA5;
        private Button btnB5;
        private Button btnB4;
        private Button btnB3;
        private Button btnB2;
        private Button btnB1;
        private Button btnC5;
        private Button btnC4;
        private Button btnC3;
        private Button btnC2;
        private Button btnC1;
        private Button btnD5;
        private Button btnD4;
        private Button btnD3;
        private Button btnD2;
        private Button btnD1;
        private RichTextBox rtbFactura;
        private Label lblCantidad;
        private Label lblTotal;
    }
}
