using number_5_core.Interfaces;
using number_5_core.Models;

namespace number_5_core.InputCheckers
{
    public class BelowZero : IInputChecker
    {
        public InputCheckerDto Validate(string input)
        {
            if (long.TryParse(input, out long num))
                if (num < 0)
                    return new InputCheckerDto(error: "Input is below 0.");

            return new InputCheckerDto(valid: true);
        }
    }
}
