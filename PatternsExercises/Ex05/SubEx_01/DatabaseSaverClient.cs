using Patterns.Ex05.ExternalLibs;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Ex05.SubEx_01
{

    /// <summary>
    /// Наблюдатель
    /// </summary>
    public class DatabaseSaverWithSubscribers : IDatabaseSaver
    {
        //private List<object> subscribers = new List<object>();


        //public void addSubscriber(object subscriber)
        //{
        //    subscribers.Add(subscriber);
        //}


        //public void removeSubscriber(object subscriber)
        //{
        //    subscribers.Remove(subscriber);
        //}


        //public void notify()
        //{

        //}

        private MailSender mailSender = new MailSender();
        private CacheUpdater cacheUpdater = new CacheUpdater();
        private IDatabaseSaver databaseSaver;

        public DatabaseSaverWithSubscribers(IDatabaseSaver databaseSaver)
        {
            this.databaseSaver = databaseSaver;
        }
        

        public void SaveData(object data)
        {
            databaseSaver.SaveData(null);
            mailSender.Send("");
            cacheUpdater.UpdateCache();
        }


    }


    public class DatabaseSaverClient
    {

        public void Main(bool b)
        {
            //var databaseSaver = new DatabaseSaver();
            var databaseSaverWithSubscribers = new DatabaseSaverWithSubscribers(new DatabaseSaver());
            DoSmth(databaseSaverWithSubscribers);
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}