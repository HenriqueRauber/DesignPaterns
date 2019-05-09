using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoObservador;
        private AssuntoConcreto _assunto;
        public AssuntoConcreto Assunto { get; set; }

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            _nome = nome;
            _assunto = assunto;
        }

        public override void Update()
        {
            _estadoObservador = _assunto.EstadoAssunto;
            Console.WriteLine("Observador '{0}' seu novo estado é: {1}", _nome, _estadoObservador);
        }

    }
}
