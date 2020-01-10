using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace COUNTDOWN.Managers
{
    class DataManager
    {

        private static Dictionary<String, DataManager> DataManagerMap = new Dictionary<String, DataManager>();

        public static DataManager getDataManager(String name)
        {
            if (name == null)
            {
                MessageBox.Show("ERROR: Value name in getDataManager == null");
                return null;
            }
            else
            {
                foreach (String map in DataManagerMap.Keys)
                {
                    if (map == null)
                    {
                        MessageBox.Show("ERROR: Value name map in the foreach section of the method getDataManager == null");
                        return null;
                    }
                    else
                    {
                        if (name.Contains(map))
                        {
                            return DataManagerMap[name];
                        }
                    }
                }  
            }
            return null;
        }

        
        List<String> Times = new List<string>();
        List<String> MondayBoss = new List<string>();
        List<String> TuesdayBoss = new List<string>();
        List<String> WendsdayBoss = new List<string>();
        List<String> ThursdayBoss = new List<string>();
        List<String> FridayBoss = new List<string>();
        List<String> SathurdayBoss = new List<string>();
        List<String> SundayBoss = new List<string>();


        String times = Properties.Settings.Default.Times;
        String Monday = Properties.Settings.Default.Monday;
        String Tuesday = Properties.Settings.Default.Tuesday;
        String Wendsday = Properties.Settings.Default.Wendsday;
        String Thursday = Properties.Settings.Default.Thursday;
        String Friday = Properties.Settings.Default.Friday;
        String Sathurday = Properties.Settings.Default.Sathurday;
        String Sunday = Properties.Settings.Default.Sunday;

        public DataManager(String name)
        {
            if(name == null)
            {
                MessageBox.Show("ERROR: Value name in DataManager == null");
            }
            else
            {
                DataManagerMap.Add(name, this);
            }
        }

        public void addTimes(String times)
        {
            String[] timeSplit = times.Split(';');

            foreach (String boss in timeSplit)
            {
                Times.Add(boss);
            }
        }
        public List<String> getTimes()
        {
            return Times;
        }


        public void addMondayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach(String boss in bossSplit)
            {
                MondayBoss.Add(boss);
            }
        }
        public void addTuesdayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach (String boss in bossSplit)
            {
                TuesdayBoss.Add(boss);
            }
        }
        public void addWendsdayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach (String boss in bossSplit)
            {
                WendsdayBoss.Add(boss);
            }
        }
        public void addThursdayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach (String boss in bossSplit)
            {
                ThursdayBoss.Add(boss);
            }
        }
        public void addFridayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach (String boss in bossSplit)
            {
                FridayBoss.Add(boss);
            }
        }
        public void addSathurdayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach (String boss in bossSplit)
            {
                SathurdayBoss.Add(boss);
            }
        }
        public void addSundayBosses(String bosses)
        {
            String[] bossSplit = bosses.Split(';');

            foreach (String boss in bossSplit)
            {
                SundayBoss.Add(boss);
            }
        }


        public List<String> getMondayBosses()
        {
            return MondayBoss;
        }
        public List<String> getTuesdayBosses()
        {
            return TuesdayBoss;
        }
        public List<String> getWendsdayBosses()
        {
            return WendsdayBoss;
        }
        public List<String> getThursdayBosses()
        {
            return ThursdayBoss;
        }
        public List<String> getFridayBosses()
        {
            return FridayBoss;
        }
        public List<String> getSathurdayBosses()
        {
            return SathurdayBoss;
        }
        public List<String> getSundayBosses()
        {
            return SundayBoss;
        }
       


        public void load()
        {
            addTimes(times);
            addMondayBosses(Monday);
            addTuesdayBosses(Tuesday);
            addWendsdayBosses(Wendsday);
            addThursdayBosses(Thursday);
            addFridayBosses(Friday);
            addSathurdayBosses(Sathurday);
            addSundayBosses(Sunday);
        }

        public void save()
        {
            string combindedTimes = string.Join(";", Times);
            string combindedMonday = string.Join(";", MondayBoss);
            string combindedTuesday = string.Join(";", TuesdayBoss);
            string combindedWendsday = string.Join(";", WendsdayBoss);
            string combindedThursday = string.Join(";", ThursdayBoss);
            string combindedFriday = string.Join(";", FridayBoss);
            string combindedSathurday = string.Join(";", SathurdayBoss);
            string combindedSunday = string.Join(";", SundayBoss);

            Properties.Settings.Default.Times = combindedTimes;
            Properties.Settings.Default.Monday = combindedMonday;
            Properties.Settings.Default.Tuesday = combindedTuesday;
            Properties.Settings.Default.Wendsday = combindedWendsday;
            Properties.Settings.Default.Thursday = combindedThursday;
            Properties.Settings.Default.Friday = combindedFriday;
            Properties.Settings.Default.Sathurday = combindedSathurday;
            Properties.Settings.Default.Sunday = combindedSunday;
            Properties.Settings.Default.Save();
        }
    }
}
