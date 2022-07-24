using EFCore.Helper;

namespace Log.Min.Data;

public interface ILogUnitOfWork 
	: IUnitOfWork
{
	ILogRepo Log { get; }
}