USE [IF4101_B97452_LAB1]
GO

CREATE PROCEDURE [COUNTRIES].[sp_INSERT_COUNTRIES] @COUNTRY_NAME VARCHAR(50)
	,@CURRENCY_ID  INT
AS
BEGIN

INSERT INTO [COUNTRIES].[B97452_IF4101_tb_COUNTRY]
(
	[CURRENCY_ID]
  , [COUNTRY_NAME]
)
VALUES
(
 @CURRENCY_ID
,@COUNTRY_NAME
)
END

