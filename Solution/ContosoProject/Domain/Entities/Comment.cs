using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    enum CommentType { Order=1, Customer, Goods}

    public class Comment:BaseEntity
    {
        private string message;
        private CommentType type;

        public string Message
        {
            get
            { 
                return message;
            }
            set
            {
                if (value.Length != 0)
                {
                    message = value;
                }

                else
                {
                    message = "default message";
                }
            }
        }

        public CommentType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Comment(string inputMessage, CommentType inputType)
        {
            message = inputMessage;
            type = inputType;
        }

       
    }
}
