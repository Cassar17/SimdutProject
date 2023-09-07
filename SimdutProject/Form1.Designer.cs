namespace SimdutProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.txtEquip = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.Label();
            this.txtFab = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.Label();
            this.txtEstagios = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.Label();
            this.txtCoord = new System.Windows.Forms.Label();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.textBoxFab = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.textBoxEstagios = new System.Windows.Forms.TextBox();
            this.textBoxPotencia = new System.Windows.Forms.TextBox();
            this.textBoxCoord = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curvesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curvesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 475);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEquip
            // 
            this.textBoxEquip.Location = new System.Drawing.Point(147, 12);
            this.textBoxEquip.Name = "textBoxEquip";
            this.textBoxEquip.Size = new System.Drawing.Size(156, 26);
            this.textBoxEquip.TabIndex = 2;
            // 
            // txtEquip
            // 
            this.txtEquip.AutoSize = true;
            this.txtEquip.Location = new System.Drawing.Point(12, 18);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(104, 20);
            this.txtEquip.TabIndex = 3;
            this.txtEquip.Text = "Equipamento";
            // 
            // txtTag
            // 
            this.txtTag.AutoSize = true;
            this.txtTag.Location = new System.Drawing.Point(12, 57);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(36, 20);
            this.txtTag.TabIndex = 4;
            this.txtTag.Text = "Tag";
            // 
            // txtFab
            // 
            this.txtFab.AutoSize = true;
            this.txtFab.Location = new System.Drawing.Point(12, 92);
            this.txtFab.Name = "txtFab";
            this.txtFab.Size = new System.Drawing.Size(85, 20);
            this.txtFab.TabIndex = 5;
            this.txtFab.Text = "Fabricante";
            // 
            // txtModelo
            // 
            this.txtModelo.AutoSize = true;
            this.txtModelo.Location = new System.Drawing.Point(12, 128);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(61, 20);
            this.txtModelo.TabIndex = 6;
            this.txtModelo.Text = "Modelo";
            // 
            // txtLocal
            // 
            this.txtLocal.AutoSize = true;
            this.txtLocal.Location = new System.Drawing.Point(12, 163);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(47, 20);
            this.txtLocal.TabIndex = 7;
            this.txtLocal.Text = "Local";
            // 
            // txtEstagios
            // 
            this.txtEstagios.AutoSize = true;
            this.txtEstagios.Location = new System.Drawing.Point(12, 199);
            this.txtEstagios.Name = "txtEstagios";
            this.txtEstagios.Size = new System.Drawing.Size(99, 20);
            this.txtEstagios.TabIndex = 8;
            this.txtEstagios.Text = "No. Estagios";
            // 
            // txtPotencia
            // 
            this.txtPotencia.AutoSize = true;
            this.txtPotencia.Location = new System.Drawing.Point(12, 239);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(71, 20);
            this.txtPotencia.TabIndex = 9;
            this.txtPotencia.Text = "Potencia";
            // 
            // txtCoord
            // 
            this.txtCoord.AutoSize = true;
            this.txtCoord.Location = new System.Drawing.Point(12, 276);
            this.txtCoord.Name = "txtCoord";
            this.txtCoord.Size = new System.Drawing.Size(105, 20);
            this.txtCoord.TabIndex = 10;
            this.txtCoord.Text = "Coordenadas";
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(147, 54);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(156, 26);
            this.textBoxTag.TabIndex = 11;
            // 
            // textBoxFab
            // 
            this.textBoxFab.Location = new System.Drawing.Point(147, 92);
            this.textBoxFab.Name = "textBoxFab";
            this.textBoxFab.Size = new System.Drawing.Size(156, 26);
            this.textBoxFab.TabIndex = 12;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(147, 128);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(156, 26);
            this.textBoxModelo.TabIndex = 13;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(147, 163);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(156, 26);
            this.textBoxLocal.TabIndex = 14;
            // 
            // textBoxEstagios
            // 
            this.textBoxEstagios.Location = new System.Drawing.Point(147, 199);
            this.textBoxEstagios.Name = "textBoxEstagios";
            this.textBoxEstagios.Size = new System.Drawing.Size(156, 26);
            this.textBoxEstagios.TabIndex = 15;
            // 
            // textBoxPotencia
            // 
            this.textBoxPotencia.Location = new System.Drawing.Point(147, 239);
            this.textBoxPotencia.Name = "textBoxPotencia";
            this.textBoxPotencia.Size = new System.Drawing.Size(156, 26);
            this.textBoxPotencia.TabIndex = 16;
            // 
            // textBoxCoord
            // 
            this.textBoxCoord.Location = new System.Drawing.Point(147, 276);
            this.textBoxCoord.Name = "textBoxCoord";
            this.textBoxCoord.Size = new System.Drawing.Size(156, 26);
            this.textBoxCoord.TabIndex = 17;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(309, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(135, 444);
            this.listBox.TabIndex = 18;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(708, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(656, 444);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 64);
            this.button2.TabIndex = 21;
            this.button2.Text = "Mostrar gráfico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.curvesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(450, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(252, 444);
            this.dataGridView2.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 64);
            this.button3.TabIndex = 23;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 64);
            this.button4.TabIndex = 24;
            this.button4.Text = "Salvar XML";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(162, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 64);
            this.button5.TabIndex = 25;
            this.button5.Text = "Carregar XML";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // curvesBindingSource
            // 
            this.curvesBindingSource.DataSource = typeof(SimdutProject.Curves);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 854);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxCoord);
            this.Controls.Add(this.textBoxPotencia);
            this.Controls.Add(this.textBoxEstagios);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxFab);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.txtCoord);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtEstagios);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFab);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.txtEquip);
            this.Controls.Add(this.textBoxEquip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curvesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEquip;
        private System.Windows.Forms.Label txtEquip;
        private System.Windows.Forms.Label txtTag;
        private System.Windows.Forms.Label txtFab;
        private System.Windows.Forms.Label txtModelo;
        private System.Windows.Forms.Label txtLocal;
        private System.Windows.Forms.Label txtEstagios;
        private System.Windows.Forms.Label txtPotencia;
        private System.Windows.Forms.Label txtCoord;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.TextBox textBoxFab;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxEstagios;
        private System.Windows.Forms.TextBox textBoxPotencia;
        private System.Windows.Forms.TextBox textBoxCoord;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource curvesBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

