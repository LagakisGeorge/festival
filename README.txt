**** FESTIVAL 28/3/2023
PEL PRIMARY KEY EMAIL NOT NULL







****************************************************************************************************
 Dim Printer As New Printer
Printer.Print("Total (" & (19 + 300) / 4 & ")")
Printer.EndDoc()
 
 
 SYNTAGES:
 SELECT KODSYNOD AS [���������],STR(POSOSTO,6,3) AS [�������]  FROM SYNTAGES where KOD='" + kodPROION + "' ", ListBox2)
 
���� ��� ��������
KOD:  ���. ���������
KODSYNOD : ���. � ����
PSOSSTO:  ������� ����������


YLIKA:
SELECT ONO AS [����� ],KOD AS [���],N1 AS [�����],BAROS AS [�����],C1 AS MONADAMETRHSHS,C2  FROM YLIKA
 1=A YLES
 4=PROION
 
 2=EMPOR
 3=ANALOSIMA
 5=BOH�.�����
 
 
 CREATE TABLE [dbo].[YLIKA](
	[KOD] [varchar](50) NOT NULL,
	[ONO] [varchar](90) NULL,
	[BAROS] [float] NULL,
	[N1] [float] NULL,
	[N2] [float] NULL,
	[C1] [varchar](50) NULL,
	[C2] [varchar](50) NULL,
	[D1] [date] NULL,
	[D2] [date] NULL,
 CONSTRAINT [PK_YLIKA] PRIMARY KEY CLUSTERED 
(
	[KOD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[SYNTAGES](
	[KOD] [nvarchar](30) NULL,
	[KODSYNOD] [nvarchar](30) NULL,
	[POSOSTO] [real] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SYNTAGES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[TIMS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HME] [date] NOT NULL,
	[ATIM] [nvarchar](10) NOT NULL,
	[POSO] [real] NOT NULL,
	[KOD] [nvarchar](30) NOT NULL,
	[PROM] [nvarchar](50) NULL,
 CONSTRAINT [PK_TIMS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



