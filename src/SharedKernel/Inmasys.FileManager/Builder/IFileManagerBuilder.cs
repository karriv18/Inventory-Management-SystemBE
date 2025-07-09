using Microsoft.Extensions.DependencyInjection;

namespace Inmasys.FileManager.Builder;

public interface IFileManagerBuilder
{
    IServiceCollection Services { get; }    
}
