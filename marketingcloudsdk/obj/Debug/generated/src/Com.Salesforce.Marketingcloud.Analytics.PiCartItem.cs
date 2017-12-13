using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/PiCartItem", DoNotGenerateAcw=true)]
	public abstract partial class PiCartItem : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/analytics/PiCartItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PiCartItem); }
		}

		protected PiCartItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/constructor[@name='PiCartItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PiCartItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PiCartItem)) {
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

		static IntPtr id_create_Ljava_lang_String_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("create", "(Ljava/lang/String;ID)Lcom/salesforce/marketingcloud/analytics/PiCartItem;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem Create (string p0, int p1, double p2)
		{
			if (id_create_Ljava_lang_String_ID == IntPtr.Zero)
				id_create_Ljava_lang_String_ID = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;ID)Lcom/salesforce/marketingcloud/analytics/PiCartItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_ID, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_create_Ljava_lang_String_IDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='create' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;IDLjava/lang/String;)Lcom/salesforce/marketingcloud/analytics/PiCartItem;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem Create (string p0, int p1, double p2, string p3)
		{
			if (id_create_Ljava_lang_String_IDLjava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_IDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;IDLjava/lang/String;)Lcom/salesforce/marketingcloud/analytics/PiCartItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_IDLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_item;
#pragma warning disable 0169
		static Delegate GetItemHandler ()
		{
			if (cb_item == null)
				cb_item = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Item);
			return cb_item;
		}

		static IntPtr n_Item (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Item ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='item' and count(parameter)=0]"
		[Register ("item", "()Ljava/lang/String;", "GetItemHandler")]
		public abstract string Item ();

		static Delegate cb_price;
#pragma warning disable 0169
		static Delegate GetPriceHandler ()
		{
			if (cb_price == null)
				cb_price = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Price);
			return cb_price;
		}

		static double n_Price (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Price ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='price' and count(parameter)=0]"
		[Register ("price", "()D", "GetPriceHandler")]
		public abstract double Price ();

		static Delegate cb_quantity;
#pragma warning disable 0169
		static Delegate GetQuantityHandler ()
		{
			if (cb_quantity == null)
				cb_quantity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Quantity);
			return cb_quantity;
		}

		static int n_Quantity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quantity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='quantity' and count(parameter)=0]"
		[Register ("quantity", "()I", "GetQuantityHandler")]
		public abstract int Quantity ();

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public abstract global::Org.Json.JSONObject ToJson ();

		static Delegate cb_uniqueId;
#pragma warning disable 0169
		static Delegate GetUniqueIdHandler ()
		{
			if (cb_uniqueId == null)
				cb_uniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_UniqueId);
			return cb_uniqueId;
		}

		static IntPtr n_UniqueId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='uniqueId' and count(parameter)=0]"
		[Register ("uniqueId", "()Ljava/lang/String;", "GetUniqueIdHandler")]
		public abstract string UniqueId ();

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
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/PiCartItem", DoNotGenerateAcw=true)]
	internal partial class PiCartItemInvoker : PiCartItem {

		public PiCartItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PiCartItemInvoker); }
		}

		static IntPtr id_item;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='item' and count(parameter)=0]"
		[Register ("item", "()Ljava/lang/String;", "GetItemHandler")]
		public override unsafe string Item ()
		{
			if (id_item == IntPtr.Zero)
				id_item = JNIEnv.GetMethodID (class_ref, "item", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_item), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_price;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='price' and count(parameter)=0]"
		[Register ("price", "()D", "GetPriceHandler")]
		public override unsafe double Price ()
		{
			if (id_price == IntPtr.Zero)
				id_price = JNIEnv.GetMethodID (class_ref, "price", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_price);
			} finally {
			}
		}

		static IntPtr id_quantity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='quantity' and count(parameter)=0]"
		[Register ("quantity", "()I", "GetQuantityHandler")]
		public override unsafe int Quantity ()
		{
			if (id_quantity == IntPtr.Zero)
				id_quantity = JNIEnv.GetMethodID (class_ref, "quantity", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_quantity);
			} finally {
			}
		}

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public override unsafe global::Org.Json.JSONObject ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_uniqueId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCartItem']/method[@name='uniqueId' and count(parameter)=0]"
		[Register ("uniqueId", "()Ljava/lang/String;", "GetUniqueIdHandler")]
		public override unsafe string UniqueId ()
		{
			if (id_uniqueId == IntPtr.Zero)
				id_uniqueId = JNIEnv.GetMethodID (class_ref, "uniqueId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uniqueId), JniHandleOwnership.TransferLocalRef);
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
