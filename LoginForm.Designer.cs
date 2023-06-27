namespace ProjetoFinal
{
    partial class LoginForm
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
            logarButton = new Button();
            sairButton = new Button();
            loginLabel = new Label();
            senhaLabel = new Label();
            senhaTextBox = new TextBox();
            loginTextBox = new TextBox();
            mostrarCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // logarButton
            // 
            logarButton.Location = new Point(98, 124);
            logarButton.Margin = new Padding(3, 2, 3, 2);
            logarButton.Name = "logarButton";
            logarButton.Size = new Size(82, 22);
            logarButton.TabIndex = 0;
            logarButton.Text = "OK";
            logarButton.UseVisualStyleBackColor = true;
            logarButton.Click += logarButton_Click;
            // 
            // sairButton
            // 
            sairButton.Location = new Point(10, 124);
            sairButton.Margin = new Padding(3, 2, 3, 2);
            sairButton.Name = "sairButton";
            sairButton.Size = new Size(82, 22);
            sairButton.TabIndex = 1;
            sairButton.Text = "Sair";
            sairButton.UseVisualStyleBackColor = true;
            sairButton.Click += sairButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(10, 9);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(40, 15);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new Point(10, 58);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(42, 15);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(10, 75);
            senhaTextBox.Margin = new Padding(3, 2, 3, 2);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(170, 23);
            senhaTextBox.TabIndex = 4;
            senhaTextBox.Leave += senhaTextBox_Leave;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(10, 26);
            loginTextBox.Margin = new Padding(3, 2, 3, 2);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(170, 23);
            loginTextBox.TabIndex = 5;
            loginTextBox.Leave += loginTextBox_Leave;
            // 
            // mostrarCheckBox
            // 
            mostrarCheckBox.AutoSize = true;
            mostrarCheckBox.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            mostrarCheckBox.Location = new Point(93, 103);
            mostrarCheckBox.Name = "mostrarCheckBox";
            mostrarCheckBox.Size = new Size(87, 16);
            mostrarCheckBox.TabIndex = 6;
            mostrarCheckBox.Text = "Mostrar Senha";
            mostrarCheckBox.UseVisualStyleBackColor = true;
            mostrarCheckBox.CheckedChanged += mostrarCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 157);
            Controls.Add(mostrarCheckBox);
            Controls.Add(loginTextBox);
            Controls.Add(senhaTextBox);
            Controls.Add(senhaLabel);
            Controls.Add(loginLabel);
            Controls.Add(sairButton);
            Controls.Add(logarButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nome generico";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logarButton;
        private Button sairButton;
        private Label loginLabel;
        private Label senhaLabel;
        private TextBox senhaTextBox;
        private TextBox loginTextBox;
        private CheckBox mostrarCheckBox;
    }
}