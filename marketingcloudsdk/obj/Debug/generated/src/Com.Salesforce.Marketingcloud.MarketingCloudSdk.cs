using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudSdk", DoNotGenerateAcw=true)]
	public sealed partial class MarketingCloudSdk : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MarketingCloudSdk.InitializationListener']"
		[Register ("com/salesforce/marketingcloud/MarketingCloudSdk$InitializationListener", "", "Com.Salesforce.Marketingcloud.MarketingCloudSdk/IInitializationListenerInvoker")]
		public partial interface IInitializationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MarketingCloudSdk.InitializationListener']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.InitializationStatus']]"
			[Register ("complete", "(Lcom/salesforce/marketingcloud/InitializationStatus;)V", "GetComplete_Lcom_salesforce_marketingcloud_InitializationStatus_Handler:Com.Salesforce.Marketingcloud.MarketingCloudSdk/IInitializationListenerInvoker, marketingcloudsdk")]
			void Complete (global::Com.Salesforce.Marketingcloud.InitializationStatus p0);

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudSdk$InitializationListener", DoNotGenerateAcw=true)]
		internal class IInitializationListenerInvoker : global::Java.Lang.Object, IInitializationListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/MarketingCloudSdk$InitializationListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInitializationListenerInvoker); }
			}

			IntPtr class_ref;

			public static IInitializationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInitializationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.MarketingCloudSdk.InitializationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInitializationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_complete_Lcom_salesforce_marketingcloud_InitializationStatus_;
#pragma warning disable 0169
			static Delegate GetComplete_Lcom_salesforce_marketingcloud_InitializationStatus_Handler ()
			{
				if (cb_complete_Lcom_salesforce_marketingcloud_InitializationStatus_ == null)
					cb_complete_Lcom_salesforce_marketingcloud_InitializationStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Complete_Lcom_salesforce_marketingcloud_InitializationStatus_);
				return cb_complete_Lcom_salesforce_marketingcloud_InitializationStatus_;
			}

			static void n_Complete_Lcom_salesforce_marketingcloud_InitializationStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IInitializationListener __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IInitializationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Salesforce.Marketingcloud.InitializationStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Complete (p0);
			}
#pragma warning restore 0169

			IntPtr id_complete_Lcom_salesforce_marketingcloud_InitializationStatus_;
			public unsafe void Complete (global::Com.Salesforce.Marketingcloud.InitializationStatus p0)
			{
				if (id_complete_Lcom_salesforce_marketingcloud_InitializationStatus_ == IntPtr.Zero)
					id_complete_Lcom_salesforce_marketingcloud_InitializationStatus_ = JNIEnv.GetMethodID (class_ref, "complete", "(Lcom/salesforce/marketingcloud/InitializationStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_complete_Lcom_salesforce_marketingcloud_InitializationStatus_, __args);
			}

		}

		public partial class InitializationEventArgs : global::System.EventArgs {

			public InitializationEventArgs (global::Com.Salesforce.Marketingcloud.InitializationStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Salesforce.Marketingcloud.InitializationStatus p0;
			public global::Com.Salesforce.Marketingcloud.InitializationStatus P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/salesforce/marketingcloud/MarketingCloudSdk_InitializationListenerImplementor")]
		internal sealed partial class IInitializationListenerImplementor : global::Java.Lang.Object, IInitializationListener {

			object sender;

			public IInitializationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/salesforce/marketingcloud/MarketingCloudSdk_InitializationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InitializationEventArgs> Handler;
#pragma warning restore 0649

			public void Complete (global::Com.Salesforce.Marketingcloud.InitializationStatus p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InitializationEventArgs (p0));
			}

			internal static bool __IsEmpty (IInitializationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MarketingCloudSdk.WhenReadyListener']"
		[Register ("com/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener", "", "Com.Salesforce.Marketingcloud.MarketingCloudSdk/IWhenReadyListenerInvoker")]
		public partial interface IWhenReadyListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MarketingCloudSdk.WhenReadyListener']/method[@name='ready' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.MarketingCloudSdk']]"
			[Register ("ready", "(Lcom/salesforce/marketingcloud/MarketingCloudSdk;)V", "GetReady_Lcom_salesforce_marketingcloud_MarketingCloudSdk_Handler:Com.Salesforce.Marketingcloud.MarketingCloudSdk/IWhenReadyListenerInvoker, marketingcloudsdk")]
			void Ready (global::Com.Salesforce.Marketingcloud.MarketingCloudSdk p0);

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener", DoNotGenerateAcw=true)]
		internal class IWhenReadyListenerInvoker : global::Java.Lang.Object, IWhenReadyListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IWhenReadyListenerInvoker); }
			}

			IntPtr class_ref;

			public static IWhenReadyListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWhenReadyListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.MarketingCloudSdk.WhenReadyListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWhenReadyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_;
#pragma warning disable 0169
			static Delegate GetReady_Lcom_salesforce_marketingcloud_MarketingCloudSdk_Handler ()
			{
				if (cb_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_ == null)
					cb_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_);
				return cb_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_;
			}

			static void n_Ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IWhenReadyListener __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IWhenReadyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Salesforce.Marketingcloud.MarketingCloudSdk p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudSdk> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Ready (p0);
			}
#pragma warning restore 0169

			IntPtr id_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_;
			public unsafe void Ready (global::Com.Salesforce.Marketingcloud.MarketingCloudSdk p0)
			{
				if (id_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_ == IntPtr.Zero)
					id_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_ = JNIEnv.GetMethodID (class_ref, "ready", "(Lcom/salesforce/marketingcloud/MarketingCloudSdk;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ready_Lcom_salesforce_marketingcloud_MarketingCloudSdk_, __args);
			}

		}

		public partial class WhenReadyEventArgs : global::System.EventArgs {

			public WhenReadyEventArgs (global::Com.Salesforce.Marketingcloud.MarketingCloudSdk p0)
			{
				this.p0 = p0;
			}

			global::Com.Salesforce.Marketingcloud.MarketingCloudSdk p0;
			public global::Com.Salesforce.Marketingcloud.MarketingCloudSdk P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/salesforce/marketingcloud/MarketingCloudSdk_WhenReadyListenerImplementor")]
		internal sealed partial class IWhenReadyListenerImplementor : global::Java.Lang.Object, IWhenReadyListener {

			object sender;

			public IWhenReadyListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/salesforce/marketingcloud/MarketingCloudSdk_WhenReadyListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<WhenReadyEventArgs> Handler;
#pragma warning restore 0649

			public void Ready (global::Com.Salesforce.Marketingcloud.MarketingCloudSdk p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new WhenReadyEventArgs (p0));
			}

			internal static bool __IsEmpty (IWhenReadyListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/MarketingCloudSdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketingCloudSdk); }
		}

		internal MarketingCloudSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAnalyticsManager;
		public unsafe global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager AnalyticsManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getAnalyticsManager' and count(parameter)=0]"
			[Register ("getAnalyticsManager", "()Lcom/salesforce/marketingcloud/analytics/AnalyticsManager;", "GetGetAnalyticsManagerHandler")]
			get {
				if (id_getAnalyticsManager == IntPtr.Zero)
					id_getAnalyticsManager = JNIEnv.GetMethodID (class_ref, "getAnalyticsManager", "()Lcom/salesforce/marketingcloud/analytics/AnalyticsManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.IAnalyticsManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnalyticsManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInitializationStatus;
		public unsafe global::Com.Salesforce.Marketingcloud.InitializationStatus InitializationStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getInitializationStatus' and count(parameter)=0]"
			[Register ("getInitializationStatus", "()Lcom/salesforce/marketingcloud/InitializationStatus;", "GetGetInitializationStatusHandler")]
			get {
				if (id_getInitializationStatus == IntPtr.Zero)
					id_getInitializationStatus = JNIEnv.GetMethodID (class_ref, "getInitializationStatus", "()Lcom/salesforce/marketingcloud/InitializationStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitializationStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudSdk Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/salesforce/marketingcloud/MarketingCloudSdk;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/salesforce/marketingcloud/MarketingCloudSdk;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudSdk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isInitializing;
		public static unsafe bool IsInitializing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='isInitializing' and count(parameter)=0]"
			[Register ("isInitializing", "()Z", "GetIsInitializingHandler")]
			get {
				if (id_isInitializing == IntPtr.Zero)
					id_isInitializing = JNIEnv.GetStaticMethodID (class_ref, "isInitializing", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInitializing);
				} finally {
				}
			}
		}

		static IntPtr id_isReady;
		public static unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetStaticMethodID (class_ref, "isReady", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isReady);
				} finally {
				}
			}
		}

		static IntPtr id_getLogLevel;
		static IntPtr id_setLogLevel_I;
		public static unsafe int LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()I", "GetGetLogLevelHandler")]
			get {
				if (id_getLogLevel == IntPtr.Zero)
					id_getLogLevel = JNIEnv.GetStaticMethodID (class_ref, "getLogLevel", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getLogLevel);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogLevel", "(I)V", "GetSetLogLevel_IHandler")]
			set {
				if (id_setLogLevel_I == IntPtr.Zero)
					id_setLogLevel_I = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMarketingCloudConfig;
		public unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig MarketingCloudConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getMarketingCloudConfig' and count(parameter)=0]"
			[Register ("getMarketingCloudConfig", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig;", "GetGetMarketingCloudConfigHandler")]
			get {
				if (id_getMarketingCloudConfig == IntPtr.Zero)
					id_getMarketingCloudConfig = JNIEnv.GetMethodID (class_ref, "getMarketingCloudConfig", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarketingCloudConfig), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSdkState;
		public unsafe global::Org.Json.JSONObject SdkState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getSdkState' and count(parameter)=0]"
			[Register ("getSdkState", "()Lorg/json/JSONObject;", "GetGetSdkStateHandler")]
			get {
				if (id_getSdkState == IntPtr.Zero)
					id_getSdkState = JNIEnv.GetMethodID (class_ref, "getSdkState", "()Lorg/json/JSONObject;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSdkState), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSdkVersionCode;
		public static unsafe int SdkVersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getSdkVersionCode' and count(parameter)=0]"
			[Register ("getSdkVersionCode", "()I", "GetGetSdkVersionCodeHandler")]
			get {
				if (id_getSdkVersionCode == IntPtr.Zero)
					id_getSdkVersionCode = JNIEnv.GetStaticMethodID (class_ref, "getSdkVersionCode", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getSdkVersionCode);
				} finally {
				}
			}
		}

		static IntPtr id_getSdkVersionName;
		public static unsafe string SdkVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='getSdkVersionName' and count(parameter)=0]"
			[Register ("getSdkVersionName", "()Ljava/lang/String;", "GetGetSdkVersionNameHandler")]
			get {
				if (id_getSdkVersionName == IntPtr.Zero)
					id_getSdkVersionName = JNIEnv.GetStaticMethodID (class_ref, "getSdkVersionName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSdkVersionName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_init_Landroid_app_Application_Lcom_salesforce_marketingcloud_MarketingCloudConfig_Lcom_salesforce_marketingcloud_MarketingCloudSdk_InitializationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.salesforce.marketingcloud.MarketingCloudConfig'] and parameter[3][@type='com.salesforce.marketingcloud.MarketingCloudSdk.InitializationListener']]"
		[Register ("init", "(Landroid/app/Application;Lcom/salesforce/marketingcloud/MarketingCloudConfig;Lcom/salesforce/marketingcloud/MarketingCloudSdk$InitializationListener;)V", "")]
		public static unsafe void Init (global::Android.App.Application p0, global::Com.Salesforce.Marketingcloud.MarketingCloudConfig p1, global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IInitializationListener p2)
		{
			if (id_init_Landroid_app_Application_Lcom_salesforce_marketingcloud_MarketingCloudConfig_Lcom_salesforce_marketingcloud_MarketingCloudSdk_InitializationListener_ == IntPtr.Zero)
				id_init_Landroid_app_Application_Lcom_salesforce_marketingcloud_MarketingCloudConfig_Lcom_salesforce_marketingcloud_MarketingCloudSdk_InitializationListener_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/app/Application;Lcom/salesforce/marketingcloud/MarketingCloudConfig;Lcom/salesforce/marketingcloud/MarketingCloudSdk$InitializationListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_app_Application_Lcom_salesforce_marketingcloud_MarketingCloudConfig_Lcom_salesforce_marketingcloud_MarketingCloudSdk_InitializationListener_, __args);
			} finally {
			}
		}

		static IntPtr id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='requestSdk' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.MarketingCloudSdk.WhenReadyListener']]"
		[Register ("requestSdk", "(Lcom/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener;)V", "")]
		public static unsafe void RequestSdk (global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IWhenReadyListener p0)
		{
			if (id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_ == IntPtr.Zero)
				id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_ = JNIEnv.GetStaticMethodID (class_ref, "requestSdk", "(Lcom/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_, __args);
			} finally {
			}
		}

		static IntPtr id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_Landroid_os_Looper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='requestSdk' and count(parameter)=2 and parameter[1][@type='com.salesforce.marketingcloud.MarketingCloudSdk.WhenReadyListener'] and parameter[2][@type='android.os.Looper']]"
		[Register ("requestSdk", "(Lcom/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener;Landroid/os/Looper;)V", "")]
		public static unsafe void RequestSdk (global::Com.Salesforce.Marketingcloud.MarketingCloudSdk.IWhenReadyListener p0, global::Android.OS.Looper p1)
		{
			if (id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_Landroid_os_Looper_ == IntPtr.Zero)
				id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_Landroid_os_Looper_ = JNIEnv.GetStaticMethodID (class_ref, "requestSdk", "(Lcom/salesforce/marketingcloud/MarketingCloudSdk$WhenReadyListener;Landroid/os/Looper;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestSdk_Lcom_salesforce_marketingcloud_MarketingCloudSdk_WhenReadyListener_Landroid_os_Looper_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogListener_Lcom_salesforce_marketingcloud_MCLogListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudSdk']/method[@name='setLogListener' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.MCLogListener']]"
		[Register ("setLogListener", "(Lcom/salesforce/marketingcloud/MCLogListener;)V", "")]
		public static unsafe void SetLogListener (global::Com.Salesforce.Marketingcloud.IMCLogListener p0)
		{
			if (id_setLogListener_Lcom_salesforce_marketingcloud_MCLogListener_ == IntPtr.Zero)
				id_setLogListener_Lcom_salesforce_marketingcloud_MCLogListener_ = JNIEnv.GetStaticMethodID (class_ref, "setLogListener", "(Lcom/salesforce/marketingcloud/MCLogListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogListener_Lcom_salesforce_marketingcloud_MCLogListener_, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Salesforce.Marketingcloud.IMCLogListener"
		public event EventHandler<global::Com.Salesforce.Marketingcloud.MCLogEventArgs> Log {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Salesforce.Marketingcloud.IMCLogListener, global::Com.Salesforce.Marketingcloud.IMCLogListenerImplementor>(
						ref weak_implementor_SetLogListener,
						__CreateIMCLogListenerImplementor,
						SetLogListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Salesforce.Marketingcloud.IMCLogListener, global::Com.Salesforce.Marketingcloud.IMCLogListenerImplementor>(
						ref weak_implementor_SetLogListener,
						global::Com.Salesforce.Marketingcloud.IMCLogListenerImplementor.__IsEmpty,
						__v => SetLogListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetLogListener;

		global::Com.Salesforce.Marketingcloud.IMCLogListenerImplementor __CreateIMCLogListenerImplementor ()
		{
			return new global::Com.Salesforce.Marketingcloud.IMCLogListenerImplementor (this);
		}
#endregion
	}
}
