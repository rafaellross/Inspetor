using CadastroUsuario.Classes;
using InspetorXML_Console.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class Login : Form
    {
        public bool Logado { get; private set; } = false;

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo usuário e senha", "Erro ao logar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModeloUsuario usuario = new ModeloUsuario();
                usuario.carregaUsuario(usuario.getIdUsuario(txtUsuario.Text));
                if (usuario.Senha == ModeloUsuario.getMD5Hash(txtSenha.Text) && usuario.Administrador == "True" && usuario.Ativo == "True")
                {
                    this.Logado = true;
                    this.Close();
                }
                else
                {
                    if (usuario.Senha != ModeloUsuario.getMD5Hash(txtSenha.Text))
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", "Erro ao logar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if (usuario.Ativo != "True")
                    {
                        MessageBox.Show("Usuário desativado!", "Erro ao logar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if (usuario.Administrador != "True")
                    {
                        MessageBox.Show("O usuário não tem permissão para acessar este módulo!", "Erro ao logar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }
        }
    }
}
