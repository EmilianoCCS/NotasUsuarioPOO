using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasEx
{
    public class Usuario
    {
        public string nome { get; set; }
        public int ID { get; set; }
        public string sexo { get; set; }
        public DateTime data_nasc { get; set; }



        public List<Comentarios> ListaCadas = new List<Comentarios>();

      
    }
}
