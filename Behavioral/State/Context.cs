using System;

namespace State
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            this._state = state;
        }

        public State State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine("Estado: " + _state.GetType().Name);
            } 
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}