using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Script.Serialization;

namespace LojaOnline
{
    public partial class geraJSON : System.Web.UI.Page
    {
        private MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; user id=admin; password=te2023; database = lojaonline;");

        public string ToJSON(object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            conexao.Open();
            List<Produto> produtos = new List<Produto>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM produtos INNER JOIN categorias ON produtos.idcategoria = categorias.idcategoria", conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt32("idprod");
                string nome = reader.GetString("nomeprod");
                float preco = reader.GetFloat("preco");
                string nomecategoria = reader.GetString("nomecategoria");
                Produto prod = new Produto(id, nome, preco, nomecategoria);
                produtos.Add(prod);
            }
            string jsonString = ToJSON(produtos);
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
            Response.ContentType = "text/json";
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(jsonString);
            Response.End();
        }
    }
}