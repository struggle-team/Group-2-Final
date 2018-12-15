CREATE TABLE [dbo].[Student] (
    [StudentId]           UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [First Name]          VARCHAR (20)     NULL,
    [Last Name]           VARCHAR (20)     NOT NULL,
    [Major]               VARCHAR (70)     NOT NULL,
    [Work Ethic]          INT              NOT NULL,
    [Student Preference]  VARCHAR (50)     NULL,
    [Collaboration Style] VARCHAR (50)     NOT NULL,
    [Role]                VARCHAR (50)     NULL,
    [Reliability]         INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

