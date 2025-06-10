namespace WinFormsAppAula1
{
    partial class frmMenu
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
            btn = new Button();
            btn1 = new Button();
            btn2 = new Button();
            txtResultado = new TextBox();
            txtTexto = new TextBox();
            lbResultado = new Label();
            lbTexto = new Label();
            cbTimes = new ComboBox();
            rbMasculino = new RadioButton();
            rbFeminino = new RadioButton();
            txtSenha = new TextBox();
            lbSenha = new Label();
            chAtivo = new CheckBox();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(655, 373);
            btn.Name = "btn";
            btn.Size = new Size(70, 34);
            btn.TabIndex = 0;
            btn.Text = "Menssage";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(132, 293);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // btn2
            // 
            btn2.Location = new Point(231, 293);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(132, 94);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(174, 23);
            txtResultado.TabIndex = 3;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(132, 159);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(174, 128);
            txtTexto.TabIndex = 4;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(132, 76);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado";
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Location = new Point(132, 141);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(35, 15);
            lbTexto.TabIndex = 6;
            lbTexto.Text = "Texto";
            // 
            // cbTimes
            // 
            cbTimes.FormattingEnabled = true;
            cbTimes.Items.AddRange(new object[] { "São Paulo", "Palmeiras", "Corinthians", "Santos", "Flamengo" });
            cbTimes.Location = new Point(551, 94);
            cbTimes.Name = "cbTimes";
            cbTimes.Size = new Size(121, 23);
            cbTimes.TabIndex = 7;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(312, 211);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 8;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(312, 236);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 9;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(327, 94);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(177, 23);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(327, 76);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 11;
            lbSenha.Text = "Senha";
            // 
            // chAtivo
            // 
            chAtivo.AutoSize = true;
            chAtivo.Location = new Point(618, 211);
            chAtivo.Name = "chAtivo";
            chAtivo.Size = new Size(54, 19);
            chAtivo.TabIndex = 12;
            chAtivo.Text = "Ativo";
            chAtivo.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(chAtivo);
            Controls.Add(lbSenha);
            Controls.Add(txtSenha);
            Controls.Add(rbFeminino);
            Controls.Add(rbMasculino);
            Controls.Add(cbTimes);
            Controls.Add(lbTexto);
            Controls.Add(lbResultado);
            Controls.Add(txtTexto);
            Controls.Add(txtResultado);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Button btn1;
        private Button btn2;
        private TextBox txtResultado;
        private TextBox txtTexto;
        private Label lbResultado;
        private Label lbTexto;
        private ComboBox cbTimes;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private TextBox txtSenha;
        private Label lbSenha;
        private CheckBox chAtivo;
    }
}
