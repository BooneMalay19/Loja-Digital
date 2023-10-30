using MySql.Data.MySqlClient;
using System;


namespace LojaOnline
{
    public partial class autentica : System.Web.UI.Page
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private MySqlDataReader rs;
        private String sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            String idusuario, senhausuario;
            try
            {
                conexao = new MySqlConnection("server = localhost; port = 3306; user id=admin; password=te2023; database=lojaonline; ");
                conexao.Open();

                idusuario = Convert.ToString(Request.Params["idusuario"]);
                senhausuario = Convert.ToString(Request.Params["senhausuario"]);
                sql = "SELECT nomeusuario,idusuario,senhausuario FROM usuarios WHERE idusuario = @idusuario and senhausuario = @senhausuario";
                command = new MySqlCommand(sql, conexao);
                command.Parameters.AddWithValue("@idusuario", idusuario);
                command.Parameters.AddWithValue("@senhausuario", senhausuario);
                command.Prepare();
                rs = command.ExecuteReader();
                if (rs.Read())
                {
                    Session["idusuario"] = rs.GetString("idusuario");
                    Session["nomeusuario"] = rs.GetString("nomeusuario");
                    Response.Redirect("menu.aspx");
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            finally
            {
                if(conexao!=null)conexao.Close();
                if(rs!=null)rs.Close();
            }
        }
               
    }
}