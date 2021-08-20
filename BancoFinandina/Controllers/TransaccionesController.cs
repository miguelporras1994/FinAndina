using BusinessAcessLayer.Interface;
using BusinessAcessLayer.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoFinandina.Controllers
{
    public class TransaccionesController : Controller
    {
         
        private IRepositorioCliente _RepositorioCliente;
        private IRepositorioTransacciones _RepositorioTransacciones;
        private IRepositorioTipoTransacciones _RepositorioTipoTransacciones;



        public TransaccionesController()
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




        // GET: Libros
        public ActionResult Index()
        {




            return View();
        }



        [HttpPost]
        public JsonResult GetCliente( )
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


        //public JsonResult EditTeam(int id)


        //{

        //    var Obtener = _RepositorioCliente.ObtenerLibrosId(id);




        //    object[] Mostrar = { Obtener };


        //    var retorno = Json(Mostrar);
        //    return retorno;



        //}




        //public JsonResult ValidarComplemento(string valores)
        //{


        //    List<object[]> Info = new List<object[]>();
        //    var retorno = Json(Info);



        //    switch (valores)
        //    {



        //        case "Estado":






        //            var Estado = _RepositorioEstado.ObtenerTodosEstado();

        //            retorno = Json(Estado);
        //            break;

        //        case "TipoTransacciones":





        //            var TipoTransacciones = _RepositorioTipoTransacciones.ObtenerTodosTipoTransacciones();


        //            retorno = Json(TipoTransacciones);


        //            break;


        //        case "Transacciones":


        //            var Transacciones = _RepositorioTransacciones.ObtenerTodosTransacciones();





        //            retorno = Json(Transacciones);


        //            break;




        //    }

        //    return retorno;
        //}



        //public string SaveTeam(int Id, string Titulo, string Autor, string Mar, string Transacciones, string State, string difference)
        //{
        //    var Save = "Save";

        //    ModeloEstado ConsuEstado = _RepositorioEstado.ObtenerEstadoNom(State);
        //    ModeloTransacciones ConsuTransacciones = _RepositorioTransacciones.ObtenerTransaccionesNom(Transacciones);
        //    ModeloTipoTransacciones ConsuTipoTransacciones = _RepositorioTipoTransacciones.ObtenerTipoTransaccionesNom(Mar);

        //    if (difference == "Create")
        //    {

        //        ModeloLibro Team = new ModeloLibro()
        //        {

        //            Id_Libro = Id,
        //            Titulo = Titulo,
        //            Id_Transacciones = ConsuTransacciones.Id_Transacciones,
        //            Transacciones = Transacciones,
        //            Id_TipoTransacciones = ConsuTipoTransacciones.Id_TipoTransacciones,
        //            TipoTransacciones = Mar,
        //            Id_Estado = ConsuEstado.Id_Estado,
        //            Nom_Estado = State,
        //            Autor = Autor,
        //        };
        //        _RepositorioCliente.AgregarLibros(Team);

        //    }
        //    if (difference == "Edit")
        //    {



        //        ModeloLibro Team = new ModeloLibro()
        //        {
        //            Id_Libro = Id,
        //            Titulo = Titulo,
        //            Id_Transacciones = ConsuTransacciones.Id_Transacciones,
        //            Transacciones = Transacciones,
        //            Id_TipoTransacciones = ConsuTipoTransacciones.Id_TipoTransacciones,
        //            TipoTransacciones = Mar,
        //            Id_Estado = ConsuEstado.Id_Estado,
        //            Nom_Estado = State,
        //            Autor = Autor,
        //        };

        //        _RepositorioCliente.EditarLibros(Team);


        //    }












        //    return Save;
        //}

    }
}