CREATE TABLE [dbo].[CheckOutModels] (
    [ID]         INT IDENTITY (1, 1) NOT NULL,
    [CustId] INT NULL,
    [VidID]    INT NULL,
	[RentalDate] DATETIME Not Null,
	[ReturnDate] DATETIME NOT NULL,
    CONSTRAINT [PK_CheckOutModels] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_CheckOutModels_customers_customerID] FOREIGN KEY ([CustId]) REFERENCES [dbo].[customers] ([ID]),
    CONSTRAINT [FK_CheckOutModels_videos_videoID] FOREIGN KEY ([VidID]) REFERENCES [dbo].[videos] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CheckOutModels_customerID]
    ON [dbo].[CheckOutModels]([custID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CheckOutModels_videoID]
    ON [dbo].[CheckOutModels]([vidID] ASC);

