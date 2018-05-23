using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2Project.Messages
{
    class MessageB : AbstractMessage
    {
        protected override void MyCustomMethod()
        {
            Console.WriteLine("Calling MyCustomMethodB()");
        }

        public override void Execute()
        {
            base.Execute();
            SomeAdditionalMethodOnB();
        }

        private void SomeAdditionalMethodOnB()
        {
            Console.WriteLine("Calling SomeAdditionalMethodOnB()");
        }
    }
}
