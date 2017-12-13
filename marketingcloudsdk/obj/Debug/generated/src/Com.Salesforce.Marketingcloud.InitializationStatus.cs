using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/InitializationStatus", DoNotGenerateAcw=true)]
	public abstract partial class InitializationStatus : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus.Status']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/InitializationStatus$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr COMPLETED_WITH_DEGRADED_FUNCTIONALITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus.Status']/field[@name='COMPLETED_WITH_DEGRADED_FUNCTIONALITY']"
			[Register ("COMPLETED_WITH_DEGRADED_FUNCTIONALITY")]
			public static global::Com.Salesforce.Marketingcloud.InitializationStatus.Status CompletedWithDegradedFunctionality {
				get {
					if (COMPLETED_WITH_DEGRADED_FUNCTIONALITY_jfieldId == IntPtr.Zero)
						COMPLETED_WITH_DEGRADED_FUNCTIONALITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED_WITH_DEGRADED_FUNCTIONALITY", "Lcom/salesforce/marketingcloud/InitializationStatus$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_WITH_DEGRADED_FUNCTIONALITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus.Status']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Com.Salesforce.Marketingcloud.InitializationStatus.Status Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/salesforce/marketingcloud/InitializationStatus$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus.Status']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Com.Salesforce.Marketingcloud.InitializationStatus.Status Success {
				get {
					if (SUCCESS_jfieldId == IntPtr.Zero)
						SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/salesforce/marketingcloud/InitializationStatus$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/InitializationStatus$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/InitializationStatus$Status;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.InitializationStatus.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/InitializationStatus$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.InitializationStatus.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/salesforce/marketingcloud/InitializationStatus$Status;", "")]
			public static unsafe global::Com.Salesforce.Marketingcloud.InitializationStatus.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/salesforce/marketingcloud/InitializationStatus$Status;");
				try {
					return (global::Com.Salesforce.Marketingcloud.InitializationStatus.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Salesforce.Marketingcloud.InitializationStatus.Status));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/InitializationStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitializationStatus); }
		}

		protected InitializationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/constructor[@name='InitializationStatus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InitializationStatus ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InitializationStatus)) {
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

		static IntPtr id_isUsable;
		public unsafe bool IsUsable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='isUsable' and count(parameter)=0]"
			[Register ("isUsable", "()Z", "GetIsUsableHandler")]
			get {
				if (id_isUsable == IntPtr.Zero)
					id_isUsable = JNIEnv.GetMethodID (class_ref, "isUsable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUsable);
				} finally {
				}
			}
		}

		static Delegate cb_encryptionChanged;
#pragma warning disable 0169
		static Delegate GetEncryptionChangedHandler ()
		{
			if (cb_encryptionChanged == null)
				cb_encryptionChanged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EncryptionChanged);
			return cb_encryptionChanged;
		}

		static bool n_EncryptionChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncryptionChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='encryptionChanged' and count(parameter)=0]"
		[Register ("encryptionChanged", "()Z", "GetEncryptionChangedHandler")]
		public abstract bool EncryptionChanged ();

		static Delegate cb_initializedComponents;
#pragma warning disable 0169
		static Delegate GetInitializedComponentsHandler ()
		{
			if (cb_initializedComponents == null)
				cb_initializedComponents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InitializedComponents);
			return cb_initializedComponents;
		}

		static IntPtr n_InitializedComponents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.InitializedComponents ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='initializedComponents' and count(parameter)=0]"
		[Register ("initializedComponents", "()Ljava/util/List;", "GetInitializedComponentsHandler")]
		public abstract global::System.Collections.Generic.IList<string> InitializedComponents ();

		static Delegate cb_locationPlayServicesStatus;
#pragma warning disable 0169
		static Delegate GetLocationPlayServicesStatusHandler ()
		{
			if (cb_locationPlayServicesStatus == null)
				cb_locationPlayServicesStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_LocationPlayServicesStatus);
			return cb_locationPlayServicesStatus;
		}

		static int n_LocationPlayServicesStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationPlayServicesStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='locationPlayServicesStatus' and count(parameter)=0]"
		[Register ("locationPlayServicesStatus", "()I", "GetLocationPlayServicesStatusHandler")]
		public abstract int LocationPlayServicesStatus ();

		static Delegate cb_locationsError;
#pragma warning disable 0169
		static Delegate GetLocationsErrorHandler ()
		{
			if (cb_locationsError == null)
				cb_locationsError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LocationsError);
			return cb_locationsError;
		}

		static bool n_LocationsError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationsError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='locationsError' and count(parameter)=0]"
		[Register ("locationsError", "()Z", "GetLocationsErrorHandler")]
		public abstract bool LocationsError ();

		static Delegate cb_locationsMessage;
#pragma warning disable 0169
		static Delegate GetLocationsMessageHandler ()
		{
			if (cb_locationsMessage == null)
				cb_locationsMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LocationsMessage);
			return cb_locationsMessage;
		}

		static IntPtr n_LocationsMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocationsMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='locationsMessage' and count(parameter)=0]"
		[Register ("locationsMessage", "()Ljava/lang/String;", "GetLocationsMessageHandler")]
		public abstract string LocationsMessage ();

		static Delegate cb_messagingPermissionError;
#pragma warning disable 0169
		static Delegate GetMessagingPermissionErrorHandler ()
		{
			if (cb_messagingPermissionError == null)
				cb_messagingPermissionError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MessagingPermissionError);
			return cb_messagingPermissionError;
		}

		static bool n_MessagingPermissionError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessagingPermissionError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='messagingPermissionError' and count(parameter)=0]"
		[Register ("messagingPermissionError", "()Z", "GetMessagingPermissionErrorHandler")]
		public abstract bool MessagingPermissionError ();

		static Delegate cb_proximityError;
#pragma warning disable 0169
		static Delegate GetProximityErrorHandler ()
		{
			if (cb_proximityError == null)
				cb_proximityError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ProximityError);
			return cb_proximityError;
		}

		static bool n_ProximityError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProximityError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='proximityError' and count(parameter)=0]"
		[Register ("proximityError", "()Z", "GetProximityErrorHandler")]
		public abstract bool ProximityError ();

		static Delegate cb_status;
#pragma warning disable 0169
		static Delegate GetInvokeStatusHandler ()
		{
			if (cb_status == null)
				cb_status = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeStatus);
			return cb_status;
		}

		static IntPtr n_InvokeStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeStatus ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='status' and count(parameter)=0]"
		[Register ("status", "()Lcom/salesforce/marketingcloud/InitializationStatus$Status;", "GetInvokeStatusHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.InitializationStatus.Status InvokeStatus ();

		static Delegate cb_storageError;
#pragma warning disable 0169
		static Delegate GetStorageErrorHandler ()
		{
			if (cb_storageError == null)
				cb_storageError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StorageError);
			return cb_storageError;
		}

		static bool n_StorageError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StorageError ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='storageError' and count(parameter)=0]"
		[Register ("storageError", "()Z", "GetStorageErrorHandler")]
		public abstract bool StorageError ();

		static Delegate cb_unrecoverableException;
#pragma warning disable 0169
		static Delegate GetUnrecoverableExceptionHandler ()
		{
			if (cb_unrecoverableException == null)
				cb_unrecoverableException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_UnrecoverableException);
			return cb_unrecoverableException;
		}

		static IntPtr n_UnrecoverableException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.InitializationStatus __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnrecoverableException ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='unrecoverableException' and count(parameter)=0]"
		[Register ("unrecoverableException", "()Ljava/lang/Throwable;", "GetUnrecoverableExceptionHandler")]
		public abstract global::Java.Lang.Throwable UnrecoverableException ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/InitializationStatus", DoNotGenerateAcw=true)]
	internal partial class InitializationStatusInvoker : InitializationStatus {

		public InitializationStatusInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitializationStatusInvoker); }
		}

		static IntPtr id_encryptionChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='encryptionChanged' and count(parameter)=0]"
		[Register ("encryptionChanged", "()Z", "GetEncryptionChangedHandler")]
		public override unsafe bool EncryptionChanged ()
		{
			if (id_encryptionChanged == IntPtr.Zero)
				id_encryptionChanged = JNIEnv.GetMethodID (class_ref, "encryptionChanged", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_encryptionChanged);
			} finally {
			}
		}

		static IntPtr id_initializedComponents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='initializedComponents' and count(parameter)=0]"
		[Register ("initializedComponents", "()Ljava/util/List;", "GetInitializedComponentsHandler")]
		public override unsafe global::System.Collections.Generic.IList<string> InitializedComponents ()
		{
			if (id_initializedComponents == IntPtr.Zero)
				id_initializedComponents = JNIEnv.GetMethodID (class_ref, "initializedComponents", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initializedComponents), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_locationPlayServicesStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='locationPlayServicesStatus' and count(parameter)=0]"
		[Register ("locationPlayServicesStatus", "()I", "GetLocationPlayServicesStatusHandler")]
		public override unsafe int LocationPlayServicesStatus ()
		{
			if (id_locationPlayServicesStatus == IntPtr.Zero)
				id_locationPlayServicesStatus = JNIEnv.GetMethodID (class_ref, "locationPlayServicesStatus", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_locationPlayServicesStatus);
			} finally {
			}
		}

		static IntPtr id_locationsError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='locationsError' and count(parameter)=0]"
		[Register ("locationsError", "()Z", "GetLocationsErrorHandler")]
		public override unsafe bool LocationsError ()
		{
			if (id_locationsError == IntPtr.Zero)
				id_locationsError = JNIEnv.GetMethodID (class_ref, "locationsError", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_locationsError);
			} finally {
			}
		}

		static IntPtr id_locationsMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='locationsMessage' and count(parameter)=0]"
		[Register ("locationsMessage", "()Ljava/lang/String;", "GetLocationsMessageHandler")]
		public override unsafe string LocationsMessage ()
		{
			if (id_locationsMessage == IntPtr.Zero)
				id_locationsMessage = JNIEnv.GetMethodID (class_ref, "locationsMessage", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_locationsMessage), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_messagingPermissionError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='messagingPermissionError' and count(parameter)=0]"
		[Register ("messagingPermissionError", "()Z", "GetMessagingPermissionErrorHandler")]
		public override unsafe bool MessagingPermissionError ()
		{
			if (id_messagingPermissionError == IntPtr.Zero)
				id_messagingPermissionError = JNIEnv.GetMethodID (class_ref, "messagingPermissionError", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_messagingPermissionError);
			} finally {
			}
		}

		static IntPtr id_proximityError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='proximityError' and count(parameter)=0]"
		[Register ("proximityError", "()Z", "GetProximityErrorHandler")]
		public override unsafe bool ProximityError ()
		{
			if (id_proximityError == IntPtr.Zero)
				id_proximityError = JNIEnv.GetMethodID (class_ref, "proximityError", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_proximityError);
			} finally {
			}
		}

		static IntPtr id_status;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='status' and count(parameter)=0]"
		[Register ("status", "()Lcom/salesforce/marketingcloud/InitializationStatus$Status;", "GetInvokeStatusHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.InitializationStatus.Status InvokeStatus ()
		{
			if (id_status == IntPtr.Zero)
				id_status = JNIEnv.GetMethodID (class_ref, "status", "()Lcom/salesforce/marketingcloud/InitializationStatus$Status;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.InitializationStatus.Status> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_status), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_storageError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='storageError' and count(parameter)=0]"
		[Register ("storageError", "()Z", "GetStorageErrorHandler")]
		public override unsafe bool StorageError ()
		{
			if (id_storageError == IntPtr.Zero)
				id_storageError = JNIEnv.GetMethodID (class_ref, "storageError", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_storageError);
			} finally {
			}
		}

		static IntPtr id_unrecoverableException;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='InitializationStatus']/method[@name='unrecoverableException' and count(parameter)=0]"
		[Register ("unrecoverableException", "()Ljava/lang/Throwable;", "GetUnrecoverableExceptionHandler")]
		public override unsafe global::Java.Lang.Throwable UnrecoverableException ()
		{
			if (id_unrecoverableException == IntPtr.Zero)
				id_unrecoverableException = JNIEnv.GetMethodID (class_ref, "unrecoverableException", "()Ljava/lang/Throwable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unrecoverableException), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
