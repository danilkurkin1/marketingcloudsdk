using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/PiOrder", DoNotGenerateAcw=true)]
	public abstract partial class PiOrder : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/analytics/PiOrder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PiOrder); }
		}

		protected PiOrder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/constructor[@name='PiOrder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PiOrder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PiOrder)) {
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

		static Delegate cb_cart;
#pragma warning disable 0169
		static Delegate GetCartHandler ()
		{
			if (cb_cart == null)
				cb_cart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Cart);
			return cb_cart;
		}

		static IntPtr n_Cart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cart ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='cart' and count(parameter)=0]"
		[Register ("cart", "()Lcom/salesforce/marketingcloud/analytics/PiCart;", "GetCartHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Analytics.PiCart Cart ();

		static IntPtr id_create_Lcom_salesforce_marketingcloud_analytics_PiCart_Ljava_lang_String_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='create' and count(parameter)=4 and parameter[1][@type='com.salesforce.marketingcloud.analytics.PiCart'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("create", "(Lcom/salesforce/marketingcloud/analytics/PiCart;Ljava/lang/String;DD)Lcom/salesforce/marketingcloud/analytics/PiOrder;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Analytics.PiOrder Create (global::Com.Salesforce.Marketingcloud.Analytics.PiCart p0, string p1, double p2, double p3)
		{
			if (id_create_Lcom_salesforce_marketingcloud_analytics_PiCart_Ljava_lang_String_DD == IntPtr.Zero)
				id_create_Lcom_salesforce_marketingcloud_analytics_PiCart_Ljava_lang_String_DD = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/salesforce/marketingcloud/analytics/PiCart;Ljava/lang/String;DD)Lcom/salesforce/marketingcloud/analytics/PiOrder;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_salesforce_marketingcloud_analytics_PiCart_Ljava_lang_String_DD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_discount;
#pragma warning disable 0169
		static Delegate GetDiscountHandler ()
		{
			if (cb_discount == null)
				cb_discount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Discount);
			return cb_discount;
		}

		static double n_Discount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Discount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='discount' and count(parameter)=0]"
		[Register ("discount", "()D", "GetDiscountHandler")]
		public abstract double Discount ();

		static Delegate cb_orderNumber;
#pragma warning disable 0169
		static Delegate GetOrderNumberHandler ()
		{
			if (cb_orderNumber == null)
				cb_orderNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OrderNumber);
			return cb_orderNumber;
		}

		static IntPtr n_OrderNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrderNumber ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='orderNumber' and count(parameter)=0]"
		[Register ("orderNumber", "()Ljava/lang/String;", "GetOrderNumberHandler")]
		public abstract string OrderNumber ();

		static Delegate cb_shipping;
#pragma warning disable 0169
		static Delegate GetShippingHandler ()
		{
			if (cb_shipping == null)
				cb_shipping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Shipping);
			return cb_shipping;
		}

		static double n_Shipping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Shipping ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='shipping' and count(parameter)=0]"
		[Register ("shipping", "()D", "GetShippingHandler")]
		public abstract double Shipping ();

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
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public abstract global::Org.Json.JSONObject ToJson ();

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
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Salesforce.Marketingcloud.Analytics.PiOrder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiOrder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/PiOrder", DoNotGenerateAcw=true)]
	internal partial class PiOrderInvoker : PiOrder {

		public PiOrderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PiOrderInvoker); }
		}

		static IntPtr id_cart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='cart' and count(parameter)=0]"
		[Register ("cart", "()Lcom/salesforce/marketingcloud/analytics/PiCart;", "GetCartHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Analytics.PiCart Cart ()
		{
			if (id_cart == IntPtr.Zero)
				id_cart = JNIEnv.GetMethodID (class_ref, "cart", "()Lcom/salesforce/marketingcloud/analytics/PiCart;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cart), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_discount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='discount' and count(parameter)=0]"
		[Register ("discount", "()D", "GetDiscountHandler")]
		public override unsafe double Discount ()
		{
			if (id_discount == IntPtr.Zero)
				id_discount = JNIEnv.GetMethodID (class_ref, "discount", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_discount);
			} finally {
			}
		}

		static IntPtr id_orderNumber;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='orderNumber' and count(parameter)=0]"
		[Register ("orderNumber", "()Ljava/lang/String;", "GetOrderNumberHandler")]
		public override unsafe string OrderNumber ()
		{
			if (id_orderNumber == IntPtr.Zero)
				id_orderNumber = JNIEnv.GetMethodID (class_ref, "orderNumber", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_orderNumber), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_shipping;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='shipping' and count(parameter)=0]"
		[Register ("shipping", "()D", "GetShippingHandler")]
		public override unsafe double Shipping ()
		{
			if (id_shipping == IntPtr.Zero)
				id_shipping = JNIEnv.GetMethodID (class_ref, "shipping", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_shipping);
			} finally {
			}
		}

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiOrder']/method[@name='toJson' and count(parameter)=0]"
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
