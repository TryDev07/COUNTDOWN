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
    }
}
