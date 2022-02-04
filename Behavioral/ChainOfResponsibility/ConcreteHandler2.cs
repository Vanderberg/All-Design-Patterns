﻿using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if ((request >= 10) && (request < 20))
            {
                Console.WriteLine("{0} Handler request {1}", this.GetType().Name, request);
            }else if (Sucessor != null)
            {
                Sucessor.HandleRequest(request);
            }
        }
    }
}