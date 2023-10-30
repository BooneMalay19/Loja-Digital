using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaOnline
{
    public class Produto
    {
        private int idprod;
        private string nomeprod;
        private float preco;
        private string nomecategoria;
        public Produto(int idprod, string nomeprod, float preco, string nomecategoria)
        {
            this.idprod = idprod;
            this.nomeprod = nomeprod;
            this.preco = preco;
            this.nomecategoria = nomecategoria;
        }

        public int Idprod { get => idprod; set => idprod = value; }
        public string Nomeprod { get => nomeprod; set => nomeprod = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Nomecategoria { get => nomecategoria; set => nomecategoria = value; }
    }
}