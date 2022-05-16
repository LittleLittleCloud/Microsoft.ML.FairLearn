using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ML.FairLearn
{
    public class FairLearnCatalog
    {
        private readonly MLContext context;

        public FairLearnCatalog(MLContext context)
        {
            this.context = context;
            this.Metric = new FairLearnMetricCatalog(context);
        }

        public FairLearnMetricCatalog Metric { get; }

        public FairLearnReductionCatalog Reduction { get;  }
    }
}
