using System;
using System.Collections.Generic;

namespace Forum
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Tittle { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int IdAuthor { get; set; }
        public int? IdWorker { get; set; }
        public int Status { get; set; }

        public virtual User IdAuthorNavigation { get; set; } = null!;
        public virtual User? IdWorkerNavigation { get; set; }
        public virtual Status StatusNavigation { get; set; } = null!;
    }
}
