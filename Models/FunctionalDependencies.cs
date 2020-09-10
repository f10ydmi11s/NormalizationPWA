using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormalizationPWA.Models
{
    public class FunctionalDependencies
    {
        public string Lhs { get; set; }
        public string Rhs { get; set; }
        public bool IsDone { get; set; }
    }
}
