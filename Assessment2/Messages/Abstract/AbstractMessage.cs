using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2Project.Messages
{
    /// <summary>
    /// This class represents an abstraction of the messages used in our application.
    /// (All new messages should inherit from this class)
    /// </summary>
    public abstract class AbstractMessage
    {
        protected abstract void MyCustomMethod();
        
        /// <summary>
        /// Default execution Strategy of a message
        /// </summary>
        public virtual void Execute()
        {
            MyCustomMethod();
        }
    }
}
