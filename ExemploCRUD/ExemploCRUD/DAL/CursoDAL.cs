using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploCRUD.DAL
{
    class CursoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Curso a)
        {
            //Instanciar um objeto de comando SQL.
            SqlCommand cmd = new SqlCommand();
            //Configurar a conexao.
            cmd.Connection = con.Conectar();
            //Configurar o comando SQL.
            cmd.CommandText = @"INSERT INTO TB_CURSO(                                 
                                    Nome,
                                    Cod_Coordenador
                                    )
                                VALUES(@nome, @codCoord)";
            //Configurar os valores.
            //cmd.Parameters.AddWithValue("@cod", a.Cod);
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@CodCoord", a.Cod_coordenador);                  
            //Executar os comandos SQL.
            cmd.ExecuteNonQuery();
            //Fechar a conexão com o banco de dados.
            con.Desconectar();
        }

       

        public DataTable Consultar()
        {
            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    C.Cod,
                                    C.Nome AS NomeCurso,
                                    C.Cod_Coordenador,
                                    CD.Nome AS NomeCoordenador                               
                                FROM
                                    TB_Curso AS C
                                INNER JOIN 
                                    TB_COORDENADOR AS CD
                                 ON C.Cod_Coordenador = CD.Cod";          
            SqlDataAdapter da = new SqlDataAdapter();          
            da.SelectCommand = cmd;           
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }

       
    }
}
