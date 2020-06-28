using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ShowTestResults
{
    public class Results
    {
        public Results()
        {
            TestArtifactsDbConnectionString = ConfigurationManager.ConnectionStrings["TestArtifactsDB"].ToString();
            TicketsManagementSystemUrl = ConfigurationManager.AppSettings["TicketsManagementSystemURL"];
        }

        public string TicketsManagementSystemUrl { get; set; }

        public static string TestArtifactsDbConnectionString { get; set; }
        public string Project { get; set; }
        public string TestEnvironment { get; set; }
        public string TestDate { get; set; }

        public DataSet Get()
        {
            var storedProcedureName = "usp_GetTestResults";
            var parameters = new Dictionary<string, string>();
            parameters.Add("project", Project);
            parameters.Add("environment", TestEnvironment);
            parameters.Add("testDate", TestDate);

            using (var connection = new SqlConnection(TestArtifactsDbConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    foreach (var pair in parameters)
                    {
                        // Add the input parameter and set its properties.
                        var parameter = new SqlParameter
                        {
                            ParameterName = pair.Key,
                            SqlDbType = SqlDbType.NVarChar,
                            Direction = ParameterDirection.Input,
                            Value = pair.Value
                        };

                        // Add the parameter to the Parameters collection. 
                        command.Parameters.Add(parameter);
                    }

                    connection.Open();
                    command.CommandTimeout = 0;
                    var outputDataset = new DataSet();
                    var dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(outputDataset);

                    return outputDataset;
                }
            }
        }
    }
}
