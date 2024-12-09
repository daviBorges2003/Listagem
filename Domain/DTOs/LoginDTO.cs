using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListagemAPi.Domain.DTOs
{ 
    public class LoginDTO()
    {
        public string email { get; set; }
        public string senha { get; set; }
    }
}