--drop table ARTICOLI;
-- IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'ARTICOLI')
--    BEGIN
--        CREATE TABLE ARTICOLI(
--        codArticolo INT PRIMARY KEY IDENTITY(1,1),
--        Titolo VARCHAR(50) NOT NULL,
--        Testo VARCHAR(50) NOT NULL,
--        Fotografia VARCHAR(100) NOT NULL,
--        annoPubblicazione INT,
--        codPubblicazioni INT,
--        FOREIGN KEY (codPubblicazioni) REFERENCES PUBBLICAZIONI(codPubblicazioni) );
--    END;

DECLARE @codPubblicazioniMax INT;
SELECT @codPubblicazioniMax=IDENT_CURRENT('PUBBLICAZIONI');

INSERT INTO ARTICOLI(Titolo,Testo,Fotografia,annoPubblicazione,codPubblicazioni)
values(
'Titolo'+cast(IDENT_CURRENT('ARTICOLI') as varchar),
'Testo per il '+cast(IDENT_CURRENT('ARTICOLI') as varchar)+' articolo',
'Dunno what to put in here',
ROUND(RAND()*(YEAR(GETDATE())-1970)+1970,1),
ROUND(RAND()*(@codPubblicazioniMax-1)+1,1));

SELECT * FROM ARTICOLI;