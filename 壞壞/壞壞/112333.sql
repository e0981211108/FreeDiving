USE [FreeDiving]
GO
/****** Object:  Table [dbo].[Evieusers]    Script Date: 2024/11/13 下午 11:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evieusers](
	[name] [varchar](50) NOT NULL,
	[ID] [varchar](15) NOT NULL,
	[password] [varchar](30) NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[email] [nvarchar](30) NOT NULL,
	[manager] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 2024/11/13 下午 11:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Members__3214EC279D5987A6] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderdetail]    Script Date: 2024/11/13 下午 11:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetail](
	[orderID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[uninPrice] [int] NOT NULL,
	[totalPrice] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2024/11/13 下午 11:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Orders__C3905BAFB81EB44C] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pd]    Script Date: 2024/11/13 下午 11:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pd](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](100) NULL,
	[price] [int] NULL,
	[image] [nchar](500) NULL,
	[Classification] [nvarchar](50) NULL,
	[stock] [int] NULL,
	[brand] [nchar](100) NULL,
 CONSTRAINT [PK_products_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'梁芷郡', N'1', N'1', N'0926189376', N'高雄市小港區大平路126巷29號', N'e20801720@gmail.com', 1)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'梁素瑩', N'e20801721', N'123456', N'0935123456', N'台北市大安區忠孝東路4段256號', N'yaya123@gmail.com', 2)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'林莉純', N'e20801722', N'123456', N'0925123457', N'新北市中和區中山路二段450巷12號', N'zxcvbnm999@gmail.com', 2)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'林佳樺', N'e20801723', N'123456', N'0955123458', N'台中市北屯區文心路三段69號', N'luna0525@gmail.com', 3)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'陳君宜', N'e20801724', N'123456', N'0912123459', N'台南市東區勝利路23巷45弄11號', N'ppp000@gmail.com', 3)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'林佳馨', N'e20801725', N'123456', N'0938123460', N'桃園市中壢區新生路5段9號', N'tomtom88@gmail.com', 3)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'蔡家豪', N'e20801726', N'123456', N'0987123461', N'高雄市左營區明誠路100號', N'coco7878@gmail.com', 0)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'黃麗玲', N'e20801727', N'123456', N'0975123462', N'新竹市香山區光復路250巷20弄5號', N'lily888@gmail.com', 0)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'張宇豪', N'e20801728', N'123456', N'0967123463', N'台中市西屯區青海路2段6號', N'yuyu1234@gmail.com', 0)
GO
INSERT [dbo].[Evieusers] ([name], [ID], [password], [phone], [address], [email], [manager]) VALUES (N'吳小梅', N'e20801729', N'123456', N'0922123464', N'台南市永康區大橋路三段123巷25號', N'maymay2020@gmail.com', 0)
GO
SET IDENTITY_INSERT [dbo].[Members] ON 
GO
INSERT [dbo].[Members] ([ID], [Name], [Account], [Password], [Phone], [Email], [Address], [CreateDate]) VALUES (1, N'123', N'123', N'123', N'123', N'123', N'123', CAST(N'2024-11-11T22:18:18.203' AS DateTime))
GO
INSERT [dbo].[Members] ([ID], [Name], [Account], [Password], [Phone], [Email], [Address], [CreateDate]) VALUES (4, N'1234', N'1234', N'132', N'123', N'123', N'123
123', CAST(N'2024-11-12T00:06:45.877' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[Pd] ON 
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1, N'Gull Vader Fanette                                                                                  ', 5586, N'Gull Vader Fanette.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'面鏡', 5, N'Gull                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (2, N'Gull Vader                                                                                          ', 5586, N'Gull Vader.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ', N'面鏡', 0, N'Gull                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (3, N'Gull Lanze                                                                                          ', 3136, N'Gull Lanze.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ', N'面鏡', 0, N'Gull                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (4, N'Gull coco                                                                                           ', 3087, N'Gull coco.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', N'面鏡', 0, N'Gull                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (5, N'IST- PANORAMA鋁合金系列面鏡                                                                                ', 1550, N'IST- PANORAMA.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', N'面鏡', 0, N'IST                                                                                                 ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (6, N'IST - PROTEUS 防霧鏡片低容積雙面鏡                                                                            ', 1700, N'IST - PROTEUS.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', N'面鏡', 0, N'IST                                                                                                 ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (7, N'IST - SONIC低容積雙面鏡                                                                                   ', 1500, N'IST - SONIC.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', N'面鏡', 0, N'IST                                                                                                 ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (8, N'AquaLung SPHERA X                                                                                   ', 2950, N'AquaLung SPHERA X.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ', N'面鏡', 0, N'Aqua lung                                                                                           ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (9, N'APOLLO - BIO METAL                                                                                  ', 7800, N'APOLLO - BIO METAL.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'面鏡', 0, N'APOLLO                                                                                              ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (10, N'AQUA LUNG - SPHERA X                                                                                ', 2650, N'AQUA LUNG - SPHERA X.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ', N'面鏡', 0, N'AQUA                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (11, N'TUSA - FREEDOM CEOS                                                                                 ', 2500, N'TUSA - FREEDOM CEOS.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ', N'面鏡', 0, N'TUSA                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (12, N'MOLCHANOVS 抹茶 CORE                                                                                  ', 1500, N'MOLCHANOVS 抹茶 CORE.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'面鏡', 0, N'MOLCHANOVS                                                                                          ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (13, N'水呼吸 breathe 全乾式呼吸管                                                                                  ', 850, N'水呼吸 breathe 全乾式呼吸管.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'呼吸管', 0, N'BREATHE                                                                                             ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (14, N'BEUCHAT SPY                                                                                         ', 850, N'BEUCHAT SPY.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', N'呼吸管', 0, N'BEUCHAT                                                                                             ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (15, N'Cressi CORSICA 克西卡                                                                                  ', 850, N'Cressi CORSICA 克西卡.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'呼吸管', 0, N'MOLCHANOVS                                                                                          ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (16, N'MOLCHANOVS 抹茶 CORE核心呼吸管                                                                             ', 800, N'MOLCHANOVS 抹茶 CORE核心呼吸管.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         ', N'呼吸管', 0, N'TUSA                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (17, N'PLATINA II HYPERDRY                                                                                 ', 1568, N'PLATINA II HYPERDRY.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ', N'呼吸管', 0, N'IST                                                                                                 ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (18, N'SN-204                                                                                              ', 1078, N'SN-204.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          ', N'呼吸管', 0, N'V DIVE                                                                                              ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (19, N'SnorkelSN08                                                                                         ', 860, N'SnorkelSN08.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', N'呼吸管', 0, N'V DIVE                                                                                              ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (23, N'抹茶PRO Hyper碳纖維雙蹼                                                                                    ', 29617, N'抹茶PRO Hyper碳纖維雙蹼.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', N'長蛙鞋', 0, N'MOLCHANOVS                                                                                          ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (24, N'抹茶SPORT Bifins 3 碳纖維                                                                                ', 16277, N'抹茶SPORT Bifins 3 碳纖維.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ', N'長蛙鞋', 0, N'MOLCHANOVS                                                                                          ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (27, N'AlchemyV3-30                                                                                        ', 19600, N'AlchemyV3-30.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', N'長蛙鞋', 0, N'ALCHEMY                                                                                             ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (30, N'EDGE 碳纖維長蛙板                                                                                         ', 17500, N'EDGE 碳纖維長蛙板.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', N'長蛙鞋', 0, N'EDGE                                                                                                ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (31, N'MANTRA CWT 碳纖維長蛙板 競技款                                                                               ', 17500, N'MANTRA CWT 碳纖維長蛙板 競技款.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ', N'長蛙鞋', 0, N'MANTRA CWT                                                                                          ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (32, N'MANTRA 碳纖維長蛙板                                                                                       ', 17500, N'MANTRA 碳纖維長蛙板.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', N'長蛙鞋', 0, N'MANTRA CWT                                                                                          ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1036, N'DiveR - 情定落日鯨                                                                                       ', 18850, N'DiveR - 情定落日鯨.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1037, N'DiveR－天使永恆愛戀                                                                                        ', 18850, N'DiveR－天使永恆愛戀.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1038, N'DiveR - 翅鯨擁月                                                                                        ', 18850, N'DiveR - 翅鯨擁月.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1040, N'DiveR－垂頭鯊                                                                                           ', 13360, N'DiveR－垂頭鯊.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1041, N'DiveR - 海神波賽頓                                                                                       ', 16850, N'DiveR - 海神波賽頓.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1042, N'DiveR樂遊小白鯨                                                                                          ', 18850, N'DiveR樂遊小白鯨.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1043, N'DiveRInnegra裸女之愛                                                                                    ', 20000, N'DiveRInnegra裸女之愛.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1044, N'DiveR 全碳纖維長蛙板-乘風破浪                                                                                  ', 16850, N'DiveR 全碳纖維長蛙板-乘風破浪.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1045, N'SnorkelSN11                                                                                         ', 800, N'SnorkelSN11.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', N'呼吸管', 0, N'LAZYFISH                                                                                            ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1046, N'NULLLAZYFISH - ULTRA Pro                                                                            ', 19980, N'LAZYFISH - ULTRA Pro.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ', N'長蛙鞋', 0, N'LAZYFISH                                                                                            ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1047, N'LAZYFISH 經典碳纖維專業長蛙                                                                                  ', 16800, N'LAZYFISH 經典碳纖維專業長蛙.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              ', N'長蛙鞋', 0, N'LAZYFISH                                                                                            ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1051, N'LAZULI 極致碳纖維長蛙板                                                                                     ', 17388, N'LAZULI 極致碳纖維長蛙板.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ', N'長蛙鞋', 0, N'LAZYFISH                                                                                            ')
GO
INSERT [dbo].[Pd] ([ID], [name], [price], [image], [Classification], [stock], [brand]) VALUES (1052, N'DiveR - 海流邂逅                                                                                        ', 18850, N'DiveR - 海流邂逅.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', N'長蛙鞋', 0, N'DiveR                                                                                               ')
GO
SET IDENTITY_INSERT [dbo].[Pd] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Members__B0C3AC46B7D58987]    Script Date: 2024/11/13 下午 11:13:34 ******/
ALTER TABLE [dbo].[Members] ADD  CONSTRAINT [UQ__Members__B0C3AC46B7D58987] UNIQUE NONCLUSTERED 
(
	[Account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Members] ADD  CONSTRAINT [DF__Members__CreateD__3C69FB99]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF__Orders__CreateDa__49C3F6B7]  DEFAULT (getdate()) FOR [CreateDate]
GO
