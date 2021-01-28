using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchievementsProject
{
    class Person
    {
        //установка имени
        public Person(string name)
        {
            this.name = name;
        }

        //имя
        private string name;
        public string Name { get => name; }

        //лист ачивок
        private List<Advancement> advList;
        public List<Advancement> AdvList { get => advList; }

        //добавление ачивки
        public bool AddAdv(Advancement adv)
        {
            //проверка, вдруг уже есть
            bool isAdvAlreadyInList = false;
            foreach (Advancement a in this.advList)
            {
                if (a == adv)
                {
                    isAdvAlreadyInList = true;
                    break;
                }
            }

            if (isAdvAlreadyInList)
                return false; //добавление не удалось, тк ачивка уже есть в списке

            else //проверка, чья ачивка?
            {
                bool isMentor = true;
                try
                {
                    Mentor m = (Mentor)this;
                }
                catch
                {
                    isMentor = false;
                    Kid k = (Kid)this;
                }
                if (isMentor && adv.IsMentorAdv || !isMentor && !adv.IsMentorAdv)
                {
                    advList.Add(adv);
                    return true; //ачивка успешно добавлена
                }
                else
                {
                    if (isMentor)
                        return false; //нельзя добавить ачивку ребенка воспитателю
                    else
                        return false; //нельзя добавить ачивку вопитателя ребенку
                }

            }
        }

        //сколько ачивок выполнено за все время?
        public int GetAdvCount()
        {
            return advList.Count();
        }

        //сколько ачивок выполнено за период?
        public int GetAdvCount(DateTime from, DateTime to)
        {
            //List.Sort(advList, new AdvancemntComparer()); //сортировка по времени выполнения
            int count = 0;
            foreach(Advancement a in advList)
            {
                if (a.AdvTimeCompleted != null) //вдруг время не задано
                    if (a.AdvTimeCompleted >= from && a.AdvTimeCompleted <= to)
                        count++;
            }
            return count;
        }
    }
}
