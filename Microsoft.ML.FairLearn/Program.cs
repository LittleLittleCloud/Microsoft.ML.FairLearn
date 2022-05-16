// See https://aka.ms/new-console-template for more information
using Microsoft.ML;
using Microsoft.ML.AutoML;
using Microsoft.ML.FairLearn;

Console.WriteLine("Hello, World!");

IDataView testData = null;
var context = new MLContext();

// train a model using fair learn
// create a fairlearn experiment using AutoML
var experiment = context.Auto().CreateExperiment();

// reducing demographic parity using "Zone" as sensitive feature.
experiment.ReduceDemographicParityUsingGridSearch(0.9, 0.5, 10, 100, "Zone");

var result = await experiment.Run();
var bestModel = result.Model;

// evaluate a model using fairlearn metric
var evaluateData = bestModel.Transform(testData);
var groupMetric = context.FairLearn().Metric.SelectionRate(evaluateData, "Label", "Predicted", "Zone");

// output 0.3
groupMetric.OverAll();

// output 
// | Zone  | SelectionRate  |
// | 98101 | 0.2            |
// | 98004 | 0.5            |
// | 98010 | 0.1            |
groupMetric.ByGroup();


// output: 0.4
// this can be used to evaluate unfairness as well.
groupMetric.DifferenceBetweenGroups();




