using System;
using System.Collections.Generic;
using System.Text;

namespace TareaMVVM.Models
{
    public class Cargos
    {
        public string Cargo { get; set; }
        public static List<Cargos> GetCargos()
        {
            var cargo = new List<Cargos>()
            {
               
              
                new Cargos(){ Cargo ="IT" },
                new Cargos(){ Cargo ="Supervisor" },
                new Cargos(){ Cargo ="Acesor" },
                 new Cargos(){ Cargo ="Administrador" }

            };
            return cargo;
        }
    }
}
