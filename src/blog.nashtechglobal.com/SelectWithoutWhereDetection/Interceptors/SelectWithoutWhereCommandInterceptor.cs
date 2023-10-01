using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace SelectWithoutWhereDetection.Interceptors;

public class SelectWithoutWhereCommandInterceptor : DbCommandInterceptor
{
    public override InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
    {
        CheckCommand(command);

        return result;
    }

    public override ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result, CancellationToken cancellationToken = default)
    {
        CheckCommand(command);

        return new ValueTask<InterceptionResult<DbDataReader>>(result);
    }

    private void CheckCommand(DbCommand command)
    {
        if (command.CommandText.Contains("SELECT COUNT(*)", StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        if (command.CommandText.Contains("SELECT", StringComparison.OrdinalIgnoreCase))
        {
            if (command.CommandText.Contains("WHERE", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            if (command.CommandText.Contains("OFFSET", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            if (command.CommandText.Contains("FETCH", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var stackTrace = string.Join("\n", Environment.StackTrace.Split('\n')
                .Where(x => x.Contains("at ClassifiedAds."))
                .Select(x => x));

            Log(command.CommandText, stackTrace);
        }
    }

    private void Log(string commandText, string stackTrace)
    {
        File.AppendAllText("../../../logs.txt", $"SELECT WITHOUT WHERE: {Environment.NewLine} {commandText} {Environment.NewLine} {stackTrace} {Environment.NewLine}");
    }
}
