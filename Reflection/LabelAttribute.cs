using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LabelAttribute : Attribute
    {
        public string Label { get; init; }
        public LabelAttribute(string label)
        {
            Label = label;
        }
    }
}
