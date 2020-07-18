using System;
using System.Collections.Generic;

namespace OneMove.Models
{
    public partial class Room
    {
        public Room()
        {
            Layout = new HashSet<Layout>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int DimensionX { get; set; }
        public int DimensionY { get; set; }
        public int DimensionZ { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Layout> Layout { get; set; }
    }
}
