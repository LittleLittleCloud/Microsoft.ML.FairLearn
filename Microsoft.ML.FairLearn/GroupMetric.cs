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
        /// calculate min/max difference across group. It returns a dictionary which key is metric name
        /// and value is metric value
        /// </summary>
        /// <returns></returns>
        Dictionary<string, double> DifferenceBetweenGroups();

        /// <summary>
        /// calculate metric all over group. It returns a dictionary which key is metric name
        /// and value is metric value
        /// </summary>
        Dictionary<string, double> OverAll();

        /// <summary>
        /// calculate metric according to group. It returns a dataframe
        /// which index is each value in a group and column is metric name and metric name.
        /// </summary>
        /// <returns></returns>
        DataFrame ByGroup();
    }
}
