using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediadorConcreto mediador = new MediadorConcreto();
            ColegaConcretoUm colegaUm = new ColegaConcretoUm(mediador);
            ColegaConcretoDois colegaDois = new ColegaConcretoDois(mediador);

            mediador.ColegaUm = colegaUm;
            mediador.ColegaDois = colegaDois;
            
            colegaUm.Enviar("Como voce está");
            colegaDois.Enviar("Bem obrigado");
        }
    }
}