using Microsoft.AspNetCore.Identity;
using Servicios.api.Seguridad.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.api.Seguridad.Core.Persistence
{
    public class SeguridadData
    {
        public static async Task InsertartUsuario(SeguridadContexto context, UserManager<Usuario> usuarioManager) {

            if (!usuarioManager.Users.Any()) {

                var usuario = new Usuario
                {
                    Nombre = "Roberto",
                    Apellido = "Pineda",
                    Direccion = "La Victoria",
                    UserName = "rpineda",
                    Email = "rpineda@x-codec.net"
                };

                await usuarioManager.CreateAsync(usuario, "Password123$");

            }

        }

    }
}
