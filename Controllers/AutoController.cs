using Examen_Practico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examen_Practico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly OnlineStoreContext _baseDatos;

        public AutoController(OnlineStoreContext baseDatos)
        {
            _baseDatos = baseDatos;
        }

        [HttpGet]
        [Route("Productos")]
        public async Task<IActionResult> Lista()
        {
            var listaProductos = await _baseDatos.onlineStore.ToListAsync();
            return Ok(listaProductos);
        }
    }
}
