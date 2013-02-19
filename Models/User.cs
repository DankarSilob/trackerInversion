using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace trackerInversion.Models
{
    public class User
    {
        [Required(ErrorMessage="El nombre de usuario es necesario")]
        [Display(Name= "Usuario")]
        public string Usuario {get; set;}

        [Required(ErrorMessage = "La contraseña es necesaria")]
        [DataType(DataType.Password)]
        [Display(Name= "Contrasena")]
        public string Password {get; set;}

        public bool IsValid(string _usuario, string _password)
        {
            return true;
        }
    }


}