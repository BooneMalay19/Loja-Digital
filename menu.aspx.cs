using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace LojaOnline
{
    public partial class menu : System.Web.UI.Page
    {
        private MySqlConnection conexao;
        private MySqlCommand command;
        private MySqlDataAdapter ad;
        private String sql;        
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            conexao = new MySqlConnection("server = localhost; port = 3306; user id = admin; password = te2023; database = lojaonline;");         
            String nomeusuario, idusuario;
            try
            {
                if (String.IsNullOrEmpty((String)Session["idusuario"])
                    || String.IsNullOrEmpty((String)Session["nomeusuario"]))
                {
                    Response.Redirect("index.aspx");
                }
                nomeusuario = Convert.ToString(Session["nomeusuario"]);
                idusuario = Convert.ToString(Session["idusuario"]);
                Label4.Text = "Seja bem-vindo(a) " + nomeusuario + "(" + idusuario + ")" + " e boas compras! ";
                conexao.Open();
                //Vamos adicionar INNER JOIN, para mostrar o nome do produto, que é
                //um campo da tabela 'produtos':
                sql = "SELECT idproduto, nomeprod, qtdecomprada FROM comprasefetuadas "
                    + " INNER JOIN produtos ON produtos.idprod = comprasefetuadas.idproduto "
                    + " WHERE idusuario = " + idusuario ;
                command = new MySqlCommand(sql, conexao);
                DataTable dt = new DataTable();
                ad = new MySqlDataAdapter(command);
                ad.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Erro " + ex.Message);

            }
            finally
            {
                if (conexao != null) conexao.Close();
                if (command != null) command.Dispose();
            }
        }

        protected void GridView1_RowDataBound(object o, GridViewRowEventArgs e)
        {
            //Para alinhar a coluna dos nomes dos produtos à esquerda:
            e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Left;
            //Temos que adicionar também o atributo a seguir na tag do GridView1:
            //   OnRowDataBound = "GridView1_RowDataBound"
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("index.aspx");
        }

      
    }
}