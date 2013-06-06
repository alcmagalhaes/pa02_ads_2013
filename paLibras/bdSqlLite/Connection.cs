using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace testeSQLite
{
    class Connection
    {
        // C:\Mateus\Faculdade\2periodo\pa\sqlite\libras.s3db
        private static SQLiteConnection conexao = new SQLiteConnection("Data Source= " + System.IO.Directory.GetCurrentDirectory() + @"\libras.s3db;
                                                                        Version=3;New=False;Compress=True;");

        public static void conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();

            }
        }

        public static void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public static bool testaConexao()
        {
            return conexao.State == System.Data.ConnectionState.Open;
        }

        public static string BuscaPalavra(int id)
        {
            string p="";
            try
            {
                conexao.Open();
                SQLiteCommand comando = conexao.CreateCommand();                
                comando.CommandText = "SELECT palavra FROM palavras WHERE id = " + id;
                SQLiteDataReader dr = comando.ExecuteReader();
                dr.Read();
                p = dr["palavra"].ToString();
                
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexao.Close();
            }

            return p;
        }
    }
}
