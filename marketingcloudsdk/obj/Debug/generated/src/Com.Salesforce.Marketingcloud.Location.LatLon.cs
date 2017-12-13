using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/location/LatLon", DoNotGenerateAcw=true)]
	public abstract partial class LatLon : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/location/LatLon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLon); }
		}

		protected LatLon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/constructor[@name='LatLon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LatLon ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LatLon)) {
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

		static IntPtr id_a_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/method[@name='a' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("a", "(DD)Lcom/salesforce/marketingcloud/location/LatLon;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Location.LatLon A (double p0, double p1)
		{
			if (id_a_DD == IntPtr.Zero)
				id_a_DD = JNIEnv.GetStaticMethodID (class_ref, "a", "(DD)Lcom/salesforce/marketingcloud/location/LatLon;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_DD, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/method[@name='b' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("b", "(Lorg/json/JSONObject;)Lcom/salesforce/marketingcloud/location/LatLon;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Location.LatLon B (global::Org.Json.JSONObject p0)
		{
			if (id_b_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_b_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Lorg/json/JSONObject;)Lcom/salesforce/marketingcloud/location/LatLon;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Salesforce.Marketingcloud.Location.LatLon __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_latitude;
#pragma warning disable 0169
		static Delegate GetLatitudeHandler ()
		{
			if (cb_latitude == null)
				cb_latitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Latitude);
			return cb_latitude;
		}

		static double n_Latitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Location.LatLon __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/method[@name='latitude' and count(parameter)=0]"
		[Register ("latitude", "()D", "GetLatitudeHandler")]
		public abstract double Latitude ();

		static Delegate cb_longitude;
#pragma warning disable 0169
		static Delegate GetLongitudeHandler ()
		{
			if (cb_longitude == null)
				cb_longitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Longitude);
			return cb_longitude;
		}

		static double n_Longitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Location.LatLon __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/method[@name='longitude' and count(parameter)=0]"
		[Register ("longitude", "()D", "GetLongitudeHandler")]
		public abstract double Longitude ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/location/LatLon", DoNotGenerateAcw=true)]
	internal partial class LatLonInvoker : LatLon {

		public LatLonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLonInvoker); }
		}

		static IntPtr id_latitude;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/method[@name='latitude' and count(parameter)=0]"
		[Register ("latitude", "()D", "GetLatitudeHandler")]
		public override unsafe double Latitude ()
		{
			if (id_latitude == IntPtr.Zero)
				id_latitude = JNIEnv.GetMethodID (class_ref, "latitude", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_latitude);
			} finally {
			}
		}

		static IntPtr id_longitude;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.location']/class[@name='LatLon']/method[@name='longitude' and count(parameter)=0]"
		[Register ("longitude", "()D", "GetLongitudeHandler")]
		public override unsafe double Longitude ()
		{
			if (id_longitude == IntPtr.Zero)
				id_longitude = JNIEnv.GetMethodID (class_ref, "longitude", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_longitude);
			} finally {
			}
		}

	}

}
