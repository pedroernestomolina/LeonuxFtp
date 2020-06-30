using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestComprimirDescomprimirZip
{

    public class ResultadoEntidad<T> : Resultado
    {

        public T Entidad { get; set; }

        public ResultadoEntidad()
            : base()
        {
        }

    }

}
