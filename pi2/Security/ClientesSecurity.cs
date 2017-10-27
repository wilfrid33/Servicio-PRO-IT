using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pi2.Models;

namespace pi2.Security
{
    public class ClientesSecurity


    {

        public static bool Login(string username, string password)
        {
          using (proyectoEntities entities = new proyectoEntities())
            {
               return entities.Clientes.Any(user =>
                  user.Email.Equals(username, StringComparison.OrdinalIgnoreCase)
                  && user.Password == password);
            }
        }

    }
}