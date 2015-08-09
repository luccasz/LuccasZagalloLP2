namespace Trabalho1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrar_button = new System.Windows.Forms.Button();
            this.mostrar_listbox = new System.Windows.Forms.ListBox();
            this.pesquisarId_button = new System.Windows.Forms.Button();
            this.pesquisarId_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(12, 323);
            this.cadastrar_button.Name = "cadastrar_button";
            this.cadastrar_button.Size = new System.Drawing.Size(158, 34);
            this.cadastrar_button.TabIndex = 0;
            this.cadastrar_button.Text = "ADICIONAR CARROS";
            this.cadastrar_button.UseVisualStyleBackColor = true;
            this.cadastrar_button.Click += new System.EventHandler(this.cadastrar_button_Click);
            // 
            // mostrar_listbox
            // 
            this.mostrar_listbox.FormattingEnabled = true;
            this.mostrar_listbox.Location = new System.Drawing.Point(12, 12);
            this.mostrar_listbox.Name = "mostrar_listbox";
            this.mostrar_listbox.Size = new System.Drawing.Size(424, 303);
            this.mostrar_listbox.TabIndex = 1;
            // 
            // pesquisarId_button
            // 
            this.pesquisarId_button.Location = new System.Drawing.Point(325, 352);
            this.pesquisarId_button.Name = "pesquisarId_button";
            this.pesquisarId_button.Size = new System.Drawing.Size(111, 24);
            this.pesquisarId_button.TabIndex = 2;
            this.pesquisarId_button.Text = "Pesquisar ID";
            this.pesquisarId_button.UseVisualStyleBackColor = true;
            this.pesquisarId_button.Click += new System.EventHandler(this.pesquisarId_button_Click);
            // 
            // pesquisarId_textbox
            // 
            this.pesquisarId_textbox.Location = new System.Drawing.Point(325, 323);
            this.pesquisarId_textbox.Multiline = true;
            this.pesquisarId_textbox.Name = "pesquisarId_textbox";
            this.pesquisarId_textbox.Size = new System.Drawing.Size(111, 23);
            this.pesquisarId_textbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 388);
            this.Controls.Add(this.pesquisarId_textbox);
            this.Controls.Add(this.pesquisarId_button);
            this.Controls.Add(this.mostrar_listbox);
            this.Controls.Add(this.cadastrar_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar_button;
        private System.Windows.Forms.ListBox mostrar_listbox;
        private System.Windows.Forms.Button pesquisarId_button;
        private System.Windows.Forms.TextBox pesquisarId_textbox;
    }
}

