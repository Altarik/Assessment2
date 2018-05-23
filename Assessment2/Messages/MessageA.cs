using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2Project.Messages
{
    class MessageA : AbstractMessage
    {
        protected override void MyCustomMethod()
        {
            Console.WriteLine("Calling MyCustomMethodA()");
        }
    }
}
