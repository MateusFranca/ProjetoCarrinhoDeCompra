using ProjetoCarrinhoDeCompra.Contexto;

namespace ProjetoCarrinhoDeCompra.Services
{
    public class Servidor
    {
        private readonly ContextoBD _context;

        public Servidor(ContextoBD con)
        {
            _context = con;
        }
    }
}
