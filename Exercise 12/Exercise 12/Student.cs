namespace Exercise_12
{
    internal class Student : IStudent
    {
        private readonly List<string> _takenTests;

        public Student()
        {
            _takenTests = new List<string>();
        }

        public string[] TestsTaken => _takenTests.Count == 0 ? new[] { "No tests taken" } : _takenTests.ToArray();

        public void TakeTest(ITestPaper paper, string[] answers)
        {
            var correctAnswers = 0;
            var result = string.Empty;

            for (var i = 0; i < paper.MarkScheme.Length; i++)
            {
                if (paper.MarkScheme[i] == answers[i])
                {
                    correctAnswers++;
                }
            }

            var percentage = (double)correctAnswers / paper.MarkScheme.Length * 100;

            if (percentage >= int.Parse(paper.PassMark.TrimEnd('%')))
            {
                result = "Passed";
            }
            else
            {
                result = "Failed";
            }

            _takenTests.Add($"{paper.Subject}: {result}! ({percentage:0#}%)");
        }
    }
}