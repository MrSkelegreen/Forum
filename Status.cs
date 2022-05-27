using System;
using System.Collections.Generic;

namespace Forum
{
    public partial class Status
    {
        public Status()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Tittle { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
