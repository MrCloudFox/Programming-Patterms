namespace Patterns.Ex02
{
    public class VkUserService : GeneralPartOfGetUserInfo
    {
        /// <summary>
        /// Этот метод содержить дублирование с TwitterUserService.GetUserInfo
        /// необходимо избавиться от дублирования (см. задание)
        /// </summary>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(string pageUrl)
        {
            var userId = Parse(pageUrl);

            VkUser[] users = GetFriendsById(userId);
            UserInfo[] friends = ConvertToUserInfo(users);
            return GetUser(GetName(userId), userId, friends);
        }



        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private string GetName(string userId)
        {
            return "NAME";
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private VkUser[] GetFriendsById(string userId)
        {
            return new VkUser[0];
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        private string Parse(string pageUrl)
        {
            return "USER_ID";
        }


        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="friends"></param>
        /// <returns></returns>
        private UserInfo[] ConvertToUserInfo(VkUser[] friends)
        {
            return new UserInfo[0];
        }
    }
}