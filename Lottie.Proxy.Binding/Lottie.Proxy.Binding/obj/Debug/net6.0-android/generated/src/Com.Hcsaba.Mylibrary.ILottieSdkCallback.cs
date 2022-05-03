using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Hcsaba.Mylibrary {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.hcsaba.mylibrary']/interface[@name='LottieSdkCallback']"
	[Register ("com/hcsaba/mylibrary/LottieSdkCallback", "", "Com.Hcsaba.Mylibrary.ILottieSdkCallbackInvoker")]
	public partial interface ILottieSdkCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hcsaba.mylibrary']/interface[@name='LottieSdkCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Handler:Com.Hcsaba.Mylibrary.ILottieSdkCallbackInvoker, Lottie.Proxy.Binding")]
		void OnFailure (string? p0);

	}

	[global::Android.Runtime.Register ("com/hcsaba/mylibrary/LottieSdkCallback", DoNotGenerateAcw=true)]
	internal partial class ILottieSdkCallbackInvoker : global::Java.Lang.Object, ILottieSdkCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/hcsaba/mylibrary/LottieSdkCallback", typeof (ILottieSdkCallbackInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ILottieSdkCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILottieSdkCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.hcsaba.mylibrary.LottieSdkCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILottieSdkCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Hcsaba.Mylibrary.ILottieSdkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_String_;
		public unsafe void OnFailure (string? p0)
		{
			if (id_onFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
