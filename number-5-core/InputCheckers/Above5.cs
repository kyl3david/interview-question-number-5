using number_5_core.Interfaces;
using number_5_core.Models;

namespace number_5_core.InputCheckers
{
    public class Above5 : IInputChecker
    {
        public InputCheckerDto Validate(string input)
        {
            if (long.TryParse(input, out long num))
                if (num > 5)
                    return new InputCheckerDto(error: "Input is above 5.");

            return new InputCheckerDto(valid: true);
        }
    }
}
