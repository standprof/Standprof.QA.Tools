using System;
using System.Data;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using TestResultsDashboard.Code.Models;

namespace TestResultsDashboard.Code
{
    public class MongoDbQueries
    {
        private IMongoCollection<TestResults> GetTestResultsCollection()
        {
            var client = new MongoClient(Configuration.TestArtifactsDbConnectionString);
            var database = client.GetDatabase(Configuration.TestArtifactsDbName);
            return database.GetCollection<TestResults>("TestResults");
        }

        public string[] QueryProjects()
        {
            var collection = GetTestResultsCollection();

            var query = collection.AsQueryable()
                .GroupBy(p => p.Project).Select(s => s.Key);
            return query.ToArray();
        }

        public string[] QueryTestEnvironments(string project)
        {
            var collection = GetTestResultsCollection();

            var query = collection.AsQueryable()
                .Where(s => s.Project == project)
                .GroupBy(p => p.TestEnvironment)
                .Select(s => s.Key);
            return query.ToArray();
        }

        public DataTable QueryTestResultsSummary(string project, string testEnvironment, DateTime testDate)
        {
            var collection = GetTestResultsCollection();

            var match = new BsonDocument
            {
                {
                    "$group",
                    new BsonDocument
                    {
                        {"_id", "$TestId"},
                        {
                            "TestDateTime", new BsonDocument
                            {
                                {
                                    "$last", "$TestDateTime"
                                }
                            }
                        },
                        {
                            "TestResult", new BsonDocument
                            {
                                {
                                    "$last", "$TestResult"
                                }
                            }
                        },
                        {
                            "Project", new BsonDocument
                            {
                                {
                                    "$last", "$Project"
                                }
                            }
                        },
                        {
                            "TestEnvironment", new BsonDocument
                            {
                                {
                                    "$last", "$TestEnvironment"
                                }
                            }
                        }
                    }
                }
            };

            var pipeline = new[] {match};
            var result = collection.Aggregate<TestResults>(pipeline).ToList();

            var selectedTests = result.AsQueryable()
                .Where(s => s.Project == project && s.TestEnvironment == testEnvironment && s.TestDateTime >= testDate);


            var passedTestsAmount = Convert.ToDecimal(selectedTests.Count(s => s.TestResult == "Pass").ToString());

            var failedTestsAmount = Convert.ToDecimal(selectedTests.Count(s => s.TestResult == "Fail").ToString());
            
            var totalTestsAmount = Convert.ToDecimal(selectedTests.Count().ToString());

            var summaryTable = new DataTable();
            summaryTable.Columns.Add("Status");
            summaryTable.Columns.Add("Amount");
            summaryTable.Columns.Add("%");
            summaryTable.Rows.Add("Pass", passedTestsAmount, $"{Math.Round((passedTestsAmount / totalTestsAmount)*100)}%");
            summaryTable.Rows.Add("Fail", failedTestsAmount, $"{Math.Round((failedTestsAmount / totalTestsAmount)*100)}%");
            summaryTable.Rows.Add("Total", totalTestsAmount, "100%");

            return summaryTable;
        }

        public DataTable QueryTestResultsDetails(string project, string testEnvironment, DateTime testDate)
        {
            var collection = GetTestResultsCollection();

            var match = new BsonDocument
            {
                {
                    "$group",
                    new BsonDocument
                    {
                        {"_id", "$TestId"},
                        {
                            "TestId", new BsonDocument
                            {
                                {
                                    "$last", "$TestId"
                                }
                            }
                        },
                        {
                            "TestType", new BsonDocument
                            {
                                {
                                    "$last", "$TestType"
                                }
                            }
                        },
                        {
                            "Project", new BsonDocument
                            {
                                {
                                    "$last", "$Project"
                                }
                            }
                        },
                        {
                            "Feature", new BsonDocument
                            {
                                {
                                    "$last", "$Feature"
                                }
                            }
                        },
                        {
                            "TestSummary", new BsonDocument
                            {
                                {
                                    "$last", "$TestSummary"
                                }
                            }
                        },
                        {
                            "Parameter", new BsonDocument
                            {
                                {
                                    "$last", "$Parameter"
                                }
                            }
                        },
                        {
                            "TestResult", new BsonDocument
                            {
                                {
                                    "$last", "$TestResult"
                                }
                            }
                        },
                        {
                            "Bugs", new BsonDocument
                            {
                                {
                                    "$last", "$Bugs"
                                }
                            }
                        },
                        {
                            "Error", new BsonDocument
                            {
                                {
                                    "$last", "$Error"
                                }
                            }
                        },
                        {
                            "TestDateTime", new BsonDocument
                            {
                                {
                                    "$last", "$TestDateTime"
                                }
                            }
                        },
                        {
                            "TestSteps", new BsonDocument
                            {
                                {
                                    "$last", "$TestSteps"
                                }
                            }
                        },
                        {
                            "Tags", new BsonDocument
                            {
                                {
                                    "$last", "$Tags"
                                }
                            }
                        },
                        {
                            "Browser", new BsonDocument
                            {
                                {
                                    "$last", "$Browser"
                                }
                            }
                        },
                        {
                            "TestEnvironment", new BsonDocument
                            {
                                {
                                    "$last", "$TestEnvironment"
                                }
                            }
                        },
                        {
                            "TestMachine", new BsonDocument
                            {
                                {
                                    "$last", "$TestMachine"
                                }
                            }
                        }
                    }
                }
            };

            var pipeline = new[] {match};
            var result = collection.Aggregate<TestResults>(pipeline).ToList();

            var allTests = result.AsQueryable()
                .Where(s => s.Project == project && s.TestEnvironment == testEnvironment && s.TestDateTime >= testDate)
                .ToList();

            var allTestsTable = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(allTests));

            return allTestsTable;
        }

        public DataTable QueryTestHistoryFromDb(string project, string testId)
        {
            var collection = GetTestResultsCollection();

            var testHistoryList = collection.AsQueryable()
                .Where(s => s.Project == project && s.TestId == testId);

            var allTestsTable = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(testHistoryList));

            return allTestsTable;
        }
    }
}