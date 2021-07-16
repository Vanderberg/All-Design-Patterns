using System;

namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montarCarro(string tipo)
        {
            CarroFactory cf = null;

            switch (tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "popular":
                    cf = new CarroPopularFactory();
                    break;
                default:
                    throw new System.NotImplementedException();
                    
            }
            
            Carro carro = new Carro();
            if (cf != null)
            {
                carro.Roda = cf.montarRoda();
                carro.Som = cf.montarSom();
            } 
            return carro;
        }
    }
}