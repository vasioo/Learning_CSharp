using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        public Box()
        {
            this.Items = new List<int>();
        }
        public List<int> Items { get; set; }
        
        StringBuilder stringBuilder = new StringBuilder();
        
        public override string ToString()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (i==FirstIndex)
                {
                    int midd = Items[SecondIndex];
                    Items[SecondIndex] = Items[FirstIndex];
                    Items[FirstIndex] = midd;
                }
                stringBuilder.AppendLine($"{typeof(T)}: {Items[i]}");
            }
            return stringBuilder.ToString();
        }
        public int FirstIndex { get; set; }
        public int SecondIndex { get; set; }
    }
}
