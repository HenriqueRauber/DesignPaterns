using System;

namespace State
{
    public class Context
    {
        public State  _state;

        public Context(State state)
        {
            State = state;
        }

        public State State
        {
            get
            {
                return _state;
            }
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