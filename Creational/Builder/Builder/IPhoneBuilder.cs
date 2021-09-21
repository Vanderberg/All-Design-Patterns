namespace Builder
{
    public class IPhoneBuilder : ICelular
    {
        private Celular _celular;
        
        public IPhoneBuilder()
        {
            _celular = new Celular("IPhone");
        }
        
        public void BuildTela()
        {
            this._celular.Tela = "9";
        }

        public void BuildBateria()
        {
            this._celular.Bateria = "AAA_1500";
        }

        public void BuildSistema()
        {
            this._celular.SistemaOperacional = "IOS";
        }

        public void BuildCamera()
        {
            this._celular.Camera = "16 MP";
        }

        public Celular Celular
        {
            get { return this._celular; }
        }
    }
}