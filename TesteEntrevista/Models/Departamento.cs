using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadFuncionario.Models
{
    public class Departamento
    {

       
        public int DepartamentoID { get; set; }


        [Display(Name = "Departamento")]
        public string DEPARTAMENTO_NOME { get; set; }


        [Display(Name = "Sala")]
        public string DEPARTAMENTO_SALA { get; set; }


        [Display(Name = "Andar")]
        public string ANDAR { get; set; }


        public virtual ICollection<Funcionario> Funcionarios { get; set; }



    }
}