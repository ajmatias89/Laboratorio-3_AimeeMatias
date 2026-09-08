using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3_AimeeMatias
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personas miColaborador1 = new Personas();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodríguez";
            miColaborador1.Email = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            listaPersonas.Add(miColaborador1);
            dtgDatos.DataSource = null;
            dtgDatos.DataSource = listaPersonas;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Ingrese los nombres del colaborador");
                txtNombres.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombres, "");
            }

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese los apellidos del colaborador");
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }

            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Personas colaborador1 = new Personas();
            colaborador1.Id = int.Parse(txtID.Text);
            colaborador1.Nombres = txtNombres.Text;
            colaborador1.Apellidos = txtApellidos.Text;
            colaborador1.Email = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacimiento.Value;
            listaPersonas.Add(colaborador1);
            dtgDatos.DataSource = null;
            dtgDatos.DataSource = listaPersonas;

        }
    }
}