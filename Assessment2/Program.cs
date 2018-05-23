using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment2Project.Messages;

namespace Assessment2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //We read the typed character 
                Console.Write("Choose a message type (A, B or C) : ");
                char messageKey = Console.ReadKey().KeyChar;
                Console.WriteLine("");
             
                //Assessment algorithm optimisation:
                //----------------------------------
                
                //START
                
                //Create the message matching the entered letter (A -> MessageA, B -> MessageB,...) 
                AbstractMessage message = MessageFactory(messageKey);

                message.Execute();

                //END

            }
            catch (Exception e)
            {
                Console.WriteLine("Message execution error : " + e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Message static Factory
        /// (For this example)
        /// </summary>
        public static AbstractMessage MessageFactory(char pressedKey)
        {
            switch(Char.ToUpper(pressedKey))
            {
                case 'A': return new MessageA();
                case 'B': return new MessageB();
                case 'C': return new MessageC();
                default: throw new Exception("Message not implemented.");
            }
        }
    }
}
