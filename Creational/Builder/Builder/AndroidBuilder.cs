namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        private Celular _celular;
        public AndroidBuilder()
        {
            _celular = new Celular("Android");        
        }
        
        public void BuildTela()
        {
            this._celular.Tela = "7";
        }

        public void BuildBateria()
        {
            this._celular.Bateria = "MAH_1500";
        }

        public void BuildSistema()
        {
            this._celular.SistemaOperacional = "Android 10.0";
        }

        public void BuildCamera()
        {
            this._celular.Camera = "15 MP";
        }
        
        public Celular Celular
        {
            get { return this._celular; }
        }
    }
}