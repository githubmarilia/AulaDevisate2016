using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDevisate2016
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }
        int nv = 0;
        public fMenu(int nivel)
        {
            nv = nivel;
            InitializeComponent();
            if (nv == 0)
            {
                MessageBox.Show("Bem vindo... Usuário com Acesso Total");
            }
        }

        private void fMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
