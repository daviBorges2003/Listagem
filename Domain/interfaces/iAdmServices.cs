using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListagemAPi.Domain.DTOs;
using ListagemAPi.Domain.Entities;

namespace ListagemAPi.Infraestrutura.interfaces
{
    public interface iAdmServices
    {
        Administrador? Login(LoginDTO loginDTO);
    }
}