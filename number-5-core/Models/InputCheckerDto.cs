using System;
namespace number_5_core.Models
{
    public class InputCheckerDto
    {
        public InputCheckerDto(bool valid)
        {
            if (!valid)
                throw new ArgumentException(message: "If not valid please use constructor that specifies the error.", paramName: nameof(valid));
            Valid = valid;
        }
        public InputCheckerDto(string error)
        {
            Valid = false;
            Error = error;
        }
        public bool Valid { get; set; }
        public string Error { get; set; }
    }
}
