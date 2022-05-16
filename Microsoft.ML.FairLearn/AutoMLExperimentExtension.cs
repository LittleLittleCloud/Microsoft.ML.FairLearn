using Microsoft.ML.AutoML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ML.FairLearn
{
    public static class AutoMLExperimentExtension
    {
        /// <summary>
        /// Reduce demographic parity using grid search. The demographic parity is introduced into optimize metric using <paramref name="constraintWeight"/> and error rate would have (1- <paramref name="constraintWeight"/>).
        /// When using demographic parity to reduce unfairness. During training, it "twists" the model by assigning a weight to each piece of data and pass it through <paramref name="sampleWeightColumn"/>, which will be used
        /// in the following classification/regression task. And during consuming, the model just do a normal inference.
        /// See <a cref="https://fairlearn.org/v0.7.0/api_reference/fairlearn.reductions.html#fairlearn.reductions.GridSearch">this link</a> for more information.
        /// </summary>
        /// <param name="differenceBound">setting demographic parity using difference bound constraints</param>
        /// <param name="constraintWeight">constraint weight, this has to be (0, 1)</param>
        /// <param name="gridSize">The number of Lagrange multipliers to generate in the grid</param>
        /// <param name="gridLimit">The largest Lagrange multiplier to generate. The grid will contain values distributed between -grid_limit and grid_limit by default</param>
        /// <param name="sensitiveFeature"></param>
        /// <param name="sampleWeightColumn">The sample weight column name.</param>
        public static AutoMLExperiment ReduceDemographicParityUsingGridSearch(this AutoMLExperiment experiment, double differenceBound, double constraintWeight, int gridSize, float gridLimit, string sensitiveFeature, string sampleWeightColumn = "SampleWeightColumn")
        {
            throw new NotImplementedException();
        }
    }
}
