namespace TeoremaTriangulo
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
            titleApp = new Label();
            txtA = new TextBox();
            lblLadoA = new Label();
            lblLadoB = new Label();
            txtB = new TextBox();
            lblLadoC = new Label();
            txtC = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblResultados = new Label();
            lblParametro = new Label();
            lblArea = new Label();
            lblExistencia = new Label();
            lblTipo = new Label();
            lblVisualiza = new Label();
            txtExistencia = new TextBox();
            txtPerimetro = new TextBox();
            txtTipo = new TextBox();
            txtArea = new TextBox();
            imgTry = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgTry).BeginInit();
            SuspendLayout();
            // 
            // titleApp
            // 
            titleApp.AutoSize = true;
            titleApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleApp.Location = new Point(34, 25);
            titleApp.Name = "titleApp";
            titleApp.Size = new Size(442, 32);
            titleApp.TabIndex = 0;
            titleApp.Text = "INGRESE LOS LADOS DEL TRIANGULO";
            // 
            // txtA
            // 
            txtA.Location = new Point(119, 89);
            txtA.Name = "txtA";
            txtA.Size = new Size(106, 31);
            txtA.TabIndex = 1;
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLadoA.Location = new Point(34, 92);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(78, 25);
            lblLadoA.TabIndex = 4;
            lblLadoA.Text = "Lado A :";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLadoB.Location = new Point(309, 95);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(77, 25);
            lblLadoB.TabIndex = 6;
            lblLadoB.Text = "Lado B :";
            // 
            // txtB
            // 
            txtB.Location = new Point(394, 92);
            txtB.Name = "txtB";
            txtB.Size = new Size(111, 31);
            txtB.TabIndex = 5;
            // 
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLadoC.Location = new Point(585, 98);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(77, 25);
            lblLadoC.TabIndex = 8;
            lblLadoC.Text = "Lado C :";
            // 
            // txtC
            // 
            txtC.Location = new Point(667, 95);
            txtC.Name = "txtC";
            txtC.Size = new Size(106, 31);
            txtC.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(196, 154);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(149, 36);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(466, 154);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 36);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultados.Location = new Point(159, 231);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(129, 24);
            lblResultados.TabIndex = 12;
            lblResultados.Text = "Resultados :";
            // 
            // lblParametro
            // 
            lblParametro.AutoSize = true;
            lblParametro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParametro.Location = new Point(239, 321);
            lblParametro.Name = "lblParametro";
            lblParametro.Size = new Size(104, 25);
            lblParametro.TabIndex = 13;
            lblParametro.Text = "Perimetro :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(283, 371);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(59, 25);
            lblArea.TabIndex = 14;
            lblArea.Text = "Area :";
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencia.Location = new Point(241, 276);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(102, 25);
            lblExistencia.TabIndex = 15;
            lblExistencia.Text = "Existencia :";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(284, 417);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(58, 25);
            lblTipo.TabIndex = 16;
            lblTipo.Text = "Tipo :";
            // 
            // lblVisualiza
            // 
            lblVisualiza.AutoSize = true;
            lblVisualiza.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisualiza.Location = new Point(227, 464);
            lblVisualiza.Name = "lblVisualiza";
            lblVisualiza.Size = new Size(115, 25);
            lblVisualiza.TabIndex = 17;
            lblVisualiza.Text = "Se visualiza :";
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(349, 275);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(238, 31);
            txtExistencia.TabIndex = 18;
            // 
            // txtPerimetro
            // 
            txtPerimetro.BackColor = SystemColors.Window;
            txtPerimetro.Location = new Point(349, 321);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.Size = new Size(238, 31);
            txtPerimetro.TabIndex = 19;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(349, 414);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(238, 31);
            txtTipo.TabIndex = 21;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(349, 368);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(238, 31);
            txtArea.TabIndex = 20;
            // 
            // imgTry
            // 
            imgTry.Location = new Point(355, 464);
            imgTry.Name = "imgTry";
            imgTry.Size = new Size(232, 134);
            imgTry.TabIndex = 22;
            imgTry.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(822, 646);
            Controls.Add(imgTry);
            Controls.Add(txtTipo);
            Controls.Add(txtArea);
            Controls.Add(txtPerimetro);
            Controls.Add(txtExistencia);
            Controls.Add(lblVisualiza);
            Controls.Add(lblTipo);
            Controls.Add(lblExistencia);
            Controls.Add(lblArea);
            Controls.Add(lblParametro);
            Controls.Add(lblResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtC);
            Controls.Add(lblLadoC);
            Controls.Add(lblLadoB);
            Controls.Add(txtB);
            Controls.Add(lblLadoA);
            Controls.Add(txtA);
            Controls.Add(titleApp);
            Name = "Form1";
            Text = "Calculando Triangulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgTry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleApp;
        private TextBox txtA;
        private Label lblLadoA;
        private Label lblLadoB;
        private TextBox txtB;
        private Label lblLadoC;
        private TextBox txtC;
        internal Button btnCalcular;
        internal Button btnLimpiar;
        private Label lblResultados;
        private Label lblParametro;
        private Label lblArea;
        private Label lblExistencia;
        private Label lblTipo;
        private Label lblVisualiza;
        private TextBox txtExistencia;
        private TextBox txtPerimetro;
        private TextBox txtTipo;
        private TextBox txtArea;
        private PictureBox imgTry;
    }
}
