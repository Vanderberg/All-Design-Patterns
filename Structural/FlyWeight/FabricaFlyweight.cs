using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FlyWeight
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga> ListaDeTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(String cor)
        {
            Tartaruga tartaruga = null;

            if (ListaDeTartarugas.ContainsKey(cor))
            {
                tartaruga = ListaDeTartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul": tartaruga = new Azul();
                        break;
                    case "verde": tartaruga = new Verde();
                        break;
                    case "vernelha": tartaruga = new Vermelha();
                        break;
                    case "laranja": tartaruga = new Laranja();
                        break;
                }
                
                ListaDeTartarugas.Add(cor, tartaruga);
            }

            return tartaruga;
        }
    }
}