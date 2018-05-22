using System;
using RPS.Lib;

namespace RPS.App
{
    public class ConsoleUserInterface : IUserInterface
    {
        public string GetFromUser()
        {
            return Console.ReadLine().Trim().ToUpper();
        }

        public void ShowToUser(string message)
        {
            Console.Write(message);
        }
    }
}