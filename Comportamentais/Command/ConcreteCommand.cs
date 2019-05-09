using System;

namespace Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver rc) : base(rc)
        {

        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
