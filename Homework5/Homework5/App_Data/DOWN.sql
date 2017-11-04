IF EXISTS
(
	SELECT *
	FROM sys.tables
	WHERE tables.name = 'Customers'

)
BEGIN
	DROP TABLE dbo.Customers
END