using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSorter.Generating
{
    class ConcreteArrayClass
    {
        private IArrayGenerator _arrayGenerator;
        public ConcreteArrayClass(IArrayGenerator arrayGenerator)
        {
            _arrayGenerator = arrayGenerator;
        }

        public int[] GenerateArray()
        {
            return _arrayGenerator.GenerateArray();
        }
    }
}
