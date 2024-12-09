using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ListagemAPi.Domain.DTOs;
using ListagemAPi.Domain.Entities;
using ListagemAPi.Infraestrutura.Db;
using ListagemAPi.Infraestrutura.interfaces;
using Microsoft.EntityFrameworkCore.Internal;

namespace ListagemAPi.Domain.Services
{
    public class AdminServices : iAdmServices
    {
        private readonly DbContexto _context;

        public AdminServices(DbContexto contexto)
        {
            _context = contexto;
        }
        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _context.Administradores.Where( a => a.Email == loginDTO.email && a.Senha == loginDTO.senha).FirstOrDefault();
            
            return adm;
        }
    }
}