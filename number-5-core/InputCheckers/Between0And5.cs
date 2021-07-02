using number_5_core.Interfaces;
using number_5_core.Models;

namespace number_5_core.InputCheckers
{
    public class Between0And5 : IInputChecker
    {
        public InputCheckerDto Validate(string input)
        {
            if (long.TryParse(input, out long num))
                if (num >= 0 && num <= 5)
                    return new InputCheckerDto(valid: true);

            return new InputCheckerDto(error: "Input is not between 0 (including) and 5 (including).");
        }
    }
}
