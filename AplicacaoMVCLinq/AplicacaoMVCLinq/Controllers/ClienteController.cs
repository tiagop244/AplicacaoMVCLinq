using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            Cliente c1 = new Cliente(1, "Alice", "alice@teste.com", "1234-5678", new DateOnly(2000, 6, 1));
            listaCliente.Add(c1);
            Cliente c2 = new Cliente(2, "Alice", "alice@teste.com", "1234-5678", new DateOnly(2000, 6, 1));
            listaCliente.Add(c2);
            Cliente c3 = new Cliente(3, "Alice", "alice@teste.com", "1234-5678", new DateOnly(2000, 6, 1));
            listaCliente.Add(c3);
            Cliente c4 = new Cliente(4, "Alice", "alice@teste.com", "1234-5678", new DateOnly(2000, 6, 1));
            listaCliente.Add(c4);
            Cliente c5 = new Cliente(5, "Alice", "alice@teste.com", "1234-5678", new DateOnly(2000, 6, 1));
            listaCliente.Add(c5);

            return View(listaCliente);
        }
    }
}
