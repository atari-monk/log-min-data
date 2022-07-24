using System.Linq.Expressions;
using EFCore.Helper;

namespace Log.Min.Data;

public interface ILogRepo 
    : IRepository<LogModel>
{
	IEnumerable<LogModel> GetLog(
        Expression<Func<LogModel, bool>>? filter);
}