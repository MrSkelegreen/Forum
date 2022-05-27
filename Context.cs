using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum
{
    internal class Context
    {
        public static ForumContext db = new ForumContext();
        public static User userSession;
        public static Task task;
    }
}
