CREATE TABLE [dbo].[tbl_TestResults] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Project]         VARCHAR (100) NOT NULL,
    [TestId]          VARCHAR (50)  NOT NULL,
    [TestType]        VARCHAR (200) NOT NULL,
    [Feature]         VARCHAR (200) NOT NULL,
    [API]             VARCHAR (200) NULL,
    [TestSummary]     VARCHAR (MAX) NOT NULL,
    [Browser]         VARCHAR (100) NULL,
    [Parameter]       VARCHAR (100) NULL,
    [TestSteps]       VARCHAR (MAX) NOT NULL,
    [Tags]            VARCHAR (200) NOT NULL,
    [TestResult]      VARCHAR (20)  NOT NULL,
    [TestEnvironment] VARCHAR (200) NULL,
    [TestMachine]     VARCHAR (200) NULL,
    [TestDateTime]    DATETIME      NULL,
    [Importance]      VARCHAR (200) NULL,
    [Bugs]            VARCHAR (100) NULL,
    [Error]           VARCHAR (MAX) NULL
);







