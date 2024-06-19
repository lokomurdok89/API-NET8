using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
    }
}