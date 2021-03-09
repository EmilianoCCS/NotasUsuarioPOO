using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasEx
{

    public class Comentarios
    {
        public Comentarios(Comentarios item)
        {
            this.Estrela = Estrela;
            this.Comentario = Comentario;
        }


        public int Estrela { get; set; }
        public string Comentario { get; set; }

    } 
}
