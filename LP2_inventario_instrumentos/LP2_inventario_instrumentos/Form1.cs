using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LP2_inventario_instrumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_retirada_Click(object sender, EventArgs e)
        {
            retirada newRetirada = new retirada();
            newRetirada.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar_Instrumento newCadastrar_Instrumento = new Cadastrar_Instrumento();
            newCadastrar_Instrumento.ShowDialog();
            

        }

        private void btn_relatorios_Click(object sender, EventArgs e)
        {
            relatorios newrelatorios = new relatorios();
            newrelatorios.ShowDialog();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            consultar_instrumentos newconsultar = new consultar_instrumentos();
            newconsultar.ShowDialog();
        }
    }
}
