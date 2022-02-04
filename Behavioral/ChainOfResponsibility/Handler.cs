namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler Sucessor;

        public void SetSucessor(Handler sucessor)
        {
            this.Sucessor = sucessor;
        }

        public abstract void HandleRequest(int request);
    }
}