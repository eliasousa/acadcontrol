//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcadControl.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Historico
    {
        public int ano { get; set; }
        public int semestre { get; set; }
        public int id_aluno { get; set; }
        public int id_disc { get; set; }
        public bool situacao { get; set; }
        public double media { get; set; }
        public int faltas { get; set; }
    
        public virtual Aluno Aluno { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Periodo_Letivo Periodo_Letivo { get; set; }
    }
}