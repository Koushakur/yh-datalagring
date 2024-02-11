DROP TABLE Reviews
DROP TABLE Images
DROP TABLE Categories
DROP TABLE ProductOrder
DROP TABLE ProductCategory
DROP TABLE ProductPrices
DROP TABLE ProductReviews
DROP TABLE ProductImages
DROP TABLE Orders
DROP TABLE Customers
DROP TABLE Currencies
DROP TABLE Products

CREATE TABLE Products (
  [ArticleNumber] nvarchar(256) PRIMARY KEY NOT NULL,
  [Name] nvarchar(256) NOT NULL,
  [Ingress] nvarchar(256),
  [Description] nvarchar(4000) NOT NULL,
  [ThumbnailURL] nvarchar(256),
  [DetailedSpecs] nvarchar(4000)
)

CREATE TABLE Currencies (
  [ISOCode] char(3) PRIMARY KEY NOT NULL,
  [Name] nvarchar(256) NOT NULL,
  [Symbol] nchar(1) NOT NULL
)

CREATE TABLE Customers (
  [Id] int PRIMARY KEY NOT NULL,
  [FirstName] nvarchar(256) NOT NULL,
  [LastName] nvarchar(256),
  [RegisteredDate] datetime2 NOT NULL
)

CREATE TABLE Reviews (
  [Id] int PRIMARY KEY NOT NULL,
  [CustomerId] int NOT NULL references Customers(Id),
  [Rating] tinyint NOT NULL,
  [Titel] nvarchar(256),
  [Content] nvarchar(4000)
)

CREATE TABLE Images (
  [Id] int PRIMARY KEY NOT NULL,
  [ContentURL] nvarchar(4000) NOT NULL
)

CREATE TABLE Categories (
  [Id] int PRIMARY KEY NOT NULL,
  [ParentCategoryId] int references Categories(Id),
  [Name] nvarchar(256) NOT NULL
)

CREATE TABLE Orders (
  [Id] int PRIMARY KEY NOT NULL,
  [CustomerId] int NOT NULL references Customers(Id),
  [ProductList] nvarchar(4000) NOT NULL,
  [Cost] money NOT NULL,
  [CostCurrencyISOCode] char(3) NOT NULL references Currencies(ISOCode),
  [DateOrdered] datetime2 NOT NULL
)

CREATE TABLE [ProductOrder] (
  [ProductId] nvarchar(256) NOT NULL references Products(ArticleNumber),
  [OrderId] int NOT NULL references Orders(Id),
  PRIMARY KEY ([ProductId], [OrderId])
)

CREATE TABLE [ProductCategory] (
  [CategoryId] int NOT NULL references Categories(Id),
  [ArticleNumber] nvarchar(256) NOT NULL references Products(ArticleNumber),
  PRIMARY KEY ([CategoryId], [ArticleNumber])
)

CREATE TABLE [ProductImages] (
  [ArticleNumber] nvarchar(256) NOT NULL references Products(ArticleNumber),
  [ImageID] int NOT NULL references Images(Id),
  PRIMARY KEY ([ArticleNumber], [ImageID])
)

CREATE TABLE [ProductReviews] (
  [ArticleNumber] nvarchar(256) NOT NULL references Products(ArticleNumber),
  [ReviewID] int NOT NULL references Reviews(Id),
  PRIMARY KEY ([ArticleNumber], [ReviewID])
)

CREATE TABLE [ProductPrices] (
  [ArticleNumber] nvarchar(256) PRIMARY KEY NOT NULL references Products(ArticleNumber),
  [CurrencyISOCode] char(3) NOT NULL references Currencies(ISOCode),
  [Price] money NOT NULL,
  [PriceDiscounted] money,
  [PriceLast30Days] money
)