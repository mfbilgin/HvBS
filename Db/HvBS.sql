USE [HvBSDatabase]
GO
/****** Object:  Table [dbo].[Bases]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bases](
	[BaseId] [int] IDENTITY(1,1) NOT NULL,
	[BaseName] [nvarchar](max) NOT NULL,
	[AuthorizedStaffOnBase] [nvarchar](max) NOT NULL,
	[AircraftOnBase] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Bases] PRIMARY KEY CLUSTERED 
(
	[BaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintenanceTypes]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintenanceTypes](
	[MaintenanceTypeId] [int] IDENTITY(1,1) NOT NULL,
	[BaseId] [int] NOT NULL,
	[MaintenanceName] [nvarchar](max) NOT NULL,
	[MaintenancePeriot] [nvarchar](max) NOT NULL,
	[Definition] [nvarchar](max) NOT NULL,
	[ToDoDuringMaintenance] [nvarchar](max) NULL,
 CONSTRAINT [PK_MaintenanceTypes] PRIMARY KEY CLUSTERED 
(
	[MaintenanceTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationClaims]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationClaims](
	[OperationClaimId] [int] IDENTITY(1,1) NOT NULL,
	[OperationClaimName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OperationClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parts]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parts](
	[PartId] [int] IDENTITY(1,1) NOT NULL,
	[BaseId] [int] NOT NULL,
	[PartNumber] [nvarchar](max) NOT NULL,
	[PartName] [nvarchar](max) NOT NULL,
	[StockStatus] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planes](
	[PlaneId] [int] IDENTITY(1,1) NOT NULL,
	[BaseId] [int] NOT NULL,
	[PlaneType] [nvarchar](50) NOT NULL,
	[SerialNumber] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PlaneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Records]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Records](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[BaseId] [int] NOT NULL,
	[CompletedUserId] [int] NULL,
	[AircraftSerialNumber] [nvarchar](max) NOT NULL,
	[Trouble] [nvarchar](max) NOT NULL,
	[RegisterDate] [datetime2](0) NOT NULL,
	[EstimatedEndDate] [datetime2](0) NULL,
	[CompleteDate] [datetime2](0) NULL,
	[ReasonOfWaiting] [nvarchar](max) NOT NULL,
	[PartsNeed] [nvarchar](max) NULL,
	[StaffOfRecording] [nvarchar](max) NOT NULL,
	[StaffOfIdentifyTrouble] [nvarchar](max) NULL,
	[MaintenanceChief] [nvarchar](max) NULL,
	[MaintenanceTypes] [nvarchar](max) NOT NULL,
	[IsEmergency] [bit] NOT NULL,
	[IsWaiting] [bit] NOT NULL,
	[IsCompleted] [bit] NOT NULL,
 CONSTRAINT [PK__Records__FBDF78E9AB1AEF5C] PRIMARY KEY CLUSTERED 
(
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOperationClaims]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperationClaims](
	[UserOperationClaimId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OperationClaimId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserOperationClaimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/30/2023 11:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](11) NOT NULL,
	[PasswordHash] [varbinary](max) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Rank] [nvarchar](max) NOT NULL,
	[HvBSNumber] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaintenanceTypes]  WITH CHECK ADD  CONSTRAINT [FK_MaintenanceTypes_Bases] FOREIGN KEY([BaseId])
REFERENCES [dbo].[Bases] ([BaseId])
GO
ALTER TABLE [dbo].[MaintenanceTypes] CHECK CONSTRAINT [FK_MaintenanceTypes_Bases]
GO
ALTER TABLE [dbo].[Parts]  WITH CHECK ADD  CONSTRAINT [FK_Parts_Bases] FOREIGN KEY([BaseId])
REFERENCES [dbo].[Bases] ([BaseId])
GO
ALTER TABLE [dbo].[Parts] CHECK CONSTRAINT [FK_Parts_Bases]
GO
ALTER TABLE [dbo].[Planes]  WITH CHECK ADD  CONSTRAINT [FK_Planes_ToBase] FOREIGN KEY([BaseId])
REFERENCES [dbo].[Bases] ([BaseId])
GO
ALTER TABLE [dbo].[Planes] CHECK CONSTRAINT [FK_Planes_ToBase]
GO
ALTER TABLE [dbo].[Records]  WITH CHECK ADD  CONSTRAINT [FK_Records_Bases] FOREIGN KEY([BaseId])
REFERENCES [dbo].[Bases] ([BaseId])
GO
ALTER TABLE [dbo].[Records] CHECK CONSTRAINT [FK_Records_Bases]
GO
ALTER TABLE [dbo].[UserOperationClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserOperationClaim_OperationClaims] FOREIGN KEY([OperationClaimId])
REFERENCES [dbo].[OperationClaims] ([OperationClaimId])
GO
ALTER TABLE [dbo].[UserOperationClaims] CHECK CONSTRAINT [FK_UserOperationClaim_OperationClaims]
GO
ALTER TABLE [dbo].[UserOperationClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserOperationClaim_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserOperationClaims] CHECK CONSTRAINT [FK_UserOperationClaim_Users]
GO
