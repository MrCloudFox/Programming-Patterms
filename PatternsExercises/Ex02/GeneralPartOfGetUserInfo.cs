using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex02
{
    /// <summary>
    /// Шаблонный метод
    /// </summary>
    public abstract class GeneralPartOfGetUserInfo
    {

        //protected abstract string GetName(string pageUrlOrUserId);

        public UserInfo GetUser(string userName, string userId, UserInfo[] friends)
        {
            return new UserInfo
            {
                Name = userName,
                UserId = userId,
                Friends = friends
            };
        }



    }
}
