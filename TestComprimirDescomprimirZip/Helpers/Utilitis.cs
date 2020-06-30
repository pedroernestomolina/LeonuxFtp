using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace TestComprimirDescomprimirZip.Helpers
{

    public class Utilitis
    {

        static public Resultado CargarXml()
        {
            var result = new Resultado();

            try
            {
                var doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Conf.XML");

                if (doc.HasChildNodes)
                {
                    foreach (XmlNode nd in doc)
                    {
                        if (nd.LocalName.ToUpper().Trim() == "CONFIGURACION")
                        {
                            foreach (XmlNode nv in nd.ChildNodes)
                            {
                                if (nv.LocalName.ToUpper().Trim() == "MODO")
                                {
                                    if (nv.InnerText.Trim().ToUpper() == "MASTER") 
                                    {
                                        Sistema._isMaster = true;
                                    }
                                }

                                if (nv.LocalName.ToUpper().Trim() == "SUCURSAL")
                                {
                                    foreach (XmlNode sc in nv.ChildNodes)
                                    {
                                        if (sc.LocalName.ToUpper().Trim() == "ID")
                                        {
                                            Sistema._IdSucursal = sc.InnerText.Trim().ToUpper();
                                        }
                                        if (sc.LocalName.ToUpper().Trim() == "RUTAUBICACIONBOLETIN")
                                        {
                                            Sistema._RutaUbicacionBoletin = sc.InnerText.Trim();
                                        }
                                        if (sc.LocalName.ToUpper().Trim() == "RUTAUBICACIONCIERRE")
                                        {
                                            Sistema._RutaUbicacionCierre = sc.InnerText.Trim();
                                        }
                                    }
                                }


                                if (nv.LocalName.ToUpper().Trim() == "SERVIDOR")
                                {
                                    foreach (XmlNode sv in nv.ChildNodes)
                                    {
                                        if (sv.LocalName.Trim().ToUpper() == "HOST")
                                        {
                                            Sistema._ServidorHost = sv.InnerText.Trim();
                                        }
                                        if (sv.LocalName.Trim().ToUpper() == "BD")
                                        {
                                            Sistema._ServidorBD = sv.InnerText.Trim();
                                        }
                                    }
                                }

                                if (nv.LocalName.ToUpper().Trim() == "ENVIARBOLETINA")
                                {
                                    Sistema._ListaSucursalesEnviarBoletin = nv.InnerText.Trim().Split(',');
                                }

                                if (nv.LocalName.ToUpper().Trim() == "DATALOCAL")
                                {
                                    //_DataLocal = nv.InnerText.Trim();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                result.Result = Enumerados.EnumResult.isError;
                result.Mensaje = e.Message;
            }

            return result;
        }

    }

}