USE [master]
GO

/****** Object:  Database [praktika]    Script Date: 15.03.2022 13:27:16 ******/
CREATE DATABASE [praktika]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'praktika', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\praktika.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'praktika_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\praktika_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [praktika].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [praktika] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [praktika] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [praktika] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [praktika] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [praktika] SET ARITHABORT OFF 
GO

ALTER DATABASE [praktika] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [praktika] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [praktika] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [praktika] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [praktika] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [praktika] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [praktika] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [praktika] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [praktika] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [praktika] SET  DISABLE_BROKER 
GO

ALTER DATABASE [praktika] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [praktika] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [praktika] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [praktika] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [praktika] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [praktika] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [praktika] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [praktika] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [praktika] SET  MULTI_USER 
GO

ALTER DATABASE [praktika] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [praktika] SET DB_CHAINING OFF 
GO

ALTER DATABASE [praktika] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [praktika] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [praktika] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [praktika] SET QUERY_STORE = OFF
GO

ALTER DATABASE [praktika] SET  READ_WRITE 
GO

