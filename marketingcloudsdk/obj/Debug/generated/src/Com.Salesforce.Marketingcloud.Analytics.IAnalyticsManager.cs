using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Analytics {

	[Register ("com/salesforce/marketingcloud/analytics/AnalyticsManager", DoNotGenerateAcw=true)]
	public abstract class AnalyticsManager : Java.Lang.Object {

		internal AnalyticsManager ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/field[@name='WAMA_MAX_FIELD_SIZE']"
		[Register ("WAMA_MAX_FIELD_SIZE")]
		public const int WamaMaxFieldSize = (int) 1024;
	}

	[Register ("com/salesforce/marketingcloud/analytics/AnalyticsManager", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AnalyticsManager' type. This type will be removed in a future release.")]
	public abstract class AnalyticsManagerConsts : AnalyticsManager {

		private AnalyticsManagerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']"
	[Register ("com/salesforce/marketingcloud/analytics/AnalyticsManager", "", "Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker")]
	public partial interface IAnalyticsManager : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackCartContents' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.analytics.PiCart']]"
		[Register ("trackCartContents", "(Lcom/salesforce/marketingcloud/analytics/PiCart;)V", "GetTrackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackCartContents (global::Com.Salesforce.Marketingcloud.Analytics.PiCart p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackCartConversion' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.analytics.PiOrder']]"
		[Register ("trackCartConversion", "(Lcom/salesforce/marketingcloud/analytics/PiOrder;)V", "GetTrackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackCartConversion (global::Com.Salesforce.Marketingcloud.Analytics.PiOrder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackInboxOpenEvent' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.messages.cloudpage.CloudPageMessage']]"
		[Register ("trackInboxOpenEvent", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V", "GetTrackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackInboxOpenEvent (global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackPageView' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trackPageView", "(Ljava/lang/String;)V", "GetTrackPageView_Ljava_lang_String_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackPageView (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackPageView' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackPageView", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTrackPageView_Ljava_lang_String_Ljava_lang_String_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackPageView (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackPageView' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("trackPageView", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetTrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackPageView (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/interface[@name='AnalyticsManager']/method[@name='trackPageView' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("trackPageView", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetTrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManagerInvoker, marketingcloudsdk")]
		void TrackPageView (string p0, string p1, string p2, string p3);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/AnalyticsManager", DoNotGenerateAcw=true)]
	internal class IAnalyticsManagerInvoker : global::Java.Lang.Object, IAnalyticsManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/analytics/AnalyticsManager");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAnalyticsManagerInvoker); }
		}

		IntPtr class_ref;

		public static IAnalyticsManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAnalyticsManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.analytics.AnalyticsManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAnalyticsManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_;
#pragma warning disable 0169
		static Delegate GetTrackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_Handler ()
		{
			if (cb_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_ == null)
				cb_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_);
			return cb_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_;
		}

		static void n_TrackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Salesforce.Marketingcloud.Analytics.PiCart p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackCartContents (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_;
		public unsafe void TrackCartContents (global::Com.Salesforce.Marketingcloud.Analytics.PiCart p0)
		{
			if (id_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_ == IntPtr.Zero)
				id_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_ = JNIEnv.GetMethodID (class_ref, "trackCartContents", "(Lcom/salesforce/marketingcloud/analytics/PiCart;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackCartContents_Lcom_salesforce_marketingcloud_analytics_PiCart_, __args);
		}

		static Delegate cb_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_;
#pragma warning disable 0169
		static Delegate GetTrackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_Handler ()
		{
			if (cb_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_ == null)
				cb_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_);
			return cb_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_;
		}

		static void n_TrackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackCartConversion (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_;
		public unsafe void TrackCartConversion (global::Com.Salesforce.Marketingcloud.Analytics.PiOrder p0)
		{
			if (id_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_ == IntPtr.Zero)
				id_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_ = JNIEnv.GetMethodID (class_ref, "trackCartConversion", "(Lcom/salesforce/marketingcloud/analytics/PiOrder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackCartConversion_Lcom_salesforce_marketingcloud_analytics_PiOrder_, __args);
		}

		static Delegate cb_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
#pragma warning disable 0169
		static Delegate GetTrackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_Handler ()
		{
			if (cb_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ == null)
				cb_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_);
			return cb_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
		}

		static void n_TrackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackInboxOpenEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
		public unsafe void TrackInboxOpenEvent (global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0)
		{
			if (id_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ == IntPtr.Zero)
				id_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ = JNIEnv.GetMethodID (class_ref, "trackInboxOpenEvent", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackInboxOpenEvent_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_, __args);
		}

		static Delegate cb_trackPageView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrackPageView_Ljava_lang_String_Handler ()
		{
			if (cb_trackPageView_Ljava_lang_String_ == null)
				cb_trackPageView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackPageView_Ljava_lang_String_);
			return cb_trackPageView_Ljava_lang_String_;
		}

		static void n_TrackPageView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackPageView (p0);
		}
#pragma warning restore 0169

		IntPtr id_trackPageView_Ljava_lang_String_;
		public unsafe void TrackPageView (string p0)
		{
			if (id_trackPageView_Ljava_lang_String_ == IntPtr.Zero)
				id_trackPageView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "trackPageView", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackPageView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_trackPageView_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrackPageView_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_trackPageView_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_trackPageView_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackPageView_Ljava_lang_String_Ljava_lang_String_);
			return cb_trackPageView_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TrackPageView_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TrackPageView (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_trackPageView_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void TrackPageView (string p0, string p1)
		{
			if (id_trackPageView_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_trackPageView_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "trackPageView", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackPageView_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TrackPageView (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void TrackPageView (string p0, string p1, string p2)
		{
			if (id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "trackPageView", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TrackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.TrackPageView (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void TrackPageView (string p0, string p1, string p2, string p3)
		{
			if (id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "trackPageView", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackPageView_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

}
