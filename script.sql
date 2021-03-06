USE [master]
GO
/****** Object:  Database [Movie_Rental_Store]    Script Date: 5/8/2020 8:01:06 PM ******/
CREATE DATABASE [Movie_Rental_Store]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Movie_Rental_Store', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Movie_Rental_Store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Movie_Rental_Store_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Movie_Rental_Store_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Movie_Rental_Store] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Movie_Rental_Store].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Movie_Rental_Store] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET ARITHABORT OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Movie_Rental_Store] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Movie_Rental_Store] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Movie_Rental_Store] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Movie_Rental_Store] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Movie_Rental_Store] SET  MULTI_USER 
GO
ALTER DATABASE [Movie_Rental_Store] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Movie_Rental_Store] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Movie_Rental_Store] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Movie_Rental_Store] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Movie_Rental_Store] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Movie_Rental_Store] SET QUERY_STORE = OFF
GO
USE [Movie_Rental_Store]
GO
/****** Object:  Table [dbo].[Customer_Field]    Script Date: 5/8/2020 8:01:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Field](
	[Cust_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[City] [varchar](50) NULL,
 CONSTRAINT [PK_Customer_Field] PRIMARY KEY CLUSTERED 
(
	[Cust_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie_Field]    Script Date: 5/8/2020 8:01:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Field](
	[Movie_Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Points] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Copies] [varchar](50) NULL,
	[Plot] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Movie_Field] PRIMARY KEY CLUSTERED 
(
	[Movie_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_Field]    Script Date: 5/8/2020 8:01:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_Field](
	[Rental_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cust_Id] [int] NULL,
	[Movie_Id] [int] NULL,
	[Issue_Date] [varchar](50) NULL,
	[Return_Date] [varchar](50) NULL,
 CONSTRAINT [PK_Rental_Field] PRIMARY KEY CLUSTERED 
(
	[Rental_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Movie_Rental_Store] SET  READ_WRITE 
GO
