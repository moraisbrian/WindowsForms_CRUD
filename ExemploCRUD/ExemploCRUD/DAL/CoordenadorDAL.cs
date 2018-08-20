using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploCRUD.DAL
{
    class CoordenadorDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Coordenador a)
        {
            
            SqlCommand cmd = new SqlCommand();            
            cmd.Connection = con.Conectar();            
            cmd.CommandText = @"INSERT INTO TB_COORDENADOR(                                   
                                    Nome,
                                    Idade,
                                    Salario)
                                VALUES(@nome,@idade,@salario)";
                       
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@idade", a.Idade);
            cmd.Parameters.AddWithValue("@salario", a.Salario);
            
            cmd.ExecuteNonQuery();
            
            con.Desconectar();
        }   

        public DataTable Consultar()
        {
           
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Nome,
                                    Idade,
                                    Salario
                                FROM
                                    TB_COORDENADOR";
            
            SqlDataAdapter da = new SqlDataAdapter();
            
            da.SelectCommand = cmd;
            
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public DataTable Consultar(BLL.Coordenador a)
        {
            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Nome,
                                    Idade,
                                    Salario
                                FROM
                                    TB_COORDENADOR
                                WHERE
                                    Nome like @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + a.Nome + "%");           
            SqlDataAdapter da = new SqlDataAdapter();            
            da.SelectCommand = cmd;            
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public void Excluir(BLL.Coordenador a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    TB_COORDENADOR
                                WHERE
                                    Cod = @cod";
            cmd.Parameters.AddWithValue("@cod", a.Cod);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Coordenador PreecheAluno(BLL.Coordenador a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Nome,
                                    Salario,
                                    Idade
                                FROM 
                                    TB_COORDENADOR
                                WHERE 
                                    Cod = @cod";
            cmd.Parameters.AddWithValue("@cod", a.Cod);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                a.Cod = Convert.ToInt16(dr["Cod"]);
                a.Nome = dr["Nome"].ToString();
                a.Salario = Convert.ToDouble(dr["Salario"]);
                a.Idade = Convert.ToInt16(dr["Idade"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                a.Cod = 0;
            }

            return (a);

        }

        public void Atualizar(BLL.Coordenador a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    TB_COORDENADOR
                                SET
                                    Nome = @nome,
                                    Salario = @salario,
                                    Idade = @idade                                    
                                WHERE
                                    Cod = @cod";
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@salario", a.Salario);
            cmd.Parameters.AddWithValue("@idade", a.Idade);
            cmd.Parameters.AddWithValue("@cod", a.Cod);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
