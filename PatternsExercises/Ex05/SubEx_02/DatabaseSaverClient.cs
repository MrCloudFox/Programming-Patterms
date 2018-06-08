using Patterns.Ex05.ExternalLibs;
using System.Collections.Generic;

namespace Patterns.Ex05.SubEx_02
{
    /// <summary>
    /// Наблюдатель (первое решение)
    /// </summary>
    //public interface ISubscriber
    //{
    //    void DoSomething();
    //}

    //public class SubscribeService
    //{
    //    private List<ISubscriber> subscribers = new List<ISubscriber>();
    //    private IDatabaseSaver databaseSaver;
    //    private MailSender mailSender;
    //    private CacheUpdater cacheUpdater;

    //    public SubscribeService(IDatabaseSaver databaseSaver)
    //    {
    //        this.databaseSaver = databaseSaver;
    //        mailSender = new MailSender();
    //        cacheUpdater = new CacheUpdater();
    //    }


    //    public void addSubscriber(ISubscriber subscriber)
    //    {
    //        subscribers.Add(subscriber);
    //    }


    //    public void removeSubscriber(ISubscriber subscriber)
    //    {
    //        subscribers.Remove(subscriber);
    //    }


    //    public void Notify(object obj)
    //    {
    //        databaseSaver.SaveData(obj);
    //        mailSender.Send(null);
    //        cacheUpdater.UpdateCache();
    //        foreach (ISubscriber subscr in subscribers)
    //        {
    //            subscr.DoSomething();
    //        }
    //    }

    //}


    /// <summary>
    /// Декоратор (второе решение)
    /// </summary>
    public class MyDecorator : IDatabaseSaver
    {
        private IDatabaseSaver databaseSaver;

        public MyDecorator(IDatabaseSaver databaseSaver)
        {
            this.databaseSaver = databaseSaver;
        }

        public void SaveData(object obj)
        {
            databaseSaver.SaveData(obj);
        }

    }


    public class SomeChildDecorator : MyDecorator
    {
        private IDatabaseSaver databaseSaver;
        private MailSender mailSender;
        private CacheUpdater cacheUpdater;

        public SomeChildDecorator(IDatabaseSaver databaseSaver, MailSender mailSender, CacheUpdater cacheUpdater)
           : base(databaseSaver)
        {
            this.mailSender = mailSender;
            this.cacheUpdater = cacheUpdater;
        }


        public void SaveData(object obj)
        {
            databaseSaver.SaveData(obj);
            mailSender.Send(null);
            cacheUpdater.UpdateCache();
            // I can add more methods
        }
    }


    public class DatabaseSaverClient
    {

        public void Main(bool b)
        {
            var databaseSaver = new DatabaseSaver();
            //var subscribeService = new SubscribeService(databaseSaver); // First resolution
            //subscribeService.Notify(null);                              // First resolution
            var databaseSaverDec = new SomeChildDecorator(databaseSaver, new MailSender(), new CacheUpdater());  // Second resolution
            DoSmth(databaseSaver);
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}
