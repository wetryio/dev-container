USE [Todo]
GO
/****** Object:  User [TodoApplication]    Script Date: 31-01-20 21:41:27 ******/
CREATE USER [TodoApplication] FOR LOGIN [TodoApplication] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [TodoApplication]
GO
ALTER ROLE [db_datareader] ADD MEMBER [TodoApplication]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [TodoApplication]
GO
