using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ExemploCRUD.DAL
{
    class LoginDAL
    {
        Conexao con = new Conexao();

        public BLL.Login Autenticar(BLL.Login l)
        {
            //l.Autenticado = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    USUARIO,
                                    SENHA
                                FROM
                                    TB_LOGIN
                                WHERE
                                    USUARIO = @usuario
                                AND
                                    SENHA = @senha";
            cmd.Parameters.AddWithValue("@usuario", l.Usuario);
            cmd.Parameters.AddWithValue("@senha", Embaralhar(l.Senha));
            
            SqlDataReader dr = cmd.ExecuteReader();

            l.Autenticado = dr.HasRows;

            con.Desconectar();

            return l;
        }

        private string Embaralhar(string senha)
        {
            string resultado = string.Empty;

            MD5 embaralhador = MD5.Create();

            byte[] vetorSenhaByte = System.Text.Encoding.UTF8.GetBytes(senha);

            byte[] vetorSenhaByetEmbaralhada = embaralhador.ComputeHash(vetorSenhaByte);

            foreach (byte b in vetorSenhaByetEmbaralhada)
            {
                resultado += b.ToString("X2");
            }

            return resultado;
         }
    }
}
