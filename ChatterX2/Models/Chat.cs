using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatterX2.Models
{
    public class Chat
    {
        public int ID { get; set; }
        [MaxLength(150)]

        public string Chats { get; set; }
        public virtual ApplicationUser Username { get; set; }
    }
}