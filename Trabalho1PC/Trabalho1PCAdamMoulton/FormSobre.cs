using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1PCAdamMoulton
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();

            lblTexto.Text = @"Trabalho da disciplina de Programação Científica do curso de Ciência da Computação da Univresidade Federal Fluminense.

Nosso trabalho é baseado no método de predição-correção Adams-Moulton de passo 2. 

Como o método é de passo múltiplo, tivemos que inicializá-lo com um método explícito de passo 2(Adams-Bashforth), que 
por sua vez, foi inicializado com um método explícito de passo simples (Euler Modificado).

Membros:
- Gustavo Dauer
- Jorge da Silva
- Pablo Moreira
- Pedro Develly
- Vinícius Brum";
        }
    }
}
