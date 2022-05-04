using Foundation;
using UIKit;
using ObjCRuntime;

namespace LottieProxyiOS.Binding
{
	// @interface LottieAnimationViewWrapper : NSObject
	[BaseType(typeof(NSObject))]
	interface LottieAnimationViewWrapper
	{
		// -(void)initAnimation __attribute__((objc_method_family("none")));
		[Export("initAnimation")]
		void InitAnimation();

		// -(void)setAnimationWithAnimation:(NSString * _Nonnull)animation;
		[Export("setAnimationWithAnimation:")]
		void SetAnimationWithAnimation(string animation);

		// -(UIView * _Nonnull)getView __attribute__((warn_unused_result("")));
		[Export("getView")]
		UIView View { get; }
	}
}
