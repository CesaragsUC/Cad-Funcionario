using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadFuncionario.Models
{
    public class Funcionario
    {
       
        public int FuncionarioID { get; set; }

        [Display(Name ="Email")]
        public string FUNCIONARIO_EMAIL { get; set; }

        [Display(Name = "Nome")]
        public string FUNCIONARIO_NOME { get; set; }

        [Display(Name = "Cidade")]
        public string FUNCIONARIO_CIDADE { get; set; }


        [Display(Name = "Endereço")]
        public string FUNCIONARIO_ENDERECO { get; set; }

        [Display(Name = "CPF")]
        public string FUNCIONARIO_CPF { get; set; }


        [Display(Name = "Telefone")]
        public string FUNCIONARIO_TELEFONE { get; set; }

        public int DepartamentoID { get; set; }


        [ ForeignKey("DepartamentoID")]
        public virtual  Departamento Departamento { get; set; }


    }
}