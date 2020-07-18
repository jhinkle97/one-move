using System;
using System.Collections.Generic;

namespace OneMove.Models
{
    public partial class User
    {
        public User()
        {
            Layout = new HashSet<Layout>();
            Room = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<Layout> Layout { get; set; }
        public virtual ICollection<Room> Room { get; set; }
    }
}
