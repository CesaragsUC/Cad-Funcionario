using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadFuncionario.Models
{
    public class Usuario
    {

        public int UsuarioID { get; set; }

        public string USER_NAME { get; set; }
  
        public string USER_SENHA { get; set; }

        public string PERFIL  { get; set; }
        public string ATIVO { get; set; }
    }
}