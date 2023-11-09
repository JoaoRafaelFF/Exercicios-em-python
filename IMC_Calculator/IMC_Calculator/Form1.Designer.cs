namespace IMC_Calculator
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
            BtnCalc = new Button();
            label1 = new Label();
            label2 = new Label();
            TbAlt = new TextBox();
            TbPeso = new TextBox();
            BtnExit = new Button();
            label3 = new Label();
            label4 = new Label();
            TbNome = new TextBox();
            TbEndereco = new TextBox();
            label5 = new Label();
            LblResults = new Label();
            BtReiniciar = new Button();
            LblClassfic = new Label();
            LblNome = new Label();
            LblEndereco = new Label();
            SuspendLayout();
            // 
            // BtnCalc
            // 
            BtnCalc.Location = new Point(108, 369);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(75, 23);
            BtnCalc.TabIndex = 0;
            BtnCalc.Text = "Calcular";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 180);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 184);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Peso";
            // 
            // TbAlt
            // 
            TbAlt.Location = new Point(71, 206);
            TbAlt.Name = "TbAlt";
            TbAlt.Size = new Size(100, 23);
            TbAlt.TabIndex = 3;
            // 
            // TbPeso
            // 
            TbPeso.Location = new Point(252, 206);
            TbPeso.Name = "TbPeso";
            TbPeso.Size = new Size(100, 23);
            TbPeso.TabIndex = 4;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(483, 369);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 38);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome do paciente ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 65);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 7;
            label4.Text = "Endereco Completo";
            // 
            // TbNome
            // 
            TbNome.Location = new Point(194, 41);
            TbNome.Name = "TbNome";
            TbNome.Size = new Size(100, 23);
            TbNome.TabIndex = 8;
            // 
            // TbEndereco
            // 
            TbEndereco.Location = new Point(194, 70);
            TbEndereco.Name = "TbEndereco";
            TbEndereco.Size = new Size(100, 23);
            TbEndereco.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 209);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 10;
            label5.Text = "Resultado :";
            // 
            // LblResults
            // 
            LblResults.AutoSize = true;
            LblResults.Location = new Point(480, 239);
            LblResults.Name = "LblResults";
            LblResults.Size = new Size(0, 15);
            LblResults.TabIndex = 11;
            // 
            // BtReiniciar
            // 
            BtReiniciar.Location = new Point(219, 369);
            BtReiniciar.Name = "BtReiniciar";
            BtReiniciar.Size = new Size(75, 23);
            BtReiniciar.TabIndex = 12;
            BtReiniciar.Text = "Reiniciar";
            BtReiniciar.UseVisualStyleBackColor = true;
            BtReiniciar.Click += BtReiniciar_Click;
            // 
            // LblClassfic
            // 
            LblClassfic.AutoSize = true;
            LblClassfic.Location = new Point(480, 254);
            LblClassfic.Name = "LblClassfic";
            LblClassfic.Size = new Size(0, 15);
            LblClassfic.TabIndex = 13;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(480, 209);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(0, 15);
            LblNome.TabIndex = 14;
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(480, 224);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(0, 15);
            LblEndereco.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblEndereco);
            Controls.Add(LblNome);
            Controls.Add(LblClassfic);
            Controls.Add(BtReiniciar);
            Controls.Add(LblResults);
            Controls.Add(label5);
            Controls.Add(TbEndereco);
            Controls.Add(TbNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnExit);
            Controls.Add(TbPeso);
            Controls.Add(TbAlt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCalc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalc;
        private Label label1;
        private Label label2;
        private TextBox TbAlt;
        private TextBox TbPeso;
        private Button BtnExit;
        private Label label3;
        private Label label4;
        private TextBox TbNome;
        private TextBox TbEndereco;
        private Label label5;
        private Label LblResults;
        private Button BtReiniciar;
        private Label LblClassfic;
        private Label LblNome;
        private Label LblEndereco;
    }
}