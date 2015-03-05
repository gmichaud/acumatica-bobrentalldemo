---- Database scripts to create the Tool and Rental tables
CREATE TABLE [dbo].[Tool](
	[CompanyID] [int] NOT NULL,
	[ToolCD] [nvarchar](30) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Cost] [decimal](19,2) NULL,
	[SerialNumber] [nvarchar](50) NULL,
	[NoteID] [uniqueidentifier] NULL,
 CONSTRAINT [Tool_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[ToolCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Tool] ADD  DEFAULT ((0)) FOR [CompanyID]
GO

CREATE TABLE [dbo].[Rental](
	[CompanyID] [int] NOT NULL,
	[RentalID] [int] IDENTITY(1,1) NOT NULL,
	[ToolCD] [nvarchar](30) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[NoteID] [uniqueidentifier] NULL,
 CONSTRAINT [Rental_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[RentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Rental] ADD  DEFAULT ((0)) FOR [CompanyID]
GO


