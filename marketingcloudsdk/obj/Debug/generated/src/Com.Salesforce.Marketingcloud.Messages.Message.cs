using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Messages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message", DoNotGenerateAcw=true)]
	public abstract partial class Message : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='d']"
		[Register ("d")]
		public const int D = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='e']"
		[Register ("e")]
		public const int E = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='f']"
		[Register ("f")]
		public const int F = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='g']"
		[Register ("g")]
		public const int G = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='h']"
		[Register ("h")]
		public const int H = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='i']"
		[Register ("i")]
		public const int I = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='j']"
		[Register ("j")]
		public const int J = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='k']"
		[Register ("k")]
		public const int K = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='l']"
		[Register ("l")]
		public const int L = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='m']"
		[Register ("m")]
		public const int M = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='n']"
		[Register ("n")]
		public const int N = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='o']"
		[Register ("o")]
		public const int O = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='p']"
		[Register ("p")]
		public const int P = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='q']"
		[Register ("q")]
		public const int Q = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='r']"
		[Register ("r")]
		public const int R = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/field[@name='s']"
		[Register ("s")]
		public const int S = (int) 3;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/interface[@name='Message.ContentType']"
		[Register ("com/salesforce/marketingcloud/messages/Message$ContentType", "", "Com.Salesforce.Marketingcloud.Messages.Message/IContentTypeInvoker")]
		public partial interface IContentType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message$ContentType", DoNotGenerateAcw=true)]
		internal class IContentTypeInvoker : global::Java.Lang.Object, IContentType {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Message$ContentType");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IContentTypeInvoker); }
			}

			IntPtr class_ref;

			public static IContentType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IContentType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.messages.Message.ContentType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IContentTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IContentType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message$Media", DoNotGenerateAcw=true)]
		public abstract partial class Media : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Message$Media", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']/constructor[@name='Message.Media' and count(parameter)=0]"
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
				global::Com.Salesforce.Marketingcloud.Messages.Message.Media __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AltText ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']/method[@name='altText' and count(parameter)=0]"
			[Register ("altText", "()Ljava/lang/String;", "GetAltTextHandler")]
			public abstract string AltText ();

			static IntPtr id_create_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("create", "(Ljava/lang/String;Ljava/lang/String;)Lcom/salesforce/marketingcloud/messages/Message$Media;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.Messages.Message.Media Create (string p0, string p1)
			{
				if (id_create_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_create_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;Ljava/lang/String;)Lcom/salesforce/marketingcloud/messages/Message$Media;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					global::Com.Salesforce.Marketingcloud.Messages.Message.Media __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.Media> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Salesforce.Marketingcloud.Messages.Message.Media __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.Media> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Url ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']/method[@name='url' and count(parameter)=0]"
			[Register ("url", "()Ljava/lang/String;", "GetUrlHandler")]
			public abstract string Url ();

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message$Media", DoNotGenerateAcw=true)]
		internal partial class MediaInvoker : Media {

			public MediaInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaInvoker); }
			}

			static IntPtr id_altText;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']/method[@name='altText' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message.Media']/method[@name='url' and count(parameter)=0]"
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/interface[@name='Message.MessageType']"
		[Register ("com/salesforce/marketingcloud/messages/Message$MessageType", "", "Com.Salesforce.Marketingcloud.Messages.Message/IMessageTypeInvoker")]
		public partial interface IMessageType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message$MessageType", DoNotGenerateAcw=true)]
		internal class IMessageTypeInvoker : global::Java.Lang.Object, IMessageType {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Message$MessageType");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMessageTypeInvoker); }
			}

			IntPtr class_ref;

			public static IMessageType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMessageType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.messages.Message.MessageType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMessageTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IMessageType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/interface[@name='Message.PeriodType']"
		[Register ("com/salesforce/marketingcloud/messages/Message$PeriodType", "", "Com.Salesforce.Marketingcloud.Messages.Message/IPeriodTypeInvoker")]
		public partial interface IPeriodType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message$PeriodType", DoNotGenerateAcw=true)]
		internal class IPeriodTypeInvoker : global::Java.Lang.Object, IPeriodType {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Message$PeriodType");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPeriodTypeInvoker); }
			}

			IntPtr class_ref;

			public static IPeriodType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPeriodType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.messages.Message.PeriodType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPeriodTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IPeriodType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/interface[@name='Message.Proximity']"
		[Register ("com/salesforce/marketingcloud/messages/Message$Proximity", "", "Com.Salesforce.Marketingcloud.Messages.Message/IProximityInvoker")]
		public partial interface IProximity : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message$Proximity", DoNotGenerateAcw=true)]
		internal class IProximityInvoker : global::Java.Lang.Object, IProximity {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Message$Proximity");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProximityInvoker); }
			}

			IntPtr class_ref;

			public static IProximity GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProximity> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.messages.Message.Proximity"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProximityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.IProximity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/constructor[@name='Message' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Message ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Message)) {
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

		static IntPtr id_hasEntered;
		public unsafe bool HasEntered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='hasEntered' and count(parameter)=0]"
			[Register ("hasEntered", "()Z", "GetHasEnteredHandler")]
			get {
				if (id_hasEntered == IntPtr.Zero)
					id_hasEntered = JNIEnv.GetMethodID (class_ref, "hasEntered", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasEntered);
				} finally {
				}
			}
		}

		static Delegate cb_isRollingPeriod;
#pragma warning disable 0169
		static Delegate GetIsRollingPeriodHandler ()
		{
			if (cb_isRollingPeriod == null)
				cb_isRollingPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRollingPeriod);
			return cb_isRollingPeriod;
		}

		static bool n_IsRollingPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRollingPeriod;
		}
#pragma warning restore 0169

		public abstract bool IsRollingPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='isRollingPeriod' and count(parameter)=0]"
			[Register ("isRollingPeriod", "()Z", "GetIsRollingPeriodHandler")] get;
		}

		static IntPtr id_getLastShownDate;
		public unsafe global::Java.Util.Date LastShownDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='getLastShownDate' and count(parameter)=0]"
			[Register ("getLastShownDate", "()Ljava/util/Date;", "GetGetLastShownDateHandler")]
			get {
				if (id_getLastShownDate == IntPtr.Zero)
					id_getLastShownDate = JNIEnv.GetMethodID (class_ref, "getLastShownDate", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastShownDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNextAllowedShow;
		public unsafe global::Java.Util.Date NextAllowedShow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='getNextAllowedShow' and count(parameter)=0]"
			[Register ("getNextAllowedShow", "()Ljava/util/Date;", "GetGetNextAllowedShowHandler")]
			get {
				if (id_getNextAllowedShow == IntPtr.Zero)
					id_getNextAllowedShow = JNIEnv.GetMethodID (class_ref, "getNextAllowedShow", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextAllowedShow), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNotifyId;
		public unsafe int NotifyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='getNotifyId' and count(parameter)=0]"
			[Register ("getNotifyId", "()I", "GetGetNotifyIdHandler")]
			get {
				if (id_getNotifyId == IntPtr.Zero)
					id_getNotifyId = JNIEnv.GetMethodID (class_ref, "getNotifyId", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotifyId);
				} finally {
				}
			}
		}

		static IntPtr id_getPeriodShowCount;
		public unsafe int PeriodShowCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='getPeriodShowCount' and count(parameter)=0]"
			[Register ("getPeriodShowCount", "()I", "GetGetPeriodShowCountHandler")]
			get {
				if (id_getPeriodShowCount == IntPtr.Zero)
					id_getPeriodShowCount = JNIEnv.GetMethodID (class_ref, "getPeriodShowCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeriodShowCount);
				} finally {
				}
			}
		}

		static IntPtr id_getShowCount;
		public unsafe int ShowCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='getShowCount' and count(parameter)=0]"
			[Register ("getShowCount", "()I", "GetGetShowCountHandler")]
			get {
				if (id_getShowCount == IntPtr.Zero)
					id_getShowCount = JNIEnv.GetMethodID (class_ref, "getShowCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getShowCount);
				} finally {
				}
			}
		}

		static IntPtr id_a_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_a_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("a", "(Ljava/util/Date;)V", "")]
		public unsafe void A (global::Java.Util.Date p0)
		{
			if (id_a_Ljava_util_Date_ == IntPtr.Zero)
				id_a_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_util_Date_, __args);
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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Alert ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='alert' and count(parameter)=0]"
		[Register ("alert", "()Ljava/lang/String;", "GetAlertHandler")]
		public abstract string Alert ();

		static IntPtr id_b_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='b' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("b", "(I)V", "")]
		public unsafe void B (int p0)
		{
			if (id_b_I == IntPtr.Zero)
				id_b_I = JNIEnv.GetMethodID (class_ref, "b", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_I, __args);
			} finally {
			}
		}

		static IntPtr id_b_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("b", "(Ljava/util/Date;)V", "")]
		public unsafe void B (global::Java.Util.Date p0)
		{
			if (id_b_Ljava_util_Date_ == IntPtr.Zero)
				id_b_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_Ljava_util_Date_, __args);
			} finally {
			}
		}

		static IntPtr id_b_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='b' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("b", "(Lorg/json/JSONObject;)Lcom/salesforce/marketingcloud/messages/Message;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Messages.Message B (global::Org.Json.JSONObject p0)
		{
			if (id_b_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_b_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lorg/json/JSONObject;)Lcom/salesforce/marketingcloud/messages/Message;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Salesforce.Marketingcloud.Messages.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_c_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='c' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("c", "(I)V", "")]
		public unsafe void C (int p0)
		{
			if (id_c_I == IntPtr.Zero)
				id_c_I = JNIEnv.GetMethodID (class_ref, "c", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_c_I, __args);
			} finally {
			}
		}

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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()I", "GetContentTypeHandler")]
		public abstract int ContentType ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Custom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='custom' and count(parameter)=0]"
		[Register ("custom", "()Ljava/lang/String;", "GetCustomHandler")]
		public abstract string Custom ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndDateUtc ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='endDateUtc' and count(parameter)=0]"
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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='id' and count(parameter)=0]"
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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Registration.Attribute>.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='keys' and count(parameter)=0]"
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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeMedia ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='media' and count(parameter)=0]"
		[Register ("media", "()Lcom/salesforce/marketingcloud/messages/Message$Media;", "GetInvokeMediaHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Messages.Message.Media InvokeMedia ();

		static Delegate cb_messageLimit;
#pragma warning disable 0169
		static Delegate GetMessageLimitHandler ()
		{
			if (cb_messageLimit == null)
				cb_messageLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MessageLimit);
			return cb_messageLimit;
		}

		static int n_MessageLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageLimit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='messageLimit' and count(parameter)=0]"
		[Register ("messageLimit", "()I", "GetMessageLimitHandler")]
		public abstract int MessageLimit ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='messageType' and count(parameter)=0]"
		[Register ("messageType", "()I", "GetMessageTypeHandler")]
		public abstract int MessageType ();

		static Delegate cb_messagesPerPeriod;
#pragma warning disable 0169
		static Delegate GetMessagesPerPeriodHandler ()
		{
			if (cb_messagesPerPeriod == null)
				cb_messagesPerPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MessagesPerPeriod);
			return cb_messagesPerPeriod;
		}

		static int n_MessagesPerPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessagesPerPeriod ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='messagesPerPeriod' and count(parameter)=0]"
		[Register ("messagesPerPeriod", "()I", "GetMessagesPerPeriodHandler")]
		public abstract int MessagesPerPeriod ();

		static Delegate cb_numberOfPeriods;
#pragma warning disable 0169
		static Delegate GetNumberOfPeriodsHandler ()
		{
			if (cb_numberOfPeriods == null)
				cb_numberOfPeriods = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NumberOfPeriods);
			return cb_numberOfPeriods;
		}

		static int n_NumberOfPeriods (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfPeriods ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='numberOfPeriods' and count(parameter)=0]"
		[Register ("numberOfPeriods", "()I", "GetNumberOfPeriodsHandler")]
		public abstract int NumberOfPeriods ();

		static Delegate cb_openDirect;
#pragma warning disable 0169
		static Delegate GetOpenDirectHandler ()
		{
			if (cb_openDirect == null)
				cb_openDirect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenDirect);
			return cb_openDirect;
		}

		static IntPtr n_OpenDirect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpenDirect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='openDirect' and count(parameter)=0]"
		[Register ("openDirect", "()Ljava/lang/String;", "GetOpenDirectHandler")]
		public abstract string OpenDirect ();

		static Delegate cb_periodType;
#pragma warning disable 0169
		static Delegate GetPeriodTypeHandler ()
		{
			if (cb_periodType == null)
				cb_periodType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_PeriodType);
			return cb_periodType;
		}

		static int n_PeriodType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeriodType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='periodType' and count(parameter)=0]"
		[Register ("periodType", "()I", "GetPeriodTypeHandler")]
		public abstract int PeriodType ();

		static Delegate cb_proximity;
#pragma warning disable 0169
		static Delegate GetProximityHandler ()
		{
			if (cb_proximity == null)
				cb_proximity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Proximity);
			return cb_proximity;
		}

		static int n_Proximity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Proximity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='proximity' and count(parameter)=0]"
		[Register ("proximity", "()I", "GetProximityHandler")]
		public abstract int Proximity ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sound ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='sound' and count(parameter)=0]"
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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartDateUtc ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='startDateUtc' and count(parameter)=0]"
		[Register ("startDateUtc", "()Ljava/util/Date;", "GetStartDateUtcHandler")]
		public abstract global::Java.Util.Date StartDateUtc ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='title' and count(parameter)=0]"
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
			global::Com.Salesforce.Marketingcloud.Messages.Message __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "GetUrlHandler")]
		public abstract string Url ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Message", DoNotGenerateAcw=true)]
	internal partial class MessageInvoker : Message {

		public MessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageInvoker); }
		}

		static IntPtr id_isRollingPeriod;
		public override unsafe bool IsRollingPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='isRollingPeriod' and count(parameter)=0]"
			[Register ("isRollingPeriod", "()Z", "GetIsRollingPeriodHandler")]
			get {
				if (id_isRollingPeriod == IntPtr.Zero)
					id_isRollingPeriod = JNIEnv.GetMethodID (class_ref, "isRollingPeriod", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRollingPeriod);
				} finally {
				}
			}
		}

		static IntPtr id_alert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='alert' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='contentType' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='custom' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='endDateUtc' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='id' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='keys' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='media' and count(parameter)=0]"
		[Register ("media", "()Lcom/salesforce/marketingcloud/messages/Message$Media;", "GetInvokeMediaHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Messages.Message.Media InvokeMedia ()
		{
			if (id_media == IntPtr.Zero)
				id_media = JNIEnv.GetMethodID (class_ref, "media", "()Lcom/salesforce/marketingcloud/messages/Message$Media;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Message.Media> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_media), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_messageLimit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='messageLimit' and count(parameter)=0]"
		[Register ("messageLimit", "()I", "GetMessageLimitHandler")]
		public override unsafe int MessageLimit ()
		{
			if (id_messageLimit == IntPtr.Zero)
				id_messageLimit = JNIEnv.GetMethodID (class_ref, "messageLimit", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_messageLimit);
			} finally {
			}
		}

		static IntPtr id_messageType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='messageType' and count(parameter)=0]"
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

		static IntPtr id_messagesPerPeriod;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='messagesPerPeriod' and count(parameter)=0]"
		[Register ("messagesPerPeriod", "()I", "GetMessagesPerPeriodHandler")]
		public override unsafe int MessagesPerPeriod ()
		{
			if (id_messagesPerPeriod == IntPtr.Zero)
				id_messagesPerPeriod = JNIEnv.GetMethodID (class_ref, "messagesPerPeriod", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_messagesPerPeriod);
			} finally {
			}
		}

		static IntPtr id_numberOfPeriods;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='numberOfPeriods' and count(parameter)=0]"
		[Register ("numberOfPeriods", "()I", "GetNumberOfPeriodsHandler")]
		public override unsafe int NumberOfPeriods ()
		{
			if (id_numberOfPeriods == IntPtr.Zero)
				id_numberOfPeriods = JNIEnv.GetMethodID (class_ref, "numberOfPeriods", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_numberOfPeriods);
			} finally {
			}
		}

		static IntPtr id_openDirect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='openDirect' and count(parameter)=0]"
		[Register ("openDirect", "()Ljava/lang/String;", "GetOpenDirectHandler")]
		public override unsafe string OpenDirect ()
		{
			if (id_openDirect == IntPtr.Zero)
				id_openDirect = JNIEnv.GetMethodID (class_ref, "openDirect", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openDirect), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_periodType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='periodType' and count(parameter)=0]"
		[Register ("periodType", "()I", "GetPeriodTypeHandler")]
		public override unsafe int PeriodType ()
		{
			if (id_periodType == IntPtr.Zero)
				id_periodType = JNIEnv.GetMethodID (class_ref, "periodType", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_periodType);
			} finally {
			}
		}

		static IntPtr id_proximity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='proximity' and count(parameter)=0]"
		[Register ("proximity", "()I", "GetProximityHandler")]
		public override unsafe int Proximity ()
		{
			if (id_proximity == IntPtr.Zero)
				id_proximity = JNIEnv.GetMethodID (class_ref, "proximity", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_proximity);
			} finally {
			}
		}

		static IntPtr id_sound;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='sound' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='startDateUtc' and count(parameter)=0]"
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

		static IntPtr id_title;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='title' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Message']/method[@name='url' and count(parameter)=0]"
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
