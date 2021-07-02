using number_5_core.Interfaces;
using number_5_core.Models;

namespace number_5_core.InputCheckers
{
    public class NonNumericValue : IInputChecker
    {
        public InputCheckerDto Validate(string input)
        {
            if (!long.TryParse(input, out _))
                return new InputCheckerDto(error: "Input is not a numeric value.");

            return new InputCheckerDto(valid: true);
        }
    }
}
