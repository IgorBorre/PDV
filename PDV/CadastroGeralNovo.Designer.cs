namespace PDV
{
    partial class CadastroGeralNovo
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
            TfCodigo = new TextBox();
            label2 = new Label();
            TfNome = new TextBox();
            label3 = new Label();
            TfIdentificacao = new TextBox();
            label4 = new Label();
            TfTelefone = new MaskedTextBox();
            label5 = new Label();
            CBEstado = new ComboBox();
            label6 = new Label();
            TfCidade = new TextBox();
            label7 = new Label();
            TfNascimento = new MaskedTextBox();
            label8 = new Label();
            CBSituacao = new ComboBox();
            groupBox1 = new GroupBox();
            TfReferencia = new TextBox();
            label15 = new Label();
            TfCep = new TextBox();
            label14 = new Label();
            TfBairro = new TextBox();
            label13 = new Label();
            TfComplemento = new TextBox();
            label12 = new Label();
            TfNumero = new TextBox();
            label10 = new Label();
            TfRua = new TextBox();
            CBLogradouro = new ComboBox();
            label9 = new Label();
            BtOK = new Button();
            BtCancelar = new Button();
            label11 = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // TfCodigo
            // 
            TfCodigo.Enabled = false;
            TfCodigo.Location = new Point(80, 12);
            TfCodigo.Name = "TfCodigo";
            TfCodigo.Size = new Size(100, 23);
            TfCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // TfNome
            // 
            TfNome.Location = new Point(80, 50);
            TfNome.Name = "TfNome";
            TfNome.Size = new Size(321, 23);
            TfNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF/CNPJ";
            // 
            // TfIdentificacao
            // 
            TfIdentificacao.Location = new Point(80, 89);
            TfIdentificacao.Name = "TfIdentificacao";
            TfIdentificacao.Size = new Size(227, 23);
            TfIdentificacao.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 15);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefone";
            // 
            // TfTelefone
            // 
            TfTelefone.Location = new Point(528, 12);
            TfTelefone.Mask = "(00)00000-0000";
            TfTelefone.Name = "TfTelefone";
            TfTelefone.Size = new Size(136, 23);
            TfTelefone.TabIndex = 7;
            TfTelefone.MaskInputRejected += TfTelefone_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 170);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // CBEstado
            // 
            CBEstado.AutoCompleteMode = AutoCompleteMode.Suggest;
            CBEstado.AutoCompleteSource = AutoCompleteSource.ListItems;
            CBEstado.FormattingEnabled = true;
            CBEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT ", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            CBEstado.Location = new Point(79, 167);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(50, 23);
            CBEstado.TabIndex = 9;
            CBEstado.Text = "AC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 132);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Cidade";
            // 
            // TfCidade
            // 
            TfCidade.Location = new Point(345, 129);
            TfCidade.Name = "TfCidade";
            TfCidade.Size = new Size(223, 23);
            TfCidade.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(451, 53);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Nascimento";
            // 
            // TfNascimento
            // 
            TfNascimento.Location = new Point(528, 50);
            TfNascimento.Mask = "00/00/0000";
            TfNascimento.Name = "TfNascimento";
            TfNascimento.Size = new Size(66, 23);
            TfNascimento.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(451, 92);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 14;
            label8.Text = "Situação";
            // 
            // CBSituacao
            // 
            CBSituacao.FormattingEnabled = true;
            CBSituacao.Items.AddRange(new object[] { "NORMAL", "BLOQUEADO" });
            CBSituacao.Location = new Point(528, 89);
            CBSituacao.Name = "CBSituacao";
            CBSituacao.Size = new Size(121, 23);
            CBSituacao.TabIndex = 15;
            CBSituacao.Text = "NORMAL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TfReferencia);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(TfCep);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(TfBairro);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(TfComplemento);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(TfNumero);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TfRua);
            groupBox1.Controls.Add(CBLogradouro);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(CBEstado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TfCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(11, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 265);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // TfReferencia
            // 
            TfReferencia.Location = new Point(345, 167);
            TfReferencia.Name = "TfReferencia";
            TfReferencia.Size = new Size(223, 23);
            TfReferencia.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(275, 170);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 24;
            label15.Text = "Referência";
            // 
            // TfCep
            // 
            TfCep.Location = new Point(169, 167);
            TfCep.Name = "TfCep";
            TfCep.Size = new Size(100, 23);
            TfCep.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(135, 170);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 22;
            label14.Text = "CEP";
            // 
            // TfBairro
            // 
            TfBairro.Location = new Point(79, 129);
            TfBairro.Name = "TfBairro";
            TfBairro.Size = new Size(183, 23);
            TfBairro.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 132);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 20;
            label13.Text = "Bairro";
            // 
            // TfComplemento
            // 
            TfComplemento.Location = new Point(294, 90);
            TfComplemento.Name = "TfComplemento";
            TfComplemento.Size = new Size(274, 23);
            TfComplemento.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(206, 93);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 18;
            label12.Text = "Complemento";
            // 
            // TfNumero
            // 
            TfNumero.Location = new Point(79, 90);
            TfNumero.Name = "TfNumero";
            TfNumero.Size = new Size(121, 23);
            TfNumero.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 93);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 15;
            label10.Text = "Número";
            // 
            // TfRua
            // 
            TfRua.Location = new Point(206, 59);
            TfRua.Name = "TfRua";
            TfRua.Size = new Size(362, 23);
            TfRua.TabIndex = 14;
            // 
            // CBLogradouro
            // 
            CBLogradouro.FormattingEnabled = true;
            CBLogradouro.Items.AddRange(new object[] { "Alameda  ", "Avenida  ", "Campo  ", "Chácara  ", "Colônia  ", "Condomínio  ", "Conjunto  ", "Distrito  ", "Esplanada  ", "Estação  ", "Estrada  ", "Favela  ", "Fazenda  ", "Feira  ", "Jardim  ", "Ladeira  ", "Lago  ", "Lagoa  ", "Largo  ", "Loteamento  ", "Morro  ", "Parque  ", "Passarela  ", "Pátio  ", "Praça  ", "Quadra  ", "Recanto  ", "Residencial  ", "Rodovia  ", "Rua  ", "Setor  ", "Sítio  ", "Travessa  ", "Trecho  ", "Trevo  ", "Vale  ", "Vereda  ", "Via  ", "Viela  ", "Vila  " });
            CBLogradouro.Location = new Point(79, 59);
            CBLogradouro.Name = "CBLogradouro";
            CBLogradouro.Size = new Size(121, 23);
            CBLogradouro.TabIndex = 13;
            CBLogradouro.Text = "Rua";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 62);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 12;
            label9.Text = "Logradouro";
            // 
            // BtOK
            // 
            BtOK.Image = Properties.Resources.verifica__2___1_;
            BtOK.ImageAlign = ContentAlignment.MiddleLeft;
            BtOK.Location = new Point(21, 472);
            BtOK.Name = "BtOK";
            BtOK.Size = new Size(75, 23);
            BtOK.TabIndex = 17;
            BtOK.Text = "OK";
            BtOK.UseVisualStyleBackColor = true;
            BtOK.Click += BtOK_Click;
            // 
            // BtCancelar
            // 
            BtCancelar.Image = Properties.Resources.cancelar__1_;
            BtCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtCancelar.Location = new Point(136, 472);
            BtCancelar.Name = "BtCancelar";
            BtCancelar.Size = new Size(75, 23);
            BtCancelar.TabIndex = 18;
            BtCancelar.Text = "    Cancelar";
            BtCancelar.UseVisualStyleBackColor = true;
            BtCancelar.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(45, 50);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 19;
            label11.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Red;
            label16.Location = new Point(62, 89);
            label16.Name = "label16";
            label16.Size = new Size(12, 15);
            label16.TabIndex = 20;
            label16.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(336, 472);
            label17.Name = "label17";
            label17.Size = new Size(128, 15);
            label17.TabIndex = 21;
            label17.Text = "* Campos Obrigatórios";
            // 
            // CadastroGeralNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 507);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(BtCancelar);
            Controls.Add(BtOK);
            Controls.Add(groupBox1);
            Controls.Add(CBSituacao);
            Controls.Add(label8);
            Controls.Add(TfNascimento);
            Controls.Add(label7);
            Controls.Add(TfTelefone);
            Controls.Add(label4);
            Controls.Add(TfIdentificacao);
            Controls.Add(label3);
            Controls.Add(TfNome);
            Controls.Add(label2);
            Controls.Add(TfCodigo);
            Controls.Add(label1);
            Name = "CadastroGeralNovo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroGeralNovo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TfCodigo;
        private Label label2;
        private TextBox TfNome;
        private Label label3;
        private TextBox TfIdentificacao;
        private Label label4;
        private MaskedTextBox TfTelefone;
        private Label label5;
        private ComboBox CBEstado;
        private Label label6;
        private TextBox TfCidade;
        private Label label7;
        private MaskedTextBox TfNascimento;
        private Label label8;
        private ComboBox CBSituacao;
        private GroupBox groupBox1;
        private ComboBox CBLogradouro;
        private Label label9;
        private TextBox TfRua;
        private TextBox TfNumero;
        private Label label10;
        private TextBox TfBairro;
        private Label label13;
        private TextBox TfComplemento;
        private Label label12;
        private Label label15;
        private TextBox TfCep;
        private Label label14;
        private TextBox TfReferencia;
        private Button BtOK;
        private Button BtCancelar;
        private Label label11;
        private Label label16;
        private Label label17;
    }
}