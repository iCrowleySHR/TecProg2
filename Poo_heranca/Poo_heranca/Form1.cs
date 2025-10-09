using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadAluno_Click(object sender, EventArgs e)
        {
            Classe_Aluno aluno = new Classe_Aluno();

            aluno.nome=textBoxNome.Text;
            aluno.idade=int.Parse(textBoxIdade.Text);
            aluno.nro_matricula=int.Parse(textBoxMatricula.Text);   
            aluno.curso=textBoxCurso.Text;

            label5.Text = aluno.resultado(aluno.idade);
            aluno.exibir();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 prof = new Form2();
            prof.Show();
        }
    }
}

