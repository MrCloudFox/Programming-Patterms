using System;
using System.Reflection;
using System.Collections.Generic;

namespace Patterns.Ex01
{
    //Стратегия
    public interface SocNetwokStrategy
    {
        SocialNetworkUser[] GetSubscribers(); 
    }

    public class SubscriberViewer
    {
        public Dictionary<SocialNetwork, SocNetwokStrategy> dict;
        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType)
        {
            return dict[networkType].GetSubscribers();
        }

    }
}
