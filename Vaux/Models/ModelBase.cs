using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Vaux.Models
{
    public class ModelBase
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Deleted { get; set; }

        public static string GenerateUpdateTriggerSql(string tableName)
        {
            return
                @$"
                    CREATE TRIGGER [dbo].[{tableName.ToUpper()}_UPDATE] ON [dbo].[{tableName}]
                        AFTER UPDATE
                    AS
                    BEGIN
                        SET NOCOUNT ON;

                        IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

                        DECLARE @Id INT

                        SELECT @Id = INSERTED.Id
                        FROM INSERTED

                        UPDATE dbo.{tableName}
                        SET Updated = GETDATE()
                        WHERE Id = @Id
                    END
                ";
        }
    }
}
