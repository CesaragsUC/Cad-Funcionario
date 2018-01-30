using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadFuncionario.Models
{
    public class FuncionarioDetalhe
    {

        [Key]
        public int FuncionarioDetalhesId { get; set; }


        public int FuncionarioID { get; set; }

        public int DepartamentoID { get; set; }

        public virtual Funcionario Func { get; set; }


      
        public virtual Departamento Dept { get; set; }
    }
}