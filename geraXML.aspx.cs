using MySql.Data.MySqlClient;
using System;
using System.Web;

namespace LojaOnline
{
    public partial class geraXML : System.Web.UI.Page
    {
        private MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; user id=admin; password=te2023; database = lojaonline;");

        protected void Page_Load(object sender, EventArgs e)
        {
            string xmlString = "<produtos>";
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM produtos INNER JOIN categorias ON produtos.idcategoria = categorias.idcategoria", conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {                
                int id = reader.GetInt32("idprod");
                string nome = reader.GetString("nomeprod");
                float preco = reader.GetFloat("preco");
                string nomecategoria = reader.GetString("nomecategoria");
                xmlString += "<produto>";
                xmlString += "<idprod>" + id + "</idprod>";
                xmlString += "<nomeproduto>" + nome + "</nomeproduto>";
                xmlString += "<preco>" + preco+ "</preco>";
                xmlString += "<nomecategoria>" + nomecategoria + "</nomecategoria>";
                xmlString += "</produto>";
            }
            xmlString += "</produtos>";
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
            Response.ContentType = "text/xml";
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(xmlString);
            Response.End();
        }

    }
 }
