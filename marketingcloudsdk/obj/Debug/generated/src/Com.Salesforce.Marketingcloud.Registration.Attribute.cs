using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Registration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/registration/Attribute", DoNotGenerateAcw=true)]
	public abstract partial class Attribute : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Java.IO.ISerializable, global::Java.Lang.IComparable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/registration/Attribute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Attribute); }
		}

		protected Attribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/constructor[@name='Attribute' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Attribute ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Attribute)) {
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lorg/json/JSONObject;", "GetAHandler")]
		public abstract global::Org.Json.JSONObject A ();

		static IntPtr id_a_Lcom_salesforce_marketingcloud_registration_Attribute_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.registration.Attribute']]"
		[Register ("a", "(Lcom/salesforce/marketingcloud/registration/Attribute;)I", "")]
		public unsafe int A (global::Com.Salesforce.Marketingcloud.Registration.Attribute p0)
		{
			if (id_a_Lcom_salesforce_marketingcloud_registration_Attribute_ == IntPtr.Zero)
				id_a_Lcom_salesforce_marketingcloud_registration_Attribute_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/salesforce/marketingcloud/registration/Attribute;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_salesforce_marketingcloud_registration_Attribute_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)Lcom/salesforce/marketingcloud/registration/Attribute;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Registration.Attribute A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)Lcom/salesforce/marketingcloud/registration/Attribute;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Salesforce.Marketingcloud.Registration.Attribute __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_key;
#pragma warning disable 0169
		static Delegate GetKeyHandler ()
		{
			if (cb_key == null)
				cb_key = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Key);
			return cb_key;
		}

		static IntPtr n_Key (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='key' and count(parameter)=0]"
		[Register ("key", "()Ljava/lang/String;", "GetKeyHandler")]
		public abstract string Key ();

		static Delegate cb_value;
#pragma warning disable 0169
		static Delegate GetValueHandler ()
		{
			if (cb_value == null)
				cb_value = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Value);
			return cb_value;
		}

		static IntPtr n_Value (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "GetValueHandler")]
		public abstract string Value ();

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
			global::Com.Salesforce.Marketingcloud.Registration.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Salesforce.Marketingcloud.Registration.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::Com.Salesforce.Marketingcloud.Registration.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Registration.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object o);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/registration/Attribute", DoNotGenerateAcw=true)]
	internal partial class AttributeInvoker : Attribute {

		public AttributeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttributeInvoker); }
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lorg/json/JSONObject;", "GetAHandler")]
		public override unsafe global::Org.Json.JSONObject A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_key;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='key' and count(parameter)=0]"
		[Register ("key", "()Ljava/lang/String;", "GetKeyHandler")]
		public override unsafe string Key ()
		{
			if (id_key == IntPtr.Zero)
				id_key = JNIEnv.GetMethodID (class_ref, "key", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_key), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_value;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.registration']/class[@name='Attribute']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "GetValueHandler")]
		public override unsafe string Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_compareTo_Ljava_lang_Object_;
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Int32 CompareTo (global::Java.Lang.Object o)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
