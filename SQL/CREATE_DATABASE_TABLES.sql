CREATE DATABASE IF4101_B97452_LAB1
GO 

USE IF4101_B97452_LAB1
GO

CREATE SCHEMA COUNTRIES
GO

CREATE SCHEMA CURRENCY
GO

CREATE TABLE CURRENCY.B97452_IF4101_tb_CURRENCY
(
	 CURRENCY_ID   INT IDENTITY(1,1) PRIMARY KEY 
	,CURRENCY_NAME VARCHAR(50) NOT NULL
	,DOLLAR_VALUE  DECIMAL(10,5) NOT NULL
)

CREATE TABLE COUNTRIES.B97452_IF4101_tb_COUNTRY
(
	 COUNTRY_ID   INT IDENTITY(1,1) PRIMARY KEY 
	,CURRENCY_ID  INT				NOT NULL
	,COUNTRY_NAME VARCHAR(50)		NOT NULL
	,CONSTRAINT FK_COUNTRY_CURRENCY FOREIGN KEY(CURRENCY_ID)
		REFERENCES CURRENCY.B97452_IF4101_tb_CURRENCY(CURRENCY_ID)
)