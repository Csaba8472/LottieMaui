using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if __IOS__ || MACCATALYST
using PlatformView = UIKit.UIView;
#elif ANDROID
using PlatformView = AndroidX.AppCompat.Widget.AppCompatImageView;
#endif

namespace Lottie.Maui;

public partial interface ILottieHandler : IViewHandler
{
	new ILottieView VirtualView { get; }
	new PlatformView PlatformView { get; }
}
