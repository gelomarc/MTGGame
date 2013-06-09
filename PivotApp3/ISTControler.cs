using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class ISTControler
    {
        private static ISTControler instance;
        private ISTControler()
        {}

        public static ISTControler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ISTControler();
                }
                return instance;
            }
        }

        public  void add(string key, object a)
        {
            IsolatedStorageSettings.ApplicationSettings[key] = a;

            IsolatedStorageSettings.ApplicationSettings.Save();
        }

        public object find(string key)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {

                return IsolatedStorageSettings.ApplicationSettings[key];
               
            }
            return null;

        }

        public void delete(string key)
        {
            IsolatedStorageSettings.ApplicationSettings.Remove(key);
        }
    }
}

