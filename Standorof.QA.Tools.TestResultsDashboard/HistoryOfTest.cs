using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ShowTestResults
{
    public class HistoryOfTest
    {
        public HistoryOfTest()
        {
            Project = "NA";
            TestId = "NA";
        }

        public string Project { get; set; }
        public string TestId { get; set; }

        public DataSet Get()
        {
            var storedProcedureName = "usp_GetHistoryOfTest";
            var parameters = new Dictionary<string, string>();
            parameters.Add("project", Project);
            parameters.Add("testId", TestId);

            using (var connection = new SqlConnection(Results.TestArtifactsDbConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    if (parameters != null)
                    {
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
