CREATE PROCEDURE [dbo].[usp_GetTestResults] 	
	(
	@project varchar (100),
	@environment varchar (20),
	@testDate varchar(30)
	)
AS
BEGIN
	SET NOCOUNT ON;

	;WITH CTE
	AS
	(
	  
		SELECT *,ROW_NUMBER() OVER (PARTITION BY TestId, Parameter ORDER BY TestDateTime DESC) Instance 
		 FROM [dbo].[tbl_TestResults] AS tr
		 WHERE Project=@project and TestEnvironment = @environment and CONVERT(datetime,TestDateTime) >= @testDate
	)
	
	
	SELECT 'Failed' as TestOutcome, COUNT(*) as Amount FROM CTE
	WHERE Instance = 1 and TestResult = 'Fail'
	UNION 
	SELECT 'Passed' as TestOutcome,COUNT(*) as Amount FROM CTE
	WHERE Instance = 1 and TestResult = 'Pass'
	UNION
	SELECT 'Total' as TestOutcome, COUNT(*) as Amount FROM CTE
	WHERE Instance = 1 


	;WITH CTE
	AS
	(	 
		SELECT *,ROW_NUMBER() OVER (PARTITION BY TestId, Parameter ORDER BY TestDateTime DESC) Instance 
		 FROM [dbo].[tbl_TestResults] AS tr
		 WHERE Project=@project and TestEnvironment = @environment
	)
	SELECT Id, TestType, Project, TestId, Feature, API, TestSummary, Parameter, TestResult, Bugs, Error, TestDateTime, TestSteps, Importance, Tags, Browser, TestEnvironment FROM CTE
	WHERE Instance = 1 and CONVERT(datetime,TestDateTime) >= @testDate --and Bugs = '' and TestResult = 0 
	
	ORDER by TestResult, Feature, TestSummary
	
END

