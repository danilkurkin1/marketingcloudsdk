using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Messages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Region", DoNotGenerateAcw=true)]
	public abstract partial class Region : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/interface[@name='Region.RegionType']"
		[Register ("com/salesforce/marketingcloud/messages/Region$RegionType", "", "Com.Salesforce.Marketingcloud.Messages.Region/IRegionTypeInvoker")]
		public partial interface IRegionType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Region$RegionType", DoNotGenerateAcw=true)]
		internal class IRegionTypeInvoker : global::Java.Lang.Object, IRegionType {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Region$RegionType");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRegionTypeInvoker); }
			}

			IntPtr class_ref;

			public static IRegionType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRegionType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.messages.Region.RegionType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRegionTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region.IRegionType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/Region", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Region); }
		}

		protected Region (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/constructor[@name='Region' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Region ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Region)) {
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

		static Delegate cb_a_Z;
#pragma warning disable 0169
		static Delegate GetA_ZHandler ()
		{
			if (cb_a_Z == null)
				cb_a_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_A_Z);
			return cb_a_Z;
		}

		static void n_A_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "GetA_ZHandler")]
		public virtual unsafe void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_B);
			return cb_b;
		}

		static bool n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "GetBHandler")]
		public virtual unsafe bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_b);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()Z"));
			} finally {
			}
		}

		static Delegate cb_center;
#pragma warning disable 0169
		static Delegate GetCenterHandler ()
		{
			if (cb_center == null)
				cb_center = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Center);
			return cb_center;
		}

		static IntPtr n_Center (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='center' and count(parameter)=0]"
		[Register ("center", "()Lcom/salesforce/marketingcloud/location/LatLon;", "GetCenterHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.Location.LatLon Center ();

		static Delegate cb_description;
#pragma warning disable 0169
		static Delegate GetDescriptionHandler ()
		{
			if (cb_description == null)
				cb_description = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Description);
			return cb_description;
		}

		static IntPtr n_Description (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='description' and count(parameter)=0]"
		[Register ("description", "()Ljava/lang/String;", "GetDescriptionHandler")]
		public abstract string Description ();

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
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public abstract string Id ();

		static Delegate cb_major;
#pragma warning disable 0169
		static Delegate GetMajorHandler ()
		{
			if (cb_major == null)
				cb_major = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Major);
			return cb_major;
		}

		static int n_Major (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Major ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='major' and count(parameter)=0]"
		[Register ("major", "()I", "GetMajorHandler")]
		public abstract int Major ();

		static Delegate cb_messages;
#pragma warning disable 0169
		static Delegate GetMessagesHandler ()
		{
			if (cb_messages == null)
				cb_messages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Messages);
			return cb_messages;
		}

		static IntPtr n_Messages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Message>.ToLocalJniHandle (__this.Messages ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='messages' and count(parameter)=0]"
		[Register ("messages", "()Ljava/util/List;", "GetMessagesHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Messages.Message> Messages ();

		static Delegate cb_minor;
#pragma warning disable 0169
		static Delegate GetMinorHandler ()
		{
			if (cb_minor == null)
				cb_minor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Minor);
			return cb_minor;
		}

		static int n_Minor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Minor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='minor' and count(parameter)=0]"
		[Register ("minor", "()I", "GetMinorHandler")]
		public abstract int Minor ();

		static Delegate cb_name;
#pragma warning disable 0169
		static Delegate GetNameHandler ()
		{
			if (cb_name == null)
				cb_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Name);
			return cb_name;
		}

		static IntPtr n_Name (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler")]
		public abstract string Name ();

		static Delegate cb_proximityUuid;
#pragma warning disable 0169
		static Delegate GetProximityUuidHandler ()
		{
			if (cb_proximityUuid == null)
				cb_proximityUuid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ProximityUuid);
			return cb_proximityUuid;
		}

		static IntPtr n_ProximityUuid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProximityUuid ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='proximityUuid' and count(parameter)=0]"
		[Register ("proximityUuid", "()Ljava/lang/String;", "GetProximityUuidHandler")]
		public abstract string ProximityUuid ();

		static Delegate cb_radius;
#pragma warning disable 0169
		static Delegate GetRadiusHandler ()
		{
			if (cb_radius == null)
				cb_radius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Radius);
			return cb_radius;
		}

		static int n_Radius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='radius' and count(parameter)=0]"
		[Register ("radius", "()I", "GetRadiusHandler")]
		public abstract int Radius ();

		static Delegate cb_regionType;
#pragma warning disable 0169
		static Delegate GetRegionTypeHandler ()
		{
			if (cb_regionType == null)
				cb_regionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RegionType);
			return cb_regionType;
		}

		static int n_RegionType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Region __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Region> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegionType ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='regionType' and count(parameter)=0]"
		[Register ("regionType", "()I", "GetRegionTypeHandler")]
		public abstract int RegionType ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/Region", DoNotGenerateAcw=true)]
	internal partial class RegionInvoker : Region {

		public RegionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegionInvoker); }
		}

		static IntPtr id_center;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='center' and count(parameter)=0]"
		[Register ("center", "()Lcom/salesforce/marketingcloud/location/LatLon;", "GetCenterHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.Location.LatLon Center ()
		{
			if (id_center == IntPtr.Zero)
				id_center = JNIEnv.GetMethodID (class_ref, "center", "()Lcom/salesforce/marketingcloud/location/LatLon;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Location.LatLon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_center), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_description;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='description' and count(parameter)=0]"
		[Register ("description", "()Ljava/lang/String;", "GetDescriptionHandler")]
		public override unsafe string Description ()
		{
			if (id_description == IntPtr.Zero)
				id_description = JNIEnv.GetMethodID (class_ref, "description", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_description), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_id;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='id' and count(parameter)=0]"
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

		static IntPtr id_major;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='major' and count(parameter)=0]"
		[Register ("major", "()I", "GetMajorHandler")]
		public override unsafe int Major ()
		{
			if (id_major == IntPtr.Zero)
				id_major = JNIEnv.GetMethodID (class_ref, "major", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_major);
			} finally {
			}
		}

		static IntPtr id_messages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='messages' and count(parameter)=0]"
		[Register ("messages", "()Ljava/util/List;", "GetMessagesHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Messages.Message> Messages ()
		{
			if (id_messages == IntPtr.Zero)
				id_messages = JNIEnv.GetMethodID (class_ref, "messages", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_messages), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_minor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='minor' and count(parameter)=0]"
		[Register ("minor", "()I", "GetMinorHandler")]
		public override unsafe int Minor ()
		{
			if (id_minor == IntPtr.Zero)
				id_minor = JNIEnv.GetMethodID (class_ref, "minor", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_minor);
			} finally {
			}
		}

		static IntPtr id_name;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler")]
		public override unsafe string Name ()
		{
			if (id_name == IntPtr.Zero)
				id_name = JNIEnv.GetMethodID (class_ref, "name", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_proximityUuid;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='proximityUuid' and count(parameter)=0]"
		[Register ("proximityUuid", "()Ljava/lang/String;", "GetProximityUuidHandler")]
		public override unsafe string ProximityUuid ()
		{
			if (id_proximityUuid == IntPtr.Zero)
				id_proximityUuid = JNIEnv.GetMethodID (class_ref, "proximityUuid", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proximityUuid), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_radius;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='radius' and count(parameter)=0]"
		[Register ("radius", "()I", "GetRadiusHandler")]
		public override unsafe int Radius ()
		{
			if (id_radius == IntPtr.Zero)
				id_radius = JNIEnv.GetMethodID (class_ref, "radius", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_radius);
			} finally {
			}
		}

		static IntPtr id_regionType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages']/class[@name='Region']/method[@name='regionType' and count(parameter)=0]"
		[Register ("regionType", "()I", "GetRegionTypeHandler")]
		public override unsafe int RegionType ()
		{
			if (id_regionType == IntPtr.Zero)
				id_regionType = JNIEnv.GetMethodID (class_ref, "regionType", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_regionType);
			} finally {
			}
		}

	}

}
