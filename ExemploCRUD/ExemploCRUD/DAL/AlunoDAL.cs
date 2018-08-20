using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploCRUD.DAL
{
    class AlunoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Aluno a)
        {
            //Instanciar um objeto de comando SQL.
            SqlCommand cmd = new SqlCommand();
            //Configurar a conexao.
            cmd.Connection = con.Conectar();
            //Configurar o comando SQL.
            cmd.CommandText = @"INSERT INTO TB_ALUNO(
                                    RA,
                                    NOME,
                                    CPF,
                                    IDADE)
                                VALUES(@ra,@nome,@cpf,@idade)";
            //Configurar os valores.
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@cpf", a.Cpf);
            cmd.Parameters.AddWithValue("@idade", a.Idade);
            //Executar os comandos SQL.
            cmd.ExecuteNonQuery();
            //Fechar a conexão com o banco de dados.
            con.Desconectar();
        }

        public DataTable Consultar()
        {
            //Tabela de dados no padrão C# (String, double, float, int...).
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    RA,
                                    Nome,
                                    CPF,
                                    Idade
                                FROM
                                    TB_ALUNO";
            //Adaptador de dados padrão SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar qual comando de consulta
            da.SelectCommand = cmd;
            //Preencher o DataTable com o resultado adaptado da consulta
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        //Sobrecarga do metodo consultar (Filtro).
        public DataTable Consultar(BLL.Aluno a)
        {
            //Tabela de dados no padrão C# (String, double, float, int...).
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    RA,
                                    Nome,
                                    CPF,
                                    Idade
                                FROM
                                    TB_ALUNO
                                WHERE
                                    Nome like @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + a.Nome + "%");
            //Adaptador de dados padrão SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar qual comando de consulta
            da.SelectCommand = cmd;
            //Preencher o DataTable com o resultado adaptado da consulta
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public void Excluir(BLL.Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    TB_ALUNO
                                WHERE
                                    RA = @ra";
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Aluno PreecheAluno(BLL.Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    RA,
                                    Nome,
                                    CPF,
                                    Idade
                                FROM 
                                    TB_ALUNO
                                WHERE 
                                    RA = @ra";
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                a.Ra = dr["RA"].ToString();
                a.Cpf = dr["NOME"].ToString();
                a.Nome = dr["CPF"].ToString();
                a.Idade = Convert.ToInt16(dr["IDADE"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                a.Ra = "Inválido";
            }

            return (a);

        }

        public void Atualizar(BLL.Aluno a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    TB_ALUNO
                                SET
                                    Nome = @nome,
                                    CPF = @cpf,
                                    Idade = @idade
                                WHERE
                                    RA = @ra";
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@cpf", a.Cpf);
            cmd.Parameters.AddWithValue("@idade", a.Idade);
            cmd.Parameters.AddWithValue("@ra", a.Ra);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
