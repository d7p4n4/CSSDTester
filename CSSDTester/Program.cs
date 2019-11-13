using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d7p4n4Namespace.EFMethods.Class;
using d7p4n4Namespace.Final.Class;
using d7p4n4Namespace.PersistentService.Class;
using CSAc4yObjectService.Class;

namespace CSSDTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Ac4ySDSequenceEntityMethods ac4YSDSequenceEntityMethods = new Ac4ySDSequenceEntityMethods("Ac4ySD2");
            Ac4ySDSequencePersistentService ac4YSDSequencePersistentService = new Ac4ySDSequencePersistentService("Ac4ySD2");

            Ac4ySDSequence sequence = new Ac4ySDSequence()
            {
                Communication = new List<Ac4ySDCommunication>()
               {
                   new Ac4ySDCommunication()
                   {
                       Sender = new Ac4ySDParticipant(){ Name = "frontend" }
                       ,Receiver = new Ac4ySDParticipant(){ Name = "backend" }
                       ,Message = new Ac4ySDMessage(){ Message = "login" }
                   }
                   ,new Ac4ySDCommunication()
                   {
                       Sender = new Ac4ySDParticipant(){ Name = "backend" }
                       ,Receiver = new Ac4ySDParticipant(){ Name = "frontend" }
                       ,Message = new Ac4ySDMessage(){ Message = "ok" }
                   }
               }
            };

            //ac4YSDSequencePersistentService.SaveWithXml(sequence);
            GetObjectResponse obj = ac4YSDSequencePersistentService.GetFirstWithXML(1);
            Console.WriteLine(obj.Object);
        }
    }
}
