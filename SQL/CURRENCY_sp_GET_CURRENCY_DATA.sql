USE [IF4101_B97452_LAB1]
GO

CREATE PROCEDURE CURRENCY.sp_GET_CURRENCY_DATA
AS
BEGIN
	SELECT 
	  [CURRENCY_ID]
	, [CURRENCY_NAME]
	, [DOLLAR_VALUE]
	FROM [CURRENCY].[B97452_IF4101_tb_CURRENCY]
END

