using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabalho2PC
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();

            txtK.Text = "1,04";
            txtDeltaT.Text = "0,25";
            txtDeltaX.Text = "0,25";
            txtTamBarra.Text = "1,5";
            txtRo.Text = "10,6";
            txtR.Text = "5,0";
            txtC.Text = "0,056";
            txtTMin.Text = "0,0";
            txtTMax.Text = "1,0";
            txtXMin.Text = "0,0";
            txtXMax.Text = "1,5";

        }

        private void btnExplicito_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResposta.DataSource = null;

                MetodoExplicito metodo = new MetodoExplicito(Convert.ToDouble(txtDeltaT.Text), Convert.ToDouble(txtDeltaX.Text), 
                                                             Convert.ToDouble(txtTamBarra.Text), Convert.ToDouble(txtRo.Text), 
                                                             Convert.ToDouble(txtR.Text), Convert.ToDouble(txtK.Text), 
                                                             Convert.ToDouble(txtTMin.Text), Convert.ToDouble(txtTMax.Text), 
                                                             Convert.ToDouble(txtXMin.Text), Convert.ToDouble(txtXMax.Text), 
                                                             Convert.ToDouble(txtC.Text));
                metodo.calculaExplicito();

                preencheGrid(metodo.U);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMetodoImplicito_Click(object sender, EventArgs e)
        {
            dataGridViewResposta.DataSource = null;
        }

        private void preencheGrid(double[,] U)
        {
            //Preenche DataGridView
            DataTable dt = new DataTable();

            int linhas = U.GetLength(0);
            int colunas = U.GetLength(1);

            // create columns
            for (int i = 0; i < colunas; i++)
            {
                dt.Columns.Add("i = " + i);
            }

            for (int j = 0; j < linhas; j++)
            {
                // create a DataRow using .NewRow()
                DataRow row = dt.NewRow();

                // iterate over all columns to fill the row
                for (int i = 0; i < colunas; i++)
                {
                    row[i] = U[j, i];
                }

                // add the current row to the DataTable
                dt.Rows.Add(row);
            }

            dataGridViewResposta.DataSource = dt;
        }
    }


}
