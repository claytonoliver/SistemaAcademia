namespace Sistema.UI.Dashboard
{
    partial class InicioBaseForm
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
            panel1 = new Panel();
            pnlVisualizacao = new Panel();
            msMenuPricipal = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            trocaSenhaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionarioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            minhaAcademiaToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            pnlVisualizacao.SuspendLayout();
            msMenuPricipal.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlVisualizacao);
            panel1.Controls.Add(msMenuPricipal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // pnlVisualizacao
            // 
            pnlVisualizacao.Controls.Add(button3);
            pnlVisualizacao.Controls.Add(button2);
            pnlVisualizacao.Controls.Add(button1);
            pnlVisualizacao.Controls.Add(label1);
            pnlVisualizacao.Controls.Add(panel2);
            pnlVisualizacao.Location = new Point(3, 27);
            pnlVisualizacao.Name = "pnlVisualizacao";
            pnlVisualizacao.Size = new Size(794, 420);
            pnlVisualizacao.TabIndex = 2;
            // 
            // msMenuPricipal
            // 
            msMenuPricipal.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, toolStripMenuItem1, financeiroToolStripMenuItem, minhaAcademiaToolStripMenuItem });
            msMenuPricipal.Location = new Point(0, 0);
            msMenuPricipal.Name = "msMenuPricipal";
            msMenuPricipal.Size = new Size(800, 24);
            msMenuPricipal.TabIndex = 1;
            msMenuPricipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocaSenhaToolStripMenuItem, cadastrarFuncionarioToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // trocaSenhaToolStripMenuItem
            // 
            trocaSenhaToolStripMenuItem.Name = "trocaSenhaToolStripMenuItem";
            trocaSenhaToolStripMenuItem.Size = new Size(190, 22);
            trocaSenhaToolStripMenuItem.Text = "Troca Senha";
            // 
            // cadastrarFuncionarioToolStripMenuItem
            // 
            cadastrarFuncionarioToolStripMenuItem.Name = "cadastrarFuncionarioToolStripMenuItem";
            cadastrarFuncionarioToolStripMenuItem.Size = new Size(190, 22);
            cadastrarFuncionarioToolStripMenuItem.Text = "Cadastrar Funcionario";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(74, 20);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // minhaAcademiaToolStripMenuItem
            // 
            minhaAcademiaToolStripMenuItem.Name = "minhaAcademiaToolStripMenuItem";
            minhaAcademiaToolStripMenuItem.Size = new Size(109, 20);
            minhaAcademiaToolStripMenuItem.Text = "Minha Academia";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(166, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 323);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(588, 323);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 33);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 1;
            label1.Text = "Alunos Com a Parcela a Vencer";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_add_48;
            button1.Location = new Point(20, 33);
            button1.Name = "button1";
            button1.Size = new Size(104, 107);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_financial_96;
            button2.Location = new Point(20, 160);
            button2.Name = "button2";
            button2.Size = new Size(104, 107);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.icons8_logout_32;
            button3.Location = new Point(20, 287);
            button3.Name = "button3";
            button3.Size = new Size(104, 107);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // InicioBaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "InicioBaseForm";
            ShowIcon = false;
            Text = "Inicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlVisualizacao.ResumeLayout(false);
            pnlVisualizacao.PerformLayout();
            msMenuPricipal.ResumeLayout(false);
            msMenuPricipal.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip msMenuPricipal;
        private Panel pnlVisualizacao;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem trocaSenhaToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionarioToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem minhaAcademiaToolStripMenuItem;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}