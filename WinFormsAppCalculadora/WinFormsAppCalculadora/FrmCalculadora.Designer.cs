namespace WinFormsAppCalculadora
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            lbCalculadora = new Label();
            txtResultado = new TextBox();
            btnDivisao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnResultado = new Button();
            btnSoma = new Button();
            btnVirgula = new Button();
            btnLimpar = new Button();
            lbResultado = new Label();
            btnEditor = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.MenuHighlight;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(24, 150);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 40);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.MenuHighlight;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(171, 150);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 40);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.MenuHighlight;
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(98, 150);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 40);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.MenuHighlight;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(97, 205);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 40);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.MenuHighlight;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(171, 205);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 40);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.MenuHighlight;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(24, 205);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 40);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.MenuHighlight;
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(97, 255);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 40);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.MenuHighlight;
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(24, 255);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 40);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.MenuHighlight;
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(171, 255);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 40);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.MenuHighlight;
            btn0.FlatAppearance.BorderColor = Color.Black;
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(96, 306);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 40);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // lbCalculadora
            // 
            lbCalculadora.AutoSize = true;
            lbCalculadora.BackColor = SystemColors.GrayText;
            lbCalculadora.Font = new Font("Tahoma", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbCalculadora.ForeColor = Color.Gold;
            lbCalculadora.Location = new Point(24, 101);
            lbCalculadora.Name = "lbCalculadora";
            lbCalculadora.Size = new Size(174, 33);
            lbCalculadora.TabIndex = 10;
            lbCalculadora.Text = "Calculadora";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(13, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(313, 77);
            txtResultado.TabIndex = 11;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Gold;
            btnDivisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDivisao.Location = new Point(251, 150);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 40);
            btnDivisao.TabIndex = 12;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Gold;
            btnSubtracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubtracao.Location = new Point(251, 255);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 40);
            btnSubtracao.TabIndex = 13;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.Gold;
            btnMultiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultiplicacao.Location = new Point(251, 205);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(75, 40);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.Red;
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnResultado.Location = new Point(250, 104);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(75, 40);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.Gold;
            btnSoma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSoma.Location = new Point(250, 307);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 40);
            btnSoma.TabIndex = 16;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Gold;
            btnVirgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVirgula.Location = new Point(170, 306);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(75, 40);
            btnVirgula.TabIndex = 17;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gold;
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpar.Location = new Point(23, 306);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 40);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(24, 368);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(42, 33);
            lbResultado.TabIndex = 19;
            lbResultado.Text = "...";
            // 
            // btnEditor
            // 
            btnEditor.Location = new Point(216, 380);
            btnEditor.Name = "btnEditor";
            btnEditor.Size = new Size(75, 23);
            btnEditor.TabIndex = 20;
            btnEditor.Text = "Editor";
            btnEditor.UseVisualStyleBackColor = true;
            btnEditor.Click += button1_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(338, 428);
            Controls.Add(btnEditor);
            Controls.Add(lbResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnVirgula);
            Controls.Add(btnSoma);
            Controls.Add(btnResultado);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnDivisao);
            Controls.Add(txtResultado);
            Controls.Add(lbCalculadora);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Button btn6;
        private Button btn4;
        private Button btn8;
        private Button btn7;
        private Button btn9;
        private Button btn0;
        private Label lbCalculadora;
        private TextBox txtResultado;
        private Button btnDivisao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnResultado;
        private Button btnSoma;
        private Button btnVirgula;
        private Button btnLimpar;
        private Label lbResultado;
        private Button btnEditor;
    }
}
