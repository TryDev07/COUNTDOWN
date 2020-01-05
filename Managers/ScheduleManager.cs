using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace COUNTDOWN.Managers
{
    class ScheduleManager
    {
        private static Dictionary<String, ScheduleManager> DataManagerMap = new Dictionary<String, ScheduleManager>();

        public static ScheduleManager getScheduleManager(String name)
        {
            if (name == null)
            {
                MessageBox.Show("ERROR: Value name in getScheduleManager == null");
                return null;
            }
            else
            {
                foreach (String map in DataManagerMap.Keys)
                {
                    if (map == null)
                    {
                        MessageBox.Show("ERROR: Value name map in the foreach section of the method getScheduleManager == null");
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
        
        int[] times;  
        String[] Monday;
        String[] Tuesday;
        String[] Wednesday;
        String[] thursday;
        String[] Friday;
        String[] Sathurday;
        String[] Sunday;

        public ScheduleManager(String name)
        {
            if (name == null)
            {
                MessageBox.Show("ERROR: Value name in ScheduleManager == null");
            }
            else
            {
                DataManagerMap.Add(name, this);
            }
        }

        
    }
}
