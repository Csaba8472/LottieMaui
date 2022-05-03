using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Hcsaba.Mylibrary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hcsaba.mylibrary']/class[@name='LottieAnimationViewWrapper']"
	[global::Android.Runtime.Register ("com/hcsaba/mylibrary/LottieAnimationViewWrapper", DoNotGenerateAcw=true)]
	public partial class LottieAnimationViewWrapper : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/hcsaba/mylibrary/LottieAnimationViewWrapper", typeof (LottieAnimationViewWrapper));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected LottieAnimationViewWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hcsaba.mylibrary']/class[@name='LottieAnimationViewWrapper']/constructor[@name='LottieAnimationViewWrapper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.hcsaba.mylibrary.LottieSdkCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/hcsaba/mylibrary/LottieSdkCallback;)V", "")]
		public unsafe LottieAnimationViewWrapper (global::Android.Content.Context? context, global::Com.Hcsaba.Mylibrary.ILottieSdkCallback? sdkCallback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/hcsaba/mylibrary/LottieSdkCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((sdkCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdkCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (sdkCallback);
			}
		}

		static Delegate? cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Hcsaba.Mylibrary.LottieAnimationViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View? View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hcsaba.mylibrary']/class[@name='LottieAnimationViewWrapper']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_setAnimation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAnimation_Ljava_lang_String_Handler ()
		{
			if (cb_setAnimation_Ljava_lang_String_ == null)
				cb_setAnimation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAnimation_Ljava_lang_String_);
			return cb_setAnimation_Ljava_lang_String_;
		}

		static void n_SetAnimation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Hcsaba.Mylibrary.LottieAnimationViewWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var animation = JNIEnv.GetString (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimation (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hcsaba.mylibrary']/class[@name='LottieAnimationViewWrapper']/method[@name='setAnimation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAnimation", "(Ljava/lang/String;)V", "GetSetAnimation_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAnimation (string? animation)
		{
			const string __id = "setAnimation.(Ljava/lang/String;)V";
			IntPtr native_animation = JNIEnv.NewString (animation);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_animation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_animation);
			}
		}

	}
}
