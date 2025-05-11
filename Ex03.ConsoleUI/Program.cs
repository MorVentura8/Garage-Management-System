// $G$ RUL-005 (-20) Wrong zip folder structure, the zip file should contain a single folder. 
// $G$ RUL-004 (-20) Directory name 'A25 Ex03 Mor 211897137 Yakov 208196816' does not match the required format.
// $G$ RUL-003 (-20) Wrong word file name, should be same as the solution name format. 
namespace Ex03.ConsoleUI
{
    internal class Program
    {
        public static void Main() 
        {
            UserInterface startProgram = new UserInterface();
            startProgram.WelcomeToGarage();
        }
    }
}
