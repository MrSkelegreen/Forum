using System;
using System.Collections.Generic;

namespace Forum
{
    public partial class User
    {
        public User()
        {
            TaskIdAuthorNavigations = new HashSet<Task>();
            TaskIdWorkerNavigations = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string? LastName { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual ICollection<Task> TaskIdAuthorNavigations { get; set; }
        public virtual ICollection<Task> TaskIdWorkerNavigations { get; set; }
    }
}
