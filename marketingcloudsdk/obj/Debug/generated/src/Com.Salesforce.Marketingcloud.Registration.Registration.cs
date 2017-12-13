using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Registration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/registration/Registration", DoNotGenerateAcw=true)]
	public abstract partial class Registration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/registration/Registration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Registration); }
		}

		protected Registration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/constructor[@name='Registration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Registration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Registration)) {
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

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "")]
		public unsafe void A (int p0)
		{
			if (id_a_I == IntPtr.Zero)
				id_a_I = JNIEnv.GetMethodID (class_ref, "a", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_I, __args);
			} finally {
			}
		}

		static Delegate cb_appId;
#pragma warning disable 0169
		static Delegate GetAppIdHandler ()
		{
			if (cb_appId == null)
				cb_appId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AppId);
			return cb_appId;
		}

		static IntPtr n_AppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='appId' and count(parameter)=0]"
		[Register ("appId", "()Ljava/lang/String;", "GetAppIdHandler")]
		public abstract string AppId ();

		static Delegate cb_appVersion;
#pragma warning disable 0169
		static Delegate GetAppVersionHandler ()
		{
			if (cb_appVersion == null)
				cb_appVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AppVersion);
			return cb_appVersion;
		}

		static IntPtr n_AppVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='appVersion' and count(parameter)=0]"
		[Register ("appVersion", "()Ljava/lang/String;", "GetAppVersionHandler")]
		public abstract string AppVersion ();

		static Delegate cb_attributes;
#pragma warning disable 0169
		static Delegate GetAttributesHandler ()
		{
			if (cb_attributes == null)
				cb_attributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Attributes);
			return cb_attributes;
		}

		static IntPtr n_Attributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Registration.Attribute>.ToLocalJniHandle (__this.Attributes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='attributes' and count(parameter)=0]"
		[Register ("attributes", "()Ljava/util/List;", "GetAttributesHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Registration.Attribute> Attributes ();

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.B ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lorg/json/JSONObject;", "GetBHandler")]
		public abstract global::Org.Json.JSONObject B ();

		static Delegate cb_contactKey;
#pragma warning disable 0169
		static Delegate GetContactKeyHandler ()
		{
			if (cb_contactKey == null)
				cb_contactKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContactKey);
			return cb_contactKey;
		}

		static IntPtr n_ContactKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactKey ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='contactKey' and count(parameter)=0]"
		[Register ("contactKey", "()Ljava/lang/String;", "GetContactKeyHandler")]
		public abstract string ContactKey ();

		static Delegate cb_deviceId;
#pragma warning disable 0169
		static Delegate GetDeviceIdHandler ()
		{
			if (cb_deviceId == null)
				cb_deviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DeviceId);
			return cb_deviceId;
		}

		static IntPtr n_DeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='deviceId' and count(parameter)=0]"
		[Register ("deviceId", "()Ljava/lang/String;", "GetDeviceIdHandler")]
		public abstract string DeviceId ();

		static Delegate cb_dst;
#pragma warning disable 0169
		static Delegate GetDstHandler ()
		{
			if (cb_dst == null)
				cb_dst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Dst);
			return cb_dst;
		}

		static bool n_Dst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dst ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='dst' and count(parameter)=0]"
		[Register ("dst", "()Z", "GetDstHandler")]
		public abstract bool Dst ();

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()I", "")]
		public unsafe int E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_e);
			} finally {
			}
		}

		static Delegate cb_hwid;
#pragma warning disable 0169
		static Delegate GetHwidHandler ()
		{
			if (cb_hwid == null)
				cb_hwid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Hwid);
			return cb_hwid;
		}

		static IntPtr n_Hwid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hwid ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='hwid' and count(parameter)=0]"
		[Register ("hwid", "()Ljava/lang/String;", "GetHwidHandler")]
		public abstract string Hwid ();

		static Delegate cb_locale;
#pragma warning disable 0169
		static Delegate GetLocaleHandler ()
		{
			if (cb_locale == null)
				cb_locale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Locale);
			return cb_locale;
		}

		static IntPtr n_Locale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Locale ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='locale' and count(parameter)=0]"
		[Register ("locale", "()Ljava/lang/String;", "GetLocaleHandler")]
		public abstract string Locale ();

		static Delegate cb_locationEnabled;
#pragma warning disable 0169
		static Delegate GetLocationEnabledHandler ()
		{
			if (cb_locationEnabled == null)
				cb_locationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LocationEnabled);
			return cb_locationEnabled;
		}

		static bool n_LocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='locationEnabled' and count(parameter)=0]"
		[Register ("locationEnabled", "()Z", "GetLocationEnabledHandler")]
		public abstract bool LocationEnabled ();

		static Delegate cb_platform;
#pragma warning disable 0169
		static Delegate GetPlatformHandler ()
		{
			if (cb_platform == null)
				cb_platform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Platform);
			return cb_platform;
		}

		static IntPtr n_Platform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Platform ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='platform' and count(parameter)=0]"
		[Register ("platform", "()Ljava/lang/String;", "GetPlatformHandler")]
		public abstract string Platform ();

		static Delegate cb_platformVersion;
#pragma warning disable 0169
		static Delegate GetPlatformVersionHandler ()
		{
			if (cb_platformVersion == null)
				cb_platformVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PlatformVersion);
			return cb_platformVersion;
		}

		static IntPtr n_PlatformVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlatformVersion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='platformVersion' and count(parameter)=0]"
		[Register ("platformVersion", "()Ljava/lang/String;", "GetPlatformVersionHandler")]
		public abstract string PlatformVersion ();

		static Delegate cb_pushEnabled;
#pragma warning disable 0169
		static Delegate GetPushEnabledHandler ()
		{
			if (cb_pushEnabled == null)
				cb_pushEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_PushEnabled);
			return cb_pushEnabled;
		}

		static bool n_PushEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PushEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='pushEnabled' and count(parameter)=0]"
		[Register ("pushEnabled", "()Z", "GetPushEnabledHandler")]
		public abstract bool PushEnabled ();

		static Delegate cb_sdkVersion;
#pragma warning disable 0169
		static Delegate GetSdkVersionHandler ()
		{
			if (cb_sdkVersion == null)
				cb_sdkVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SdkVersion);
			return cb_sdkVersion;
		}

		static IntPtr n_SdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='sdkVersion' and count(parameter)=0]"
		[Register ("sdkVersion", "()Ljava/lang/String;", "GetSdkVersionHandler")]
		public abstract string SdkVersion ();

		static Delegate cb_systemToken;
#pragma warning disable 0169
		static Delegate GetSystemTokenHandler ()
		{
			if (cb_systemToken == null)
				cb_systemToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SystemToken);
			return cb_systemToken;
		}

		static IntPtr n_SystemToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SystemToken ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='systemToken' and count(parameter)=0]"
		[Register ("systemToken", "()Ljava/lang/String;", "GetSystemTokenHandler")]
		public abstract string SystemToken ();

		static Delegate cb_tags;
#pragma warning disable 0169
		static Delegate GetTagsHandler ()
		{
			if (cb_tags == null)
				cb_tags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Tags);
			return cb_tags;
		}

		static IntPtr n_Tags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Tags ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='tags' and count(parameter)=0]"
		[Register ("tags", "()Ljava/util/Set;", "GetTagsHandler")]
		public abstract global::System.Collections.Generic.ICollection<string> Tags ();

		static Delegate cb_timeZone;
#pragma warning disable 0169
		static Delegate GetTimeZoneHandler ()
		{
			if (cb_timeZone == null)
				cb_timeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TimeZone);
			return cb_timeZone;
		}

		static int n_TimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Registration __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Registration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeZone ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='timeZone' and count(parameter)=0]"
		[Register ("timeZone", "()I", "GetTimeZoneHandler")]
		public abstract int TimeZone ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/registration/Registration", DoNotGenerateAcw=true)]
	internal partial class RegistrationInvoker : Registration {

		public RegistrationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegistrationInvoker); }
		}

		static IntPtr id_appId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='appId' and count(parameter)=0]"
		[Register ("appId", "()Ljava/lang/String;", "GetAppIdHandler")]
		public override unsafe string AppId ()
		{
			if (id_appId == IntPtr.Zero)
				id_appId = JNIEnv.GetMethodID (class_ref, "appId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_appVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='appVersion' and count(parameter)=0]"
		[Register ("appVersion", "()Ljava/lang/String;", "GetAppVersionHandler")]
		public override unsafe string AppVersion ()
		{
			if (id_appVersion == IntPtr.Zero)
				id_appVersion = JNIEnv.GetMethodID (class_ref, "appVersion", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_appVersion), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_attributes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='attributes' and count(parameter)=0]"
		[Register ("attributes", "()Ljava/util/List;", "GetAttributesHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Registration.Attribute> Attributes ()
		{
			if (id_attributes == IntPtr.Zero)
				id_attributes = JNIEnv.GetMethodID (class_ref, "attributes", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Registration.Attribute>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_attributes), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lorg/json/JSONObject;", "GetBHandler")]
		public override unsafe global::Org.Json.JSONObject B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_contactKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='contactKey' and count(parameter)=0]"
		[Register ("contactKey", "()Ljava/lang/String;", "GetContactKeyHandler")]
		public override unsafe string ContactKey ()
		{
			if (id_contactKey == IntPtr.Zero)
				id_contactKey = JNIEnv.GetMethodID (class_ref, "contactKey", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contactKey), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_deviceId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='deviceId' and count(parameter)=0]"
		[Register ("deviceId", "()Ljava/lang/String;", "GetDeviceIdHandler")]
		public override unsafe string DeviceId ()
		{
			if (id_deviceId == IntPtr.Zero)
				id_deviceId = JNIEnv.GetMethodID (class_ref, "deviceId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deviceId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='dst' and count(parameter)=0]"
		[Register ("dst", "()Z", "GetDstHandler")]
		public override unsafe bool Dst ()
		{
			if (id_dst == IntPtr.Zero)
				id_dst = JNIEnv.GetMethodID (class_ref, "dst", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_dst);
			} finally {
			}
		}

		static IntPtr id_hwid;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='hwid' and count(parameter)=0]"
		[Register ("hwid", "()Ljava/lang/String;", "GetHwidHandler")]
		public override unsafe string Hwid ()
		{
			if (id_hwid == IntPtr.Zero)
				id_hwid = JNIEnv.GetMethodID (class_ref, "hwid", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hwid), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_locale;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='locale' and count(parameter)=0]"
		[Register ("locale", "()Ljava/lang/String;", "GetLocaleHandler")]
		public override unsafe string Locale ()
		{
			if (id_locale == IntPtr.Zero)
				id_locale = JNIEnv.GetMethodID (class_ref, "locale", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_locale), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_locationEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='locationEnabled' and count(parameter)=0]"
		[Register ("locationEnabled", "()Z", "GetLocationEnabledHandler")]
		public override unsafe bool LocationEnabled ()
		{
			if (id_locationEnabled == IntPtr.Zero)
				id_locationEnabled = JNIEnv.GetMethodID (class_ref, "locationEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_locationEnabled);
			} finally {
			}
		}

		static IntPtr id_platform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='platform' and count(parameter)=0]"
		[Register ("platform", "()Ljava/lang/String;", "GetPlatformHandler")]
		public override unsafe string Platform ()
		{
			if (id_platform == IntPtr.Zero)
				id_platform = JNIEnv.GetMethodID (class_ref, "platform", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_platform), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_platformVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='platformVersion' and count(parameter)=0]"
		[Register ("platformVersion", "()Ljava/lang/String;", "GetPlatformVersionHandler")]
		public override unsafe string PlatformVersion ()
		{
			if (id_platformVersion == IntPtr.Zero)
				id_platformVersion = JNIEnv.GetMethodID (class_ref, "platformVersion", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_platformVersion), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_pushEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='pushEnabled' and count(parameter)=0]"
		[Register ("pushEnabled", "()Z", "GetPushEnabledHandler")]
		public override unsafe bool PushEnabled ()
		{
			if (id_pushEnabled == IntPtr.Zero)
				id_pushEnabled = JNIEnv.GetMethodID (class_ref, "pushEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_pushEnabled);
			} finally {
			}
		}

		static IntPtr id_sdkVersion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='sdkVersion' and count(parameter)=0]"
		[Register ("sdkVersion", "()Ljava/lang/String;", "GetSdkVersionHandler")]
		public override unsafe string SdkVersion ()
		{
			if (id_sdkVersion == IntPtr.Zero)
				id_sdkVersion = JNIEnv.GetMethodID (class_ref, "sdkVersion", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sdkVersion), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_systemToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='systemToken' and count(parameter)=0]"
		[Register ("systemToken", "()Ljava/lang/String;", "GetSystemTokenHandler")]
		public override unsafe string SystemToken ()
		{
			if (id_systemToken == IntPtr.Zero)
				id_systemToken = JNIEnv.GetMethodID (class_ref, "systemToken", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_systemToken), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_tags;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='tags' and count(parameter)=0]"
		[Register ("tags", "()Ljava/util/Set;", "GetTagsHandler")]
		public override unsafe global::System.Collections.Generic.ICollection<string> Tags ()
		{
			if (id_tags == IntPtr.Zero)
				id_tags = JNIEnv.GetMethodID (class_ref, "tags", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tags), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_timeZone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Registration']/method[@name='timeZone' and count(parameter)=0]"
		[Register ("timeZone", "()I", "GetTimeZoneHandler")]
		public override unsafe int TimeZone ()
		{
			if (id_timeZone == IntPtr.Zero)
				id_timeZone = JNIEnv.GetMethodID (class_ref, "timeZone", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_timeZone);
			} finally {
			}
		}

	}

}
