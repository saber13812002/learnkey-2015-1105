USE [master]
GO
/****** Object:  Database [learnkey_arjang]    Script Date: 03/08/2014 01:44:59 ******/
CREATE DATABASE [learnkey_arjang] ON  PRIMARY 
( NAME = N'learnkey_arjang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\learnkey_arjang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'learnkey_arjang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\learnkey_arjang_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [learnkey_arjang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [learnkey_arjang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [learnkey_arjang] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [learnkey_arjang] SET ANSI_NULLS OFF
GO
ALTER DATABASE [learnkey_arjang] SET ANSI_PADDING OFF
GO
ALTER DATABASE [learnkey_arjang] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [learnkey_arjang] SET ARITHABORT OFF
GO
ALTER DATABASE [learnkey_arjang] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [learnkey_arjang] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [learnkey_arjang] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [learnkey_arjang] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [learnkey_arjang] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [learnkey_arjang] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [learnkey_arjang] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [learnkey_arjang] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [learnkey_arjang] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [learnkey_arjang] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [learnkey_arjang] SET  DISABLE_BROKER
GO
ALTER DATABASE [learnkey_arjang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [learnkey_arjang] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [learnkey_arjang] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [learnkey_arjang] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [learnkey_arjang] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [learnkey_arjang] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [learnkey_arjang] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [learnkey_arjang] SET  READ_WRITE
GO
ALTER DATABASE [learnkey_arjang] SET RECOVERY FULL
GO
ALTER DATABASE [learnkey_arjang] SET  MULTI_USER
GO
ALTER DATABASE [learnkey_arjang] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [learnkey_arjang] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'learnkey_arjang', N'ON'
GO
USE [learnkey_arjang]
GO
/****** Object:  User [saber]    Script Date: 03/08/2014 01:44:59 ******/
CREATE USER [saber] FOR LOGIN [MESBAHSOFT\saber] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [learnkey_arjang_user]    Script Date: 03/08/2014 01:44:59 ******/
CREATE USER [learnkey_arjang_user] FOR LOGIN [learnkey_arjang] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[lk_certifications$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_certifications$](
	[id_cer] [float] NULL,
	[name] [nvarchar](255) NULL,
	[owner] [nvarchar](255) NULL,
	[expiredate] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_toplinkbar$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_toplinkbar$](
	[id_top] [float] NULL,
	[name] [nvarchar](255) NULL,
	[desc] [nvarchar](255) NULL,
	[url] [nvarchar](255) NULL,
	[enable] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_stuudents$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_stuudents$](
	[id_st] [float] NULL,
	[name] [nvarchar](255) NULL,
	[name_eng] [nvarchar](255) NULL,
	[birthday] [float] NULL,
	[mobile] [float] NULL,
	[tel] [float] NULL,
	[address] [nvarchar](255) NULL,
	[gmail] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_nextcourses$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_nextcourses$](
	[id_cource] [float] NULL,
	[name] [nvarchar](255) NULL,
	[date] [nvarchar](255) NULL,
	[url] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_news$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_news$](
	[id_news] [nvarchar](255) NULL,
	[title] [nvarchar](255) NULL,
	[body] [nvarchar](255) NULL,
	[img] [nvarchar](255) NULL,
	[summery] [nvarchar](255) NULL,
	[url] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_metadata$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_metadata$](
	[id_meta] [float] NULL,
	[name] [nvarchar](255) NULL,
	[tag] [nvarchar](255) NULL,
	[desc] [nvarchar](255) NULL,
	[title] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_instructor$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_instructor$](
	[id_ins] [float] NULL,
	[name] [nvarchar](255) NULL,
	[picture] [nvarchar](255) NULL,
	[sabeghe] [nvarchar](255) NULL,
	[teachtime] [float] NULL,
	[fb_profile] [nvarchar](255) NULL,
	[msg] [nvarchar](255) NULL,
	[yahoo] [nvarchar](255) NULL,
	[gmail] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lk_arj_certified$]    Script Date: 03/08/2014 01:45:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lk_arj_certified$](
	[id] [float] NULL,
	[id_cer] [float] NULL,
	[id_st] [float] NULL,
	[date] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[mysp_learnkey_meta_title]    Script Date: 03/08/2014 01:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[mysp_learnkey_meta_title]
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
	@meta_title nvarchar(50) = 'meta_title'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT TOP 1000 [id_meta]
      ,[name]
      ,[tag]
      ,[desc]
      ,[title]
  FROM [learnkey_arjang].[dbo].[lk_arj_metadata$]
  where [tag]=@meta_title
END
GO
/****** Object:  StoredProcedure [dbo].[mysp_learnkey_html_toplinkbar]    Script Date: 03/08/2014 01:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[mysp_learnkey_html_toplinkbar]
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
	@html_enable float = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT TOP 1000 [id_top]
      ,[name]
      ,[desc]
      ,[url]
      ,[enable]
  FROM [learnkey_arjang].[dbo].[lk_arj_toplinkbar$]
  where [enable]=@html_enable
END
GO
/****** Object:  StoredProcedure [dbo].[mysp_learnkey_html_nextcources]    Script Date: 03/08/2014 01:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[mysp_learnkey_html_nextcources]
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT TOP 1000 [id_cource]
      ,[name]
      ,[date]
      ,[url]
  FROM [learnkey_arjang].[dbo].[lk_arj_nextcourses$]

END
GO
/****** Object:  StoredProcedure [dbo].[mysp_learnkey_html_certified]    Script Date: 03/08/2014 01:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[mysp_learnkey_html_certified]
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [name_eng],p2.[name]
  FROM [learnkey_arjang].[dbo].[lk_arj_stuudents$] p
  JOIN [learnkey_arjang].[dbo].[lk_arj_certified$] pv
  ON p.id_st = pv.id_st
  JOIN [learnkey_arjang].[dbo].[lk_certifications$] p2
  ON pv.id_cer = p2.id_cer

END
GO
