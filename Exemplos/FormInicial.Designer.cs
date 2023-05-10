namespace Exemplos
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            labelNumero1 = new Label();
            textBoxNumero1 = new TextBox();
            labelNumero2 = new Label();
            textBoxNumero2 = new TextBox();
            buttonCalcular = new Button();
            buttonMais = new Button();
            buttonMenos = new Button();
            buttonMultiplicar = new Button();
            buttondivisao = new Button();
            textBoxOperacao = new TextBox();
            textBoxResultado = new TextBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // labelNumero1
            // 
            labelNumero1.AutoSize = true;
            labelNumero1.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero1.Location = new Point(91, 50);
            labelNumero1.Name = "labelNumero1";
            labelNumero1.Size = new Size(63, 16);
            labelNumero1.TabIndex = 0;
            labelNumero1.Text = "Número 1";
            labelNumero1.Click += label1_Click;
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(76, 69);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(100, 23);
            textBoxNumero1.TabIndex = 0;
            textBoxNumero1.TextChanged += textBoxNumero1_TextChanged;
            // 
            // labelNumero2
            // 
            labelNumero2.AutoSize = true;
            labelNumero2.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero2.Location = new Point(305, 50);
            labelNumero2.Name = "labelNumero2";
            labelNumero2.Size = new Size(65, 16);
            labelNumero2.TabIndex = 2;
            labelNumero2.Text = "Número 2";
            labelNumero2.Click += labelNumero2_Click;
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(287, 69);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(100, 23);
            textBoxNumero2.TabIndex = 1;
            textBoxNumero2.TextChanged += textBoxNumero2_TextChanged;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.Lime;
            buttonCalcular.Cursor = Cursors.Hand;
            buttonCalcular.FlatStyle = FlatStyle.Flat;
            buttonCalcular.Font = new Font("Nexa Heavy", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalcular.Location = new Point(151, 140);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(159, 53);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonMais
            // 
            buttonMais.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMais.Location = new Point(186, 12);
            buttonMais.Name = "buttonMais";
            buttonMais.Size = new Size(27, 23);
            buttonMais.TabIndex = 3;
            buttonMais.Text = "+";
            buttonMais.UseVisualStyleBackColor = true;
            buttonMais.MouseClick += buttonMais_MouseClick;
            // 
            // buttonMenos
            // 
            buttonMenos.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenos.Location = new Point(219, 12);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(27, 23);
            buttonMenos.TabIndex = 4;
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = true;
            buttonMenos.Click += buttonMenos_Click;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMultiplicar.Location = new Point(252, 12);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(27, 23);
            buttonMultiplicar.TabIndex = 5;
            buttonMultiplicar.Text = "X";
            buttonMultiplicar.UseVisualStyleBackColor = true;
            buttonMultiplicar.MouseClick += buttonMultiplicar_MouseClick;
            // 
            // buttondivisao
            // 
            buttondivisao.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttondivisao.Location = new Point(285, 12);
            buttondivisao.Name = "buttondivisao";
            buttondivisao.Size = new Size(27, 23);
            buttondivisao.TabIndex = 6;
            buttondivisao.Text = "/";
            buttondivisao.UseVisualStyleBackColor = true;
            buttondivisao.MouseClick += buttondivisao_MouseClick;
            // 
            // textBoxOperacao
            // 
            textBoxOperacao.BackColor = Color.Silver;
            textBoxOperacao.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxOperacao.Location = new Point(219, 69);
            textBoxOperacao.Name = "textBoxOperacao";
            textBoxOperacao.ReadOnly = true;
            textBoxOperacao.Size = new Size(28, 26);
            textBoxOperacao.TabIndex = 9;
            textBoxOperacao.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Cursor = Cursors.IBeam;
            textBoxResultado.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxResultado.Location = new Point(138, 111);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.PlaceholderText = "Resultado";
            textBoxResultado.Size = new Size(190, 26);
            textBoxResultado.TabIndex = 7;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Font = new Font("Nexa Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpar.Location = new Point(154, 12);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(27, 23);
            buttonLimpar.TabIndex = 2;
            buttonLimpar.Text = "C";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.MouseClick += buttonLimpar_MouseClick;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(466, 205);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxOperacao);
            Controls.Add(buttondivisao);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonMenos);
            Controls.Add(buttonMais);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxNumero2);
            Controls.Add(labelNumero2);
            Controls.Add(textBoxNumero1);
            Controls.Add(labelNumero1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInicial";
            Text = "Calculadora da Academia no Forms";
            Load += FormInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumero1;
        private TextBox textBoxNumero1;
        private Label labelNumero2;
        private TextBox textBoxNumero2;
        private Button buttonCalcular;
        private Button buttonMais;
        private Button buttonMenos;
        private Button buttonMultiplicar;
        private Button buttondivisao;
        private TextBox textBoxOperacao;
        private TextBox textBoxResultado;
        private Button buttonLimpar;
    }
}