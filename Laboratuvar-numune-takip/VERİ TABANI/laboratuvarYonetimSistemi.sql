USE [laboratuvarYonetimSistemi]
GO
/****** Object:  Table [dbo].[duyurular]    Script Date: 18.05.2019 14:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[duyurular](
	[duyuru_id] [int] IDENTITY(1,1) NOT NULL,
	[konu] [nvarchar](50) NULL,
	[duyurular] [nvarchar](max) NULL,
 CONSTRAINT [PK_duyurular] PRIMARY KEY CLUSTERED 
(
	[duyuru_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanicilar]    Script Date: 18.05.2019 14:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicilar](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[yetki] [int] NOT NULL,
	[kullanici_image] [varbinary](1024) NULL,
	[ad_soyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[laboratuvar_musteri]    Script Date: 18.05.2019 14:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[laboratuvar_musteri](
	[firma_id] [int] IDENTITY(1,1) NOT NULL,
	[istek_no] [nvarchar](15) NULL,
	[firma_adi] [nvarchar](50) NULL,
	[firma_tel] [nvarchar](50) NULL,
	[yetkili_kisi] [nvarchar](50) NULL,
	[firma_mail] [nvarchar](50) NULL,
	[giriste_teslim_alan] [nvarchar](50) NULL,
	[giriste_teslim_eden] [nvarchar](50) NULL,
	[cikista_teslim_alan] [nvarchar](50) NULL,
	[cikista_teslim_eden] [nvarchar](50) NULL,
	[firma_adres] [nvarchar](500) NULL,
	[firma_not] [nvarchar](500) NULL,
	[giris_tarihi] [nvarchar](50) NULL,
	[test_tarihi] [nvarchar](50) NULL,
	[bitis_tarihi] [nvarchar](50) NULL,
	[numune_durum] [int] NOT NULL,
	[teknikDeger] [bit] NOT NULL,
	[yardimciEkipman] [bit] NOT NULL,
	[gozleKontrol] [bit] NOT NULL,
	[ambalajKontrol] [bit] NOT NULL,
 CONSTRAINT [PK_labaratuvar_musteri] PRIMARY KEY CLUSTERED 
(
	[firma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri_tablosu]    Script Date: 18.05.2019 14:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri_tablosu](
	[firma_id] [int] IDENTITY(1,1) NOT NULL,
	[firma_ad] [nvarchar](100) NULL,
	[firma_tel] [nvarchar](100) NULL,
	[firma_mail] [nvarchar](100) NULL,
	[gorusulenKisi] [nvarchar](100) NULL,
	[gorusenPersonel] [nvarchar](100) NULL,
	[firma_adres] [nvarchar](max) NULL,
	[notlar] [nvarchar](max) NULL,
	[gorusme_tarihi] [nvarchar](100) NULL,
	[sektor] [nchar](100) NULL,
	[il] [nchar](100) NULL,
	[musteri_durum] [int] NOT NULL,
 CONSTRAINT [PK_musteri_tablosu] PRIMARY KEY CLUSTERED 
(
	[firma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notlar]    Script Date: 18.05.2019 14:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notlar](
	[not_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[notlar] [nvarchar](max) NULL,
 CONSTRAINT [PK_notlar] PRIMARY KEY CLUSTERED 
(
	[not_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[numune_tablosu]    Script Date: 18.05.2019 14:59:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[numune_tablosu](
	[numune_id] [int] IDENTITY(1,1) NOT NULL,
	[numune_numarasi] [nvarchar](50) NULL,
	[numune_ad] [nvarchar](50) NULL,
	[deney_methodu] [nvarchar](50) NULL,
 CONSTRAINT [PK_numune_tablosu] PRIMARY KEY CLUSTERED 
(
	[numune_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[kullanicilar] ADD  CONSTRAINT [DF_kullanicilar_yetki]  DEFAULT ((1)) FOR [yetki]
GO
ALTER TABLE [dbo].[laboratuvar_musteri] ADD  CONSTRAINT [DF_labaratuvar_musteri_numune_durun]  DEFAULT ((1)) FOR [numune_durum]
GO
ALTER TABLE [dbo].[laboratuvar_musteri] ADD  CONSTRAINT [DF_laboratuvar_musteri_teknikDeger]  DEFAULT ((0)) FOR [teknikDeger]
GO
ALTER TABLE [dbo].[laboratuvar_musteri] ADD  CONSTRAINT [DF_laboratuvar_musteri_yardimciEkipman]  DEFAULT ((0)) FOR [yardimciEkipman]
GO
ALTER TABLE [dbo].[laboratuvar_musteri] ADD  CONSTRAINT [DF_laboratuvar_musteri_gozleKontrol]  DEFAULT ((0)) FOR [gozleKontrol]
GO
ALTER TABLE [dbo].[laboratuvar_musteri] ADD  CONSTRAINT [DF_laboratuvar_musteri_ambalajKontrol]  DEFAULT ((0)) FOR [ambalajKontrol]
GO
ALTER TABLE [dbo].[musteri_tablosu] ADD  CONSTRAINT [DF_musteri_tablosu_musteri_durum]  DEFAULT ((1)) FOR [musteri_durum]
GO
