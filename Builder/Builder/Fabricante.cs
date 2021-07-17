namespace Builder
{
    public class Fabricante
    {
        public void Constructor(ICelular celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildCamera();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
        }
    }
}