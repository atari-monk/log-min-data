using EFCore.Helper;

namespace Log.Min.Data;

public class LogUnitOfWork
    : UnitOfWork
        , ILogUnitOfWork
{
    private readonly ILogRepo log;

    public ILogRepo Log => log;

    public LogUnitOfWork(
        LogDbContext context
        , ILogRepo log)
            : base(context)
    {
        this.log = log;
        ArgumentNullException.ThrowIfNull(this.log);
    }
}