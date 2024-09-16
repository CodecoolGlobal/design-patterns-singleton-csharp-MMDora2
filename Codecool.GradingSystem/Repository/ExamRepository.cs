using Codecool.GradingSystem.Model;

namespace Codecool.GradingSystem.Repository
{
    public class ExamRepository : IExamRepository
    {
        private static ExamRepository _instance;
        private readonly List<Exam> _exams = new();

        private ExamRepository() { }

        public static ExamRepository GetInstance()
        {
          if (_instance == null)
        {
               _instance = new ExamRepository();
         }
          return _instance;
        }

        public void AddExam(Exam exam)
        {
            _exams.Add(exam);
        }

        public IEnumerable<Exam> GetExams()
        {
            return _exams;
        }
    }
}
