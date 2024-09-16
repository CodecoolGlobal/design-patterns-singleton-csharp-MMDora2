using Codecool.GradingSystem.Repository;
using Codecool.GradingSystem.Ui;

namespace Codecool.GradingSystem;

class Program
{
    static void Main(string[] args)
    {
        //Inject the instance of ExamRepository into the UiSelector constructor
        var uiSelector = new UiSelector();
        uiSelector.SelectUi();
    }
}
