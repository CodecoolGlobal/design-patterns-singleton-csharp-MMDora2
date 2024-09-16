using Codecool.GradingSystem.Repository;
using Codecool.GradingSystem.Ui;

namespace Codecool.GradingSystem;

class Program
{
    static void Main(string[] args)
    {
        IExamRepository examRepository = new ExamRepository();

        //Inject the instance of ExamRepository into the UiSelector constructor
        var uiSelector = new UiSelector(examRepository);
        uiSelector.SelectUi();
    }
}
