
using Microsoft.Maui.Handlers;
using UIKit;
using LottieProxyiOS.Binding;

namespace Lottie.Maui;


public partial class LottieHandler : ViewHandler<ILottieView, UIView>
{

    LottieAnimationViewWrapper platformView;

    private static void MapResetAnimation(LottieHandler handler, ILottieView view, object args)
    {
        //handler.PlatformView.Progress = 0;
    }


    private static void MapIsPlaying(LottieHandler handler, ILottieView view)
    {
        /*
        if (view.IsPlaying)
            handler.PlatformView.PlayAnimation();
        else
            handler.PlatformView.PauseAnimation();

        */
    }
    private static void MapLoops(LottieHandler handler, ILottieView view)
    {
        // handler.PlatformView.Loop(view.Loops);
    }


    public static void MapAnimation(LottieHandler handler, ILottieView view)
    {
        var name = view?.Animation.Split(".")[0];
        handler.UpdateAnimation(name);
    }

    void UpdateAnimation(string name)
    {
        platformView.SetAnimationWithAnimation(name);
    }

    protected override UIView CreatePlatformView()
    {
        platformView = new LottieAnimationViewWrapper();
        platformView.InitAnimation();
        return platformView.View;
    }
}