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
// 0.9: differenceBound
// 0.5: constraint weight
// 10: grid limit
// 100: grid size
// "Zone": Sensitive feature
experiment.ReduceDemographicParityUsingGridSearch(0.9, 0.5, 10, 100, "Zone");

// or
var constraint = new DemographicParity(bound: 0.9);
experiment.SetSensitiveFeature("Zone");
experiment.SetConstraint(constraint, weight: 0.5);
experiment.ReducingConstraintUseGridSearch(gridLimit: 10, gridSize: 100);

var result = await experiment.Run();
var bestModel = result.Model;

// evaluate a model using fairlearn metric
var evaluateData = bestModel.Transform(testData);
var groupMetric = context.FairLearn().Metric.BinaryClassificationMetrics(evaluateData, "Label", "Predicted", "Zone");

// output
// | Accuracy | AOC | .. 
// | 0.33     | 0.4 |
// equal to call context.Binary.Evaluate(evaluateData, "Label");
groupMetric.OverAll();

// output 
// | Zone  | Accuracy   | AUC | ...
// | 98101 | 0.2        | 0.3 |
// | 98004 | 0.5        | 0.9 |
// | 98010 | 0.1        | 0.7 |
groupMetric.ByGroup();

// output 
// | Accuracy   | AUC | ...
// | 0.4        | 0.6 |
groupMetric.DifferenceBetweenGroups();




