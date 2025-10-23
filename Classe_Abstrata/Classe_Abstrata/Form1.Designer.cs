namespace Classe_Abstrata
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.radioButtonDesigner = new System.Windows.Forms.RadioButton();
            this.radioButtonProgramador = new System.Windows.Forms.RadioButton();
            this.buttonReajustar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.radioButtonDesenvolvedorWeb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(44, 53);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(353, 22);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(44, 127);
            this.textBoxSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(165, 22);
            this.textBoxSalario.TabIndex = 3;
            // 
            // radioButtonDesigner
            // 
            this.radioButtonDesigner.AutoSize = true;
            this.radioButtonDesigner.Location = new System.Drawing.Point(44, 210);
            this.radioButtonDesigner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDesigner.Name = "radioButtonDesigner";
            this.radioButtonDesigner.Size = new System.Drawing.Size(83, 20);
            this.radioButtonDesigner.TabIndex = 4;
            this.radioButtonDesigner.TabStop = true;
            this.radioButtonDesigner.Text = "Designer";
            this.radioButtonDesigner.UseVisualStyleBackColor = true;
            // 
            // radioButtonProgramador
            // 
            this.radioButtonProgramador.AutoSize = true;
            this.radioButtonProgramador.Location = new System.Drawing.Point(44, 255);
            this.radioButtonProgramador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonProgramador.Name = "radioButtonProgramador";
            this.radioButtonProgramador.Size = new System.Drawing.Size(108, 20);
            this.radioButtonProgramador.TabIndex = 5;
            this.radioButtonProgramador.TabStop = true;
            this.radioButtonProgramador.Text = "Programador";
            this.radioButtonProgramador.UseVisualStyleBackColor = true;
            // 
            // buttonReajustar
            // 
            this.buttonReajustar.Location = new System.Drawing.Point(44, 316);
            this.buttonReajustar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReajustar.Name = "buttonReajustar";
            this.buttonReajustar.Size = new System.Drawing.Size(167, 28);
            this.buttonReajustar.TabIndex = 6;
            this.buttonReajustar.Text = "Reajustar";
            this.buttonReajustar.UseVisualStyleBackColor = true;
            this.buttonReajustar.Click += new System.EventHandler(this.buttonReajustar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(219, 322);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(69, 16);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Resultado";
            // 
            // radioButtonDesenvolvedorWeb
            // 
            this.radioButtonDesenvolvedorWeb.AutoSize = true;
            this.radioButtonDesenvolvedorWeb.Location = new System.Drawing.Point(44, 170);
            this.radioButtonDesenvolvedorWeb.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDesenvolvedorWeb.Name = "radioButtonDesenvolvedorWeb";
            this.radioButtonDesenvolvedorWeb.Size = new System.Drawing.Size(153, 20);
            this.radioButtonDesenvolvedorWeb.TabIndex = 8;
            this.radioButtonDesenvolvedorWeb.TabStop = true;
            this.radioButtonDesenvolvedorWeb.Text = "Desenvolvedor Web";
            this.radioButtonDesenvolvedorWeb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 374);
            this.Controls.Add(this.radioButtonDesenvolvedorWeb);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonReajustar);
            this.Controls.Add(this.radioButtonProgramador);
            this.Controls.Add(this.radioButtonDesigner);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.RadioButton radioButtonDesigner;
        private System.Windows.Forms.RadioButton radioButtonProgramador;
        private System.Windows.Forms.Button buttonReajustar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.RadioButton radioButtonDesenvolvedorWeb;
    }
}

