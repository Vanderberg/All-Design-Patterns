using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if ((request >= 20) && (request < 30))
            {
                Console.WriteLine("{0} Handler request {1}", this.GetType().Name, request);
            }else if (Sucessor != null)
            {
                Sucessor.HandleRequest(request);
            }   
        }
    }
}