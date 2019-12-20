CREATE TABLE unsolved (ID INT IDENTITY(1,1),
 CharID AS 'U' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    [under section]  NCHAR (100)  NULL,
    [challan]        NCHAR (100)  NULL,
    [police station] NCHAR (100)  NULL,
    [date]           NCHAR (100)  NULL,
    [court]          NCHAR (100)  NULL,
    [discription]    NCHAR (1000) NULL,
    [name]           NCHAR (100)  NULL,
    [age]            NCHAR (100)  NULL,
    [address]        NCHAR (100)  NULL,
    [number]         NCHAR (100)  NULL,
    [cnic]           NCHAR (100)  NULL,
    [against]        NCHAR (100)  NULL,
    [case status]    NCHAR (100)  NULL,
    [fir no]         NCHAR (100)  NULL, CONSTRAINT PK_YourTable PRIMARY KEY(CharID)

);
CREATE TABLE [dbo].[still] (ID INT IDENTITY(1,1),
 CharID AS 'S' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    [evidence]        NCHAR (100)  NULL,
    [under section]   NCHAR (100)  NULL,
    [police station]  NCHAR (100)  NULL,
    [date]            NCHAR (100)  NULL,
    [criminal status] NCHAR (100)  NULL,
    [discription]     NCHAR (1000) NULL,
    [name]            NCHAR (100)  NULL,
    [age]             NCHAR (100)  NULL,
    [address]         NCHAR (100)  NULL,
    [number]          NCHAR (100)  NULL,
    [cnic]            NCHAR (100)  NULL,
    [fir no]          NCHAR (100)  NULL,
    [case no]         NCHAR (100)  NULL,
    [disposal reason] NCHAR (100)  NULL, CONSTRAINT PK_still PRIMARY KEY(CharID)

);
CREATE TABLE [dbo].[solved] (ID INT IDENTITY(1,1),
 CharID AS 'S' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    
    [under section]  NCHAR (10)  NULL,
    [challan]        NCHAR (100) NULL,
    [police station] NCHAR (100) NULL,
    [date]           NCHAR (100) NULL,
    [court]          NCHAR (100) NULL,
    [discription]    NCHAR (100) NULL,
    [name]           NCHAR (100) NULL,
    [age]            NCHAR (100) NULL,
    [address]        NCHAR (100) NULL,
    [number]         NCHAR (100) NULL,
    [cnic]           NCHAR (100) NULL,
    [against]        NCHAR (100) NULL,
    [case status]    NCHAR (100) NULL,
    [fir no]         NCHAR (100) NULL, CONSTRAINT PK_solved PRIMARY KEY(CharID)

);

CREATE TABLE [dbo].[robery] (ID INT IDENTITY(1,1),
 CharID AS 'R' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    [evidence]      NCHAR (100)  NULL,
    [station]       NCHAR (100)  NULL,
    [date]          NCHAR (100)  NULL,
    [vitness]       NCHAR (100)  NULL,
    [discription]   NCHAR (1000) NULL,
    [name]          NCHAR (100)  NULL,
    [age]           NCHAR (100)  NULL,
    [address]       NCHAR (100)  NULL,
    [phone]         NCHAR (100)  NULL,
    [cnic]          NCHAR (100)  NULL,
    [accuse]        NCHAR (100)  NULL,
    [accuse ph]     NCHAR (100)  NULL,
    [under section] NCHAR (100)  NULL, CONSTRAINT PK_robery PRIMARY KEY(CharID)
);

CREATE TABLE [dbo].[other] (ID INT IDENTITY(1,1),
 CharID AS 'O' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    [evidence]      NCHAR (100)  NULL,
    [station]       NCHAR (100)  NULL,
    [date]          NCHAR (100)  NULL,
    [vitness]       NCHAR (100)  NULL,
    [discription]   NCHAR (1000) NULL,
    [name]          NCHAR (100)  NULL,
    [age]           NCHAR (100)  NULL,
    [address]       NCHAR (100)  NULL,
    [phone]         NCHAR (100)  NULL,
    [cnic]          NCHAR (100)  NULL,
    [accuse]        NCHAR (100)  NULL,
    [accuse ph]     NCHAR (100)  NULL,
    [under section] NCHAR (100)  NULL, CONSTRAINT PK_other PRIMARY KEY(CharID)
);

CREATE TABLE [dbo].[murder] (ID INT IDENTITY(1,1),
 CharID AS 'M' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
   
    [evidence]      NCHAR (100)  NULL,
    [station]       NCHAR (100)  NULL,
    [date]          NCHAR (100)  NULL,
    [vitness]       NCHAR (100)  NULL,
    [discription]   NCHAR (1000) NULL,
    [name]          NCHAR (100)  NULL,
    [age]           NCHAR (100)  NULL,
    [address]       NCHAR (100)  NULL,
    [phone]         NCHAR (100)  NULL,
    [cnic]          NCHAR (100)  NULL,
    [accuse]        NCHAR (100)  NULL,
    [accuse ph]     NCHAR (100)  NULL,
    [under section] NCHAR (100)  NULL, CONSTRAINT PK_murder PRIMARY KEY(CharID)
);


CREATE TABLE [dbo].[disposal] (ID INT IDENTITY(1,1),
 CharID AS 'D' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    
    [evidence]        NCHAR (100)  NULL,
    [under section]   NCHAR (100)  NULL,
    [police station]  NCHAR (100)  NULL,
    [date]            NCHAR (100)  NULL,
    [criminal status] NCHAR (100)  NULL,
    [discription]     NCHAR (1000) NULL,
    [name]            NCHAR (100)  NULL,
    [age]             NCHAR (100)  NULL,
    [address]         NCHAR (100)  NULL,
    [number]          NCHAR (100)  NULL,
    [cnic]            NCHAR (100)  NULL,
    [fir no]          NCHAR (100)  NULL,
    [case no]         NCHAR (100)  NULL,
    [disposal reason] NCHAR (100)  NULL, CONSTRAINT PK_disposal PRIMARY KEY(CharID)
);

CREATE TABLE [dbo].[bell] (ID INT IDENTITY(1,1),
 CharID AS 'B' + RIGHT('000' + CAST(ID AS VARCHAR(3)), 3) PERSISTED,
    
    [evidence]        NCHAR (100) NULL,
    [under section]   NCHAR (100) NULL,
    [police station]  NCHAR (100) NULL,
    [date]            NCHAR (100) NULL,
    [criminal status] NCHAR (100) NULL,
    [discription]     NCHAR (100) NULL,
    [name]            NCHAR (100) NULL,
    [age]             NCHAR (100) NULL,
    [address]         NCHAR (100) NULL,
    [number]          NCHAR (100) NULL,
    [cnic]            NCHAR (100) NULL,
    [fir no]          NCHAR (100) NULL,
    [case no]         NCHAR (100) NULL,
    [disposal reason] NCHAR (100) NULL, CONSTRAINT PK_bell PRIMARY KEY(CharID)
);

delete from murder
delete from robery
delete from other

delete from bell
delete from still
delete from disposal

delete from solved
delete from unsolved




