using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestComprimirDescomprimirZip
{
    
    public class Sistema
    {

        public static bool _isMaster { get; set; }

        public static string _ServidorHost { get; set; }
        public static string _ServidorBD { get; set; }

        public static string _FtpHost { get; set; }
        public static string _FtpUser { get; set; }
        public static string _FtpClave { get; set; }

        public static string _IdSucursal { get; set; }
        public static string _RutaUbicacionBoletin { get; set; }
        public static string _RutaUbicacionCierre { get; set; }

        public static string _RutaMaster_ParaAlojarBoletin { get; set; }

        public static string _RutaParaCrearArchivoCierre  {get;set;}
        public static string _RutaParaAlojarCierre  {get;set;}
        public static string _RutaParaAlojarBoletin {get;set;}
        public static string _RutaParaDescomprimirBoletin {get;set;}

        public static string[] _ListaSucursalesEnviarBoletin { get; set; }

    }

}