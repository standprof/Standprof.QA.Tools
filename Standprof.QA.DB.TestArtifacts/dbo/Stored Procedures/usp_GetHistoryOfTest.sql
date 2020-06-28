﻿

CREATE PROCEDURE [dbo].[usp_GetHistoryOfTest] 	
	(
	    @project varchar(20),
		@testId varchar(10)
	)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT Project, TestDateTime, TestId, TestType, Feature, API, TestSummary, Parameter,  TestSteps, TestResult, Bugs, Error, Importance, Browser, TestEnvironment, Tags
	FROM [dbo].[tbl_TestResults]
	WHERE Project=@project and TestId=@testId 
	ORDER BY TestDateTime DESC
	
END