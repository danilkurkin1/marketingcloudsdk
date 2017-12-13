using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Notifications {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/notifications/NotificationMessage", DoNotGenerateAcw=true)]
	public abstract partial class NotificationMessage : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/field[@name='a']"
		[Register ("a")]
		public const string A = (string) "_m";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Sound']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/notifications/NotificationMessage$Sound", DoNotGenerateAcw=true)]
		public sealed partial class Sound : global::Java.Lang.Enum {


			static IntPtr CUSTOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Sound']/field[@name='CUSTOM']"
			[Register ("CUSTOM")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound Custom {
				get {
					if (CUSTOM_jfieldId == IntPtr.Zero)
						CUSTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Sound']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Sound']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/notifications/NotificationMessage$Sound", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Sound); }
			}

			internal Sound (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Sound']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Sound']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;");
				try {
					return (global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Trigger']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/notifications/NotificationMessage$Trigger", DoNotGenerateAcw=true)]
		public sealed partial class Trigger : global::Java.Lang.Enum {


			static IntPtr BEACON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Trigger']/field[@name='BEACON']"
			[Register ("BEACON")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger Beacon {
				get {
					if (BEACON_jfieldId == IntPtr.Zero)
						BEACON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEACON", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEACON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GEOFENCE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Trigger']/field[@name='GEOFENCE']"
			[Register ("GEOFENCE")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger Geofence {
				get {
					if (GEOFENCE_jfieldId == IntPtr.Zero)
						GEOFENCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GEOFENCE", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GEOFENCE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PUSH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Trigger']/field[@name='PUSH']"
			[Register ("PUSH")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger Push {
				get {
					if (PUSH_jfieldId == IntPtr.Zero)
						PUSH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUSH", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUSH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/notifications/NotificationMessage$Trigger", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Trigger); }
			}

			internal Trigger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Trigger']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Trigger']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;");
				try {
					return (global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Type']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/notifications/NotificationMessage$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr CLOUD_PAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Type']/field[@name='CLOUD_PAGE']"
			[Register ("CLOUD_PAGE")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type CloudPage {
				get {
					if (CLOUD_PAGE_jfieldId == IntPtr.Zero)
						CLOUD_PAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOUD_PAGE", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOUD_PAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_DIRECT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Type']/field[@name='OPEN_DIRECT']"
			[Register ("OPEN_DIRECT")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type OpenDirect {
				get {
					if (OPEN_DIRECT_jfieldId == IntPtr.Zero)
						OPEN_DIRECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_DIRECT", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_DIRECT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Type']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/notifications/NotificationMessage$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;");
				try {
					return (global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/notifications/NotificationMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationMessage); }
		}

		protected NotificationMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/constructor[@name='NotificationMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NotificationMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NotificationMessage)) {
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

		static Delegate cb_alert;
#pragma warning disable 0169
		static Delegate GetAlertHandler ()
		{
			if (cb_alert == null)
				cb_alert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Alert);
			return cb_alert;
		}

		static IntPtr n_Alert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alert ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='alert' and count(parameter)=0]"
		[Register ("alert", "()Ljava/lang/String;", "GetAlertHandler")]
		public abstract string Alert ();

		static Delegate cb_custom;
#pragma warning disable 0169
		static Delegate GetCustomHandler ()
		{
			if (cb_custom == null)
				cb_custom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Custom);
			return cb_custom;
		}

		static IntPtr n_Custom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Custom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='custom' and count(parameter)=0]"
		[Register ("custom", "()Ljava/lang/String;", "GetCustomHandler")]
		public abstract string Custom ();

		static Delegate cb_customKeys;
#pragma warning disable 0169
		static Delegate GetCustomKeysHandler ()
		{
			if (cb_customKeys == null)
				cb_customKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CustomKeys);
			return cb_customKeys;
		}

		static IntPtr n_CustomKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CustomKeys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='customKeys' and count(parameter)=0]"
		[Register ("customKeys", "()Ljava/util/Map;", "GetCustomKeysHandler")]
		public abstract global::System.Collections.Generic.IDictionary<string, string> CustomKeys ();

		static Delegate cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Id);
			return cb_id;
		}

		static IntPtr n_Id (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public abstract string Id ();

		static Delegate cb_mediaAltText;
#pragma warning disable 0169
		static Delegate GetMediaAltTextHandler ()
		{
			if (cb_mediaAltText == null)
				cb_mediaAltText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MediaAltText);
			return cb_mediaAltText;
		}

		static IntPtr n_MediaAltText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MediaAltText ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='mediaAltText' and count(parameter)=0]"
		[Register ("mediaAltText", "()Ljava/lang/String;", "GetMediaAltTextHandler")]
		public abstract string MediaAltText ();

		static Delegate cb_mediaUrl;
#pragma warning disable 0169
		static Delegate GetMediaUrlHandler ()
		{
			if (cb_mediaUrl == null)
				cb_mediaUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MediaUrl);
			return cb_mediaUrl;
		}

		static IntPtr n_MediaUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MediaUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='mediaUrl' and count(parameter)=0]"
		[Register ("mediaUrl", "()Ljava/lang/String;", "GetMediaUrlHandler")]
		public abstract string MediaUrl ();

		static Delegate cb_notificationId;
#pragma warning disable 0169
		static Delegate GetNotificationIdHandler ()
		{
			if (cb_notificationId == null)
				cb_notificationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NotificationId);
			return cb_notificationId;
		}

		static int n_NotificationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationId ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='notificationId' and count(parameter)=0]"
		[Register ("notificationId", "()I", "GetNotificationIdHandler")]
		public abstract int NotificationId ();

		static Delegate cb_payload;
#pragma warning disable 0169
		static Delegate GetPayloadHandler ()
		{
			if (cb_payload == null)
				cb_payload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Payload);
			return cb_payload;
		}

		static IntPtr n_Payload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Payload ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='payload' and count(parameter)=0]"
		[Register ("payload", "()Landroid/os/Bundle;", "GetPayloadHandler")]
		public abstract global::Android.OS.Bundle Payload ();

		static Delegate cb_pictureUrl;
#pragma warning disable 0169
		static Delegate GetPictureUrlHandler ()
		{
			if (cb_pictureUrl == null)
				cb_pictureUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PictureUrl);
			return cb_pictureUrl;
		}

		static IntPtr n_PictureUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PictureUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_pictureUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='pictureUrl' and count(parameter)=0]"
		[Register ("pictureUrl", "()Ljava/lang/String;", "GetPictureUrlHandler")]
		public virtual unsafe string PictureUrl ()
		{
			if (id_pictureUrl == IntPtr.Zero)
				id_pictureUrl = JNIEnv.GetMethodID (class_ref, "pictureUrl", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pictureUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pictureUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_regionId;
#pragma warning disable 0169
		static Delegate GetRegionIdHandler ()
		{
			if (cb_regionId == null)
				cb_regionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RegionId);
			return cb_regionId;
		}

		static IntPtr n_RegionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegionId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='regionId' and count(parameter)=0]"
		[Register ("regionId", "()Ljava/lang/String;", "GetRegionIdHandler")]
		public abstract string RegionId ();

		static Delegate cb_smallIconResId;
#pragma warning disable 0169
		static Delegate GetSmallIconResIdHandler ()
		{
			if (cb_smallIconResId == null)
				cb_smallIconResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SmallIconResId);
			return cb_smallIconResId;
		}

		static int n_SmallIconResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmallIconResId ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='smallIconResId' and count(parameter)=0]"
		[Register ("smallIconResId", "()I", "GetSmallIconResIdHandler")]
		public abstract int SmallIconResId ();

		static Delegate cb_sound;
#pragma warning disable 0169
		static Delegate GetInvokeSoundHandler ()
		{
			if (cb_sound == null)
				cb_sound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeSound);
			return cb_sound;
		}

		static IntPtr n_InvokeSound (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeSound ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='sound' and count(parameter)=0]"
		[Register ("sound", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;", "GetInvokeSoundHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound InvokeSound ();

		static Delegate cb_soundName;
#pragma warning disable 0169
		static Delegate GetSoundNameHandler ()
		{
			if (cb_soundName == null)
				cb_soundName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SoundName);
			return cb_soundName;
		}

		static IntPtr n_SoundName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SoundName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='soundName' and count(parameter)=0]"
		[Register ("soundName", "()Ljava/lang/String;", "GetSoundNameHandler")]
		public abstract string SoundName ();

		static Delegate cb_subTitle;
#pragma warning disable 0169
		static Delegate GetSubTitleHandler ()
		{
			if (cb_subTitle == null)
				cb_subTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SubTitle);
			return cb_subTitle;
		}

		static IntPtr n_SubTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubTitle ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='subTitle' and count(parameter)=0]"
		[Register ("subTitle", "()Ljava/lang/String;", "GetSubTitleHandler")]
		public abstract string SubTitle ();

		static Delegate cb_title;
#pragma warning disable 0169
		static Delegate GetTitleHandler ()
		{
			if (cb_title == null)
				cb_title = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Title);
			return cb_title;
		}

		static IntPtr n_Title (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='title' and count(parameter)=0]"
		[Register ("title", "()Ljava/lang/String;", "GetTitleHandler")]
		public abstract string Title ();

		static Delegate cb_trigger;
#pragma warning disable 0169
		static Delegate GetInvokeTriggerHandler ()
		{
			if (cb_trigger == null)
				cb_trigger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeTrigger);
			return cb_trigger;
		}

		static IntPtr n_InvokeTrigger (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeTrigger ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='trigger' and count(parameter)=0]"
		[Register ("trigger", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;", "GetInvokeTriggerHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger InvokeTrigger ();

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetInvokeTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeType);
			return cb_type;
		}

		static IntPtr n_InvokeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;", "GetInvokeTypeHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type InvokeType ();

		static Delegate cb_url;
#pragma warning disable 0169
		static Delegate GetUrlHandler ()
		{
			if (cb_url == null)
				cb_url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Url);
			return cb_url;
		}

		static IntPtr n_Url (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "GetUrlHandler")]
		public abstract string Url ();

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public abstract global::System.Int32 DescribeContents ();

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/notifications/NotificationMessage", DoNotGenerateAcw=true)]
	internal partial class NotificationMessageInvoker : NotificationMessage {

		public NotificationMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationMessageInvoker); }
		}

		static IntPtr id_alert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='alert' and count(parameter)=0]"
		[Register ("alert", "()Ljava/lang/String;", "GetAlertHandler")]
		public override unsafe string Alert ()
		{
			if (id_alert == IntPtr.Zero)
				id_alert = JNIEnv.GetMethodID (class_ref, "alert", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_alert), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_custom;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='custom' and count(parameter)=0]"
		[Register ("custom", "()Ljava/lang/String;", "GetCustomHandler")]
		public override unsafe string Custom ()
		{
			if (id_custom == IntPtr.Zero)
				id_custom = JNIEnv.GetMethodID (class_ref, "custom", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_custom), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_customKeys;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='customKeys' and count(parameter)=0]"
		[Register ("customKeys", "()Ljava/util/Map;", "GetCustomKeysHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, string> CustomKeys ()
		{
			if (id_customKeys == IntPtr.Zero)
				id_customKeys = JNIEnv.GetMethodID (class_ref, "customKeys", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_customKeys), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_id;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public override unsafe string Id ()
		{
			if (id_id == IntPtr.Zero)
				id_id = JNIEnv.GetMethodID (class_ref, "id", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_id), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_mediaAltText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='mediaAltText' and count(parameter)=0]"
		[Register ("mediaAltText", "()Ljava/lang/String;", "GetMediaAltTextHandler")]
		public override unsafe string MediaAltText ()
		{
			if (id_mediaAltText == IntPtr.Zero)
				id_mediaAltText = JNIEnv.GetMethodID (class_ref, "mediaAltText", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mediaAltText), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_mediaUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='mediaUrl' and count(parameter)=0]"
		[Register ("mediaUrl", "()Ljava/lang/String;", "GetMediaUrlHandler")]
		public override unsafe string MediaUrl ()
		{
			if (id_mediaUrl == IntPtr.Zero)
				id_mediaUrl = JNIEnv.GetMethodID (class_ref, "mediaUrl", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mediaUrl), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_notificationId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='notificationId' and count(parameter)=0]"
		[Register ("notificationId", "()I", "GetNotificationIdHandler")]
		public override unsafe int NotificationId ()
		{
			if (id_notificationId == IntPtr.Zero)
				id_notificationId = JNIEnv.GetMethodID (class_ref, "notificationId", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_notificationId);
			} finally {
			}
		}

		static IntPtr id_payload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='payload' and count(parameter)=0]"
		[Register ("payload", "()Landroid/os/Bundle;", "GetPayloadHandler")]
		public override unsafe global::Android.OS.Bundle Payload ()
		{
			if (id_payload == IntPtr.Zero)
				id_payload = JNIEnv.GetMethodID (class_ref, "payload", "()Landroid/os/Bundle;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_payload), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_regionId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='regionId' and count(parameter)=0]"
		[Register ("regionId", "()Ljava/lang/String;", "GetRegionIdHandler")]
		public override unsafe string RegionId ()
		{
			if (id_regionId == IntPtr.Zero)
				id_regionId = JNIEnv.GetMethodID (class_ref, "regionId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_regionId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_smallIconResId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='smallIconResId' and count(parameter)=0]"
		[Register ("smallIconResId", "()I", "GetSmallIconResIdHandler")]
		public override unsafe int SmallIconResId ()
		{
			if (id_smallIconResId == IntPtr.Zero)
				id_smallIconResId = JNIEnv.GetMethodID (class_ref, "smallIconResId", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_smallIconResId);
			} finally {
			}
		}

		static IntPtr id_sound;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='sound' and count(parameter)=0]"
		[Register ("sound", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;", "GetInvokeSoundHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound InvokeSound ()
		{
			if (id_sound == IntPtr.Zero)
				id_sound = JNIEnv.GetMethodID (class_ref, "sound", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Sound;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Sound> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sound), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_soundName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='soundName' and count(parameter)=0]"
		[Register ("soundName", "()Ljava/lang/String;", "GetSoundNameHandler")]
		public override unsafe string SoundName ()
		{
			if (id_soundName == IntPtr.Zero)
				id_soundName = JNIEnv.GetMethodID (class_ref, "soundName", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_soundName), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subTitle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='subTitle' and count(parameter)=0]"
		[Register ("subTitle", "()Ljava/lang/String;", "GetSubTitleHandler")]
		public override unsafe string SubTitle ()
		{
			if (id_subTitle == IntPtr.Zero)
				id_subTitle = JNIEnv.GetMethodID (class_ref, "subTitle", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subTitle), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_title;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='title' and count(parameter)=0]"
		[Register ("title", "()Ljava/lang/String;", "GetTitleHandler")]
		public override unsafe string Title ()
		{
			if (id_title == IntPtr.Zero)
				id_title = JNIEnv.GetMethodID (class_ref, "title", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_title), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_trigger;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='trigger' and count(parameter)=0]"
		[Register ("trigger", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;", "GetInvokeTriggerHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger InvokeTrigger ()
		{
			if (id_trigger == IntPtr.Zero)
				id_trigger = JNIEnv.GetMethodID (class_ref, "trigger", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Trigger;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Trigger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trigger), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;", "GetInvokeTypeHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type InvokeType ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()Lcom/salesforce/marketingcloud/notifications/NotificationMessage$Type;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Notifications.NotificationMessage.Type> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_type), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_url;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.notifications']/class[@name='NotificationMessage']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "GetUrlHandler")]
		public override unsafe string Url ()
		{
			if (id_url == IntPtr.Zero)
				id_url = JNIEnv.GetMethodID (class_ref, "url", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_url), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}

}
