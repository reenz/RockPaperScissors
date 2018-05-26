using System;

namespace RPS.Lib
{
    //this interface is for extracting user input & output
    //created this for testing as Moq cannot mock non-virtual methods and sealed classes
    public interface IUserInterface
    {
        string GetFromUser();

        void ShowToUser(string message);
    }
}