using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Notifications {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='DefaultUrlPresenter']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/notifications/DefaultUrlPresenter", DoNotGenerateAcw=true)]
	public sealed partial class DefaultUrlPresenter : global::Android.App.Activity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/notifications/DefaultUrlPresenter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultUrlPresenter); }
		}

		internal DefaultUrlPresenter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='DefaultUrlPresenter']/constructor[@name='DefaultUrlPresenter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultUrlPresenter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DefaultUrlPresenter)) {
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

		static IntPtr id_intentForPresenter_Landroid_content_Context_Lcom_salesforce_marketingcloud_notifications_NotificationMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='DefaultUrlPresenter']/method[@name='intentForPresenter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.salesforce.marketingcloud.notifications.NotificationMessage']]"
		[Register ("intentForPresenter", "(Landroid/content/Context;Lcom/salesforce/marketingcloud/notifications/NotificationMessage;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent IntentForPresenter (global::Android.Content.Context p0, global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage p1)
		{
			if (id_intentForPresenter_Landroid_content_Context_Lcom_salesforce_marketingcloud_notifications_NotificationMessage_ == IntPtr.Zero)
				id_intentForPresenter_Landroid_content_Context_Lcom_salesforce_marketingcloud_notifications_NotificationMessage_ = JNIEnv.GetStaticMethodID (class_ref, "intentForPresenter", "(Landroid/content/Context;Lcom/salesforce/marketingcloud/notifications/NotificationMessage;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intentForPresenter_Landroid_content_Context_Lcom_salesforce_marketingcloud_notifications_NotificationMessage_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='DefaultUrlPresenter']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}
}
