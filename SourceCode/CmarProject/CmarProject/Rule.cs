using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmarProject
{
    public class Rule
    {
        public int Index { get; set; }
        public List<string> Items { get; set; }
        public string ClassName { get; set; }
        public string RuleText
        {
            get
            {
                return string.Join(",", Items.Skip(1).ToList());
            }
        }
        public double Conf { get; set; }
        public int Sup { get; set; }
        public bool Pruned { get; set; }
    }
}
