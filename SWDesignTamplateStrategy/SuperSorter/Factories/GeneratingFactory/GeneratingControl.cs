using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSorter.Generating;

namespace SuperSorter.Factories.GeneratingFactory
{
    public abstract class GeneratingControl
    {
        public abstract IArrayGenerator Generator();

        public IArrayGenerator GetObject()
        {
            return this.Generator();
        }
    }
}
