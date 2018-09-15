using System;
using System.Collections.Generic;
using System.Text;

namespace Coll_Mgmt_App.Models
{
    public class CollectionModel
    {
        public int CollectionModelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}
