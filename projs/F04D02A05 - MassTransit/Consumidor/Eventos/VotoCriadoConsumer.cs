using Core.Entidades;
using MassTransit;

namespace Consumer
{
    public class VotoCriadoConsumer : IConsumer<Voto>
    {
        public Task Consume(ConsumeContext<Voto> context)
        {
            Console.WriteLine(context.Message);
            return Task.CompletedTask;
        }
    }
}