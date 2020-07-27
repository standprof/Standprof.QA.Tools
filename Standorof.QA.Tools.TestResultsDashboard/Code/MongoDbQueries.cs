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
        private readonly BsonDocument _testResultsDetailsMatch = new BsonDocument
            {
                {
                    "$group",
                    new BsonDocument
                    {
                        {
                            "_id", new BsonDocument
                            {
                                {"TestId", "$TestId"},
                                {"Parameter", "$Parameter"}
                            }
},
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
                            "TestOutput", new BsonDocument
                            {
                                {
                                    "$last", "$TestOutput"
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
                                    "$last", new BsonDocument
                                    {
                                        {
                                            "$dateToString", new BsonDocument
                                            {
                                                {"date", "$TestDateTime"},
                                                {"timezone", "Europe/London"}
                                            }
                                        }
                                    }
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
                        {
                            "_id", new BsonDocument
                            {
                                {"TestId", "$TestId"},
                                {"Parameter", "$Parameter"}
                            }
                        },
                        {
                            "TestDateTime", new BsonDocument
                            {
                                {
                                    "$last", new BsonDocument
                                    {
                                        {
                                            "$dateToString", new BsonDocument
                                            {
                                                {"date", "$TestDateTime"},
                                                {"timezone", "Europe/London"}
                                            }
                                        }
                                    }
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
                            "TestOutput", new BsonDocument
                            {
                                {
                                    "$last", "$TestOutput"
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
                .Where(s =>
                    s.Project == project &&
                    s.TestEnvironment == testEnvironment &&
                    s.TestDateTime.CompareTo(testDate) >= 0);


            var passedTestsAmount = Convert.ToDecimal(selectedTests.Count(s => s.TestOutput == "Pass").ToString());

            var failedTestsAmount = Convert.ToDecimal(selectedTests.Count(s => s.TestOutput == "Fail").ToString());

            var totalTestsAmount = Convert.ToDecimal(selectedTests.Count().ToString());

            var summaryTable = new DataTable();
            summaryTable.Columns.Add("Status");
            summaryTable.Columns.Add("Amount");
            summaryTable.Columns.Add("%");

            if (totalTestsAmount == 0) return summaryTable;


            summaryTable.Rows.Add("Pass", passedTestsAmount,
                $"{Math.Round(passedTestsAmount / totalTestsAmount * 100)}%");
            summaryTable.Rows.Add("Fail", failedTestsAmount,
                $"{Math.Round(failedTestsAmount / totalTestsAmount * 100)}%");
            summaryTable.Rows.Add("Total", totalTestsAmount, "100%");

            return summaryTable;
        }

        public DataTable QueryTestResultsDetails(string project, string testEnvironment, DateTime testDate)
        {
            var collection = GetTestResultsCollection();

            var pipeline = new[] {_testResultsDetailsMatch};
            var result = collection.Aggregate<TestResults>(pipeline).ToList();

            var allTests = result.AsQueryable()
                .Where(s =>
                    s.Project == project &&
                    s.TestEnvironment == testEnvironment &&
                    s.TestDateTime.CompareTo(testDate) >= 0)
                .OrderBy(o => o.TestOutput).ThenBy(o => o.Feature).ThenBy(o => o.TestSummary);

            var allTestsTable = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(allTests));

            return allTestsTable;
        }

        public DataTable QueryTestHistory(string project, string testId)
        {
            var collection = GetTestResultsCollection();

            var pipeline = new[] { _testResultsDetailsMatch };
            var result = collection.Aggregate<TestResults>(pipeline).ToList();

            var testHistoryList = result.AsQueryable()
                .Where(s =>
                    s.Project == project &&
                    s.TestId == testId)
                .OrderByDescending(o => o.TestDateTime);
                

            var allTestsTable = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(testHistoryList));

            return allTestsTable;
        }
    }
}