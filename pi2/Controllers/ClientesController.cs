using pi2.Models;
using pi2.Security;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;

namespace pi2.Controllers
{
    [EnableCors("*", "*", "*")]
    

    public class ClientesController : ApiController
    {
        proyectoEntities bd = new proyectoEntities();

        
        public IEnumerable<Clientes> GetAll()
        {
            return bd.Clientes.ToList();
        }


        //[AllowAnonymous]
        //comentandoooo
        //Comentario de wilfrid
        public Boolean Post(Clientes reg)
        {


            try
            {
                Clientes obj = new Clientes();

                obj.NombreCliente = reg.NombreCliente;
                obj.ApellidosCliente = reg.ApellidosCliente;
                obj.Email = reg.Email;
                obj.TelefonoCliente = reg.TelefonoCliente;
                obj.Password = reg.Password;
                bd.Clientes.Add(obj);
                bd.SaveChanges();


            }
            catch (Exception) { }
            return true;
        }


        
        
       public Clientes login(string Email, string Password)
        {
            
  return bd.Clientes.FirstOrDefault(p => p.Email == Email && p.Password == Password);
                       
        }

        //Estuvimo comentando

        
       
        





        //[AllowAnonymous]
        //[Route("login")]
        // public IHttpActionResult Login(string username, string password)
        // {
        //   string username2= Thread.CurrentPrincipal.Identity.Name;
        //   using (proyectoEntities entities = new proyectoEntities())

        //   {


        //      if (username2.StartsWith("xxx") { 
        //      return Ok(new { success = false, message = "User code or password is incorrect" });
        //}
        //     return Ok(new { success = true });
        //
        //   }
        //    }

        //   [BasicAuthentication]
        //  [HttpPost]
        //  [Route("login")]
        //  public HttpResponseMessage  Get()
        //  {

        //  string username = Thread.CurrentPrincipal.Identity.Name;

        //   using (proyectoEntities entities = new proyectoEntities())
        // {
        //    if (username.Contains(".com"))
        //    {

        //       return Request.CreateResponse(HttpStatusCode.OK,
        //        entities.Clientes.ToList());
        //   } else {
        //    return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }



        //   }
        //   }
    }
    
}
