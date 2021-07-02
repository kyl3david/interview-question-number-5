using number_5_core.Interfaces;
using number_5_core.Models;
using System.Collections.Generic;

namespace number_5_core
{
    public class NumberCheckerService
    {
        private List<IInputChecker> inputCheckers { get; set; }
        public NumberCheckerService()
        {
            inputCheckers = new List<IInputChecker>
            {
                new InputCheckers.Nothing(),
                new InputCheckers.NonNumericValue(),
                new InputCheckers.BelowZero(),
                new InputCheckers.Above5(),
                new InputCheckers.Between0And5()
            };
        }

        public NumberCheckerDto DifferenceBetweenInputAnd5(string input)
        {
            try
            {
                foreach (var inputChecker in inputCheckers)
                {
                    var inputCheckerResult = inputChecker.Validate(input: input);
                    if (!inputCheckerResult.Valid)
                        return new NumberCheckerDto(error: inputCheckerResult.Error);
                }

                var num = long.Parse(input);
                var difference = 5 - num;
                return new NumberCheckerDto(difference: difference);
            }
            catch (System.Exception)
            {
                var error = $"Failed to find the difference between the input '{input}' and 5, which wasn't picked up by the InputCheckers.";
                System.Diagnostics.Debug.Fail(message: error);
                return new NumberCheckerDto(error: error);
            }
        }
    }
}
