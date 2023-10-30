using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace LojaOnline
{
    public partial class listar : System.Web.UI.Page
    {
        private MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; user id=admin; password=te2023; database = lojaonline;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((String)Session["idusuario"])
                || String.IsNullOrEmpty((String)Session["nomeusuario"]))
            {
                Response.Redirect("index.aspx");
            }
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM produtos INNER JOIN categorias ON produtos.idcategoria = categorias.idcategoria", conexao);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("menu.aspx");
        }

        protected void GridView1_RowDataBound(object o, GridViewRowEventArgs e)
        {
            //Para alinhar a coluna dos nomes dos produtos à esquerda:
            e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Left;
            //Temos que adicionar também o atributo a seguir na tag do GridView1:
            //   OnRowDataBound = "GridView1_RowDataBound"
        }
    }
}