using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchievementsProject
{
    //для работы сортировки по времени получения ачивки
    class AdvancementComparer : IComparer<Advancement>
    {
        public int Compare(Advancement a1, Advancement a2)
        {
            if (a1.AdvTimeCompleted > a2.AdvTimeCompleted)
                return 1;
            else if (a1.AdvTimeCompleted < a2.AdvTimeCompleted)
                return -1;
            else
                return 0;
        }
    }
}
