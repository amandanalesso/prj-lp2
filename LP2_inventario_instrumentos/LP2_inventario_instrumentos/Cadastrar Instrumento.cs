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
using System.IO;

namespace LP2_inventario_instrumentos
{
    public partial class Cadastrar_Instrumento : Form {

        private static string conexao = "Data Source = instrumentos.db";
        private static string instrumentos = "instrumentos.db";


        public Cadastrar_Instrumento()
        {
            InitializeComponent();        
        }

        private void Cadastrar_Instrumento_Load(object sender, EventArgs e)
        {
         
                if (!File.Exists(instrumentos))
                {
                    SQLiteConnection.CreateFile(instrumentos);
                    SQLiteConnection conn = new SQLiteConnection(conexao);
                    conn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine(
                    "CREATE TABLE IF NOT EXISTS INSTRUMENTO ([ID] INTEGER PRIMARY KEY AUTOINCREMENT,"
                    );
                    sql.AppendLine("[NOME] VARCHAR(50))");
                    SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco de dados: " + ex.Message);
                    }
                }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
