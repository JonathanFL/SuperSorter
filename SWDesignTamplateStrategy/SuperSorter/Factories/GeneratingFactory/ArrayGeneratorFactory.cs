using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter.Generating;

namespace SuperSorter.Factories.GeneratingFactory
{
    public class ArrayGeneratorFactory : GeneratingControl
    {
        private const int Max = 10;
        private const int SizeN = 10;
        public override IArrayGenerator Generator()
        {
            IArrayGenerator generator = new ArrayGenerator(Guid.NewGuid().GetHashCode(), Max, SizeN);
            return generator;
        }
    }
}
