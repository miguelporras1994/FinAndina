using BusinessAcessLayer.Interface;
using BusinessAcessLayer.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoFinandina.Controllers
{
    public class ClienteController : Controller

    {


        private IRepositorioCliente _RepositorioCliente;
        private IRepositorioTransacciones _RepositorioTransacciones;
        private IRepositorioTipoTransacciones _RepositorioTipoTransacciones;



        public ClienteController()
        {

            if (_RepositorioCliente == null)
            {
                _RepositorioCliente = new RespositorioCliente();
            }
            if (_RepositorioTransacciones == null)
            {
                _RepositorioTransacciones = new RespositorioTransacciones();
            }
            if (_RepositorioTipoTransacciones == null)
            {
                _RepositorioTipoTransacciones = new RespositorioTipoTransacciones();
            }



        }





        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public JsonResult GetCliente()
        {

            var listarCliente = _RepositorioCliente.ObtenerTodosCliente().ToList();



            string Paginador = "";




            List<object[]> datos = new List<object[]>();


            string Filtrar = "  ";

            foreach (var data in listarCliente)
            {


                Filtrar += "<center>" + "<tr>" +
                "<td>" + data.Nombre + "</td>" +
                 "<td>" + data.Telefono + "</td>" +
                  "<td>" + data.Cuidad + "</td>" +
                   "<td>" + "<a class='btn btn-primary' data-toggle='modal' data-target='#EditTeam' onclick='EditTeam(" + data.Numero_Identificacion + ")'>Ir Cuenta</a>" + "</td>";


            }


            object[] Mostrar = { Filtrar, Paginador };

            datos.Add(Mostrar);
            var retorno = Json(Mostrar);
            return retorno;


        }

    }
}