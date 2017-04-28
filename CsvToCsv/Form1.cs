using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CsvToCsv
{
    public partial class Form1 : Form
    {
        List<string[]> parsedata = new List<string[]>();
        List<string[]> copias = new List<string[]>();
        string[] copia;

        public Form1()
        {
            InitializeComponent();
        }

        private string formatFecha(string fecha)
        {
            fecha = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd");
            return fecha;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string buscaRepetido(string folio, string tipoDte, string rutEmis)
        {
            string existe = "False";
            foreach (string[] row in copias)
            {
                if (row[1] == folio && row[0] == tipoDte && row[2] == rutEmis)
                {
                    existe = "True";
                }
            }
            return existe;
        }

        private string getLineadosImp(string folio, string tipoDte, string rutEmis)
        {
            string[] lista;
            string linea = string.Empty;
            List<string[]> listas = new List<string[]>();
            int conteo = 0;
            foreach (string[] row in parsedata)
            {
                if (row[1] == folio && row[0] == tipoDte && row[2] == rutEmis)
                {
                    conteo += 1;
                    lista = row;
                    listas.Add(lista);
                    string impto18 = "0";
                    if (conteo > 1)
                    {

                        foreach (string[] rowCopia in listas)
                        {
                            string fecha = formatFecha(rowCopia[6]);
                            string impto10 = "0";
                            string impto25 = "0";
                            string impto30 = "0";
                            string rutemisor = rowCopia[2];
                            if (rowCopia[15] == "18") impto18 = rowCopia[16];
                            if (rowCopia[15] == "10") impto10 = rowCopia[16];
                            if (rowCopia[15] == "25") impto10 = rowCopia[16];
                            if (rowCopia[15] == "30") impto10 = rowCopia[16];
                            if (rowCopia[8] == "") rowCopia[8] = "0";
                            if (rowCopia[9] == "") rowCopia[9] = "0";
                            if (rowCopia[10] == "") rowCopia[10] = "0";
                            if (row[11] == "") row[11] = "0";
                            if (row[12] == "") row[12] = "0";
                            Console.WriteLine(rowCopia[0] + ";" + rowCopia[1] + ";" + rowCopia[2] + ";" + rowCopia[16]);
                            if (rowCopia[15] == "18")
                            {
                                impto18 = rowCopia[16];
                            }
                            else
                            {
                                linea = (rowCopia[0] + ";"
                                     + rowCopia[1] + ";"
                                     + fecha + ";"
                                     + rutemisor + ";"
                                     + textBoxRutReceptor.Text + ";"
                                     + rowCopia[4] + ";"
                                     + rowCopia[9] + ";"
                                     + rowCopia[8] + ";"
                                     + rowCopia[10] + ";"
                                     + "0" + ";"
                                     + rowCopia[28] + ";"
                                     + impto18 + ";"
                                     + impto10 + ";"
                                     + impto25 + ";"
                                     + impto30 + ";"
                                     + "PREVIO" + ";"
                                     + row[12] + ";"
                                     + row[11]
                                     );
                                copia = rowCopia;
                            }
                        }
                    }
                }


            }
            return linea;

        }

        private void buttonAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = this.openFileDialog1.FileName;
            }
            this.openFileDialog1.Dispose();

            using (var sr = new StreamReader(@"" + label1.Text + "", Encoding.Default, true))
            {
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("Ñ", "N");
                    line = line.Replace("&", "Y");
                    string[] row = line.Split(';');
                    Console.WriteLine(row[2]);
                    parsedata.Add(row);

                }
            }
            dataGridView1.ColumnCount = 18;
            for (int i = 0; i < 18; i++)
            {
                var sb = new StringBuilder(parsedata[0][i]);
                sb.Replace('_', ' ');
                sb.Replace("\"", "");
                dataGridView1.Columns[i].Name = sb.ToString();

            }

            foreach (string[] row in parsedata)
            {
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);

        }

        private void buttonGeneraCsv_Click(object sender, EventArgs e)
        {
            string fchActual = DateTime.Now.ToString("yyyyMMddhhmmss");
            string dirDestino = this.openFileDialog1.FileName;
            dirDestino = dirDestino.Replace(".CSV", "_Procesado.CSV");
            StreamWriter escribe = new StreamWriter(@"" + dirDestino);
            escribe.WriteLine("tipodoc;folio;fchemis;rutemisor;rutrecep;rznsocemisor;mntneto;mntexe;mntiva;otrosimpto;mnttotal;impto18;impto10;impto25;impto30;estado;ivanorec;codivanorec");

            foreach (string[] row in parsedata)
            {
                // elimino la primera linea
                if (row[0] != "Tipo Doc")
                {
                    //doy formato a la fecha y declaro variables
                    string fecha = formatFecha(row[6]);
                    string impto18 = "0";
                    string impto10 = "0";
                    string impto25 = "0";
                    string impto30 = "0";
                    string rutemisor = row[2];
                    if (row[2].Length < 10) rutemisor = row[2].Insert(0, "0");
                    //cargo la fila
                    // si tasa de impuesto es 18(row[15]) monto es igual a impto18
                    if (row[15] == "18") impto18 = row[16];
                    if (row[15] == "10") impto10 = row[16];
                    if (row[15] == "25") impto10 = row[16];
                    if (row[15] == "30") impto10 = row[16];
                    if (row[8] == "") row[8] = "0";
                    if (row[9] == "") row[9] = "0";
                    if (row[10] == "") row[10] = "0";
                    if (row[11] == "") row[11] = "0";
                    if (row[12] == "") row[12] = "0";

                    Console.WriteLine(row[15]);

                    if (getLineadosImp(row[1], row[0], row[2]) != "")
                    {
                        if (buscaRepetido(row[1], row[0], row[2]) == "False")
                        {
                            escribe.WriteLine(getLineadosImp(row[1], row[0], row[2]));
                            copias.Add(copia);
                            copia.Initialize();
                        }

                    }
                    else
                    {

                        escribe.WriteLine(row[0] + ";"
                                        + row[1] + ";"
                                        + fecha + ";"
                                        + rutemisor + ";"
                                        + textBoxRutReceptor.Text + ";"
                                        + row[4] + ";"
                                        + row[9] + ";"
                                        + row[8] + ";"
                                        + row[10] + ";"
                                        + "0" + ";"
                                        + row[17] + ";"
                                        + impto18 + ";"
                                        + impto10 + ";"
                                        + impto25 + ";"
                                        + impto30 + ";"
                                        + "PREVIO" + ";"
                                        + row[12] + ";"
                                        + row[11]
                                        );

                    }

                }

            }
            escribe.Close();
            MessageBox.Show("Archivo Generado en: " + dirDestino);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fchActual = DateTime.Now.ToString("yyyyMMddhhmmss");
            string dirDestino = this.openFileDialog1.FileName;
            dirDestino = dirDestino.Replace(".CSV", "_Procesado.CSV");
            StreamWriter escribe = new StreamWriter(@"" + dirDestino);
            escribe.WriteLine("tipodoc;folio;fchemis;rutemisor;rutrecep;rznsocemisor;mntneto;mntexe;mntiva;codimp;tasaimp;mntimp;mnttotal;estado;ivanorec;codivanorec;tipolibro;codautrec");

            foreach (string[] row in parsedata)
            {
                // elimino la primera linea
                if (row[0] != "Tipo Doc")
                {
                    //doy formato a la fecha y declaro variables
                    string fecha = formatFecha(row[6]);
                    string impto18 = "0";
                    string impto10 = "0";
                    string impto25 = "0";
                    string impto30 = "0";
                    string rutemisor = row[2];
                    if (row[2].Length < 10) rutemisor = row[2].Insert(0, "0");
                    //cargo la fila
                    // si tasa de impuesto es 18(row[15]) monto es igual a impto18
                    if (row[15] == "18") impto18 = row[16];
                    if (row[15] == "10") impto10 = row[16];
                    if (row[15] == "25") impto10 = row[16];
                    if (row[15] == "30") impto10 = row[16];
                    if (row[8] == "") row[8] = "0";
                    if (row[9] == "") row[9] = "0";
                    if (row[10] == "") row[10] = "0";
                    if (row[11] == "") row[11] = "0";
                    if (row[12] == "") row[12] = "0";
                    if (row[14] == "") row[14] = "0";
                    if (row[15] == "") row[15] = "0";
                    if (row[16] == "") row[16] = "0";

                    escribe.WriteLine(row[0] + ";"
                                    + row[1] + ";"
                                    + fecha + ";"
                                    + rutemisor + ";"
                                    + textBoxRutReceptor.Text + ";"
                                    + row[4] + ";"
                                    + row[9] + ";"
                                    + row[8] + ";"
                                    + row[10] + ";"
                                    + row[14] + ";"
                                    + row[15] + ";"
                                    + row[16] + ";"
                                    + row[28] + ";"
                                    + "PREVIO" + ";"
                                    + row[12] + ";"
                                    + row[11] + ";"
                                    + textBoxTipoLibro.Text + ";"
                                    + textBoxCodAutRec.Text
                                    );
                }

            }
            escribe.Close();
            MessageBox.Show("Archivo Generado en: " + dirDestino);
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fchActual = DateTime.Now.ToString("yyyyMMddhhmmss");
            string dirDestino = this.openFileDialog1.FileName;
            dirDestino = dirDestino.Replace(".csv", "_Procesado.CSV");
            StreamWriter escribe = new StreamWriter(@"" + dirDestino);
            escribe.WriteLine("tipodoc;folio;fchemis;rutemisor;rutrecep;rznsocemisor;mntneto;mntexe;mntiva;codimp;tasaimp;mntimp;mnttotal;mntsincred;estado;ivanorec;codivanorec;tipolibro;codautrec");

            foreach (string[] row in parsedata)
            {
                // elimino la primera linea
                if (row[0] != "Tipo Doc")
                {
                    //doy formato a la fecha y declaro variables
                    string fecha = formatFecha(row[6]);
                    string impto18 = "0";
                    string impto10 = "0";
                    string impto25 = "0";
                    string impto30 = "0";
                    string rutemisor = row[2];
                    if (row[2].Length < 10) rutemisor = row[2].Insert(0, "0");
                    //cargo la fila
                    // si tasa de impuesto es 18(row[15]) monto es igual a impto18
                    if (row[15] == "18") impto18 = row[16];
                    if (row[15] == "10") impto10 = row[16];
                    if (row[15] == "25") impto10 = row[16];
                    if (row[15] == "30") impto10 = row[16];
                    if (row[8] == "") row[8] = "0";
                    if (row[9] == "") row[9] = "0";
                    if (row[10] == "") row[10] = "0";
                    if (row[11] == "") row[11] = "0";
                    if (row[12] == "") row[12] = "0";
                    if (row[14] == "") row[14] = "0";
                    if (row[15] == "") row[15] = "0";
                    if (row[16] == "") row[16] = "0";

                    escribe.WriteLine(row[0] + ";"
                                    + row[1] + ";"
                                    + fecha + ";"
                                    + rutemisor + ";"
                                    + textBoxRutReceptor.Text + ";"
                                    + row[4] + ";"
                                    + row[9] + ";"
                                    + row[8] + ";"
                                    + row[10] + ";"
                                    + row[14] + ";"
                                    + row[15] + ";"
                                    + row[16] + ";"
                                    + row[17] + ";"
                                    + row[18] + ";"
                                    + "PREVIO" + ";"
                                    + row[12] + ";"
                                    + row[11] + ";"
                                    + textBoxTipoLibro.Text + ";"
                                    + textBoxCodAutRec.Text
                                    );
                }

            }
            escribe.Close();
            MessageBox.Show("Archivo Generado en: " + dirDestino);
            this.Close();
        }
    }
}
