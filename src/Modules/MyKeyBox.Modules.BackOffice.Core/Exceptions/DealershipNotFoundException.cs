using MyKeyBox.Shared.Abstractions.Exception;

namespace MyKeyBox.Modules.BackOffice.Core.Exceptions;

internal class DealershipNotFoundException:CustomException
{
    public DealershipNotFoundException(int id) : base($"{id} non found") {}
}