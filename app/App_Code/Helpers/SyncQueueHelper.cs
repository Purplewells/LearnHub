using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using zLearnHub.Data;
using zLearnHub.Services;

namespace zLearnHub.Helpers
{



/// <summary>
/// Summary description for SyncQueueHelper
/// </summary>
public static class SyncQueueHelper
{
        /// <summary>
        /// Enqueue any entity into the SyncQueue table for background processing.
        /// </summary>
        /// <param name="entityName">The name of the entity/controller</param>
        /// <param name="entityId">Primary key of the entity</param>
        /// <param name="action">Action performed: Insert, Update, Delete</param>
        /// <param name="entityValues">The row values to serialize as payload</param>
        /// <param name="targetSystem">Destination system, e.g., LMS, ERP</param>
        /// 

        public static void Enqueue(string entityName, int entityId, string action, string entityValues, string targetSystem)
        {
            // Serialize the entity values to JSON
            string payload = new JavaScriptSerializer().Serialize(entityValues);

            // Use SqlText helper provided by Code On Time
            SqlText.ExecuteNonQuery(@"
            INSERT INTO SyncQueue (EntityName, EntityID, Action, Payload, TargetSystem, CreatedAt, Status)
            VALUES (@EntityName, @EntityID, @Action, @Payload, @TargetSystem, GETDATE(), 'Pending')
        ",
            new
            {
                EntityName = entityName,
                EntityID = entityId,
                Action = action,
                Payload = payload,
                TargetSystem = targetSystem
            });
        }
}

}