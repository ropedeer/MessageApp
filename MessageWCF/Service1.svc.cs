using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace MessageWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<MessageModel> MessageModels;

        public Service1()
        {
            MessageModels = new List<MessageModel>();
        }

        public void SaveMessage(MessageModel message)
        {
            try
            {
                using (var db = new MessageBoardEntities())
                {
                    db.Messages.Add(new Message()
                    {
                        Title = message.Title,
                        Body = message.Body,
                        DateOfMessage = message.DateOfMessage
                    });

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new FaultException("Your message couldn't be saved, please try again later.");
            }

        }

        public IEnumerable<MessageModel> GetMessages()
        {
            using (var db = new MessageBoardEntities())
            {
                var messages = db.Messages.ToList();

                messages.ForEach(message => MessageModels.Add(new MessageModel()
                {
                    Title = message.Title,
                    Body = message.Body,
                    DateOfMessage = message.DateOfMessage

                }));

                return MessageModels;
            }
        }
    }
}
