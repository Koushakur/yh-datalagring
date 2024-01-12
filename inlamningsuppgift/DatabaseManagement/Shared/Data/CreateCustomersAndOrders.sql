CREATE TABLE [Currencies] (
  [ISOCode] char(3) PRIMARY KEY NOT NULL,
  [Name] nvarchar(256) UNIQUE NOT NULL,
  [Symbol] nchar(1) UNIQUE NOT NULL
)
GO

CREATE TABLE [Customers] (
  [Id] int PRIMARY KEY NOT NULL,
  [FirstName] nvarchar(256) NOT NULL,
  [LastName] nvarchar(256),
  [RegisteredDate] datetime2 NOT NULL
)
GO

CREATE TABLE [Orders] (
  [OrderId] int PRIMARY KEY NOT NULL,
  [CustomerId] int NOT NULL REFERENCES Customers(Id),
  [ProductList] nvarchar(4000) NOT NULL,
  [Cost] money NOT NULL,
  [CurrencyISOCode] char(3) NOT NULL REFERENCES Currencies(ISOCode),
  [DateOrdered] datetime2 NOT NULL
)
GO

CREATE TABLE [ProductOrderRows] (
  [ProductId] nvarchar(256) NOT NULL REFERENCES Products(ArticleNumber),
  [OrderId] int NOT NULL REFERENCES Orders(OrderId),
  [Price] money,
  [CurrencyISOCode] char(3) REFERENCES Currencies(ISOCode),
  [Count] int,
  PRIMARY KEY ([ProductId], [OrderId])
)
GO