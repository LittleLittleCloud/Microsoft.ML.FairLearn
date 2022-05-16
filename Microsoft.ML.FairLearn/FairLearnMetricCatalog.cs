namespace Microsoft.ML.FairLearn
{
    public class FairLearnMetricCatalog
    {
        private readonly MLContext context;

        public FairLearnMetricCatalog(MLContext context)
        {
            this.context = context;
        }

        #region binary classification
        public IGroupMetric FalseNegativeRate(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        public IGroupMetric FalsePositiveRate(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        public IGroupMetric TrueNegativeRate(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        public IGroupMetric TruePositiveRate(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        public IGroupMetric SelectionRate(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// caculate demographic parity difference, the demograhic parity difference is the difference between latest and smallest
        /// group-level selection rate across all value in <paramref name="sensitiveFeatureColumn"/>.
        /// 
        /// See <a href="https://fairlearn.org/v0.7.0/api_reference/fairlearn.metrics.html#fairlearn.metrics.demographic_parity_difference">this link</a> for more inforamtion
        /// </summary>
        /// <param name="eval">input data.</param>
        /// <param name="labelColumn">label column name, must be boolean type.</param>
        /// <param name="predictedColumn">predicted column name, must be boolean type.</param>
        /// <param name="sensitiveFeatureColumn">sensitive feature name, must be key type.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float DemographicParityDifference(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// caculate demographic parity difference, it returns the greater of <see cref="FalsePositiveRateDifference(IDataView, string, string, string)"/> and <see cref="TruePositiveRateDifference(IDataView, string, string, string)"/>.see <a href="https://fairlearn.org/v0.7.0/api_reference/fairlearn.metrics.html#fairlearn.metrics.equalized_odds_difference">this link</a> for more information.
        /// </summary>
        /// <param name="eval">input data.</param>
        /// <param name="labelColumn">label column name, must be boolean type.</param>
        /// <param name="predictedColumn">predicted column name, must be boolean type.</param>
        /// <param name="sensitiveFeatureColumn">sensitive feature name, must be key type.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float EqualizedOddsDifference(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Caculate false positive rate difference, it's defined as the largest and smallest of P[h(x)=1|A=a, Y=0] for all value a in <paramref name="sensitiveFeatureColumn"/>.
        /// </summary>
        /// <param name="eval">input data.</param>
        /// <param name="labelColumn">label column name, must be boolean type.</param>
        /// <param name="predictedColumn">predicted column name, must be boolean type.</param>
        /// <param name="sensitiveFeatureColumn">sensitive feature name, must be key type.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float FalsePositiveRateDifference(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Caculate true positive rate difference, it's defined as the largest and smallest of P[h(x)=1|A=a, Y=1] for all value a in <paramref name="sensitiveFeatureColumn"/>.
        /// </summary>
        /// <param name="eval">input data.</param>
        /// <param name="labelColumn">label column name, must be boolean type.</param>
        /// <param name="predictedColumn">predicted column name, must be boolean type.</param>
        /// <param name="sensitiveFeatureColumn">sensitive feature name, must be key type.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float TruePositiveRateDifference(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }
    }
}