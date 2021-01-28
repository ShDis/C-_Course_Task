using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchievementsProject
{
    class Mentor:Person
    {
        public Mentor(string name) : base(name)
        {

        }

        //получить статус воспитателя
        public string GetMentorStatus()
        {
            int count = base.GetAdvCount(); //чекнуть кол-во ачивок

            if (count >= 10)
                return "Platina";
            else if (count >= 5)
                return "Gold";
            else if (count >= 3)
                return "Bronze";
            else return "None";
        }
    }
}
