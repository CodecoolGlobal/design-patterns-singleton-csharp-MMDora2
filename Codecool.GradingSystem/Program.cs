using Codecool.GradingSystem.Repository;
using Codecool.GradingSystem.Ui;

namespace Codecool.GradingSystem;

class Program
{
    static void Main(string[] args)
    {
        //Task1:
        // var uiSelector = new UiSelector();
        // uiSelector.SelectUi();

        IExamRepository examRepository = new ExamRepository();

        // Injektáljuk az ExamRepository példányát az UiSelector konstruktorába
        var uiSelector = new UiSelector(examRepository);
        uiSelector.SelectUi();
    }
}