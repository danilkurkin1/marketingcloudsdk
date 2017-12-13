using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Messages.Geofence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.geofence']/class[@name='GeofenceMessageResponse']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/geofence/GeofenceMessageResponse", DoNotGenerateAcw=true)]
	public abstract partial class GeofenceMessageResponse : global::Com.Salesforce.Marketingcloud.Messages.MessageResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/geofence/GeofenceMessageResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeofenceMessageResponse); }
		}

		protected GeofenceMessageResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.geofence']/class[@name='GeofenceMessageResponse']/constructor[@name='GeofenceMessageResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeofenceMessageResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeofenceMessageResponse)) {
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

		static IntPtr id_a_Lcom_salesforce_marketingcloud_location_LatLon_ILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.geofence']/class[@name='GeofenceMessageResponse']/method[@name='a' and count(parameter)=3 and parameter[1][@type='com.salesforce.marketingcloud.location.LatLon'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.salesforce.marketingcloud.messages.Region&gt;']]"
		[Register ("a", "(Lcom/salesforce/marketingcloud/location/LatLon;ILjava/util/List;)Lcom/salesforce/marketingcloud/messages/geofence/GeofenceMessageResponse;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.Messages.Geofence.GeofenceMessageResponse A (global::Com.Salesforce.Marketingcloud.Location.LatLon p0, int p1, global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Messages.Region> p2)
		{
			if (id_a_Lcom_salesforce_marketingcloud_location_LatLon_ILjava_util_List_ == IntPtr.Zero)
				id_a_Lcom_salesforce_marketingcloud_location_LatLon_ILjava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/salesforce/marketingcloud/location/LatLon;ILjava/util/List;)Lcom/salesforce/marketingcloud/messages/geofence/GeofenceMessageResponse;");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Region>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Salesforce.Marketingcloud.Messages.Geofence.GeofenceMessageResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Geofence.GeofenceMessageResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lcom_salesforce_marketingcloud_location_LatLon_ILjava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_fences;
#pragma warning disable 0169
		static Delegate GetFencesHandler ()
		{
			if (cb_fences == null)
				cb_fences = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Fences);
			return cb_fences;
		}

		static IntPtr n_Fences (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Geofence.GeofenceMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Geofence.GeofenceMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Region>.ToLocalJniHandle (__this.Fences ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.geofence']/class[@name='GeofenceMessageResponse']/method[@name='fences' and count(parameter)=0]"
		[Register ("fences", "()Ljava/util/List;", "GetFencesHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Messages.Region> Fences ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/geofence/GeofenceMessageResponse", DoNotGenerateAcw=true)]
	internal partial class GeofenceMessageResponseInvoker : GeofenceMessageResponse {

		public GeofenceMessageResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeofenceMessageResponseInvoker); }
		}

		static IntPtr id_fences;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.geofence']/class[@name='GeofenceMessageResponse']/method[@name='fences' and count(parameter)=0]"
		[Register ("fences", "()Ljava/util/List;", "GetFencesHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Messages.Region> Fences ()
		{
			if (id_fences == IntPtr.Zero)
				id_fences = JNIEnv.GetMethodID (class_ref, "fences", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Region>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fences), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_refreshCenter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/method[@name='refreshCenter' and count(parameter)=0]"
		[Register ("refreshCenter", "()Lcom/salesforce/marketingcloud/location/LatLon;", "GetRefreshCenterHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Location.LatLon RefreshCenter ()
		{
			if (id_refreshCenter == IntPtr.Zero)
				id_refreshCenter = JNIEnv.GetMethodID (class_ref, "refreshCenter", "()Lcom/salesforce/marketingcloud/location/LatLon;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refreshCenter), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_refreshRadius;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='MessageResponse']/method[@name='refreshRadius' and count(parameter)=0]"
		[Register ("refreshRadius", "()I", "GetRefreshRadiusHandler")]
		public override unsafe int RefreshRadius ()
		{
			if (id_refreshRadius == IntPtr.Zero)
				id_refreshRadius = JNIEnv.GetMethodID (class_ref, "refreshRadius", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_refreshRadius);
			} finally {
			}
		}

	}

}
