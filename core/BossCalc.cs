using System;
using System.Collections.Generic;
using System.Linq;

namespace COUNTDOWN.core
{
    public class BossCalc
    {
        List<BossList> Bosses = new List<BossList>();
        List<tempList> tempBosses = new List<tempList>();

        public string   boss1 = "Unavailable";
        public string   boss2 = "";
        public string   day = "";
        public int      spawntime = 999;
        
        public void GenerateList()
        {
            //Monday
            Bosses.Add(new BossList("Kutum","Karanda", 0, 15,   "Monday"));
            Bosses.Add(new BossList("Karanda","", 2, 0,    "Monday"));
            Bosses.Add(new BossList("Kzarka","", 5, 0,    "Monday"));
            Bosses.Add(new BossList("Kzarka","", 9, 0,    "Monday"));
            Bosses.Add(new BossList("Offin","", 12, 0,   "Monday"));
            Bosses.Add(new BossList("Kutum","", 16, 0,   "Monday"));
            Bosses.Add(new BossList("Nouver","", 19, 0,   "Monday"));
            Bosses.Add(new BossList("Kzarka","", 22, 15,  "Monday"));
            //Bosses.Add(new BossList("","", 23, 15,  "Monday"));

            //Tuesday
            Bosses.Add(new BossList("Karanda","", 0, 15,  "Tuesday"));
            Bosses.Add(new BossList("Kutum","", 2, 0,   "Tuesday"));
            Bosses.Add(new BossList("Kzarka","", 5, 0,   "Tuesday"));
            Bosses.Add(new BossList("Nouver","", 9, 0,   "Tuesday"));
            Bosses.Add(new BossList("Kutum","", 12, 0,  "Tuesday"));
            Bosses.Add(new BossList("Nouver","", 16, 0,  "Tuesday"));
            Bosses.Add(new BossList("Karanda","", 19, 0,  "Tuesday"));
            Bosses.Add(new BossList("Garmoth","", 22, 15, "Tuesday"));
            //Bosses.Add(new BossList("","", 23, 15, "Tuesday"));

            //Wednesday
            Bosses.Add(new BossList("Kutum","Kzarka", 0, 15,  "Wednesday"));
            Bosses.Add(new BossList("Karanda","", 2, 0,   "Wednesday"));
            Bosses.Add(new BossList("Kzarka","", 5, 0,   "Wednesday"));
            Bosses.Add(new BossList("Karanda","", 9, 0,   "Wednesday"));
            Bosses.Add(new BossList("Maintenance","", 10, 0,  "Wednesday"));
            Bosses.Add(new BossList("Kutum","", 16, 0,  "Wednesday"));
            Bosses.Add(new BossList("Offin","", 19, 0,  "Wednesday"));
            Bosses.Add(new BossList("Karanda","Kzarka", 22, 15, "Wednesday"));
            Bosses.Add(new BossList("Quint","Muraka", 23, 15, "Wednesday"));

            //Thursday
            Bosses.Add(new BossList("Nouver","", 0, 15,  "Thursday"));
            Bosses.Add(new BossList("Kutum","", 2, 0,   "Thursday"));
            Bosses.Add(new BossList("Nouver","", 5, 0,   "Thursday"));
            Bosses.Add(new BossList("Kutum","", 9, 0,   "Thursday"));
            Bosses.Add(new BossList("Nouver","", 12, 0,  "Thursday"));
            Bosses.Add(new BossList("Kzarka","", 16, 0,  "Thursday"));
            Bosses.Add(new BossList("Kutum","", 19, 0,  "Thursday"));
            Bosses.Add(new BossList("Garmoth","", 22, 15, "Thursday"));
            //Bosses.Add(new BossList("","", 23, 15, "Thursday"));

            //Friday
            Bosses.Add(new BossList("Kzarka","Karanda", 0, 15,  "Friday"));
            Bosses.Add(new BossList("Nouver","", 2, 0,   "Friday"));
            Bosses.Add(new BossList("Karanda","", 5, 0,   "Friday"));
            Bosses.Add(new BossList("Kutum","", 9, 0,   "Friday"));
            Bosses.Add(new BossList("Karanda","", 12, 0,  "Friday"));
            Bosses.Add(new BossList("Nouver","", 16, 0,  "Friday"));
            Bosses.Add(new BossList("Kzarka","", 19, 0,  "Friday"));
            Bosses.Add(new BossList("Kutum","Kzarka", 22, 15, "Friday"));
            //Bosses.Add(new BossList("","", 23, 15, "Friday"));

            //Saturday
            Bosses.Add(new BossList("Karanda","", 0, 15,  "Saturday"));
            Bosses.Add(new BossList("Offin","", 2, 0,   "Saturday"));
            Bosses.Add(new BossList("Nouver","", 5, 0,   "Saturday"));
            Bosses.Add(new BossList("Kutum","", 9, 0,   "Saturday"));
            Bosses.Add(new BossList("Nouver","", 12, 0,  "Saturday"));
            Bosses.Add(new BossList("Quint","Muraka", 16, 0,  "Saturday"));
            Bosses.Add(new BossList("Kzarka","Karanda", 19, 0,  "Saturday"));
            Bosses.Add(new BossList("Conquest","War", 22, 15, "Saturday"));
            //Bosses.Add(new BossList("","", 23, 15, "Saturday"));

            //Sunday
            Bosses.Add(new BossList("Nouver","Kutum", 0, 15,  "Sunday"));
            Bosses.Add(new BossList("Kzarka","", 2, 0,   "Sunday"));
            Bosses.Add(new BossList("Kutum","", 5, 0,   "Sunday"));
            Bosses.Add(new BossList("Nouver","", 9, 0,   "Sunday"));
            Bosses.Add(new BossList("Kzarka","", 12, 0,  "Sunday"));
            Bosses.Add(new BossList("Vell","", 16, 0,  "Sunday"));
            Bosses.Add(new BossList("Garmoth","", 19, 0,  "Sunday"));
            Bosses.Add(new BossList("Kzarka","Nouver", 22, 15, "Sunday"));
            //Bosses.Add(new BossList("","", 23, 15, "Sunday"));

        }


        public void getNextBoss()
        {
            tempBosses.Clear();
            var dt = DateTime.UtcNow.AddHours(1);
            int Seconds = Convert.ToInt32(dt.TimeOfDay.TotalSeconds);
            int Minutes = (Seconds - (Seconds % 60)) / 60;
            int extraMinutes = 0;

            for (int i = 0; i < 7; i++)
            {
                foreach (var BossList in Bosses)
                {

                    if ((((BossList.hour() * 60) + BossList.minute()) - Minutes) > 0 && BossList.day() == dt.DayOfWeek.ToString())
                    {
                        if (!string.IsNullOrEmpty(BossList.boss1()) || !string.IsNullOrEmpty(BossList.boss2()))
                            tempBosses.Add(new tempList(BossList.boss1(), BossList.boss2(), BossList.hour(), BossList.minute(), BossList.day()));
                    }
                }
                if (tempBosses.Any())
                {
                    break;
                } 
            }

            if (!tempBosses.Any())
            {
                for (int i = 1; i < 7; i++)
                {
                    foreach (var BossList in Bosses)
                    {

                        if (BossList.day() == dt.AddDays(i).DayOfWeek.ToString())
                        {
                            if (!string.IsNullOrEmpty(BossList.boss1()) || !string.IsNullOrEmpty(BossList.boss2()))
                                tempBosses.Add(new tempList(BossList.boss1(), BossList.boss2(), BossList.hour(), BossList.minute(), BossList.day()));
                        }
                    }
                    if (tempBosses.Any())
                    {
                        extraMinutes = 1440 * i;
                        break;
                    }
                }
            }

            if (!tempBosses.Any())
            {
                boss1 = "Unavailable";
                boss2 = "";
                day = "";
                spawntime = 999;
            }
            else
            {
                boss1 = tempBosses[0].boss1();
                boss2 = tempBosses[0].boss2();
                day = tempBosses[0].day();
                spawntime = ((tempBosses[0].hour() * 60) + tempBosses[0].minute() - Minutes) + extraMinutes;
            }
        }

        public string getBosses(string c)
        {
            if (c == "bosses")
            {
                if (string.IsNullOrEmpty(boss1) || string.IsNullOrEmpty(boss2))
                {
                    if (!string.IsNullOrEmpty(boss1))
                    {
                        return boss1;
                    }
                    else if (!string.IsNullOrEmpty(boss2))
                    {
                        return boss2;
                    }
                }
                else
                    return boss1 + "/" + boss2;
            }
            else if (c == "spawntime")
            {
                return (spawntime / 60).ToString("00") + ":" + (spawntime % 60).ToString("00");
            }
            return "unavailable";
        }
    }
}
