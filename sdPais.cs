using System;
using System.Collections.Generic;
using System.Data;
using SistemaGYP.ENT;
using SistemaGYP.DAC;

namespace SistemaGYP.NEG
{
    public class sdPais: sdGenerales
    {
        /// <summary>
        /// Envía a buscar a la base de datos una lista o un registro
        /// </summary>
        /// <param name="Datos">Clase que contiene los criterios para seleccionar los datos de tipo cdMantenedorPais</param>
        /// <returns>Retorna los datos en un DataSet</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: Fecha 18/08/2017
        ///Modificacion:
        ///</History>/// 
        public DataSet LeerDataSet(cdPais Datos)
        {
            adPais adDatos = new adPais();
            try
            {
                return adDatos.LeerDataSet(Datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                adDatos = null;
            }
        }

        ///<summary>
        ///Envía a buscar a la base de datos una lista o un registro
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para seleccionar los datos de tipo cdPais</param>
        ///<returns>Retorna los datos en una lista</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: Fecha 18/08/2017
        ///Modificacion:
        ///</History>
        public List<cdPais> LeerLista(cdPais Datos)
        {
            adPais adDatos = new adPais();
            try
            {
                return adDatos.LeerLista(Datos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                adDatos = null; 
            }
        }

        ///<summary>
        ///Permite Insertar los datos de tipo TablaTipo
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para Insertar los datos de tipo cdPais</param>
        ///<returns>Retorna un DataSet con la respuesta</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: Fecha 21/08/2017
        ///</History>
        public DataSet Insertar(cdPais cdDatos)
        {
            adPais adDatos = new adPais();
            try
            {
               ValidarDatos(cdDatos);
                 GenerarError();

                return adDatos.Insertar(cdDatos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                adDatos = null;
            }
        }

        ///<summary>
        ///Envía a buscar a la base de datos una lista o un registro
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para seleccionar los datos de tipo cdPais</param>
        ///<returns>Retorna los datos en una lista</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: Fecha 21/08/2017
        ///Modificacion:
        ///</History>
        public List<cdPais> LeerFila(cdPais cdDatos)
        {
            adPais adDatos = new adPais();
            try
            {
                return adDatos.LeerFila(cdDatos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                adDatos = null;
            }
        }

        ///<summary>
        ///Permite actualizar los datos de tipo TablaTipo
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para Actualizar los datos de tipo cdPais</param>
        ///<returns>Retorna un DataSet con la respuesta</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: Fecha 21/08/2017
        ///Modificacion:
        ///</History>
        public DataSet Actualizar(cdPais cdDatos)
        {
            adPais adDatos = new adPais();
            try
            {
                return adDatos.Actualizar(cdDatos);
            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                adDatos = null;
            }

        }

        ///<summary>
        ///Permite borrar un registro asociado al IdTablaTipo
        ///</summary>
        ///<param name="Datos">Capa de transporte para entregar los parámetros de tipo cdPais</param>
        ///<returns>Retorna un DataSet con los registros</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: Fecha 21/08/2017
        ///Modificacion:
        ///</History>
        public void Eliminar(cdPais Datos)
        {
            adPais adDatos = new adPais();
            try
            {
                adDatos.Eliminar(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                adDatos = null;
            }
        }
        



        /// <summary>
        /// Método que permite realizar las reglas de negocio asociada a la capa de datos  
        /// </summary>
        /// <param name="Datos">Contiene los datos que se validarán</param>
        public void ValidarDatos(cdPais  Datos)
        {
            if (string.IsNullOrEmpty(Datos.Nombre))
                AgregarMensajeError("Debe ingresar Descripción");       

            
            
        }



    }
}
