namespace ProjetoFinal
{
    partial class PessoasForm
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
            nomeTextBox = new TextBox();
            nomeLbael = new Label();
            idLabel = new Label();
            codTextBox = new TextBox();
            cpfLabel = new Label();
            cpfTextBox = new MaskedTextBox();
            rgLabel = new Label();
            rgTextBox = new TextBox();
            generoComboBox = new ComboBox();
            generoLabel = new Label();
            nascimentoDateTimePicker = new DateTimePicker();
            aniversarioLabel = new Label();
            civilComboBox = new ComboBox();
            civilLabel = new Label();
            obsRichTextBox = new RichTextBox();
            dataGridView1 = new DataGridView();
            profissaoTextBox = new TextBox();
            profissaoLabel = new Label();
            nacionalidadelabel = new Label();
            nacionalidadeTextBox = new TextBox();
            telefoneLabel = new Label();
            telefoneMaskedTextBox = new MaskedTextBox();
            celularMaskedTextBox = new MaskedTextBox();
            celularLabel = new Label();
            zapCheckBox = new CheckBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            enderecoLabel = new Label();
            EnderecoTextBox = new TextBox();
            numeroLabel = new Label();
            numeroTextBox = new TextBox();
            ufComboBox = new ComboBox();
            ufLabel = new Label();
            cepLabel = new Label();
            cepMaskedTextBox = new MaskedTextBox();
            buscarTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            excluirButton = new Button();
            salvarButton = new Button();
            editarButton = new Button();
            adicionarbutton = new Button();
            cadastroLabel = new Label();
            inativoCheckBox = new CheckBox();
            buscaBuutton = new Button();
            complementoLabel = new Label();
            complementoTextBox = new TextBox();
            bairroLabel = new Label();
            bairroTextBox = new TextBox();
            cidadeLabel = new Label();
            cidadeTextBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(48, 92);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(193, 23);
            nomeTextBox.TabIndex = 0;
            // 
            // nomeLbael
            // 
            nomeLbael.AutoSize = true;
            nomeLbael.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLbael.Location = new Point(48, 76);
            nomeLbael.Name = "nomeLbael";
            nomeLbael.Size = new Size(40, 13);
            nomeLbael.TabIndex = 1;
            nomeLbael.Text = "Nome:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(10, 76);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(31, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Cód:";
            // 
            // codTextBox
            // 
            codTextBox.Location = new Point(10, 92);
            codTextBox.Name = "codTextBox";
            codTextBox.Size = new Size(32, 23);
            codTextBox.TabIndex = 2;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cpfLabel.Location = new Point(247, 76);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(29, 13);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "CPF:";
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(247, 92);
            cpfTextBox.Mask = "000,000,000-00";
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(89, 23);
            cpfTextBox.TabIndex = 6;
            cpfTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rgLabel.Location = new Point(342, 76);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new Size(25, 13);
            rgLabel.TabIndex = 7;
            rgLabel.Text = "RG:";
            // 
            // rgTextBox
            // 
            rgTextBox.Location = new Point(342, 92);
            rgTextBox.Name = "rgTextBox";
            rgTextBox.Size = new Size(69, 23);
            rgTextBox.TabIndex = 8;
            // 
            // generoComboBox
            // 
            generoComboBox.FormattingEnabled = true;
            generoComboBox.Items.AddRange(new object[] { "Masculino", "Feminino", "Nao-Binario" });
            generoComboBox.Location = new Point(417, 92);
            generoComboBox.Name = "generoComboBox";
            generoComboBox.Size = new Size(130, 23);
            generoComboBox.TabIndex = 9;
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            generoLabel.Location = new Point(417, 76);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new Size(48, 13);
            generoLabel.TabIndex = 10;
            generoLabel.Text = "Gênero:";
            // 
            // nascimentoDateTimePicker
            // 
            nascimentoDateTimePicker.Format = DateTimePickerFormat.Short;
            nascimentoDateTimePicker.Location = new Point(8, 136);
            nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            nascimentoDateTimePicker.Size = new Size(117, 23);
            nascimentoDateTimePicker.TabIndex = 11;
            // 
            // aniversarioLabel
            // 
            aniversarioLabel.AutoSize = true;
            aniversarioLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            aniversarioLabel.Location = new Point(8, 120);
            aniversarioLabel.Name = "aniversarioLabel";
            aniversarioLabel.Size = new Size(67, 13);
            aniversarioLabel.TabIndex = 12;
            aniversarioLabel.Text = "Aniversário:";
            // 
            // civilComboBox
            // 
            civilComboBox.FormattingEnabled = true;
            civilComboBox.Items.AddRange(new object[] { "Casado", "Solteiro", "Viúvo", "União Estável" });
            civilComboBox.Location = new Point(131, 136);
            civilComboBox.Name = "civilComboBox";
            civilComboBox.Size = new Size(121, 23);
            civilComboBox.TabIndex = 13;
            // 
            // civilLabel
            // 
            civilLabel.AutoSize = true;
            civilLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            civilLabel.Location = new Point(131, 120);
            civilLabel.Name = "civilLabel";
            civilLabel.Size = new Size(31, 13);
            civilLabel.TabIndex = 14;
            civilLabel.Text = "Civil:";
            // 
            // obsRichTextBox
            // 
            obsRichTextBox.Location = new Point(8, 313);
            obsRichTextBox.Name = "obsRichTextBox";
            obsRichTextBox.Size = new Size(539, 124);
            obsRichTextBox.TabIndex = 17;
            obsRichTextBox.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(553, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 317);
            dataGridView1.TabIndex = 18;
            // 
            // profissaoTextBox
            // 
            profissaoTextBox.Location = new Point(8, 184);
            profissaoTextBox.Name = "profissaoTextBox";
            profissaoTextBox.Size = new Size(193, 23);
            profissaoTextBox.TabIndex = 15;
            // 
            // profissaoLabel
            // 
            profissaoLabel.AutoSize = true;
            profissaoLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            profissaoLabel.Location = new Point(8, 168);
            profissaoLabel.Name = "profissaoLabel";
            profissaoLabel.Size = new Size(57, 13);
            profissaoLabel.TabIndex = 16;
            profissaoLabel.Text = "Profissão:";
            // 
            // nacionalidadelabel
            // 
            nacionalidadelabel.AutoSize = true;
            nacionalidadelabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            nacionalidadelabel.Location = new Point(207, 168);
            nacionalidadelabel.Name = "nacionalidadelabel";
            nacionalidadelabel.Size = new Size(39, 13);
            nacionalidadelabel.TabIndex = 20;
            nacionalidadelabel.Text = "Nacio:";
            // 
            // nacionalidadeTextBox
            // 
            nacionalidadeTextBox.Location = new Point(207, 184);
            nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            nacionalidadeTextBox.Size = new Size(117, 23);
            nacionalidadeTextBox.TabIndex = 19;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            telefoneLabel.Location = new Point(330, 168);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(54, 13);
            telefoneLabel.TabIndex = 22;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            telefoneMaskedTextBox.Location = new Point(330, 184);
            telefoneMaskedTextBox.Mask = "(999) 000-0000";
            telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            telefoneMaskedTextBox.Size = new Size(79, 23);
            telefoneMaskedTextBox.TabIndex = 23;
            telefoneMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // celularMaskedTextBox
            // 
            celularMaskedTextBox.Location = new Point(415, 184);
            celularMaskedTextBox.Mask = "(999) 000-0000";
            celularMaskedTextBox.Name = "celularMaskedTextBox";
            celularMaskedTextBox.Size = new Size(79, 23);
            celularMaskedTextBox.TabIndex = 24;
            celularMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            celularLabel.Location = new Point(415, 168);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new Size(46, 13);
            celularLabel.TabIndex = 25;
            celularLabel.Text = "Celular:";
            // 
            // zapCheckBox
            // 
            zapCheckBox.AutoSize = true;
            zapCheckBox.Location = new Point(498, 186);
            zapCheckBox.Name = "zapCheckBox";
            zapCheckBox.Size = new Size(49, 19);
            zapCheckBox.TabIndex = 26;
            zapCheckBox.Text = "zap?";
            zapCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(257, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 13);
            emailLabel.TabIndex = 28;
            emailLabel.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(256, 136);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(205, 23);
            emailTextBox.TabIndex = 27;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            enderecoLabel.Location = new Point(10, 213);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new Size(55, 13);
            enderecoLabel.TabIndex = 30;
            enderecoLabel.Text = "Endereço";
            // 
            // EnderecoTextBox
            // 
            EnderecoTextBox.Location = new Point(10, 229);
            EnderecoTextBox.Name = "EnderecoTextBox";
            EnderecoTextBox.Size = new Size(231, 23);
            EnderecoTextBox.TabIndex = 29;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numeroLabel.Location = new Point(247, 213);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new Size(51, 13);
            numeroLabel.TabIndex = 32;
            numeroLabel.Text = "Número:";
            // 
            // numeroTextBox
            // 
            numeroTextBox.Location = new Point(247, 229);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(57, 23);
            numeroTextBox.TabIndex = 31;
            // 
            // ufComboBox
            // 
            ufComboBox.FormattingEnabled = true;
            ufComboBox.Location = new Point(413, 229);
            ufComboBox.Name = "ufComboBox";
            ufComboBox.Size = new Size(66, 23);
            ufComboBox.TabIndex = 33;
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ufLabel.Location = new Point(417, 210);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new Size(24, 13);
            ufLabel.TabIndex = 34;
            ufLabel.Text = "UF:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cepLabel.Location = new Point(485, 213);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new Size(29, 13);
            cepLabel.TabIndex = 36;
            cepLabel.Text = "CEP:";
            // 
            // cepMaskedTextBox
            // 
            cepMaskedTextBox.Location = new Point(485, 229);
            cepMaskedTextBox.Mask = "00000-000";
            cepMaskedTextBox.Name = "cepMaskedTextBox";
            cepMaskedTextBox.Size = new Size(62, 23);
            cepMaskedTextBox.TabIndex = 37;
            // 
            // buscarTextBox
            // 
            buscarTextBox.Location = new Point(553, 92);
            buscarTextBox.Name = "buscarTextBox";
            buscarTextBox.Size = new Size(440, 23);
            buscarTextBox.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(553, 76);
            label1.Name = "label1";
            label1.Size = new Size(59, 13);
            label1.TabIndex = 39;
            label1.Text = "Pesquisar:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(excluirButton);
            panel1.Controls.Add(salvarButton);
            panel1.Controls.Add(editarButton);
            panel1.Controls.Add(adicionarbutton);
            panel1.Controls.Add(cadastroLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 68);
            panel1.TabIndex = 40;
            // 
            // excluirButton
            // 
            excluirButton.Location = new Point(958, 27);
            excluirButton.Name = "excluirButton";
            excluirButton.Size = new Size(75, 23);
            excluirButton.TabIndex = 4;
            excluirButton.Text = "Excluir";
            excluirButton.UseVisualStyleBackColor = true;
            excluirButton.Click += excluirButton_Click;
            // 
            // salvarButton
            // 
            salvarButton.Location = new Point(877, 27);
            salvarButton.Name = "salvarButton";
            salvarButton.Size = new Size(75, 23);
            salvarButton.TabIndex = 3;
            salvarButton.Text = "Salvar";
            salvarButton.UseVisualStyleBackColor = true;
            // 
            // editarButton
            // 
            editarButton.Location = new Point(796, 27);
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(75, 23);
            editarButton.TabIndex = 2;
            editarButton.Text = "Editar";
            editarButton.UseVisualStyleBackColor = true;
            // 
            // adicionarbutton
            // 
            adicionarbutton.Location = new Point(715, 27);
            adicionarbutton.Name = "adicionarbutton";
            adicionarbutton.Size = new Size(75, 23);
            adicionarbutton.TabIndex = 1;
            adicionarbutton.Text = "Cadastrar";
            adicionarbutton.UseVisualStyleBackColor = true;
            adicionarbutton.Click += adicionarbutton_Click;
            // 
            // cadastroLabel
            // 
            cadastroLabel.AutoSize = true;
            cadastroLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroLabel.ForeColor = SystemColors.ControlLightLight;
            cadastroLabel.Location = new Point(11, 13);
            cadastroLabel.Name = "cadastroLabel";
            cadastroLabel.Size = new Size(280, 37);
            cadastroLabel.TabIndex = 0;
            cadastroLabel.Text = "Cadastro de Clientes";
            // 
            // inativoCheckBox
            // 
            inativoCheckBox.AutoSize = true;
            inativoCheckBox.Location = new Point(467, 141);
            inativoCheckBox.Name = "inativoCheckBox";
            inativoCheckBox.Size = new Size(62, 19);
            inativoCheckBox.TabIndex = 41;
            inativoCheckBox.Text = "Inativo";
            inativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // buscaBuutton
            // 
            buscaBuutton.Location = new Point(999, 92);
            buscaBuutton.Name = "buscaBuutton";
            buscaBuutton.Size = new Size(34, 23);
            buscaBuutton.TabIndex = 42;
            buscaBuutton.UseVisualStyleBackColor = true;
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            complementoLabel.Location = new Point(310, 213);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new Size(40, 13);
            complementoLabel.TabIndex = 44;
            complementoLabel.Text = "Comp:";
            // 
            // complementoTextBox
            // 
            complementoTextBox.Location = new Point(310, 229);
            complementoTextBox.Name = "complementoTextBox";
            complementoTextBox.Size = new Size(97, 23);
            complementoTextBox.TabIndex = 43;
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            bairroLabel.Location = new Point(12, 255);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new Size(40, 13);
            bairroLabel.TabIndex = 46;
            bairroLabel.Text = "Bairro:";
            // 
            // bairroTextBox
            // 
            bairroTextBox.Location = new Point(12, 271);
            bairroTextBox.Name = "bairroTextBox";
            bairroTextBox.Size = new Size(153, 23);
            bairroTextBox.TabIndex = 45;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cidadeLabel.Location = new Point(171, 255);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new Size(46, 13);
            cidadeLabel.TabIndex = 48;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            cidadeTextBox.Location = new Point(171, 271);
            cidadeTextBox.Name = "cidadeTextBox";
            cidadeTextBox.Size = new Size(213, 23);
            cidadeTextBox.TabIndex = 47;
            // 
            // button1
            // 
            button1.Location = new Point(390, 270);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 49;
            button1.Text = "autoButton";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PessoasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 449);
            Controls.Add(button1);
            Controls.Add(cidadeLabel);
            Controls.Add(cidadeTextBox);
            Controls.Add(bairroLabel);
            Controls.Add(bairroTextBox);
            Controls.Add(complementoLabel);
            Controls.Add(complementoTextBox);
            Controls.Add(buscaBuutton);
            Controls.Add(inativoCheckBox);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(buscarTextBox);
            Controls.Add(cepMaskedTextBox);
            Controls.Add(cepLabel);
            Controls.Add(ufLabel);
            Controls.Add(ufComboBox);
            Controls.Add(numeroLabel);
            Controls.Add(numeroTextBox);
            Controls.Add(enderecoLabel);
            Controls.Add(EnderecoTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(zapCheckBox);
            Controls.Add(celularLabel);
            Controls.Add(celularMaskedTextBox);
            Controls.Add(telefoneMaskedTextBox);
            Controls.Add(telefoneLabel);
            Controls.Add(nacionalidadelabel);
            Controls.Add(nacionalidadeTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(obsRichTextBox);
            Controls.Add(profissaoLabel);
            Controls.Add(profissaoTextBox);
            Controls.Add(civilLabel);
            Controls.Add(civilComboBox);
            Controls.Add(aniversarioLabel);
            Controls.Add(nascimentoDateTimePicker);
            Controls.Add(generoLabel);
            Controls.Add(generoComboBox);
            Controls.Add(rgTextBox);
            Controls.Add(rgLabel);
            Controls.Add(cpfTextBox);
            Controls.Add(cpfLabel);
            Controls.Add(idLabel);
            Controls.Add(codTextBox);
            Controls.Add(nomeLbael);
            Controls.Add(nomeTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PessoasForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PessoasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomeTextBox;
        private Label nomeLbael;
        private Label idLabel;
        private TextBox codTextBox;
        private Label cpfLabel;
        private MaskedTextBox cpfTextBox;
        private Label rgLabel;
        private TextBox rgTextBox;
        private ComboBox generoComboBox;
        private Label generoLabel;
        private DateTimePicker nascimentoDateTimePicker;
        private Label aniversarioLabel;
        private ComboBox civilComboBox;
        private Label civilLabel;
        private RichTextBox obsRichTextBox;
        private DataGridView dataGridView1;
        private TextBox profissaoTextBox;
        private Label profissaoLabel;
        private Label nacionalidadelabel;
        private TextBox nacionalidadeTextBox;
        private Label telefoneLabel;
        private MaskedTextBox telefoneMaskedTextBox;
        private MaskedTextBox celularMaskedTextBox;
        private Label celularLabel;
        private CheckBox zapCheckBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label enderecoLabel;
        private TextBox EnderecoTextBox;
        private Label numeroLabel;
        private TextBox numeroTextBox;
        private ComboBox ufComboBox;
        private Label ufLabel;
        private Label cepLabel;
        private MaskedTextBox cepMaskedTextBox;
        private TextBox buscarTextBox;
        private Label label1;
        private Panel panel1;
        private Button excluirButton;
        private Button salvarButton;
        private Button editarButton;
        private Button adicionarbutton;
        private Label cadastroLabel;
        private CheckBox inativoCheckBox;
        private Button buscaBuutton;
        private Label complementoLabel;
        private TextBox complementoTextBox;
        private Label bairroLabel;
        private TextBox bairroTextBox;
        private Label cidadeLabel;
        private TextBox cidadeTextBox;
        private Button button1;
    }
}