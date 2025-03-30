--use master;
--drop database if exists EDITORIA;
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'EDITORIA')
BEGIN
    SELECT * FROM sys.databases WHERE name = 'EDITORIA'
    CREATE DATABASE EDITORIA;
    SELECT * FROM sys.databases WHERE name = 'EDITORIA'
END
ELSE
BEGIN
    PRINT 'DATABASE EDITORIA ALREADY EXISTS'
END

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'EDITORIA')
BEGIN
    SELECT DB_NAME() as 'CURRENT DATABASE';
    USE EDITORIA;
    --GO
    SELECT DB_NAME() as 'CURRENT DATABASE';
    IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'ABBONATI')
    BEGIN
        CREATE TABLE ABBONATI(
        codAbbonato int primary key identity(1,1) not null,
        cognome varchar(50) not null,
        nome varchar(50) not null,
        indirizzo varchar(50) null,
        citta varchar(50) null);
    END;
    IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'PUBBLICAZIONI')
    BEGIN
        CREATE TABLE PUBBLICAZIONI(
        codPubblicazioni int primary key identity(1,1),
        Titolo varchar(50) not null,
        Periodicità VARCHAR(50) DEFAULT('ANNUALE'),
        GR CHAR DEFAULT('G'),
        CostoTrimestrale FLOAT DEFAULT(20),
        CostoSemestrale FLOAT DEFAULT(40),
        CostoAnnuale FLOAT DEFAULT(60)
        );
    END;
    
    IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'ARGOMENTI')
    BEGIN
        CREATE TABLE ARGOMENTI(
        codArgomento INT PRIMARY KEY IDENTITY(1,1),
        Descrizione VARCHAR(100) NOT NULL);
    END;
    
    IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'ARTICOLI')
    BEGIN
        CREATE TABLE ARTICOLI(
        codArticolo INT PRIMARY KEY IDENTITY(1,1),
        Titolo VARCHAR(50) NOT NULL,
        Testo VARCHAR(50) NOT NULL,
        Fotografia VARCHAR(100) NOT NULL,
        annoPubblicazione INT,
        codPubblicazioni INT,
        FOREIGN KEY (codPubblicazioni) REFERENCES PUBBLICAZIONI(codPubblicazioni) );
    END;
    
    IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'TRATTANO')
    BEGIN
        CREATE TABLE TRATTANO(codPubblicazioni INT,
        codArgomento  INT,
        PRIMARY KEY (codPubblicazioni,codArgomento ),
        FOREIGN KEY (codPubblicazioni) REFERENCES PUBBLICAZIONI(codPubblicazioni),
        FOREIGN KEY (codArgomento) REFERENCES ARGOMENTI(codArgomento) );
    END;
    
    IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'ABBONAMENTI')
    BEGIN
        CREATE TABLE ABBONAMENTI(
        codPubblicazioni INT not null,
        codAbbonato INT not null,
        dataAbbonamento DATE DEFAULT GETDATE(),
        tipoAbbonamento VARCHAR(50) DEFAULT('ANNUALE'),
        idAbbonamento INT PRIMARY KEY IDENTITY(1,1),
        FOREIGN KEY (codPubblicazioni) REFERENCES PUBBLICAZIONI(codPubblicazioni),
        FOREIGN KEY (idAbbonamento) REFERENCES ABBONATI(codAbbonato));
    END;
    
    DECLARE @MaxTable TABLE(Abbonati int,pubblicazioni int)
    DECLARE  @MaxAbbonati int;
    DECLARE  @MaxPubblicazioni int;
    
    INSERT INTO PUBBLICAZIONI(Titolo)
    OUTPUT inserted.codPubblicazioni INTO @MaxTable(pubblicazioni)
    VALUES ('pubblicazione'+CAST(IDENT_CURRENT('PUBBLICAZIONI') as varchar));
    
    INSERT INTO ABBONATI(cognome,nome)
    OUTPUT inserted.codAbbonato INTO @MaxTable(Abbonati)
    VALUES
    (
    'cognome'+CAST(IDENT_CURRENT('ABBONATI') AS varchar),
    'nome'+CAST(IDENT_CURRENT('ABBONATI') AS varchar)
    );
    
    SELECT 
        @MaxAbbonati = Abbonati 
    FROM @MaxTable
    where Abbonati is not null
    SELECT 
        @MaxPubblicazioni = pubblicazioni 
    FROM @MaxTable
    where pubblicazioni is not null
    
    --SELECT * FROM @MaxTable
    --SELECT @MaxAbbonati
    --SELECT @MaxPubblicazioni
    
    INSERT INTO ABBONAMENTI(codPubblicazioni,codAbbonato)
    VALUES(
        round(RAND()*(@MaxPubblicazioni-1)+1,1),
        round(RAND()*(@MaxAbbonati-1)+1,1)
    );
    
    --DELETE FROM ABBONAMENTI
    --DELETE FROM PUBBLICAZIONI
    --DELETE FROM ABBONATI
    
    --DROP TABLE ABBONAMENTI,ABBONATI,PUBBLICAZIONI,ARGOMENTI,ARTICOLI,TRATTANO
    
    SELECT * from ABBONAMENTI
    SELECT * from PUBBLICAZIONI
    SELECT * from ABBONATI
END
ELSE
BEGIN
    PRINT 'DATABASE EDITORIA NOT EXISTS'
END