﻿using System.Configuration;

namespace TestResultsDashboard.Code
{
    public static class Configuration
    {
        static Configuration()
        {
            TestArtifactsDbConnectionString = ConfigurationManager.ConnectionStrings["TestArtifactsDB"].ToString();
            TicketsManagementSystemUrl = ConfigurationManager.AppSettings["TicketsManagementSystemURL"];
            CompanyName = ConfigurationManager.AppSettings["CompanyName"];
        }

        public static string CompanyName { get; set; }

        public static string TicketsManagementSystemUrl { get; set; }

        public static string TestArtifactsDbConnectionString { get; set; }
    }
}