using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto assunto = new AssuntoConcreto();
            assunto.Anexar(new ObservadorConcreto(assunto, "X"));
            assunto.Anexar(new ObservadorConcreto(assunto, "Y"));
            assunto.Anexar(new ObservadorConcreto(assunto, "Z"));

            assunto.EstadoAssunto = "ABC";
            assunto.Notificar();
            
        }
    }
}