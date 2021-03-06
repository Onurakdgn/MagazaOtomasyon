USE [master]
GO
/****** Object:  Database [magaza]    Script Date: 13.07.2022 22:10:56 ******/
CREATE DATABASE [magaza]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'magaza', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\magaza.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'magaza_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\magaza_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [magaza] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [magaza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [magaza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [magaza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [magaza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [magaza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [magaza] SET ARITHABORT OFF 
GO
ALTER DATABASE [magaza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [magaza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [magaza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [magaza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [magaza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [magaza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [magaza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [magaza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [magaza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [magaza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [magaza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [magaza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [magaza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [magaza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [magaza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [magaza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [magaza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [magaza] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [magaza] SET  MULTI_USER 
GO
ALTER DATABASE [magaza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [magaza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [magaza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [magaza] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [magaza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [magaza] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [magaza] SET QUERY_STORE = OFF
GO
USE [magaza]
GO
/****** Object:  Table [dbo].[kategori]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategori](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kategori_adi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marka]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marka](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kategori_id] [int] NULL,
	[marka_adi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[adres] [nvarchar](50) NULL,
	[adsoyad] [nvarchar](50) NULL,
	[deleted] [tinyint] NULL,
	[email] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personel]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel](
	[adres] [nvarchar](50) NULL,
	[adsoyad] [nvarchar](50) NULL,
	[deleted] [tinyint] NULL,
	[email] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personelgiris]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personelgiris](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personel_id] [int] NULL,
	[sepet_id] [int] NULL,
	[tarih] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[deleted] [tinyint] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[miktar] [int] NULL,
	[tarih] [nvarchar](50) NULL,
	[toplam_fiyat] [decimal](18, 2) NULL,
	[urun_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 13.07.2022 22:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[alis_fiyati] [decimal](18, 2) NULL,
	[barkod_no] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kategori_id] [int] NULL,
	[marka_id] [int] NULL,
	[miktar] [int] NULL,
	[satis_fiyati] [decimal](18, 2) NULL,
	[tarih] [nvarchar](50) NULL,
	[urun_adi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[musteri] ADD  CONSTRAINT [DF_musteri_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[personel] ADD  CONSTRAINT [DF_personel_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[sepet] ADD  CONSTRAINT [DF_sepet_deleted]  DEFAULT ((0)) FOR [deleted]
GO
USE [master]
GO
ALTER DATABASE [magaza] SET  READ_WRITE 
GO
