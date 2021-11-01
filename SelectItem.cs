using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanvasCodeConverter
{
    public class SelectItem
    {
        public SelectItem() { }
        public SelectItem(string label, string value)
        {
            Value = value;
            Label = label;
        }

        public string Value { get; set; }
        public string Label { get; set; }
    }
}
