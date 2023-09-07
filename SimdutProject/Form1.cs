using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimdutProject
{
    public partial class Form1 : Form
    {

        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private bool try_format(string s)
        {
            string accepted_symbols = "0123456789.,;";
            bool prev_special = false;

            if (s == "") return false;
            if (accepted_symbols.Substring(10).Contains(s[0]) || accepted_symbols.Substring(10).Contains(s[s.Length - 1])) return false;

            foreach (char c in s)
            {
                //se houver elementos nao aceitos
                if (!accepted_symbols.Contains(c)) return false;

                if (accepted_symbols.Substring(10, 3).Contains(c))
                {
                    if (prev_special) return false;
                    else prev_special = true;
                }
                else prev_special = false;

            }



            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            data.DataSetName = "pump_curves";

            dt = new DataTable("duct");


            dt.Columns.Add("Equipamento", typeof(string));
            dt.Columns.Add("Tag", typeof(string));
            dt.Columns.Add("Fabricante", typeof(string));
            dt.Columns.Add("Modelo", typeof(string));
            dt.Columns.Add("Local", typeof(string));
            dt.Columns.Add("Numero de Estagios", typeof(int));
            dt.Columns.Add("Potencia do Motor", typeof(double));
            dt.Columns.Add("Curva de Head");

            data.Tables.Add(dt);
            dataGridView1.DataSource = data.Tables["duct"];


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string equip = textBoxEquip.Text;
            string tag = textBoxTag.Text;
            string fab = textBoxFab.Text;
            string modelo = textBoxModelo.Text;
            string local = textBoxLocal.Text;

            string coords = textBoxCoord.Text;


            int estagios;
            double potencia;

            bool valid_string = try_format(coords);
            bool valid_estagios = int.TryParse(textBoxEstagios.Text, out estagios);
            bool valid_potencia = double.TryParse(textBoxPotencia.Text, out potencia);

            if (valid_string && valid_estagios && valid_potencia)
            {
                dt.Rows.Add(equip, tag, fab, modelo, local, estagios, potencia, coords);

                textBoxEquip.Clear();
                textBoxTag.Clear();
                textBoxFab.Clear();
                textBoxModelo.Clear();
                textBoxLocal.Clear();
                textBoxEstagios.Clear();
                textBoxPotencia.Clear();
                textBoxCoord.Clear();

                listBox.Items.Add(tag);
            }
            else
            {
                if (!valid_string) MessageBox.Show("Entrada para Curva de Head invalida");
                else if (!valid_estagios) MessageBox.Show("Entrada para Estagios invalida");
                else if (!valid_potencia) MessageBox.Show("Entrada para Potencia invalida");
            }






        }


        public void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tag = null;

            if (listBox.SelectedItem != null)
            {
                tag = listBox.SelectedItem.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {

                if (row.ItemArray[1] == tag)
                {

                    List<List<double>> outer_list = new List<List<double>>();
                    List<string> initial = row.ItemArray[7].ToString().Split(';').ToList();
                    List<double> inner_double = null;
                    List<Curves> curveData = new List<Curves>();

                    foreach (string s in initial)
                    {

                        List<string> inner_list = s.Split(',').ToList();
                        Curves curves = new Curves();
                        inner_double = inner_list.Select(x => double.Parse(x)).ToList();
                        curves.X = inner_double[0];
                        curves.Y = inner_double[1];
                        curveData.Add(curves);
                        outer_list.Add(inner_double);

                    }

                    curvesBindingSource.DataSource = curveData;


                }

            }





        }



        private void chart1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();
            chart1.Series.Add("Curve");
            chart1.Series["Curve"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Titles.Clear();
            chart1.Titles.Add("Curva de Head");
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    double x = Convert.ToDouble(row.Cells[0].Value);
                    double y = Convert.ToDouble(row.Cells[1].Value);
                    chart1.Series["Curve"].Points.AddXY(x, y);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tag = null;

            if (listBox.SelectedItem != null)
            {
                tag = listBox.SelectedItem.ToString();
            }

            if (tag != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["tag"] == tag)
                    {
                        string final_string = "";

                        foreach (DataGridViewRow row2 in dataGridView2.Rows)
                        {

                            if (!row2.IsNewRow)
                            {
                                final_string += row2.Cells[0].Value.ToString();
                                final_string += ',';
                                final_string += row2.Cells[1].Value.ToString();
                                final_string += ';';
                            }



                        }

                        row["Curva de Head"] = final_string.Substring(0, final_string.Length - 1);
                        dt.AcceptChanges();

                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //XML

            dt.WriteXml("DataCurvas.xml", XmlWriteMode.IgnoreSchema);
            MessageBox.Show("Dados exportados para DataCurvas.xml");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dt.ReadXml("DataCurvas.xml");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar arquivo: " + ex.Message);
            }

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    listBox.Items.Add(row["tag"].ToString());
                }

            }

        }
    }
}
