using System;

namespace Command
{
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver rc)
        {
            this.receiver = rc;
        }

        public abstract void Execute();
    }
}
