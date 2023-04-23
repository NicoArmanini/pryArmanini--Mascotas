using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini__Mascotas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<clsMacota> ListarMascota = new List<clsMacota>();
            //Listar los string y los int de clsMascota creando un nuevo objeto llamado ListarMascota

            clsMacota objMascota = new clsMacota(); //indexar es el new y crea un nuevo objeto en la memoria

            objMascota.Nombre = txtNombre.Text; //traemos el string Nombre de la cslMascota y
                                                //le asignamos el valor que se vaya a escribir en txtNombre

            objMascota.Edad = Convert.ToInt32(txtEdad.Text); //convert toInt32 para que tome
                                                    //valores numericos del txtEdad
            objMascota.Tipo = cmbTipo.Text;

            ListarMascota.Add(objMascota);

            MessageBox.Show("Datos cargados correctamente");

            foreach (clsMacota item in ListarMascota)
            {
                lstAnimales.Items.Add(item.Tipo);
                //+" || " + item.Nombre + " || " + item.Edad
            }

            LimpiarControles();

        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            cmbTipo.SelectedIndex = -1;

        }


        private void lstAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstAnimales.Text == "Caniche")
            {
                
            }
            else
            {
                if (lstAnimales.Text == "Perro Salchicha")
                {
                    picMascotas.Image = Image.FromFile("Perro-salchicha.jpg");
                }
            }


            //if (lstAnimales.Text == "Perro Golden")
            //{

            //    fotoMascota.Image = Image.FromFile("perro-golden.jpg");
            //    lblTipo.Visible = true;
            //    lblEdad.Visible = true;

            //}
            //else
            //{
            //    if (cmbTipo.Text == "Gato Persa")
            //    {
            //        fotoMascota.Image = Image.FromFile("gato-persa.jpg");
            //        lblTipo.Visible = true;
            //        lblEdad.Visible = true;
            //    }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasear_Click(object sender, EventArgs e)
        {
            clsMacota objPasear = new clsMacota();

            objPasear.Tipo = lstAnimales.SelectedItem.ToString();

            MessageBox.Show(objPasear.PasearMascota());
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            clsMacota objAlimentar = new clsMacota();

            objAlimentar.Tipo = lstAnimales.SelectedItem.ToString();

            MessageBox.Show(objAlimentar.AlimentarMascota());
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            clsMacota objJugar = new clsMacota();

            objJugar.Tipo = lstAnimales.SelectedItem.ToString();

            MessageBox.Show(objJugar.JugarMascota());
        }

        private void btnMimos_Click(object sender, EventArgs e)
        {
            clsMacota objMimos = new clsMacota();

            objMimos.Tipo = lstAnimales.SelectedItem.ToString();

            MessageBox.Show(objMimos.MimosMascota());
        }
    }
}
