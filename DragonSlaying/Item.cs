using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class Item
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public Dictionary<string, int> Effects { get; set; }

        public override string ToString()
        {
            var effectsSb = new StringBuilder();
            int effectCount = 0;
            foreach (var item in Effects)
            {
                effectCount++;
                var effectName = item.Key;
                var effectAmount = item.Value;
                if (effectCount > 1)
                {
                    effectsSb.Append(", ");
                }
                effectsSb.AppendFormat("{0} {1}", effectAmount, effectName);
            }
            return String.Format("{0} ({1})", Name, effectsSb);
        }
    }
}
