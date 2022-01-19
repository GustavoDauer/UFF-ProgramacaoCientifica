namespace Trabalho1PCAdamMoulton
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.btnRodar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MudarLimitesDoGrafico = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYminimo = new System.Windows.Forms.TextBox();
            this.textBoxYmaximo = new System.Windows.Forms.TextBox();
            this.textBoxXmaximo = new System.Windows.Forms.TextBox();
            this.textBoxXminimo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxValorY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxConstante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repeticoesEulerModificado = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.passo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_predicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_correcao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_correcao_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSobre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea3.AxisX.Maximum = 0.6D;
            chartArea3.AxisX.MaximumAutoSize = 80F;
            chartArea3.AxisY.Minimum = 0.4D;
            chartArea3.BackColor = System.Drawing.Color.LavenderBlush;
            chartArea3.CursorX.AutoScroll = false;
            chartArea3.CursorY.AutoScroll = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.Size = new System.Drawing.Size(504, 469);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserir os valores de H separados por ponto e vírgula (;):";
            // 
            // txtBoxH
            // 
            this.txtBoxH.Location = new System.Drawing.Point(6, 32);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.Size = new System.Drawing.Size(269, 20);
            this.txtBoxH.TabIndex = 4;
            // 
            // btnRodar
            // 
            this.btnRodar.Image = ((System.Drawing.Image)(resources.GetObject("btnRodar.Image")));
            this.btnRodar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRodar.Location = new System.Drawing.Point(187, 116);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(235, 36);
            this.btnRodar.TabIndex = 5;
            this.btnRodar.Text = "Rodar Adams-Moulton";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1247, 473);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MudarLimitesDoGrafico);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxYminimo);
            this.groupBox2.Controls.Add(this.textBoxYmaximo);
            this.groupBox2.Controls.Add(this.textBoxXmaximo);
            this.groupBox2.Controls.Add(this.textBoxXminimo);
            this.groupBox2.Location = new System.Drawing.Point(6, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 78);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limites do gráfico";
            // 
            // MudarLimitesDoGrafico
            // 
            this.MudarLimitesDoGrafico.Location = new System.Drawing.Point(545, 37);
            this.MudarLimitesDoGrafico.Name = "MudarLimitesDoGrafico";
            this.MudarLimitesDoGrafico.Size = new System.Drawing.Size(134, 23);
            this.MudarLimitesDoGrafico.TabIndex = 8;
            this.MudarLimitesDoGrafico.Text = "Aplicar Mudanças";
            this.MudarLimitesDoGrafico.UseVisualStyleBackColor = true;
            this.MudarLimitesDoGrafico.Click += new System.EventHandler(this.MudarLimitesDoGrafico_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y minimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "X máximo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y maximo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X minimo:";
            // 
            // textBoxYminimo
            // 
            this.textBoxYminimo.Location = new System.Drawing.Point(292, 40);
            this.textBoxYminimo.Name = "textBoxYminimo";
            this.textBoxYminimo.Size = new System.Drawing.Size(100, 20);
            this.textBoxYminimo.TabIndex = 3;
            this.textBoxYminimo.Text = "-2";
            // 
            // textBoxYmaximo
            // 
            this.textBoxYmaximo.Location = new System.Drawing.Point(419, 40);
            this.textBoxYmaximo.Name = "textBoxYmaximo";
            this.textBoxYmaximo.Size = new System.Drawing.Size(100, 20);
            this.textBoxYmaximo.TabIndex = 2;
            this.textBoxYmaximo.Text = "2";
            // 
            // textBoxXmaximo
            // 
            this.textBoxXmaximo.Location = new System.Drawing.Point(150, 40);
            this.textBoxXmaximo.Name = "textBoxXmaximo";
            this.textBoxXmaximo.Size = new System.Drawing.Size(100, 20);
            this.textBoxXmaximo.TabIndex = 1;
            this.textBoxXmaximo.Text = "1";
            // 
            // textBoxXminimo
            // 
            this.textBoxXminimo.Location = new System.Drawing.Point(7, 40);
            this.textBoxXminimo.Name = "textBoxXminimo";
            this.textBoxXminimo.Size = new System.Drawing.Size(100, 20);
            this.textBoxXminimo.TabIndex = 0;
            this.textBoxXminimo.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSobre);
            this.groupBox1.Controls.Add(this.textBoxValorY);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxConstante);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRodar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.repeticoesEulerModificado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dados do método";
            // 
            // textBoxValorY
            // 
            this.textBoxValorY.Location = new System.Drawing.Point(326, 74);
            this.textBoxValorY.Name = "textBoxValorY";
            this.textBoxValorY.Size = new System.Drawing.Size(232, 20);
            this.textBoxValorY.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Valor máximo de y";
            // 
            // textBoxConstante
            // 
            this.textBoxConstante.Location = new System.Drawing.Point(326, 31);
            this.textBoxConstante.Name = "textBoxConstante";
            this.textBoxConstante.Size = new System.Drawing.Size(232, 20);
            this.textBoxConstante.TabIndex = 11;
            this.textBoxConstante.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor de c na equação f(x,y)= -c*y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número de repetições do método de euler:";
            // 
            // repeticoesEulerModificado
            // 
            this.repeticoesEulerModificado.Location = new System.Drawing.Point(6, 75);
            this.repeticoesEulerModificado.Name = "repeticoesEulerModificado";
            this.repeticoesEulerModificado.Size = new System.Drawing.Size(269, 20);
            this.repeticoesEulerModificado.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 258);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 211);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passo,
            this.x,
            this.y,
            this.y_predicao,
            this.y_correcao1,
            this.y_correcao_2});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 293);
            this.dataGridView1.TabIndex = 6;
            // 
            // passo
            // 
            this.passo.HeaderText = "passo";
            this.passo.Name = "passo";
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.Name = "y";
            // 
            // y_predicao
            // 
            this.y_predicao.HeaderText = "y predição";
            this.y_predicao.Name = "y_predicao";
            // 
            // y_correcao1
            // 
            this.y_correcao1.HeaderText = "y 1ª correção";
            this.y_correcao1.Name = "y_correcao1";
            // 
            // y_correcao_2
            // 
            this.y_correcao_2.HeaderText = "y 2ª correção";
            this.y_correcao_2.Name = "y_correcao_2";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSobre
            // 
            this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSobre.Location = new System.Drawing.Point(646, 11);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 14;
            this.btnSobre.Text = "Sobre...";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1247, 473);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programação Científica - Adam-Moulton";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.Button btnRodar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repeticoesEulerModificado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passo;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_predicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_correcao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_correcao_2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxYminimo;
        private System.Windows.Forms.TextBox textBoxYmaximo;
        private System.Windows.Forms.TextBox textBoxXmaximo;
        private System.Windows.Forms.TextBox textBoxXminimo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConstante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValorY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button MudarLimitesDoGrafico;
        private System.Windows.Forms.Button btnSobre;
    }
}

