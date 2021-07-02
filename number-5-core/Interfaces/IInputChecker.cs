using number_5_core.Models;

namespace number_5_core.Interfaces
{
    public interface IInputChecker
    {
        InputCheckerDto Validate(string input);
    }
}
