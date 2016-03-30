using CadastroUsuario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class TelaCadastro : Form
    {

        private ModeloUsuario usuario { get; set; }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public TelaCadastro()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.usuario = new ModeloUsuario();
            if (txtIdUsuario.Text != "")
            {
                
                txtUsuario.ReadOnly = true;
            }
            dgEmpresas.DataSource = bindingSource1;
            GetData("SELECT cast(case when usr.usuario is null then 0 else 1 end  as bit) ' X ', M0_CODIGO, M0_CODFIL, M0_FILIAL, M0_NOMECOM FROM SIGAMAT left join usuario_empresa usr on sigamat.M0_CODIGO = usr.CODEMP and sigamat.M0_CODFIL = usr.CODFILIAL and usr.usuario = '" + txtUsuario.Text +"'");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirmaSenha.Text || txtSenha.Text == "")
            {
                toolTip("A senhas não coincidem!", txtSenha);
            }
            else if (txtUsuario.Text == "")
            {
                toolTip("Preencha o usuário!", txtUsuario);
            }
            else if (txtNome.Text == "")
            {
                toolTip("Preencha o nome do usuário!", txtNome);
            }
            else if (txtEmail.Text == "")
            {
                toolTip("Preencha o e-mail!", txtEmail);
            }
            else if (usuario.getIdUsuario(txtUsuario.Text) != "" && txtIdUsuario.Text == "")
            {
                MessageBox.Show("O usuário já existe, favor escolha outro", "Erro ao cadastra usuário!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(chkAtivo.CheckState.ToString());
                salvaUsuario();
                usuario.db.execQuery("delete from usuario_empresa where usuario = '" + usuario.Usuario + "';");
                foreach (DataGridViewRow dr in dgEmpresas.Rows)
                {
                    if (dr.Cells[0].Value != null && dr.Cells[0].Value.ToString() == "True")
                    {
                        var codemp = dr.Cells[1].Value.ToString();
                        var codfilial = dr.Cells[2].Value.ToString();
                        usuario.db.execQuery("insert into usuario_empresa(usuario, codemp, codfilial) values('" + usuario.Usuario + "', '" + codemp + "', '" + codfilial + "');");
                    }
                }                
            }
        }
       
        private void toolTip(string msg, TextBox box)
        {
            ToolTip tt = new ToolTip();            
            tt.BackColor = System.Drawing.Color.Red;
            int VisibleTime = 2000;  //in milliseconds
            tt.Show(msg, box, 100, 0, VisibleTime);
        }

        private void salvaUsuario()
        {
            usuario.Id = txtIdUsuario.Text;
            usuario.Usuario = txtUsuario.Text;
            usuario.Email = txtEmail.Text;
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            if (chkAtivo.CheckState == CheckState.Checked)
            {
                usuario.Ativo = "1";
            }
            else
            {
                usuario.Ativo = "0";
            }

            if (chkAdministrador.CheckState == CheckState.Checked)
            {
                usuario.Administrador = "1";
            }
            else
            {
                usuario.Administrador = "0";
            }

            if (usuario.salva())
            {
                if (txtIdUsuario.Text == "")
                {
                    MessageBox.Show("Usuário " + usuario.Usuario + " cadastrado com sucesso");
                    txtIdUsuario.Text = usuario.Id;
                    txtUsuario.ReadOnly = true;                    

                }
                else
                {
                    MessageBox.Show("Usuário " + usuario.Usuario + " atualizado com sucesso");

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgEmpresas.Columns[0].Index)
            {
                if (dgEmpresas.Rows[e.RowIndex].Cells[0].Value == null || dgEmpresas.Rows[e.RowIndex].Cells[0].Value.ToString() != "True")
                {
                    dgEmpresas.Rows[e.RowIndex].Cells[0].Value = "True";
                }
                else
                {
                    dgEmpresas.Rows[e.RowIndex].Cells[0].Value = "False";
                }
            }
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = usuario.db.connectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                
                // Resize the DataGridView columns to fit the newly loaded content.
                dgEmpresas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }
}
