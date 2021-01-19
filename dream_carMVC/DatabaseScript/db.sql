SET IDENTITY_INSERT [dbo].[Company] ON
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (1, N'Jeep', N'jeep.com', NULL, NULL, N'Toledo,ohio,US')
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (2, N'Toyota', N'toyota-global.com', NULL, NULL, N'Toyota city, japan')
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (3, N'Mazda', N'mazda.com', NULL, NULL, N'3-1 shinchi,fuchu,aki,hiroshima,japan')
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (4, N'Suzuki', N'globalsuzuki.com', NULL, NULL, N'shizuoka,japan')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Dealer] ON
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (5, N'Colemans', N'colemans-suzuki.co.nz', N'1 gundry street,Newton,Auckland', N'abc', 4)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (6, N'Andrew Simms', N'newmarket.jeepdealer.co.nz', N'500 Broadway Newmarket,Auckland', N'*******', 1)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (7, N'Toyota New Zealand', N'toyota.co.nz', N'252 Dairy Flat highway,Albany,Auckland', N'******', 2)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (8, N'John Andrew', N'johnandrewmazda.co.nz', N'38 Great North Road,gret lynn,Auckland ', N'*******', 3)
SET IDENTITY_INSERT [dbo].[Dealer] OFF
SET IDENTITY_INSERT [dbo].[Model] ON
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (1, N'GSX-R1000RA', N'2010', 4, NULL, 5)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (2, N'KATANA SUZUKIFEST', N'2012', 4, NULL, 5)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (3, N'DR-Z400E', N'2013', 4, NULL, 5)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (4, N'CHEROKEE', N'2020', 1, NULL, 6)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (5, N'Compass', N'2019', 1, NULL, 6)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (6, N'MX-5', N'2018', 3, NULL, 8)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (7, N'Mazda-6', N'2019', 3, NULL, 8)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (8, N'Camry Hybrid GX', N'2019', 2, NULL, 7)
INSERT INTO [dbo].[Model] ([Id], [Model_Name], [Model_Year], [Company_Id], [CompanyId], [DealerId]) VALUES (9, N'gr supra', N'2020', 2, NULL, 7)
SET IDENTITY_INSERT [dbo].[Model] OFF
SET IDENTITY_INSERT [dbo].[Specification] ON
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (1, N'Regular', N'auto', N'no', N'4.2', 1)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (2, N'Regular', N'auto', N'no', N'4.5', 2)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (3, N'Regular', N'auto', N'no', N'4.0', 3)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (4, N'Diesel', N'8-gear automatic', N'yes', N'4.5', 4)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (5, N'Petrol', N'Automatic', N'yes', N'4.6', 5)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (6, N'Premium unleaded', N'6-speed manual', N'yes', N'4.5', 6)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (7, N'Petrol', N'Automatic', N'yes', N'4.2', 7)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (8, N'Hybrid', N'auto', N'yes', N'4.6', 8)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (9, N'Premium unleaded', N'Automatic', N'yes', N'4.5', 9)
SET IDENTITY_INSERT [dbo].[Specification] OFF

 
