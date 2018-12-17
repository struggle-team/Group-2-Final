CREATE TABLE [dbo].[Student] (
    [StudentId]           UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [First Name]          VARCHAR (20)     NOT NULL,
    [Last Name]           VARCHAR (20)     NOT NULL,
    [Major]               VARCHAR (20)     NOT NULL,
    [Work Ethic]          INT              NOT NULL,
    [Student Preference]  VARCHAR (50)     NULL,
    [Completion Style] VARCHAR (30)     NOT NULL,
    [Role]                VARCHAR (30)     NULL,
    [Reliability]         INT              NOT NULL,
    [Availability] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

