using challenge9.Entidades;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Consumer.Controllers
{
    [ApiController]
    [Route("/enquete")]
    public class EnqueteController : ControllerBase
    {
        private readonly IBus _bus;

        public EnqueteController(IBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var endpoint = await _bus.GetSendEndpoint(new Uri("queue:fila"));

            await endpoint.Send(new Voto(1, "C#", DateTime.Now, new Usuario(1, "André", "andre@email.com")));
            await endpoint.Send(new Voto(2, "Java", DateTime.Now, new Usuario(2, "José", "jose@email.com")));
            await endpoint.Send(new Voto(3, "Go", DateTime.Now, new Usuario(3, "Maria", "maria@email.com")));
            await endpoint.Send(new Voto(4, "C#", DateTime.Now, new Usuario(4, "Joana", "joana@email.com")));

            return Ok();
        }
    }
}