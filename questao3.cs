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
    public partial class questao3 : Form
    {
        public questao3()
        {
            InitializeComponent();
        }

        private void btn_dados_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[10];
            Random aleatorio = new Random();
            for (int i = 1; i < 6; i++)
            {
                vetor[i] = aleatorio.Next(1, 6);
            }
            MessageBox.Show("Numero dos dados são:" + vetor);
        }
    }
}