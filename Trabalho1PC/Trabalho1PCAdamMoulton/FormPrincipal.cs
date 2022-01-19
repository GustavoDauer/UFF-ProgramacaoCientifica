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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }


        private void executarAdamMoulton(double h, int eulerExecucoes, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            
            double x, y, /*h,*/ fant = 0, fpos, yPreditor, yCorretor, n;
            double eulerH = 0;
            if (eulerExecucoes > 0) {
                eulerH = h / eulerExecucoes;
            }
            String output = "";
            //Condições iniciais
            x = 0;
            y = Convert.ToDouble(textBoxValorY.Text);
            //h = 0.1;
            n = 1.0f;
            int step = 0;

            //chart1.BeginInit();

            if (eulerH > 0)
            {
                chart1.Series.Add("h = " + h + " / euler H: " + eulerH);
            }
            else
            {
                chart1.Series.Add("h = " + h);
            }

            chart1.Series[chart1.Series.Count()-1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.ChartAreas[chart1.ChartAreas.Count() - 1].AxisX.Maximum = Convert.ToDouble(textBoxXmaximo.Text);
            chart1.ChartAreas[chart1.ChartAreas.Count() - 1].AxisX.Minimum = Convert.ToDouble(textBoxXminimo.Text);
            chart1.ChartAreas[chart1.ChartAreas.Count() - 1].AxisY.Maximum = Convert.ToDouble(textBoxYmaximo.Text);
            chart1.ChartAreas[chart1.ChartAreas.Count() - 1].AxisY.Minimum = Convert.ToDouble(textBoxYminimo.Text);

            chart1.Series[chart1.Series.Count() - 1].Points.AddXY(x, y);
            string[] saida = new string[] { step.ToString(), x.ToString(), y.ToString(), "", "" };
            dataGridView.Rows.Add(saida);            
            step++;
            
            //Inicializando o Adams-Bashforth com o Método de Euler Modificado.

            if (eulerExecucoes > 0)
            {
                for (int r = 0; r < eulerExecucoes; r++)
                {
                    fant = f(x, y); //Calculando fk-1
                    y = eulerModificado(x, y, eulerH);
                    x = x + eulerH;
                    saida = new string[] { step.ToString(), x.ToString(), y.ToString(), "", "" };
                    dataGridView.Rows.Add(saida);
                    chart1.Series[chart1.Series.Count() - 1].Points.AddXY(x, y);
                    step++;
                }
            }
            else
            {
                fant = f(x, y); //Calculando fk-1
                y = eulerModificado(x, y, h);
                x = x + h;
                saida = new string[] { step.ToString(), x.ToString(), y.ToString(), "", "" };
                chart1.Series[chart1.Series.Count() - 1].Points.AddXY(x, y);
                dataGridView.Rows.Add(saida);
                step++;
            }  

            fpos = f(x, y); //Calculando fk para o método Adams-Bashforth
            
            int i = 0;
            double preditor, corretor1, corretor2;
             int totalPassos = (int)Math.Floor(n / h);

            for(int l = 0; l < totalPassos-1; l++)
            {
                //Calculando o preditor utilizando dois passos : fk e fk-1
                yPreditor = adamsBashforth(y, fant, fpos, h); // y = yk , fant = fk-1 , fpos = fk
                preditor = yPreditor;
               
                //Calculando o corretor 1 utilizando dois passos : fk+1(este passo utiliza o valor de y encontrado no preditor) e fk
                //O corretor é calculado duas vezes, como é um método implícito,
                //vamos utilizar o valor de y encontrado no preditor p/ calcular o valor de fk+1
                fant = fpos;   //Como esse método utiliza dois passos, então o "primeiro" passo desse método vai ser o último do preditor
                fpos = f(x, yPreditor); //fpos utiliza o valor de y encontrado no preditor
                
                yCorretor = adamsMoulton(y, fant, fpos, h); // y = yk , fant = fk, fpos = fk+1
                corretor1 = yCorretor;
                
                double c1 = yCorretor; // Os dois valores encontrados utilizando o método corretor são armazenados para verificar a precisão.
                                       //Calculando o corretor 2 utilizando dois passos : fk+1(este passo utiliza o valor de y encontrado no corretor 1) e fk
                fpos = f(x, yCorretor); // o f é calculado novamente, mas desta vez é utilizado o valor da primeira correção
                
                yCorretor = adamsMoulton(y, fant, fpos, h); // y = yk , fant = fk , fpos = fk+1(utilizando o yk+1 calculado através do corretor 1)
                corretor2 = yCorretor;
                
                double c2 = yCorretor; //Valor armazenado para verificar precisão
                                       // Quando duas correções não são suficientes para o resultado esperado, outras correções são realizadas.
                while (!verificarPrecisao(c1, c2))
                {
                    c1 = c2;
                    fpos = f(x, yCorretor);
                    yCorretor = adamsMoulton(y, fant, fpos, h);
                    c2 = yCorretor;
                }
                
                i++;
                fpos = f(x, yCorretor);
                x = x + h;
                
                y = yCorretor;

                saida = new string[] { step.ToString(), x.ToString(), y.ToString(), preditor.ToString(), corretor1.ToString(), corretor2.ToString() };
                dataGridView.Rows.Add(saida);
                chart1.Series[chart1.Series.Count() - 1].Points.AddXY(x, c2);
                step++;
            }
        }



        double f(double x, double y)
        {
            return -Convert.ToDouble(textBoxConstante.Text)*y;
        }

        double eulerModificado(double x, double y, double h)
        {
            y = y + h * f(x + h / 2, y + (h / 2) * f(x, y));
            return y;
        }

        double adamsBashforth(double y, double f1, double f2, double h)
        {
            y = y + (h / 2) * (3 * f2 - f1);
            return y;
        }

        double adamsMoulton(double y, double f1, double f2, double h)
        {
            y = y + (h/2) * (f2+f1);
            return y;
        }

        bool verificarPrecisao(double c1, double c2)
        {
            double result, sub;
            sub = c2 - c1;
            if (sub < 0)
                sub = sub * (-1);
            if (c2 < 0)
                c2 = c2 * (-1);
            result = sub / c2;
            if (result < 0.1)
                return true;
            else
                return false;
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            try
            {
                //labelResultado.Text = "Resultado: \n\n";
                chart1.Series.Clear();
                double[] vetorH = criaVetorH();
                double eulerH = 0;
                int eulerRepeticoes = 0;
                if(repeticoesEulerModificado.Text.Length  > 0)
                    eulerRepeticoes = Convert.ToInt32(repeticoesEulerModificado.Text);
                else
                    eulerH = 0;

                if(vetorH != null)
                {
                    int page = 1;
                    tabControl1.TabPages.Clear();
                    foreach (double h in vetorH)
                    {
                        
                        TabPage tabPage = new TabPage();
                        tabPage.Name = "newPage"+page.ToString();
                        page++;
                        tabPage.Text = "h= "+h.ToString();                        
                        tabControl1.TabPages.Add(tabPage);                      
                        

                        DataGridView datagrid = new DataGridView();
                        datagrid.Columns.Add("passo","passo");
                        datagrid.Columns.Add("x","x");
                        datagrid.Columns.Add("y","y");
                        datagrid.Columns.Add("y_predicao","y predição");
                        datagrid.Columns.Add("y_correcao1","y 1ª correção");
                        datagrid.Columns.Add("y_correcao2","y 2ª correção");
                        datagrid.ReadOnly = true;
                        datagrid.Dock = (DockStyle.Fill);
                        datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        //datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                        tabPage.Controls.Add(datagrid);

                        executarAdamMoulton(h, 0, datagrid);

                        if(eulerRepeticoes >0)
                            eulerH = h / eulerRepeticoes;
                        if (eulerH > 0)
                        {
                            TabPage tabPage2 = new TabPage();
                            tabPage2.Name = "newPage" + page.ToString()+"comEulerReduzido";
                            page++;
                            tabPage2.Text = "h= " + h.ToString() +"| h Euler:" + eulerH;
                            tabControl1.TabPages.Add(tabPage2);

                            DataGridView datagrid2 = new DataGridView();
                            datagrid2.Columns.Add("passo", "passo");
                            datagrid2.Columns.Add("x", "x");
                            datagrid2.Columns.Add("y", "y");
                            datagrid2.Columns.Add("y_predicao", "y predição");
                            datagrid2.Columns.Add("y_correcao1", "y 1ª correção");
                            datagrid2.Columns.Add("y_correcao2", "y 2ª correção");
                            datagrid2.Dock = (DockStyle.Fill);
                            datagrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            
                            tabPage2.Controls.Add(datagrid2);

                            executarAdamMoulton(h, eulerRepeticoes, datagrid2);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[] criaVetorH()
        {
            try
            {
                if (txtBoxH.Text.Trim() != "")
                {
                    string[] aux = txtBoxH.Text.Split(';');
                    double[] vetorH = new double[aux.Count()];
                    int i = 0;
                    foreach (string item in aux)
                    {
                        vetorH[i] = Convert.ToDouble(item.Trim());
                        i++;
                    }
                        return vetorH;
                }
                else
                {
                    MessageBox.Show("Favor preencher no mínimo 1 valor para H.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void MudarLimitesDoGrafico_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < chart1.ChartAreas.Count(); i++)
            {
                chart1.ChartAreas[i].AxisX.Maximum = Convert.ToDouble(textBoxXmaximo.Text);
                chart1.ChartAreas[i].AxisX.Minimum = Convert.ToDouble(textBoxXminimo.Text);
                chart1.ChartAreas[i].AxisY.Maximum = Convert.ToDouble(textBoxYmaximo.Text);
                chart1.ChartAreas[i].AxisY.Minimum = Convert.ToDouble(textBoxYminimo.Text);
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormSobre frms = new FormSobre();
            frms.ShowDialog();
        }
    }
}
