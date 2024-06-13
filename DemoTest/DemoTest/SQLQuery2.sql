USE [DemoTest]
GO

INSERT INTO [dbo].[Beholder_Employee]
           ([ID_Employee]
           ,[Name]
           ,[Age]
           ,[Login]
           ,[Password])
     VALUES
           (1, 'John Doe', 30, 'johndoe', 'password1'),
           (2, 'Jane Smith', 28, 'janesmith', 'password2');
GO
