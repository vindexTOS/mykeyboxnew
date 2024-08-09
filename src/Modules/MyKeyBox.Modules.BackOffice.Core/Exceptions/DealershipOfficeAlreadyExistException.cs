using MyKeyBox.Shared.Abstractions.Exception;

namespace MyKeyBox.Modules.BackOffice.Core.Exceptions;

internal class DealershipOfficeAlreadyExistException:CustomException
{
    public DealershipOfficeAlreadyExistException(string dealerName) : base($"Dealer {dealerName} already exist") { }
}