using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if ((request >= 0) && (request < 10))
            {
                Console.WriteLine("{0} Handler request {1}", this.GetType().Name, request);
            }else if (Sucessor != null)
            {
                Sucessor.HandleRequest(request);
            }
        }
    }
}