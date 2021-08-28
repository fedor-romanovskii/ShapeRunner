namespace ShapeRunner.Game.Services
{
    public class ServiceContainer
    {
        private static ServiceContainer _instance;
        public static ServiceContainer Instance => _instance ?? (_instance = new ServiceContainer());

        public void RegisterAsSingle<T>(T implementation) where T : IService
        {
            Implementation<T>.Service = implementation;
        }

        public T GetSingle<T>() where T : IService
        {
            return Implementation<T>.Service;
        }

        private static class Implementation<T> where T : IService
        {
            public static T Service;
        }
    }
}