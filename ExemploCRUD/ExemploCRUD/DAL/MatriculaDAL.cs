using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ExemploCRUD.DAL
{
    class MatriculaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Matricula a)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TB_MATRICULA(                                 
                                    Cod_Curso,
                                    RA_Aluno,
                                    Data_Matricula
                                    )
                                VALUES(@Cod_Curso, @RA_Aluno, @Data_Matricula)";
            cmd.Parameters.AddWithValue("@Cod_Curso", a.Cod_curso);
            cmd.Parameters.AddWithValue("@RA_Aluno", a.Ra_aluno);
            cmd.Parameters.AddWithValue("@Data_Matricula", a.Data_matricula);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }



        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    TB_CURSO.Cod,
                                    TB_ALUNO.RA,
                                    TB_MATRICULA.Data_Matricula                                                               
                                FROM
                                    TB_MATRICULA
                                INNER JOIN 
                                    TB_ALUNO
                                ON TB_MATRICULA.RA_Aluno = TB_ALUNO.RA
                                INNER JOIN 
                                    TB_CURSO
                                 ON TB_MATRICULA.Cod_Curso = TB_CURSO.Cod";                                
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }

    }
}
