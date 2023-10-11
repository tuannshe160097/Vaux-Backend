namespace Vaux.Models
{
    public class Shipment : ModelBase
    {
        public int Id { get; set; }
        public int Status { get; set; }

        public long ShipmentCost { get; set; }
        public long ItemCost { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public static string OrderTotalCostTriggerSql()
        {
            return
                @"
                    CREATE TRIGGER [dbo].[TOTALCOST_UPDATE] ON [dbo].[Shipments]
                        AFTER INSERT
                    AS
                    BEGIN
                        SET NOCOUNT ON;

                        IF ((SELECT TRIGGER_NESTLEVEL('dbo_TOTALCOST_UPDATE')) > 1) RETURN;

                        DECLARE @OrderId INT, @ItemCost INT, @ShipmentCost INT

                        SELECT 
                            @OrderId = [OrderId],
                            @ItemCost = [ItemCost],
                            @ShipmentCost = [ShipmentCost]
                        FROM [inserted]

                        UPDATE [dbo].[Orders]
                        SET [TotalCost] = [TotalCost] + @ItemCost + @ShipmentCost
                        WHERE [Id] = @OrderId
                    END
                ";
        }
    }
}
