using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchievementsProject
{
    class Advancement
    {
        //создание ачивки
        public Advancement(string advName, string advDescription, bool isMentorAdv, bool isKidAdv, DateTime advTimeCompleted)
        {
            //имя
            if (advName == "")
                this.advName = "name_not_given";
            else this.advName = advName;

            //описание
            if (advDescription == "")
                this.advDescription = "description_not_given";
            else this.advDescription = advDescription;
            
            //ачивка вопспитателя?
            this.isMentorAdv = isMentorAdv;

            //ачивка ребенка?
            this.isKidAdv = isMentorAdv;

            //время получения ачивки
            this.advTimeCompleted = advTimeCompleted;
        }

        //имя
        private string advName;
        public string AdvName { get => advName; }

        //описание
        private string advDescription;
        public string AdvDescription { get => advDescription; }

        //ачивка воспитателя?
        private bool isMentorAdv;
        public bool IsMentorAdv { get => isMentorAdv; }

        //ачивка ребенка?
        private bool isKidAdv;
        public bool IsKidAdv { get => isKidAdv; }

        //время получения ачивки
        private DateTime advTimeCompleted;
        public DateTime AdvTimeCompleted { get => advTimeCompleted; }

        //для сравнения ачивок
        public static bool operator ==(Advancement adv1, Advancement adv2)
        {
            return adv1.advName == adv2.advName;
        }
        public static bool operator !=(Advancement adv1, Advancement adv2)
        {
            return adv1.advName != adv2.advName;
        }
    }
}
