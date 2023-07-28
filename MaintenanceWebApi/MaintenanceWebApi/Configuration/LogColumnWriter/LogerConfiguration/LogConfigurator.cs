
using NpgsqlTypes;
using Serilog;
using Serilog.Core;
using Serilog.Filters;
using Serilog.Sinks.PostgreSQL;

namespace MaintenanceWebApi.Configuration.LogColumnWriter.LogerConfiguration
{
    public class LogConfigurator
    {
        public static Logger ConfigureLogger(string connectionString, string seqServerURL)
        {
            Logger log = new LoggerConfiguration()
                .WriteTo.Logger(userLogger => userLogger
                    .Filter.ByIncludingOnly(Matching.FromSource("UserLog")) // Assuming logs related to users are logged with this source
                    .WriteTo.Console()
                    .WriteTo.File("Logs/UserLogs.txt")
                    .WriteTo.PostgreSQL(connectionString, "user_logs", needAutoCreateTable: true,
                       columnOptions: new Dictionary<string, ColumnWriterBase>
                                {
                                    {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
                                    {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
                                    {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
                                    {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
                                    {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
                                    {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
                                    {"user_name", new UserNameColumnWriter()}
                                }))               
                .WriteTo.Logger(equipmentLoger => equipmentLoger
                    .Filter.ByIncludingOnly(Matching.FromSource("EquipmentLpg")) // Assuming logs related to products are logged with this source
                    .WriteTo.Console()
                    .WriteTo.File("Logs/Equipmentlogs.txt")
                    .WriteTo.PostgreSQL(connectionString, "product_logs", needAutoCreateTable: true,
                    columnOptions: new Dictionary<string, ColumnWriterBase>
                                {
                                    {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
                                    {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
                                    {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
                                    {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
                                    {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
                                    {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
                                    {"user_name", new UserNameColumnWriter()}
                                }))       
                //.WriteTo.Seq(seqServerURL)
                .Enrich.FromLogContext()
                .MinimumLevel.Information()
                .CreateLogger();

            return log;
        }

    }
}
