using number_5_core.Interfaces;
using number_5_core.Models;

namespace number_5_core.InputCheckers
{
    public class Nothing : IInputChecker
    {
        public InputCheckerDto Validate(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return new InputCheckerDto(error: "Nothing has been inputted.");

            return new InputCheckerDto(valid: true);
        }
    }
}
