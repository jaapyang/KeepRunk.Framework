using KeepRunk.Dto.Core;

namespace KeepRunk.Application.Core
{
    public interface IApplicationOutput
    {
        ApplicationServiceStatus Status { get; set; }
    }
}