using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AulaDevisate2016
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string de conexao
            string CnnStr = "Data Source=(local);Initial Catalog=abvip;Integrated Security=True";
            SqlConnection Conexao = new SqlConnection(CnnStr);

            //Abrindo a Conexao
           
            string consulta = "Select * from logins 
                where login = '"+textBox1.Text+"' 
                and senha = '"+textBox2.Text+ "'";
            SqlCommand sql = new SqlCommand(consulta,Conexao);
            Conexao.Open();
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
           
                {
                    string usuario = dr["nomecompleto"].ToString();
                    int nivel = Convert.ToInt32(dr["nivel"]);
                    MessageBox.Show("Seja bem vindo " + usuario.ToString());
                    fMenu menu = new fMenu(nivel);
                    menu.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Usuário Não Encontrado. Tente Novamente");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }



            //Fechando a Conexao
            Conexao.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
