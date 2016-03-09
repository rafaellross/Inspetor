using InspetorXML_Console.Classes;
using InspetorXML_Console.Classes.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Classes
{
    class ModeloUsuario
    {
        public string Id { get; set; } = null;
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        private DB db { get; set; }
        private Parametros parametros { get; set; }

        public ModeloUsuario()
        {
            this.parametros = new Parametros();
            this.parametros.carregaParametros();
            this.db = new DB(parametros.DBInspetorServer, parametros.DBInspetor, parametros.UserDBInspetor, parametros.PasswdDBInspetor);
        }

        public void carregaUsuario(string Id)
        {
            var usuario = this.db.consultaErp("select id, usuario, email, senha from usuario");
            this.Id = usuario[0];
            this.Usuario = usuario[1];
            this.Email = usuario[2];
            this.Senha = usuario[3];
        }

        public bool salva()
        {
            if (this.Id == null)
            {
                if (this.db.execQuery("insert into usuario(usuario, email, senha, nome) values('" + this.Usuario + "', '" + this.Email + "','" + this.Senha + "', '" + this.Nome + "');"))
                {
                    this.Id = this.getIdUsuario(this.Usuario);
                    return true;
                }
                else
                {
                    return false;
                }                
            }
            else
            {
                if (this.db.execQuery("update usuario set email = '" + this.Email + "', senha = '" + this.Senha + "', nome = '" + this.Nome + "' WHERE ID = '"+ this.Id +"';"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public string getIdUsuario(string usuario)
        {
            var consultaId = this.db.consultaErp("SELECT ID FROM USUARIO WHERE usuario = '" + usuario + "';");
            string result = "";
            if (consultaId.Count > 0)
            {
                result = consultaId[0];
            }
            return result;
        }
    }
}
