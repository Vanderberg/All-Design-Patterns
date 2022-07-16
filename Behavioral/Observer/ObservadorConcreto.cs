using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoObservador;
        private AssuntoConcreto _assunto;

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            this._assunto = assunto;
            this._nome = nome;
        }
        public override void Update()
        {
            this._estadoObservador = this._assunto.EstadoAssunto;
            Console.WriteLine("Observador {0} seu novo esado é {1}", this._nome, this._estadoObservador);
        }

        public AssuntoConcreto Assunto { get; set; }
    }
}