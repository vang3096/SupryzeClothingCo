#if __ANDROID__
using SupryzeClothingCo.Droid;
#elif __IOS__
using SupryzeClothingCo.iOS.Helpers;
#elif WINDOWS_UWP
using SupryzeClothingCo.UWP.Helpers;
#endif
using SupryzeClothingCo.Helpers;
using SupryzeClothingCo.Interfaces;
using SupryzeClothingCo.Services;
using SupryzeClothingCo.Model;

namespace SupryzeClothingCo
{
    public partial class App 
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            ServiceLocator.Instance.Register<IMessageDialog, MessageDialog>();
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}