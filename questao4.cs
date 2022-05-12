using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva10DaviRibeiro
{
    public partial class questao4 : Form
    {
        public questao4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[10];
            Random aleatorio = new Random();
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = aleatorio.Next(0, 10);
                ltx_listar.Items.Add(vetor[i]);
            }
        }
    }
}
