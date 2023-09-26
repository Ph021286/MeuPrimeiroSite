using MeuSite2.Models;

namespace MeuSite2.wwwroot.Interface
{
    public interface Interface
    {
        Task<List<CustomerMovements>> BuscarTodos();
    }
}