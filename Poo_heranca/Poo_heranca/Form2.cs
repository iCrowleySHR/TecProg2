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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCadProfessor_Click(object sender, EventArgs e)
        {
            Classe_Professor professor = new Classe_Professor();

            professor.nome = textBoxNome.Text;
            professor.idade = int.Parse(textBoxIdade.Text);
            professor.salario = double.Parse(textBoxSalario.Text);
            professor.disciplina = textBoxDisciplina.Text;

            label5.Text = professor.resultado(professor.idade);
            professor.exibir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aluno = new Form1();
            aluno.Show();
        }
    }
}
