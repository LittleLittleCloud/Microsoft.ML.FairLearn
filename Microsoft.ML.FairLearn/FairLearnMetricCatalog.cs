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
        public IGroupMetric BinaryClassificationMetrics(IDataView eval, string labelColumn, string predictedColumn, string sensitiveFeatureColumn)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}