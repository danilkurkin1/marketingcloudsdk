using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Analytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/PiCart", DoNotGenerateAcw=true)]
	public abstract partial class PiCart : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/analytics/PiCart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PiCart); }
		}

		protected PiCart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']/constructor[@name='PiCart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PiCart ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PiCart)) {
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

		static Delegate cb_cartItems;
#pragma warning disable 0169
		static Delegate GetCartItemsHandler ()
		{
			if (cb_cartItems == null)
				cb_cartItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CartItems);
			return cb_cartItems;
		}

		static IntPtr n_CartItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Analytics.PiCart __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem>.ToLocalJniHandle (__this.CartItems ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']/method[@name='cartItems' and count(parameter)=0]"
		[Register ("cartItems", "()Ljava/util/List;", "GetCartItemsHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> CartItems ();

		static IntPtr id_create_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.salesforce.marketingcloud.analytics.PiCartItem&gt;']]"
		[Register ("create", "(Ljava/util/List;)Lcom/salesforce/marketingcloud/analytics/PiCart;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Analytics.PiCart Create (global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> p0)
		{
			if (id_create_Ljava_util_List_ == IntPtr.Zero)
				id_create_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/util/List;)Lcom/salesforce/marketingcloud/analytics/PiCart;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Salesforce.Marketingcloud.Analytics.PiCart __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

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
			global::Com.Salesforce.Marketingcloud.Analytics.PiCart __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']/method[@name='toJson' and count(parameter)=0]"
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
			global::Com.Salesforce.Marketingcloud.Analytics.PiCart __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Salesforce.Marketingcloud.Analytics.PiCart __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Analytics.PiCart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/analytics/PiCart", DoNotGenerateAcw=true)]
	internal partial class PiCartInvoker : PiCart {

		public PiCartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PiCartInvoker); }
		}

		static IntPtr id_cartItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']/method[@name='cartItems' and count(parameter)=0]"
		[Register ("cartItems", "()Ljava/util/List;", "GetCartItemsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem> CartItems ()
		{
			if (id_cartItems == IntPtr.Zero)
				id_cartItems = JNIEnv.GetMethodID (class_ref, "cartItems", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Analytics.PiCartItem>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cartItems), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.analytics']/class[@name='PiCart']/method[@name='toJson' and count(parameter)=0]"
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
