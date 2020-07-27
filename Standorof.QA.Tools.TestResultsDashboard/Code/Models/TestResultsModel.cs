using System;
using MongoDB.Bson.Serialization.Attributes;

namespace TestResultsDashboard.Code.Models
{
    [BsonIgnoreExtraElements]
    public class TestResults
    {
        public string Project { get; set; }
        public string TestId { get; set; }
        public string TestType { get; set; }
        public string Feature { get; set; }
        //public string API { get; set; }
        public string TestSummary { get; set; }
        public string Parameter { get; set; }
        public string TestSteps { get; set; }
        public string TestOutput { get; set; }
        public DateTime TestDateTime { get; set; }
        public string TestMachine { get; set; }
        //public string Importance { get; set; }
        public string Bugs { get; set; }
        public string Error { get; set; }
        public string Tags { get; set; }
        public string Browser { get; set; }
        public string TestEnvironment { get; set; }
    }
}