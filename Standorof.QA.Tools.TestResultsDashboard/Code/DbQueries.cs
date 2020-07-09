using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TestResultsDashboard.Code
{
    public class DbQueries
    {
        public DataTable QueryProjects()
        {
            using (var connection = new SqlConnection(Configuration.TestArtifactsDbConnectionString))
            {
                
                using (var command = new SqlCommand("SELECT Project FROM [dbo].[tbl_TestResults] group by Project order by Project", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.CommandTimeout = 0;
                    var outputDataset = new DataSet();
                    var dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(outputDataset);

                    return outputDataset.Tables[0];
                }
            }
        }
        
        public DataTable QueryTestEnvironments(string project)
        {
            using (var connection = new SqlConnection(Configuration.TestArtifactsDbConnectionString))
            {
                
                using (var command = new SqlCommand("  SELECT TestEnvironment" +
                                                            " FROM[dbo].[tbl_TestResults]" +
                                                            $" where Project = '{project}'" +
                                                            " group by TestEnvironment", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.CommandTimeout = 0;
                    var outputDataset = new DataSet();
                    var dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(outputDataset);

                    return outputDataset.Tables[0];
                }
            }
        }

        public DataSet QueryTestResultsSummary(string project, string testEnvironment, string testDate)
        {
            var storedProcedureName = "usp_GetTestResults";
            var parameters = new Dictionary<string, string>
            {
                {"project", project}, {"environment", testEnvironment}, {"testDate", testDate}
            };

            using (var connection = new SqlConnection(Configuration.TestArtifactsDbConnectionString))
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

        public DataSet QueryTestHistoryFromDb(string project, string testId)
        {
            var storedProcedureName = "usp_GetHistoryOfTest";
            var parameters = new Dictionary<string, string> { { "project", project }, { "testId", testId } };

            using (var connection = new SqlConnection(Configuration.TestArtifactsDbConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    foreach (var pair in parameters)
                    {
                        var parameter = new SqlParameter
                        {
                            ParameterName = pair.Key,
                            SqlDbType = SqlDbType.NVarChar,
                            Direction = ParameterDirection.Input,
                            Value = pair.Value
                        };

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
