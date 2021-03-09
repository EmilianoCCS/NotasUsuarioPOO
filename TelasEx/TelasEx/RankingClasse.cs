using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasEx
{

    public class RankingClasse
    {
        private Usuario item;
        private Comentarios item1;

        public RankingClasse(Usuario item)
        {
            this.item = item;
            this.Id = item.ID;
            this.Nome = item.nome;
            this.usuario = item;
            GerarRanking();
        }

        public RankingClasse(Comentarios item1)
        {
        }

        public string Nome { get; set; }
        public string Comentario { get; set; }
        public int Id { get; set; }
        public int Total { get; set; }
        public float Media { get; set; }
        private Usuario usuario { get; set; }


        public void GerarRanking()
        {
            Total = usuario.ListaCadas.Count;
            int soma = 0;
            foreach (Comentarios a in usuario.ListaCadas)
            {
                soma = soma + a.Estrela;
                Media = soma / Total;
            }

        }

        public Usuario getUsuario()
        {
            return usuario;
        }
       
           
    }
}

