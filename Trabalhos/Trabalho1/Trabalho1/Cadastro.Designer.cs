namespace Trabalho1
{
    partial class Cadastro
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
            this.placa_textbox = new System.Windows.Forms.TextBox();
            this.marca_textbox = new System.Windows.Forms.TextBox();
            this.modelo_textbox = new System.Windows.Forms.TextBox();
            this.passageiros_textbox = new System.Windows.Forms.TextBox();
            this.cadastrar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placa_textbox
            // 
            this.placa_textbox.Location = new System.Drawing.Point(12, 12);
            this.placa_textbox.Name = "placa_textbox";
            this.placa_textbox.Size = new System.Drawing.Size(100, 20);
            this.placa_textbox.TabIndex = 0;
            // 
            // marca_textbox
            // 
            this.marca_textbox.Location = new System.Drawing.Point(12, 38);
            this.marca_textbox.Name = "marca_textbox";
            this.marca_textbox.Size = new System.Drawing.Size(100, 20);
            this.marca_textbox.TabIndex = 1;
            // 
            // modelo_textbox
            // 
            this.modelo_textbox.Location = new System.Drawing.Point(12, 64);
            this.modelo_textbox.Name = "modelo_textbox";
            this.modelo_textbox.Size = new System.Drawing.Size(100, 20);
            this.modelo_textbox.TabIndex = 2;
            // 
            // passageiros_textbox
            // 
            this.passageiros_textbox.Location = new System.Drawing.Point(12, 90);
            this.passageiros_textbox.Name = "passageiros_textbox";
            this.passageiros_textbox.Size = new System.Drawing.Size(100, 20);
            this.passageiros_textbox.TabIndex = 3;
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(12, 116);
            this.cadastrar_button.Name = "cadastrar_button";
            this.cadastrar_button.Size = new System.Drawing.Size(100, 23);
            this.cadastrar_button.TabIndex = 4;
            this.cadastrar_button.Text = "CADASTRA";
            this.cadastrar_button.UseVisualStyleBackColor = true;
            this.cadastrar_button.Click += new System.EventHandler(this.cadastrar_button_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 157);
            this.Controls.Add(this.cadastrar_button);
            this.Controls.Add(this.passageiros_textbox);
            this.Controls.Add(this.modelo_textbox);
            this.Controls.Add(this.marca_textbox);
            this.Controls.Add(this.placa_textbox);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox placa_textbox;
        private System.Windows.Forms.TextBox marca_textbox;
        private System.Windows.Forms.TextBox modelo_textbox;
        private System.Windows.Forms.TextBox passageiros_textbox;
        private System.Windows.Forms.Button cadastrar_button;
    }
}