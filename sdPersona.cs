using System;
using System.Collections.Generic;
using System.Data;
using SistemaGYP.ENT;
using SistemaGYP.DAC;

namespace SistemaGYP.NEG
{
    public class sdPersona : sdGenerales
    {
        ///<summary>
        ///Envía a buscar a la base de datos una lista o un registro
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para seleccionar los datos de tipo cdPersona</param>
        ///<returns>Retorna los datos en una lista</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: 06/16/2017
        ///Modificacion:
        ///</History>
        public List<cdPersona> LeerLista(cdPersona Datos)
        {
            adPersona adDatos = new adPersona();
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
        ///Envía a buscar a la base de datos una lista o un registro
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para seleccionar los datos de tipo cdPersona</param>
        ///<returns>Retorna los datos en una lista</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: 06/10/2017
        ///Modificacion:
        ///</History>
        public List<cdPersona> LeerFila(cdPersona cdDatos)
        {
            adPersona adDatos = new adPersona();
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
        ///Permite actualizar los datos de tipo persona
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para Actualizar los datos de tipo cdPersona</param>
        ///<returns>Retorna un DataSet con la respuesta</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: 06/10/2017
        ///Modificacion:
        ///</History>
        public DataSet Actualizar(cdPersona cdDatos)
        {
            adPersona adDatos = new adPersona();
            try
            {
                ValidarDatos(cdDatos);
                GenerarError();
                return adDatos.Actualizar(cdDatos);
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
        ///Permite Insertar los datos de tipo Persona
        ///</summary>
        ///<param name="Datos">Clase que contiene los criterios para Insertar los datos de tipo cdErpsona</param>
        ///<returns>Retorna un DataSet con la respuesta</returns>
        ///<History>
        ///Autor: Marcelo Lieneros
        ///Fecha Creacion: 06/10/2017
        ///</History>
        public DataSet Insertar(cdPersona cdDatos)
        {
            adPersona adDatos = new adPersona();
            try
            {
                //ValidarDatos(cdDatos);
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
        ///Permite borrar un registro asociado al IdTablaTipo
        ///</summary>
        ///<param name="Datos">Capa de transporte para entregar los parámetros de tipo cdPersona</param>
        ///<returns>Retorna un DataSet con los registros</returns>
        ///<History>
        ///Autor: Marcelo Lineros
        ///Fecha Creacion: 06/10/2017
        ///Modificacion:
        ///</History>
        public void Eliminar(cdPersona Datos)
        {
            adPersona adDatos = new adPersona();
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
        public void ValidarDatos(cdPersona Datos)
        {
            if (string.IsNullOrEmpty(Datos.Nombres))
                AgregarMensajeError("Debe ingresar Nombre");


        }

    }
}
