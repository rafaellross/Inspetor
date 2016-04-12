using InspetorXML_Console.Classes;
using InspetorXML_Console.Classes.App;
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
    public partial class GridUsuarios : Form
    {
        private Parametros parametros { get; set; }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DB db;
        public GridUsuarios()
        {
            InitializeComponent();

        }

        private void GridUsuarios_Load(object sender, EventArgs e)
        {
            parametros = new Parametros();
            parametros.carregaParametros();
            dgUsuarios.DataSource = bindingSource1;
            GetDataUser("SELECT id, usuario, nome, email, Ativo, Administrador  FROM usuario");

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            new TelaCadastro().Show();
        }


        private void GetDataUser(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                db = new DB(parametros.DBInspetorServer, parametros.DBInspetor, parametros.UserDBInspetor, parametros.PasswdDBInspetor);
                String connectionString = db.connectionString;

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
                dgUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            new TelaCadastro().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDataUser("SELECT id, usuario, nome, email, Ativo, Administrador FROM usuario");
        }

        private void dgUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            var usuario = new TelaCadastro();
            
            usuario.txtIdUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            usuario.txtUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            usuario.txtNome.Text = dgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            usuario.txtEmail.Text = dgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            usuario.chkAtivo.CheckState = checkValor(dgUsuarios.Rows[e.RowIndex].Cells[5].Value);
            usuario.chkAdministrador.CheckState = checkValor(dgUsuarios.Rows[e.RowIndex].Cells[6].Value);
            usuario.txtSenha.Text = db.consultaErp("select senha from usuario where id = '" + dgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString() + "'")[0];
            usuario.txtConfirmaSenha.Text = usuario.txtSenha.Text;
            usuario.Show();
        }

        private CheckState checkValor(object valor)
        {
            if (valor.ToString() == "True")
            {
                return CheckState.Checked;
            }
            else
            {
                return CheckState.Unchecked;
            }
        }

        private void dgUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dgUsuarios.Columns["chkUsuarios"].Index)
            {
                //interrompe a edição
                if (dgUsuarios.Rows[e.RowIndex].Cells[0].Value == null || dgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString() != "True")
                {
                    dgUsuarios.Rows[e.RowIndex].Cells[0].Value = "True";
                }
                else
                {
                    dgUsuarios.Rows[e.RowIndex].Cells[0].Value = "False";
                }                                                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgUsuarios.Rows)
            {
                if (dr.Cells[0].Value != null && dr.Cells[0].Value.ToString() == "True")
                {                    
                    db.execQuery("delete from usuario where id = '" + dr.Cells[1].Value.ToString() + "';");
                    db.execQuery("delete from usuario_empresa where usuario = '" + dr.Cells[2].Value.ToString() + "';");
                    //Implementar código para excluir usuários e empresas do usuário                    
                }
            }
            GetDataUser("SELECT id, usuario, nome, email FROM usuario");
        }
    }
}
