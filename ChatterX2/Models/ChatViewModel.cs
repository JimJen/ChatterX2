using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatterX2.Models
{
    public class ChatViewModel
    {
        public Chat ChatView { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}