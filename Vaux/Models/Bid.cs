using System.ComponentModel.DataAnnotations.Schema;

namespace Vaux.Models
{
    public class Bid : ModelBase
    {
        public int Id { get; set; }
        public long Amount { get; set; }

        public int? ItemId { get; set; }
        public Item? Item { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public static string PreventLowerBidsTriggerSql()
        {
            return
                @"
                    CREATE TRIGGER [dbo].[BIDS_PREVENT_LOWER] ON [dbo].[Bids]
                        INSTEAD OF INSERT
                    AS
                    BEGIN
                        SET NOCOUNT ON;

                        IF ((SELECT TRIGGER_NESTLEVEL(OBJECT_ID('dbo.BIDS_PREVENT_LOWER'))) > 1) RETURN;

                        DECLARE @ItemId INT, @Amount INT, @UserId INT

                        SELECT 
                            @ItemId = ItemId,
                            @Amount = Amount,
                            @UserId = UserId
                        FROM inserted

                        IF @Amount > (SELECT ISNULL(MAX(Amount), 0) FROM [dbo].[Bids] WHERE ItemId = @ItemId)
                        BEGIN
                            INSERT INTO [dbo].[Bids] (ItemId, Amount, UserId)
                            VALUES (@ItemId, @Amount, @UserId)
                        END
                        ELSE
                            THROW 50000, 'Cannot insert Bids with lower amount than the current highest', 1;
                    END
                ";
        }
    }
}
