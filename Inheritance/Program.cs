using System;

namespace Inhritance
{
    class Sponcer
    {
        protected string owner = "Rakuteen";
    }

    class Team: Sponcer
    {
        private string teamname = "SecureStrome";
        public void printInfo()
        {
            Console.WriteLine(owner + ": " + teamname);
        }
        static void Main(string[] args)
        {
            Team myteam = new Team();
            myteam.printInfo();
        }
    }


}