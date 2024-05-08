namespace Aula20240805
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbApresentacao = new System.Windows.Forms.TextBox();
            this.txtApresentacao = new System.Windows.Forms.Label();
            this.bttConcatenar = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.cbxNomesAdicionados = new System.Windows.Forms.ComboBox();
            this.lblSelecionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(210, 87);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(210, 169);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(128, 25);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(215, 118);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(306, 29);
            this.txbNome.TabIndex = 2;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(215, 200);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(306, 29);
            this.txbSobrenome.TabIndex = 3;
            // 
            // txbApresentacao
            // 
            this.txbApresentacao.Location = new System.Drawing.Point(215, 391);
            this.txbApresentacao.Name = "txbApresentacao";
            this.txbApresentacao.Size = new System.Drawing.Size(306, 29);
            this.txbApresentacao.TabIndex = 5;
            // 
            // txtApresentacao
            // 
            this.txtApresentacao.AutoSize = true;
            this.txtApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApresentacao.Location = new System.Drawing.Point(211, 368);
            this.txtApresentacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtApresentacao.Name = "txtApresentacao";
            this.txtApresentacao.Size = new System.Drawing.Size(168, 20);
            this.txtApresentacao.TabIndex = 4;
            this.txtApresentacao.Text = "Seu nome completo é:";
            // 
            // bttConcatenar
            // 
            this.bttConcatenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConcatenar.Location = new System.Drawing.Point(259, 257);
            this.bttConcatenar.Name = "bttConcatenar";
            this.bttConcatenar.Size = new System.Drawing.Size(101, 41);
            this.bttConcatenar.TabIndex = 6;
            this.bttConcatenar.Text = "concatenar";
            this.bttConcatenar.UseVisualStyleBackColor = true;
            this.bttConcatenar.Click += new System.EventHandler(this.bttConcatenar_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpar.Location = new System.Drawing.Point(366, 257);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(101, 41);
            this.bttLimpar.TabIndex = 7;
            this.bttLimpar.Text = "limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // cbxNomesAdicionados
            // 
            this.cbxNomesAdicionados.FormattingEnabled = true;
            this.cbxNomesAdicionados.Location = new System.Drawing.Point(215, 489);
            this.cbxNomesAdicionados.Name = "cbxNomesAdicionados";
            this.cbxNomesAdicionados.Size = new System.Drawing.Size(306, 32);
            this.cbxNomesAdicionados.TabIndex = 8;
            this.cbxNomesAdicionados.SelectedIndexChanged += new System.EventHandler(this.cbxNomesAdicionados_SelectedIndexChanged);
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AllowDrop = true;
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionado.Location = new System.Drawing.Point(324, 534);
            this.lblSelecionado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(81, 20);
            this.lblSelecionado.TabIndex = 9;
            this.lblSelecionado.Text = "<<vazio>>";
            this.lblSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 636);
            this.Controls.Add(this.lblSelecionado);
            this.Controls.Add(this.cbxNomesAdicionados);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttConcatenar);
            this.Controls.Add(this.txbApresentacao);
            this.Controls.Add(this.txtApresentacao);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.TextBox txbApresentacao;
        private System.Windows.Forms.Label txtApresentacao;
        private System.Windows.Forms.Button bttConcatenar;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.ComboBox cbxNomesAdicionados;
        private System.Windows.Forms.Label lblSelecionado;
    }
}

