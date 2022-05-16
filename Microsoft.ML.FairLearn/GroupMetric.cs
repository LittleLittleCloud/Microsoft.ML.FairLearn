using Microsoft.Data.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ML.FairLearn
{
    public interface IGroupMetric
    {
        /// <summary>
        /// calculate difference between groups.
        /// see <a href="https://fairlearn.org/v0.7.0/api_reference/fairlearn.metrics.html#fairlearn.metrics.MetricFrame.difference">this link</a> for more info
        /// </summary>
        /// <returns></returns>
        float DifferenceBetweenGroups();

        /// <summary>
        /// calculate metric all over group.
        /// </summary>
        float OverAll();

        /// <summary>
        /// calculate metric according to group. It returns a dataframe
        /// which index is each value in a group and column is group name and metric name.
        /// </summary>
        /// <returns></returns>
        DataFrame ByGroup();
    }
}
