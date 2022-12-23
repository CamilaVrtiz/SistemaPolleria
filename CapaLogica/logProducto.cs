﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public DataSet ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        public DataSet ListarProductoConCategoria()
        {
            return datProducto.Instancia.ListarProductoConCategoria();
        }

        ///inserta
        public void InsertaProducto(entProducto Pro)
        {
            datProducto.Instancia.InsertaProducto(Pro);
        }

        //edita
        public void EditaProducto(entProducto Pro)
        {
            datProducto.Instancia.EditaProducto(Pro);
        }
        public Boolean EliminaProductos(entProducto Pro)
        {
            try
            {
                return datProducto.Instancia.EliminaProductos(Pro);
            }
            catch (Exception e) { throw e; }
        }
        public DataSet ConsultaProductoId(int codigoProducto)
        {
            return datProducto.Instancia.ConsultaProductoId(codigoProducto);
        }
        public entProducto BuscaProductoId(int codigoProducto)
        {
            try
            {
                return datProducto.Instancia.BuscaProductoId(codigoProducto);
            }
            catch (Exception e) { throw e; }
        }
        public DataSet BuscaProducto(string n)
        {
            return datProducto.Instancia.BuscaProducto(n);
        }
        public DataSet BuscaProductoConCategoria(string n)
        {
            return datProducto.Instancia.BuscaProductoConCategoria(n);
        }
        public DataSet BuscaNombreProducto(string n)
        {
            return datProducto.Instancia.BuscaNombreProducto(n);
        }
        #endregion metodos

    }
}
