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

        public DB db { get; set; }
        private Parametros parametros { get; set; }
        public string Ativo { get; internal set; }
        public string Administrador { get; internal set; }

        public ModeloUsuario()
        {
            this.parametros = new Parametros();
            this.parametros.carregaParametros();
            this.db = new DB(parametros.DBInspetorServer, parametros.DBInspetor, parametros.UserDBInspetor, parametros.PasswdDBInspetor);
        }

        public void carregaUsuario(string Id)
        {
            var usuario = this.db.consultaErp("select id, usuario, email, senha, ativo, administrador from usuario where id = '" + Id +"'");
            this.Id = usuario[0];
            this.Usuario = usuario[1];
            this.Email = usuario[2];
            this.Senha = usuario[3];
            this.Ativo = usuario[4];
            this.Administrador = usuario[5];
        }

        public bool salva()
        {
            if (this.Id == null || this.Id == "")
            {
                if (this.db.execQuery("insert into usuario(usuario, email, senha, nome, ativo, administrador) values('" + this.Usuario + "', '" + this.Email + "','" + this.Senha + "', '" + this.Nome + "', " + this.Ativo + ", " + this.Administrador +");"))
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
                if (this.db.execQuery("update usuario set email = '" + this.Email + "', senha = '" + this.Senha + "', nome = '" + this.Nome + "', ativo = " + this.Ativo + ", administrador = " + this.Administrador + "WHERE ID = '"+ this.Id +"';"))
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
        
        public void salvaEmpresaUsuario(string usuario, string empresa, string filial)
        {
            var qry = "SELECT usuario from usuario_empresa where usuario = '" + usuario + " and codemp = '" + empresa + "' and codfilial = '" + filial + "';";
            if (db.consultaErp(qry).Count == 0)
            {
                db.execQuery("insert into usuario_empresa(usuario, codemp, codfilial, ativo) values('" + usuario + "', '" + empresa + "', '" + filial + "', 1);");
            }
        }
        
    }
}
