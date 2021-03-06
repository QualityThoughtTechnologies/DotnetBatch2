SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reg]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Reg](
	[Name] [varchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Emailid] [varchar](50) NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
 CONSTRAINT [PK_Registration_1] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[schedule]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[schedule](
	[flightid] [int] NOT NULL,
	[Flightname] [varchar](50) NOT NULL,
	[Fromstation] [varchar](50) NOT NULL,
	[Tostation] [varchar](50) NOT NULL,
	[Firstclass] [int] NOT NULL,
	[Bussinessclass] [int] NOT NULL,
	[economicclass] [int] NOT NULL,
	[dateandtimings] [varchar](50) NOT NULL,
 CONSTRAINT [PK_schedule] PRIMARY KEY CLUSTERED 
(
	[flightid] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[canreq]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[canreq](
	[pid] [int] NOT NULL,
	[pname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_canreq] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Plist]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Plist](
	[Pid] [int] NOT NULL,
	[passengername] [varchar](50) NOT NULL,
	[flightid] [int] NOT NULL,
	[Flightname] [varchar](50) NOT NULL,
	[Fromstation] [varchar](50) NOT NULL,
	[Tostation] [varchar](50) NOT NULL,
	[category] [varchar](50) NOT NULL,
	[Dateandtimings] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Plist] PRIMARY KEY CLUSTERED 
(
	[Pid] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Fares]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Fares](
	[Flightname] [varchar](50) NOT NULL,
	[flightid] [int] NOT NULL,
	[Fromstation] [varchar](50) NOT NULL,
	[Tostation] [varchar](50) NOT NULL,
	[firstclass] [money] NOT NULL,
	[Bussinessclass] [money] NOT NULL,
	[economicclass] [money] NOT NULL,
	[dateandtimings] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Fares_1] PRIMARY KEY CLUSTERED 
(
	[flightid] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pid]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pid](
	[pid] [varchar](50) NOT NULL
) ON [PRIMARY]
END
