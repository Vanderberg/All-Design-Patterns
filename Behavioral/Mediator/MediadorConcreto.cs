namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        private ColegaConcretoUm _colegaUm;
        private ColegaConcretoDois _colegaDois;

        public ColegaConcretoUm ColegaUm
        {
            set { _colegaUm = value; }
        }
        
        public ColegaConcretoDois ColegaDois
        {
            set { _colegaDois = value; }
        }
        
        public override void Enviar(string mensagem, Colega colega)
        {
            if (colega == _colegaUm)
            {
                _colegaUm.Notificar(mensagem);
            }
            else
            {
                _colegaDois.Notificar(mensagem);
            }
        }
    }
}