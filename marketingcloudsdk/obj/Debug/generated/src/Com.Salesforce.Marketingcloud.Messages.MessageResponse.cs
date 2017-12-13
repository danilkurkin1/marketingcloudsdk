using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Messages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/MessageResponse", DoNotGenerateAcw=true)]
	public abstract partial class MessageResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/MessageResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageResponse); }
		}

		protected MessageResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/constructor[@name='MessageResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_refreshCenter;
#pragma warning disable 0169
		static Delegate GetRefreshCenterHandler ()
		{
			if (cb_refreshCenter == null)
				cb_refreshCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RefreshCenter);
			return cb_refreshCenter;
		}

		static IntPtr n_RefreshCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshCenter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/method[@name='refreshCenter' and count(parameter)=0]"
		[Register ("refreshCenter", "()Lcom/salesforce/marketingcloud/location/LatLon;", "GetRefreshCenterHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Location.LatLon RefreshCenter ();

		static Delegate cb_refreshRadius;
#pragma warning disable 0169
		static Delegate GetRefreshRadiusHandler ()
		{
			if (cb_refreshRadius == null)
				cb_refreshRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RefreshRadius);
			return cb_refreshRadius;
		}

		static int n_RefreshRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RefreshRadius ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/method[@name='refreshRadius' and count(parameter)=0]"
		[Register ("refreshRadius", "()I", "GetRefreshRadiusHandler")]
		public abstract int RefreshRadius ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/MessageResponse", DoNotGenerateAcw=true)]
	internal partial class MessageResponseInvoker : MessageResponse {

		public MessageResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageResponseInvoker); }
		}

		static IntPtr id_refreshCenter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/method[@name='refreshCenter' and count(parameter)=0]"
		[Register ("refreshCenter", "()Lcom/salesforce/marketingcloud/location/LatLon;", "GetRefreshCenterHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Location.LatLon RefreshCenter ()
		{
			if (id_refreshCenter == IntPtr.Zero)
				id_refreshCenter = JNIEnv.GetMethodID (class_ref, "refreshCenter", "()Lcom/salesforce/marketingcloud/location/LatLon;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refreshCenter), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_refreshRadius;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/method[@name='refreshRadius' and count(parameter)=0]"
		[Register ("refreshRadius", "()I", "GetRefreshRadiusHandler")]
		public override unsafe int RefreshRadius ()
		{
			if (id_refreshRadius == IntPtr.Zero)
				id_refreshRadius = JNIEnv.GetMethodID (class_ref, "refreshRadius", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_refreshRadius);
			} finally {
			}
		}

	}

}
