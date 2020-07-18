using System;
using System.Collections.Generic;

namespace OneMove.Models
{
    public partial class Layout
    {
        public Layout()
        {
            Item = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
