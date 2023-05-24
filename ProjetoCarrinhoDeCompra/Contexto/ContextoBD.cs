using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;


namespace ProjetoCarrinhoDeCompra.Contexto
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options) 
        {

        }
    }
}
