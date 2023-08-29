using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCO.Data.Interfaces;
using UCO.Models;

namespace UCO.Front
{
    public partial class Form1 : Form
    {
        readonly IArtistaData ArtistaData;
        public Form1(IArtistaData artista)
        {
            InitializeComponent();
            ArtistaData = artista;
            Init();
           // InitListView();
        }

        private void InitListView()
        {
            
        }

        private void Init()
        {
            btnSaveAr.Visible = false;
            txtArNombre.Visible = false;
            txtArPais.Visible = false;
            txtArCasa.Visible = false ;

            txtArNombre.ReadOnly = false;
            txtArPais.ReadOnly = false;
            txtArCasa.ReadOnly = false;

            txtFilAr.Visible = false;

            lblNombre.Visible = false;
            lblPais.Visible = false;
            lblCasa.Visible = false;

            btnBusAr.Visible = false;

            btnArUp.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Init();
            btnSaveAr.Visible = true;
            txtArNombre.Visible = true;
            txtArPais.Visible = true;
            txtArCasa.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtArNombre.Text.Length <= 1 || txtArNombre.Text.Length > 50)
            {

            }
            if (txtArPais.Text.Length <= 1 || txtArPais.Text.Length > 50)
            {

            }
            if (txtArCasa.Text.Length <= 1 || txtArCasa.Text.Length > 50)
            {

            }
            btnSaveAr.Visible = false ;
            txtArNombre.ReadOnly = true;
            txtArPais.ReadOnly = true;
            txtArCasa.ReadOnly = true;

            ArtistaData.Create(new Models.Artista()
            {
                Id = 0,
                Nombre = txtArNombre.Text,
                Pais = txtArPais.Text,
                CasaDisquera = txtArCasa.Text

            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            txtFilAr.Visible = true;
            lblNombre.Visible = true;
            btnBusAr.Visible = true;
        }

        private async void btnBusAr_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (string.IsNullOrEmpty(txtFilAr.Text))
            {
                txtFilAr.Text = "";
            }
            var result = await ArtistaData.filtro(txtFilAr.Text);

            dataGridView1.DataSource = result;
           
        }
        Artista Art = null;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnArUp.Visible = true;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];


            Art = new Artista()
            {
                Id = int.Parse(selectedRow.Cells[0].Value.ToString()),
                Nombre = selectedRow.Cells[1].Value.ToString(),
                Pais = selectedRow.Cells[2].Value.ToString(),
                CasaDisquera = selectedRow.Cells[3].Value.ToString()
            };
            txtArNomUP.Text = Art.Nombre;
            txtArPaisUp.Text = Art.Pais;
            txtARCasaUp.Text = Art.CasaDisquera;

        }

        private async void btnArUp_Click(object sender, EventArgs e)
        {
            if (txtArNomUP.Text.Length <= 1 )
            {
                MessageBox.Show("El nombre debe ser minimo de dos cararteres y maximo de 50 ");
                return;
            }
            if (txtArPaisUp.Text.Length <= 1)
            {
                MessageBox.Show("El pais debe ser minimo de dos cararteres y maximo de 50 ");
                return;
            }
            if (txtARCasaUp.Text.Length <= 1)
            {
                MessageBox.Show("La casa disquera debe ser minimo de dos cararteres y maximo de 50 ");
                return;
            }
            Art.Nombre = txtArNomUP.Text;
            Art.Pais = txtArPaisUp.Text;
            Art.CasaDisquera = txtARCasaUp.Text;
            var result = await ArtistaData.Update(Art);
            btnBusAr_Click(null, null);
        }
    }
}
