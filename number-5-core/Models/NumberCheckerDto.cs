namespace number_5_core.Models
{
    public class NumberCheckerDto
    {
        public NumberCheckerDto(long difference)
        {
            Valid = true;
            Difference = difference;
        }
        public NumberCheckerDto(string error)
        {
            Valid = false;
            Error = error;
        }

        public bool Valid { get; set; }
        public string Error { get; set; }
        public long? Difference { get; set; }
    }
}
