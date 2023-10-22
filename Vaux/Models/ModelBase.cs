using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Vaux.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Deleted { get; set; }

        public static string GenerateUpdateTriggerSql(string tableName)
        {
            string triggerName = tableName.ToUpper() + "_UPDATE";
            return
                @$"
                    CREATE TRIGGER [dbo].[{triggerName}] ON [dbo].[{tableName}]
                        AFTER UPDATE
                    AS
                    BEGIN
                        SET NOCOUNT ON;

                        IF ((SELECT TRIGGER_NESTLEVEL(OBJECT_ID('dbo_{triggerName}'))) > 1) RETURN;

                        DECLARE @Id INT

                        SELECT @Id = [Id]
                        FROM [inserted]

                        UPDATE dbo.{tableName}
                        SET Updated = GETDATE()
                        WHERE [Id] = @Id
                    END
                ";
        }
    }
}
