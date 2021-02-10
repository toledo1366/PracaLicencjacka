using EmotionDetectionApp.Core.Sevices;
using EmotionDetectionApp.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace EmotionDetectionApp.Core
{
    public class App:MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IPhotosService, PhotosService>();
            RegisterAppStart<MainViewModel>();
        }
    }
}
