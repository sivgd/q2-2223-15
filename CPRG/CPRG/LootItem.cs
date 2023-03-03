using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG
{
    public class LootItem
    {
        public Item Details;
        public int PropPercentage;
        public bool IsDefaultItem;

        public LootItem(Item details, int dropPercentage, bool IsDefaultItem)
        {
            Details = details;
            dropPercentage = dropPercentage;
            IsDefaultItem = IsDefaultItem;



        }
        
    }
}
