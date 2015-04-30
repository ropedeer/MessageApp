using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageWCF
{
    public class MessageModel
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime DateOfMessage { get; set; }
    }
}