using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ML.FairLearn
{
    public static class MLContextExtension
    {
        public static FairLearnCatalog FairLearn(this MLContext context)
        {
            return new FairLearnCatalog(context);
        }
    }
}
