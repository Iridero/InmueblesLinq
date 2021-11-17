using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InmueblesLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Catalogo cat = new Catalogo();
            cmbTipo.DataSource = cat.Tipos;
            cmbProvincias.DataSource = cat.Provincias;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Catalogo cat = new Catalogo();
            dataGridView1.DataSource = 
                cat.FiltrarPorTipo
                    ((string)cmbTipo.SelectedItem);
        }
    }
}
