namespace ProjetoFinal
{
    partial class MainForm
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
            mainMenuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, cadastroToolStripMenuItem, vendaToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(800, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoasToolStripMenuItem, produtosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // pessoasToolStripMenuItem
            // 
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(180, 22);
            pessoasToolStripMenuItem.Text = "Pessoas";
            pessoasToolStripMenuItem.Click += pessoasToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDVToolStripMenuItem, relatórioDeVendasToolStripMenuItem });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(51, 20);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(180, 22);
            pDVToolStripMenuItem.Text = "PDV";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(180, 22);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Nome Generico";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
    }
}