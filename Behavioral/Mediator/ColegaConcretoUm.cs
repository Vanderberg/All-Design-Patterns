using System;

namespace Mediator
{
    public class ColegaConcretoUm : Colega
    {
        public ColegaConcretoUm(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            _mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem do Colega 1: " + mensagem);
        }
    }
}