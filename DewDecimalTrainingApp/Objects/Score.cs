namespace DewDecimalTrainingApp.Objects
{
    public class Score
    {
        int CorrectAttempts { get; set; }

        int TotalAttempts { get; set; }

        public Score()
        {
            this.CorrectAttempts = 0;
            this.TotalAttempts = 0;
        }

        public string UpdateScore()
        {
            return $"Score: {CorrectAttempts}/{TotalAttempts}"; 
        }
    }   
}
