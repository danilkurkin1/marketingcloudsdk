using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Messages.Cloudpage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage", DoNotGenerateAcw=true)]
	public abstract partial class CloudPageMessage : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/field[@name='CONTENT_TYPE_CLOUD_PAGE_ONLY']"
		[Register ("CONTENT_TYPE_CLOUD_PAGE_ONLY")]
		public const int ContentTypeCloudPageOnly = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/field[@name='MESSAGE_TYPE_INBOX_MESSAGE']"
		[Register ("MESSAGE_TYPE_INBOX_MESSAGE")]
		public const int MessageTypeInboxMessage = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/field[@name='MESSAGE_TYPE_LEGACY_CLOUDPAGE']"
		[Register ("MESSAGE_TYPE_LEGACY_CLOUDPAGE")]
		public const int MessageTypeLegacyCloudpage = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media", DoNotGenerateAcw=true)]
		public abstract partial class Media : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Media); }
			}

			protected Media (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']/constructor[@name='CloudPageMessage.Media' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Media ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Media)) {
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

			static Delegate cb_altText;
#pragma warning disable 0169
			static Delegate GetAltTextHandler ()
			{
				if (cb_altText == null)
					cb_altText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AltText);
				return cb_altText;
			}

			static IntPtr n_AltText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AltText ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']/method[@name='altText' and count(parameter)=0]"
			[Register ("altText", "()Ljava/lang/String;", "GetAltTextHandler")]
			public abstract string AltText ();

			static IntPtr id_create_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;Ljava/lang/String;)Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media Create (string p0, string p1)
			{
				if (id_create_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;Ljava/lang/String;)Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

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
				global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Url ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']/method[@name='url' and count(parameter)=0]"
			[Register ("url", "()Ljava/lang/String;", "GetUrlHandler")]
			public abstract string Url ();

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media", DoNotGenerateAcw=true)]
		internal partial class MediaInvoker : Media {

			public MediaInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaInvoker); }
			}

			static IntPtr id_altText;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']/method[@name='altText' and count(parameter)=0]"
			[Register ("altText", "()Ljava/lang/String;", "GetAltTextHandler")]
			public override unsafe string AltText ()
			{
				if (id_altText == IntPtr.Zero)
					id_altText = JNIEnv.GetMethodID (class_ref, "altText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_altText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_url;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage.Media']/method[@name='url' and count(parameter)=0]"
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

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudPageMessage); }
		}

		protected CloudPageMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/constructor[@name='CloudPageMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloudPageMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CloudPageMessage)) {
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

		static Delegate cb_isLegacyMessage;
#pragma warning disable 0169
		static Delegate GetIsLegacyMessageHandler ()
		{
			if (cb_isLegacyMessage == null)
				cb_isLegacyMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLegacyMessage);
			return cb_isLegacyMessage;
		}

		static bool n_IsLegacyMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLegacyMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isLegacyMessage;
		public virtual unsafe bool IsLegacyMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='isLegacyMessage' and count(parameter)=0]"
			[Register ("isLegacyMessage", "()Z", "GetIsLegacyMessageHandler")]
			get {
				if (id_isLegacyMessage == IntPtr.Zero)
					id_isLegacyMessage = JNIEnv.GetMethodID (class_ref, "isLegacyMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLegacyMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLegacyMessage", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getLegacySubject;
		public unsafe string LegacySubject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='getLegacySubject' and count(parameter)=0]"
			[Register ("getLegacySubject", "()Ljava/lang/String;", "GetGetLegacySubjectHandler")]
			get {
				if (id_getLegacySubject == IntPtr.Zero)
					id_getLegacySubject = JNIEnv.GetMethodID (class_ref, "getLegacySubject", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLegacySubject), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alert ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='alert' and count(parameter)=0]"
		[Register ("alert", "()Ljava/lang/String;", "GetAlertHandler")]
		public abstract string Alert ();

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContentType);
			return cb_contentType;
		}

		static int n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()I", "GetContentTypeHandler")]
		public abstract int ContentType ();

		static IntPtr id_create_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("create", "(Lorg/json/JSONObject;)Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage Create (global::Org.Json.JSONObject p0)
		{
			if (id_create_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_create_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorg/json/JSONObject;)Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

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
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Custom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='custom' and count(parameter)=0]"
		[Register ("custom", "()Ljava/lang/String;", "GetCustomHandler")]
		public abstract string Custom ();

		static IntPtr id_deleted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='deleted' and count(parameter)=0]"
		[Register ("deleted", "()Z", "")]
		public unsafe bool Deleted ()
		{
			if (id_deleted == IntPtr.Zero)
				id_deleted = JNIEnv.GetMethodID (class_ref, "deleted", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleted);
			} finally {
			}
		}

		static Delegate cb_endDateUtc;
#pragma warning disable 0169
		static Delegate GetEndDateUtcHandler ()
		{
			if (cb_endDateUtc == null)
				cb_endDateUtc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EndDateUtc);
			return cb_endDateUtc;
		}

		static IntPtr n_EndDateUtc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndDateUtc ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='endDateUtc' and count(parameter)=0]"
		[Register ("endDateUtc", "()Ljava/util/Date;", "GetEndDateUtcHandler")]
		public abstract global::Java.Util.Date EndDateUtc ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public abstract string Id ();

		static Delegate cb_keys;
#pragma warning disable 0169
		static Delegate GetKeysHandler ()
		{
			if (cb_keys == null)
				cb_keys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Keys);
			return cb_keys;
		}

		static IntPtr n_Keys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Registration.Attribute>.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/List;", "GetKeysHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Registration.Attribute> Keys ();

		static Delegate cb_media;
#pragma warning disable 0169
		static Delegate GetInvokeMediaHandler ()
		{
			if (cb_media == null)
				cb_media = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeMedia);
			return cb_media;
		}

		static IntPtr n_InvokeMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeMedia ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='media' and count(parameter)=0]"
		[Register ("media", "()Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media;", "GetInvokeMediaHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media InvokeMedia ();

		static Delegate cb_messageHash;
#pragma warning disable 0169
		static Delegate GetMessageHashHandler ()
		{
			if (cb_messageHash == null)
				cb_messageHash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MessageHash);
			return cb_messageHash;
		}

		static IntPtr n_MessageHash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageHash ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='messageHash' and count(parameter)=0]"
		[Register ("messageHash", "()Ljava/lang/String;", "GetMessageHashHandler")]
		public abstract string MessageHash ();

		static Delegate cb_messageType;
#pragma warning disable 0169
		static Delegate GetMessageTypeHandler ()
		{
			if (cb_messageType == null)
				cb_messageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MessageType);
			return cb_messageType;
		}

		static int n_MessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='messageType' and count(parameter)=0]"
		[Register ("messageType", "()I", "GetMessageTypeHandler")]
		public abstract int MessageType ();

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()Z", "")]
		public unsafe bool Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_read);
			} finally {
			}
		}

		static Delegate cb_requestId;
#pragma warning disable 0169
		static Delegate GetRequestIdHandler ()
		{
			if (cb_requestId == null)
				cb_requestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RequestId);
			return cb_requestId;
		}

		static IntPtr n_RequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='requestId' and count(parameter)=0]"
		[Register ("requestId", "()Ljava/lang/String;", "GetRequestIdHandler")]
		public abstract string RequestId ();

		static IntPtr id_setDeleted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='setDeleted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDeleted", "(Z)V", "")]
		public unsafe void SetDeleted (bool p0)
		{
			if (id_setDeleted_Z == IntPtr.Zero)
				id_setDeleted_Z = JNIEnv.GetMethodID (class_ref, "setDeleted", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeleted_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setRead_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='setRead' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRead", "(Z)V", "")]
		public unsafe void SetRead (bool p0)
		{
			if (id_setRead_Z == IntPtr.Zero)
				id_setRead_Z = JNIEnv.GetMethodID (class_ref, "setRead", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRead_Z, __args);
			} finally {
			}
		}

		static Delegate cb_sound;
#pragma warning disable 0169
		static Delegate GetSoundHandler ()
		{
			if (cb_sound == null)
				cb_sound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sound);
			return cb_sound;
		}

		static IntPtr n_Sound (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sound ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='sound' and count(parameter)=0]"
		[Register ("sound", "()Ljava/lang/String;", "GetSoundHandler")]
		public abstract string Sound ();

		static Delegate cb_startDateUtc;
#pragma warning disable 0169
		static Delegate GetStartDateUtcHandler ()
		{
			if (cb_startDateUtc == null)
				cb_startDateUtc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_StartDateUtc);
			return cb_startDateUtc;
		}

		static IntPtr n_StartDateUtc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartDateUtc ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='startDateUtc' and count(parameter)=0]"
		[Register ("startDateUtc", "()Ljava/util/Date;", "GetStartDateUtcHandler")]
		public abstract global::Java.Util.Date StartDateUtc ();

		static Delegate cb_subject;
#pragma warning disable 0169
		static Delegate GetSubjectHandler ()
		{
			if (cb_subject == null)
				cb_subject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Subject);
			return cb_subject;
		}

		static IntPtr n_Subject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subject ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='subject' and count(parameter)=0]"
		[Register ("subject", "()Ljava/lang/String;", "GetSubjectHandler")]
		public abstract string Subject ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='title' and count(parameter)=0]"
		[Register ("title", "()Ljava/lang/String;", "GetTitleHandler")]
		public abstract string Title ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "GetUrlHandler")]
		public abstract string Url ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage", DoNotGenerateAcw=true)]
	internal partial class CloudPageMessageInvoker : CloudPageMessage {

		public CloudPageMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudPageMessageInvoker); }
		}

		static IntPtr id_alert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='alert' and count(parameter)=0]"
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

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()I", "GetContentTypeHandler")]
		public override unsafe int ContentType ()
		{
			if (id_contentType == IntPtr.Zero)
				id_contentType = JNIEnv.GetMethodID (class_ref, "contentType", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_contentType);
			} finally {
			}
		}

		static IntPtr id_custom;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='custom' and count(parameter)=0]"
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

		static IntPtr id_endDateUtc;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='endDateUtc' and count(parameter)=0]"
		[Register ("endDateUtc", "()Ljava/util/Date;", "GetEndDateUtcHandler")]
		public override unsafe global::Java.Util.Date EndDateUtc ()
		{
			if (id_endDateUtc == IntPtr.Zero)
				id_endDateUtc = JNIEnv.GetMethodID (class_ref, "endDateUtc", "()Ljava/util/Date;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_endDateUtc), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_id;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='id' and count(parameter)=0]"
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

		static IntPtr id_keys;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/List;", "GetKeysHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Registration.Attribute> Keys ()
		{
			if (id_keys == IntPtr.Zero)
				id_keys = JNIEnv.GetMethodID (class_ref, "keys", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Registration.Attribute>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keys), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_media;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='media' and count(parameter)=0]"
		[Register ("media", "()Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media;", "GetInvokeMediaHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media InvokeMedia ()
		{
			if (id_media == IntPtr.Zero)
				id_media = JNIEnv.GetMethodID (class_ref, "media", "()Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage$Media;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage.Media> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_media), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_messageHash;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='messageHash' and count(parameter)=0]"
		[Register ("messageHash", "()Ljava/lang/String;", "GetMessageHashHandler")]
		public override unsafe string MessageHash ()
		{
			if (id_messageHash == IntPtr.Zero)
				id_messageHash = JNIEnv.GetMethodID (class_ref, "messageHash", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_messageHash), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_messageType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='messageType' and count(parameter)=0]"
		[Register ("messageType", "()I", "GetMessageTypeHandler")]
		public override unsafe int MessageType ()
		{
			if (id_messageType == IntPtr.Zero)
				id_messageType = JNIEnv.GetMethodID (class_ref, "messageType", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_messageType);
			} finally {
			}
		}

		static IntPtr id_requestId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='requestId' and count(parameter)=0]"
		[Register ("requestId", "()Ljava/lang/String;", "GetRequestIdHandler")]
		public override unsafe string RequestId ()
		{
			if (id_requestId == IntPtr.Zero)
				id_requestId = JNIEnv.GetMethodID (class_ref, "requestId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_sound;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='sound' and count(parameter)=0]"
		[Register ("sound", "()Ljava/lang/String;", "GetSoundHandler")]
		public override unsafe string Sound ()
		{
			if (id_sound == IntPtr.Zero)
				id_sound = JNIEnv.GetMethodID (class_ref, "sound", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sound), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_startDateUtc;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='startDateUtc' and count(parameter)=0]"
		[Register ("startDateUtc", "()Ljava/util/Date;", "GetStartDateUtcHandler")]
		public override unsafe global::Java.Util.Date StartDateUtc ()
		{
			if (id_startDateUtc == IntPtr.Zero)
				id_startDateUtc = JNIEnv.GetMethodID (class_ref, "startDateUtc", "()Ljava/util/Date;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startDateUtc), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='subject' and count(parameter)=0]"
		[Register ("subject", "()Ljava/lang/String;", "GetSubjectHandler")]
		public override unsafe string Subject ()
		{
			if (id_subject == IntPtr.Zero)
				id_subject = JNIEnv.GetMethodID (class_ref, "subject", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subject), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_title;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='title' and count(parameter)=0]"
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

		static IntPtr id_url;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageMessage']/method[@name='url' and count(parameter)=0]"
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

	}

}
