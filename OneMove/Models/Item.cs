using System;
using System.Collections.Generic;

namespace OneMove.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public int LayoutId { get; set; }
        public string Name { get; set; }
        public int DimensionX { get; set; }
        public int DimensionY { get; set; }
        public int DimensionZ { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }

        public virtual Layout Layout { get; set; }
    }
}
