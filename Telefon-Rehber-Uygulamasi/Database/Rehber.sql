USE [master]
GO
/****** Object:  Database [Rehber]    Script Date: 17.02.2022 02:20:06 ******/
CREATE DATABASE [Rehber]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rehber', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rehber.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rehber_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rehber_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Rehber] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Rehber].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Rehber] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Rehber] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Rehber] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Rehber] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Rehber] SET ARITHABORT OFF 
GO
ALTER DATABASE [Rehber] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Rehber] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Rehber] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Rehber] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Rehber] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Rehber] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Rehber] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Rehber] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Rehber] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Rehber] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Rehber] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Rehber] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Rehber] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Rehber] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Rehber] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Rehber] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Rehber] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Rehber] SET RECOVERY FULL 
GO
ALTER DATABASE [Rehber] SET  MULTI_USER 
GO
ALTER DATABASE [Rehber] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Rehber] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Rehber] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Rehber] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Rehber] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Rehber] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Rehber', N'ON'
GO
ALTER DATABASE [Rehber] SET QUERY_STORE = OFF
GO
USE [Rehber]
GO
/****** Object:  Table [dbo].[Kisiler]    Script Date: 17.02.2022 02:20:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisiler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[TelefonNo] [varchar](max) NULL,
 CONSTRAINT [PK_Numbers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kisiler] ON 

INSERT [dbo].[Kisiler] ([ID], [AdSoyad], [Email], [TelefonNo]) VALUES (1, N'Onur ERDEMİROĞLU', N'onurerdemiroglu@gmail.com', N'05373249723')
INSERT [dbo].[Kisiler] ([ID], [AdSoyad], [Email], [TelefonNo]) VALUES (2, N'Burak ERDEMİROĞLU', N'burakerdemiroglu@gmail.com', N'05373249722')
INSERT [dbo].[Kisiler] ([ID], [AdSoyad], [Email], [TelefonNo]) VALUES (3, N'Yılmaz ERDEMİROĞLU', N'yilmazerdemiroglu@gmail.com', N'05373249724')
INSERT [dbo].[Kisiler] ([ID], [AdSoyad], [Email], [TelefonNo]) VALUES (6, N'Mehmet ERDEMİROĞLU', N'mehmeterdemiroglu@gmail.com', N'05373249724')
INSERT [dbo].[Kisiler] ([ID], [AdSoyad], [Email], [TelefonNo]) VALUES (7, N'Büşra ERDEMİROĞLU', N'busraerdemiroglu@gmail.com', N'05373249726')
SET IDENTITY_INSERT [dbo].[Kisiler] OFF
GO
USE [master]
GO
ALTER DATABASE [Rehber] SET  READ_WRITE 
GO
