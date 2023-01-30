using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularPromedio
{
    public partial class Form1 : Form
    {


        public void Clean()
        {


            txtNombre.Text = string.Empty;
            txtEspañol.Text = string.Empty;
            txtMatematicas.Text = string.Empty;
            txtFisica.Text = string.Empty;
            txtIngles.Text = string.Empty;

            txtNombre.Focus();

        }


         



        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TablaDeRegistro.AllowUserToAddRows = false;
        }

        private void txtEspañol_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEspañol.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtEspañol.Text = txtEspañol.Text.Remove(txtEspañol.Text.Length - 1);
            }
        }

        private void txtMatematicas_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMatematicas.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtMatematicas.Text = txtMatematicas.Text.Remove(txtMatematicas.Text.Length - 1);
            }
        }

        private void txtFisica_TextChanged(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFisica.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtFisica.Text = txtFisica.Text.Remove(txtFisica.Text.Length - 1);
            }
        }

        private void txtIngles_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtIngles.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtIngles.Text = txtIngles.Text.Remove(txtIngles.Text.Length - 1);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nom;
            string NE, NM, NF, NI;
            double sumaNotas=0;
          
            double Nmax=double.MaxValue;
            double Nmin=double.MinValue;

            if (txtNombre.Text == "" || txtEspañol.Text == "" || txtMatematicas.Text == "" || txtFisica.Text == "" || txtIngles.Text == "")
            {
                MessageBox.Show("Verifique los campos en blancos...");
            }
            else
            {


                Nom = txtNombre.Text;
                NE = txtEspañol.Text;
                NM = txtMatematicas.Text;
                NF = txtFisica.Text;
                NI = txtIngles.Text;

                string[] datos = new string[5];//se declara un array 
                datos[0] = Nom;
                datos[1] = NE;
                datos[2] = NM;
                datos[3] = NF;
                datos[4] = NI;

                TablaDeRegistro.Rows.Add(datos);
                Clean();

            }

            int NumeroEst = int.Parse(TablaDeRegistro.RowCount.ToString());
            lblTest.Text = TablaDeRegistro.RowCount.ToString();


            double sum = 0;
            foreach (DataGridViewRow row in TablaDeRegistro.Rows) {

                if (!row.IsNewRow)
                {
                    double español = Convert.ToDouble(row.Cells["español"].Value);
                    double matematicas = Convert.ToDouble(row.Cells["matematicas"].Value);
                    double fisica = Convert.ToDouble(row.Cells["fisica"].Value);
                    double ingles = Convert.ToDouble(row.Cells["ingles"].Value);
                    sum += español + matematicas + fisica + ingles;


                }

                double nota = Convert.ToDouble(row.Cells[1].Value);
                sumaNotas += nota;

                /*

                if (nota <= Nmin)
                {
                    Nmin = nota;    
                }
                 if (nota >= Nmax)
                {
                    Nmax = nota;
                }
                */
            }

            double promedio = sum / 4;
            double[] notas = new double[NumeroEst]; 
            lblTn.Text = sumaNotas.ToString();
            lblpro.Text = promedio.ToString();

            for (int i = 0; i  < NumeroEst ; i++)
            {

                notas[i] = Convert.ToDouble(TablaDeRegistro.Rows[i].Cells[1].Value);

                if (notas[i]> Nmin)
                {
                    Nmin = notas[i];
                }

                if (notas[i] < Nmax)
                {
                    Nmax = notas[i];
                }

            }

            lblmin.Text = Nmin.ToString();  
            lblMax.Text = Nmax.ToString();
            




            if (promedio >= 60)
            {
                LblAOR.Text = " aprobado";
            }
            else
            {
                LblAOR.Text = " Reprobado";
            }


            lblTn.Text = sum.ToString();
            






        }
            


            private void Eliminar_Click(object sender, EventArgs e)
            {
                int NumRowseSelect;//Variable conmtadora
                NumRowseSelect = TablaDeRegistro.CurrentRow.Index;
                TablaDeRegistro.Rows.RemoveAt(NumRowseSelect);


            }

            private void txtNalumnos_TextChanged(object sender, EventArgs e)
            {

            }






        
    }
}
