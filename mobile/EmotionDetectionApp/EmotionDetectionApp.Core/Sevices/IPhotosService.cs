using System;
using System.Collections.Generic;
using System.Text;

namespace EmotionDetectionApp.Core.Sevices
{
    interface IPhotosService
    {
        void TakePhoto();
        void Analyze();

    }
}
