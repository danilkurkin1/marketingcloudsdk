using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudConfig", DoNotGenerateAcw=true)]
	public abstract partial class MarketingCloudConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']"
		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudConfig$Builder", DoNotGenerateAcw=true)]
		public abstract partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/salesforce/marketingcloud/MarketingCloudConfig$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/constructor[@name='MarketingCloudConfig.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig;", "")]
			public unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
			{
				if (cb_setAccessToken_Ljava_lang_String_ == null)
					cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
				return cb_setAccessToken_Ljava_lang_String_;
			}

			static IntPtr n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccessToken (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetAccessToken_Ljava_lang_String_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetAccessToken (string p0);

			static Delegate cb_setAnalyticsEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetAnalyticsEnabled_ZHandler ()
			{
				if (cb_setAnalyticsEnabled_Z == null)
					cb_setAnalyticsEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAnalyticsEnabled_Z);
				return cb_setAnalyticsEnabled_Z;
			}

			static IntPtr n_SetAnalyticsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAnalyticsEnabled (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setAnalyticsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnalyticsEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetAnalyticsEnabled_ZHandler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetAnalyticsEnabled (bool p0);

			static Delegate cb_setApplicationId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetApplicationId_Ljava_lang_String_Handler ()
			{
				if (cb_setApplicationId_Ljava_lang_String_ == null)
					cb_setApplicationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApplicationId_Ljava_lang_String_);
				return cb_setApplicationId_Ljava_lang_String_;
			}

			static IntPtr n_SetApplicationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApplicationId (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationId", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetApplicationId_Ljava_lang_String_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetApplicationId (string p0);

			static Delegate cb_setApplicationLabel_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetApplicationLabel_Ljava_lang_String_Handler ()
			{
				if (cb_setApplicationLabel_Ljava_lang_String_ == null)
					cb_setApplicationLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApplicationLabel_Ljava_lang_String_);
				return cb_setApplicationLabel_Ljava_lang_String_;
			}

			static IntPtr n_SetApplicationLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApplicationLabel (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setApplicationLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationLabel", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetApplicationLabel_Ljava_lang_String_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetApplicationLabel (string p0);

			static Delegate cb_setCloudPageRecipient_Ljava_lang_Class_;
#pragma warning disable 0169
			static Delegate GetSetCloudPageRecipient_Ljava_lang_Class_Handler ()
			{
				if (cb_setCloudPageRecipient_Ljava_lang_Class_ == null)
					cb_setCloudPageRecipient_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCloudPageRecipient_Ljava_lang_Class_);
				return cb_setCloudPageRecipient_Ljava_lang_Class_;
			}

			static IntPtr n_SetCloudPageRecipient_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCloudPageRecipient (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setCloudPageRecipient' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
			[Register ("setCloudPageRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetCloudPageRecipient_Ljava_lang_Class_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetCloudPageRecipient (global::Java.Lang.Class p0);

			static Delegate cb_setCloudPagesEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetCloudPagesEnabled_ZHandler ()
			{
				if (cb_setCloudPagesEnabled_Z == null)
					cb_setCloudPagesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCloudPagesEnabled_Z);
				return cb_setCloudPagesEnabled_Z;
			}

			static IntPtr n_SetCloudPagesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCloudPagesEnabled (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setCloudPagesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCloudPagesEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetCloudPagesEnabled_ZHandler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetCloudPagesEnabled (bool p0);

			static Delegate cb_setGcmSenderId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGcmSenderId_Ljava_lang_String_Handler ()
			{
				if (cb_setGcmSenderId_Ljava_lang_String_ == null)
					cb_setGcmSenderId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGcmSenderId_Ljava_lang_String_);
				return cb_setGcmSenderId_Ljava_lang_String_;
			}

			static IntPtr n_SetGcmSenderId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGcmSenderId (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setGcmSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGcmSenderId", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetGcmSenderId_Ljava_lang_String_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetGcmSenderId (string p0);

			static Delegate cb_setGeofencingEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetGeofencingEnabled_ZHandler ()
			{
				if (cb_setGeofencingEnabled_Z == null)
					cb_setGeofencingEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetGeofencingEnabled_Z);
				return cb_setGeofencingEnabled_Z;
			}

			static IntPtr n_SetGeofencingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetGeofencingEnabled (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setGeofencingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGeofencingEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetGeofencingEnabled_ZHandler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetGeofencingEnabled (bool p0);

			static Delegate cb_setNotificationChannelName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNotificationChannelName_Ljava_lang_String_Handler ()
			{
				if (cb_setNotificationChannelName_Ljava_lang_String_ == null)
					cb_setNotificationChannelName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNotificationChannelName_Ljava_lang_String_);
				return cb_setNotificationChannelName_Ljava_lang_String_;
			}

			static IntPtr n_SetNotificationChannelName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNotificationChannelName (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setNotificationChannelName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationChannelName", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetNotificationChannelName_Ljava_lang_String_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetNotificationChannelName (string p0);

			static Delegate cb_setNotificationRecipient_Ljava_lang_Class_;
#pragma warning disable 0169
			static Delegate GetSetNotificationRecipient_Ljava_lang_Class_Handler ()
			{
				if (cb_setNotificationRecipient_Ljava_lang_Class_ == null)
					cb_setNotificationRecipient_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNotificationRecipient_Ljava_lang_Class_);
				return cb_setNotificationRecipient_Ljava_lang_Class_;
			}

			static IntPtr n_SetNotificationRecipient_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNotificationRecipient (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setNotificationRecipient' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
			[Register ("setNotificationRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetNotificationRecipient_Ljava_lang_Class_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetNotificationRecipient (global::Java.Lang.Class p0);

			static Delegate cb_setNotificationSmallIconResId_I;
#pragma warning disable 0169
			static Delegate GetSetNotificationSmallIconResId_IHandler ()
			{
				if (cb_setNotificationSmallIconResId_I == null)
					cb_setNotificationSmallIconResId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetNotificationSmallIconResId_I);
				return cb_setNotificationSmallIconResId_I;
			}

			static IntPtr n_SetNotificationSmallIconResId_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetNotificationSmallIconResId (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setNotificationSmallIconResId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotificationSmallIconResId", "(I)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetNotificationSmallIconResId_IHandler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetNotificationSmallIconResId (int p0);

			static Delegate cb_setOpenDirectRecipient_Ljava_lang_Class_;
#pragma warning disable 0169
			static Delegate GetSetOpenDirectRecipient_Ljava_lang_Class_Handler ()
			{
				if (cb_setOpenDirectRecipient_Ljava_lang_Class_ == null)
					cb_setOpenDirectRecipient_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOpenDirectRecipient_Ljava_lang_Class_);
				return cb_setOpenDirectRecipient_Ljava_lang_Class_;
			}

			static IntPtr n_SetOpenDirectRecipient_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOpenDirectRecipient (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setOpenDirectRecipient' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
			[Register ("setOpenDirectRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetOpenDirectRecipient_Ljava_lang_Class_Handler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetOpenDirectRecipient (global::Java.Lang.Class p0);

			static Delegate cb_setPiAnalyticsEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetPiAnalyticsEnabled_ZHandler ()
			{
				if (cb_setPiAnalyticsEnabled_Z == null)
					cb_setPiAnalyticsEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetPiAnalyticsEnabled_Z);
				return cb_setPiAnalyticsEnabled_Z;
			}

			static IntPtr n_SetPiAnalyticsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPiAnalyticsEnabled (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setPiAnalyticsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPiAnalyticsEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetPiAnalyticsEnabled_ZHandler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetPiAnalyticsEnabled (bool p0);

			static Delegate cb_setProximityEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetProximityEnabled_ZHandler ()
			{
				if (cb_setProximityEnabled_Z == null)
					cb_setProximityEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetProximityEnabled_Z);
				return cb_setProximityEnabled_Z;
			}

			static IntPtr n_SetProximityEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetProximityEnabled (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setProximityEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setProximityEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetProximityEnabled_ZHandler")]
			public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetProximityEnabled (bool p0);

		}

		[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudConfig$Builder", DoNotGenerateAcw=true)]
		internal partial class BuilderInvoker : Builder {

			public BuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BuilderInvoker); }
			}

			static IntPtr id_setAccessToken_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetAccessToken_Ljava_lang_String_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetAccessToken (string p0)
			{
				if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAccessToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setAnalyticsEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setAnalyticsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnalyticsEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetAnalyticsEnabled_ZHandler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetAnalyticsEnabled (bool p0)
			{
				if (id_setAnalyticsEnabled_Z == IntPtr.Zero)
					id_setAnalyticsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAnalyticsEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAnalyticsEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setApplicationId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationId", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetApplicationId_Ljava_lang_String_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetApplicationId (string p0)
			{
				if (id_setApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationId", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setApplicationLabel_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setApplicationLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationLabel", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetApplicationLabel_Ljava_lang_String_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetApplicationLabel (string p0)
			{
				if (id_setApplicationLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationLabel", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationLabel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setCloudPageRecipient_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setCloudPageRecipient' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
			[Register ("setCloudPageRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetCloudPageRecipient_Ljava_lang_Class_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetCloudPageRecipient (global::Java.Lang.Class p0)
			{
				if (id_setCloudPageRecipient_Ljava_lang_Class_ == IntPtr.Zero)
					id_setCloudPageRecipient_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setCloudPageRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCloudPageRecipient_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setCloudPagesEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setCloudPagesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCloudPagesEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetCloudPagesEnabled_ZHandler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetCloudPagesEnabled (bool p0)
			{
				if (id_setCloudPagesEnabled_Z == IntPtr.Zero)
					id_setCloudPagesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCloudPagesEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCloudPagesEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setGcmSenderId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setGcmSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGcmSenderId", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetGcmSenderId_Ljava_lang_String_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetGcmSenderId (string p0)
			{
				if (id_setGcmSenderId_Ljava_lang_String_ == IntPtr.Zero)
					id_setGcmSenderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGcmSenderId", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setGcmSenderId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setGeofencingEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setGeofencingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGeofencingEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetGeofencingEnabled_ZHandler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetGeofencingEnabled (bool p0)
			{
				if (id_setGeofencingEnabled_Z == IntPtr.Zero)
					id_setGeofencingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setGeofencingEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setGeofencingEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setNotificationChannelName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setNotificationChannelName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationChannelName", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetNotificationChannelName_Ljava_lang_String_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetNotificationChannelName (string p0)
			{
				if (id_setNotificationChannelName_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotificationChannelName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotificationChannelName", "(Ljava/lang/String;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationChannelName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setNotificationRecipient_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setNotificationRecipient' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
			[Register ("setNotificationRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetNotificationRecipient_Ljava_lang_Class_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetNotificationRecipient (global::Java.Lang.Class p0)
			{
				if (id_setNotificationRecipient_Ljava_lang_Class_ == IntPtr.Zero)
					id_setNotificationRecipient_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setNotificationRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationRecipient_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setNotificationSmallIconResId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setNotificationSmallIconResId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotificationSmallIconResId", "(I)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetNotificationSmallIconResId_IHandler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetNotificationSmallIconResId (int p0)
			{
				if (id_setNotificationSmallIconResId_I == IntPtr.Zero)
					id_setNotificationSmallIconResId_I = JNIEnv.GetMethodID (class_ref, "setNotificationSmallIconResId", "(I)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationSmallIconResId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setOpenDirectRecipient_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setOpenDirectRecipient' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends android.app.Activity&gt;']]"
			[Register ("setOpenDirectRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetOpenDirectRecipient_Ljava_lang_Class_Handler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetOpenDirectRecipient (global::Java.Lang.Class p0)
			{
				if (id_setOpenDirectRecipient_Ljava_lang_Class_ == IntPtr.Zero)
					id_setOpenDirectRecipient_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setOpenDirectRecipient", "(Ljava/lang/Class;)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOpenDirectRecipient_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setPiAnalyticsEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setPiAnalyticsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPiAnalyticsEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetPiAnalyticsEnabled_ZHandler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetPiAnalyticsEnabled (bool p0)
			{
				if (id_setPiAnalyticsEnabled_Z == IntPtr.Zero)
					id_setPiAnalyticsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setPiAnalyticsEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPiAnalyticsEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setProximityEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig.Builder']/method[@name='setProximityEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setProximityEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetSetProximityEnabled_ZHandler")]
			public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder SetProximityEnabled (bool p0)
			{
				if (id_setProximityEnabled_Z == IntPtr.Zero)
					id_setProximityEnabled_Z = JNIEnv.GetMethodID (class_ref, "setProximityEnabled", "(Z)Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setProximityEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/MarketingCloudConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketingCloudConfig); }
		}

		protected MarketingCloudConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/constructor[@name='MarketingCloudConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarketingCloudConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MarketingCloudConfig)) {
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

		static Delegate cb_accessToken;
#pragma warning disable 0169
		static Delegate GetAccessTokenHandler ()
		{
			if (cb_accessToken == null)
				cb_accessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AccessToken);
			return cb_accessToken;
		}

		static IntPtr n_AccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='accessToken' and count(parameter)=0]"
		[Register ("accessToken", "()Ljava/lang/String;", "GetAccessTokenHandler")]
		public abstract string AccessToken ();

		static Delegate cb_analyticsEnabled;
#pragma warning disable 0169
		static Delegate GetAnalyticsEnabledHandler ()
		{
			if (cb_analyticsEnabled == null)
				cb_analyticsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AnalyticsEnabled);
			return cb_analyticsEnabled;
		}

		static bool n_AnalyticsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnalyticsEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='analyticsEnabled' and count(parameter)=0]"
		[Register ("analyticsEnabled", "()Z", "GetAnalyticsEnabledHandler")]
		public abstract bool AnalyticsEnabled ();

		static Delegate cb_applicationId;
#pragma warning disable 0169
		static Delegate GetApplicationIdHandler ()
		{
			if (cb_applicationId == null)
				cb_applicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ApplicationId);
			return cb_applicationId;
		}

		static IntPtr n_ApplicationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='applicationId' and count(parameter)=0]"
		[Register ("applicationId", "()Ljava/lang/String;", "GetApplicationIdHandler")]
		public abstract string ApplicationId ();

		static Delegate cb_applicationLabel;
#pragma warning disable 0169
		static Delegate GetApplicationLabelHandler ()
		{
			if (cb_applicationLabel == null)
				cb_applicationLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ApplicationLabel);
			return cb_applicationLabel;
		}

		static IntPtr n_ApplicationLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationLabel ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='applicationLabel' and count(parameter)=0]"
		[Register ("applicationLabel", "()Ljava/lang/String;", "GetApplicationLabelHandler")]
		public abstract string ApplicationLabel ();

		static IntPtr id_builder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "")]
		public static unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder InvokeBuilder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cloudPageRecipient;
#pragma warning disable 0169
		static Delegate GetCloudPageRecipientHandler ()
		{
			if (cb_cloudPageRecipient == null)
				cb_cloudPageRecipient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CloudPageRecipient);
			return cb_cloudPageRecipient;
		}

		static IntPtr n_CloudPageRecipient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloudPageRecipient ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='cloudPageRecipient' and count(parameter)=0]"
		[Register ("cloudPageRecipient", "()Ljava/lang/Class;", "GetCloudPageRecipientHandler")]
		public abstract global::Java.Lang.Class CloudPageRecipient ();

		static Delegate cb_cloudPagesEnabled;
#pragma warning disable 0169
		static Delegate GetCloudPagesEnabledHandler ()
		{
			if (cb_cloudPagesEnabled == null)
				cb_cloudPagesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CloudPagesEnabled);
			return cb_cloudPagesEnabled;
		}

		static bool n_CloudPagesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloudPagesEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='cloudPagesEnabled' and count(parameter)=0]"
		[Register ("cloudPagesEnabled", "()Z", "GetCloudPagesEnabledHandler")]
		public abstract bool CloudPagesEnabled ();

		static Delegate cb_gcmSenderId;
#pragma warning disable 0169
		static Delegate GetGcmSenderIdHandler ()
		{
			if (cb_gcmSenderId == null)
				cb_gcmSenderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GcmSenderId);
			return cb_gcmSenderId;
		}

		static IntPtr n_GcmSenderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GcmSenderId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='gcmSenderId' and count(parameter)=0]"
		[Register ("gcmSenderId", "()Ljava/lang/String;", "GetGcmSenderIdHandler")]
		public abstract string GcmSenderId ();

		static Delegate cb_geofencingEnabled;
#pragma warning disable 0169
		static Delegate GetGeofencingEnabledHandler ()
		{
			if (cb_geofencingEnabled == null)
				cb_geofencingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GeofencingEnabled);
			return cb_geofencingEnabled;
		}

		static bool n_GeofencingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GeofencingEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='geofencingEnabled' and count(parameter)=0]"
		[Register ("geofencingEnabled", "()Z", "GetGeofencingEnabledHandler")]
		public abstract bool GeofencingEnabled ();

		static Delegate cb_notificationChannelName;
#pragma warning disable 0169
		static Delegate GetNotificationChannelNameHandler ()
		{
			if (cb_notificationChannelName == null)
				cb_notificationChannelName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NotificationChannelName);
			return cb_notificationChannelName;
		}

		static IntPtr n_NotificationChannelName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotificationChannelName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='notificationChannelName' and count(parameter)=0]"
		[Register ("notificationChannelName", "()Ljava/lang/String;", "GetNotificationChannelNameHandler")]
		public abstract string NotificationChannelName ();

		static Delegate cb_notificationRecipient;
#pragma warning disable 0169
		static Delegate GetNotificationRecipientHandler ()
		{
			if (cb_notificationRecipient == null)
				cb_notificationRecipient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NotificationRecipient);
			return cb_notificationRecipient;
		}

		static IntPtr n_NotificationRecipient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotificationRecipient ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='notificationRecipient' and count(parameter)=0]"
		[Register ("notificationRecipient", "()Ljava/lang/Class;", "GetNotificationRecipientHandler")]
		public abstract global::Java.Lang.Class NotificationRecipient ();

		static Delegate cb_notificationSmallIconResId;
#pragma warning disable 0169
		static Delegate GetNotificationSmallIconResIdHandler ()
		{
			if (cb_notificationSmallIconResId == null)
				cb_notificationSmallIconResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NotificationSmallIconResId);
			return cb_notificationSmallIconResId;
		}

		static int n_NotificationSmallIconResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationSmallIconResId ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='notificationSmallIconResId' and count(parameter)=0]"
		[Register ("notificationSmallIconResId", "()I", "GetNotificationSmallIconResIdHandler")]
		public abstract int NotificationSmallIconResId ();

		static Delegate cb_openDirectRecipient;
#pragma warning disable 0169
		static Delegate GetOpenDirectRecipientHandler ()
		{
			if (cb_openDirectRecipient == null)
				cb_openDirectRecipient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenDirectRecipient);
			return cb_openDirectRecipient;
		}

		static IntPtr n_OpenDirectRecipient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenDirectRecipient ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='openDirectRecipient' and count(parameter)=0]"
		[Register ("openDirectRecipient", "()Ljava/lang/Class;", "GetOpenDirectRecipientHandler")]
		public abstract global::Java.Lang.Class OpenDirectRecipient ();

		static Delegate cb_piAnalyticsEnabled;
#pragma warning disable 0169
		static Delegate GetPiAnalyticsEnabledHandler ()
		{
			if (cb_piAnalyticsEnabled == null)
				cb_piAnalyticsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_PiAnalyticsEnabled);
			return cb_piAnalyticsEnabled;
		}

		static bool n_PiAnalyticsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PiAnalyticsEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='piAnalyticsEnabled' and count(parameter)=0]"
		[Register ("piAnalyticsEnabled", "()Z", "GetPiAnalyticsEnabledHandler")]
		public abstract bool PiAnalyticsEnabled ();

		static Delegate cb_proximityEnabled;
#pragma warning disable 0169
		static Delegate GetProximityEnabledHandler ()
		{
			if (cb_proximityEnabled == null)
				cb_proximityEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ProximityEnabled);
			return cb_proximityEnabled;
		}

		static bool n_ProximityEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProximityEnabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='proximityEnabled' and count(parameter)=0]"
		[Register ("proximityEnabled", "()Z", "GetProximityEnabledHandler")]
		public abstract bool ProximityEnabled ();

		static Delegate cb_toBuilder;
#pragma warning disable 0169
		static Delegate GetToBuilderHandler ()
		{
			if (cb_toBuilder == null)
				cb_toBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBuilder);
			return cb_toBuilder;
		}

		static IntPtr n_ToBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.MarketingCloudConfig __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBuilder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='toBuilder' and count(parameter)=0]"
		[Register ("toBuilder", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetToBuilderHandler")]
		public abstract global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder ToBuilder ();

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MarketingCloudConfig", DoNotGenerateAcw=true)]
	internal partial class MarketingCloudConfigInvoker : MarketingCloudConfig {

		public MarketingCloudConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketingCloudConfigInvoker); }
		}

		static IntPtr id_accessToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='accessToken' and count(parameter)=0]"
		[Register ("accessToken", "()Ljava/lang/String;", "GetAccessTokenHandler")]
		public override unsafe string AccessToken ()
		{
			if (id_accessToken == IntPtr.Zero)
				id_accessToken = JNIEnv.GetMethodID (class_ref, "accessToken", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_accessToken), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_analyticsEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='analyticsEnabled' and count(parameter)=0]"
		[Register ("analyticsEnabled", "()Z", "GetAnalyticsEnabledHandler")]
		public override unsafe bool AnalyticsEnabled ()
		{
			if (id_analyticsEnabled == IntPtr.Zero)
				id_analyticsEnabled = JNIEnv.GetMethodID (class_ref, "analyticsEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_analyticsEnabled);
			} finally {
			}
		}

		static IntPtr id_applicationId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='applicationId' and count(parameter)=0]"
		[Register ("applicationId", "()Ljava/lang/String;", "GetApplicationIdHandler")]
		public override unsafe string ApplicationId ()
		{
			if (id_applicationId == IntPtr.Zero)
				id_applicationId = JNIEnv.GetMethodID (class_ref, "applicationId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_applicationId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_applicationLabel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='applicationLabel' and count(parameter)=0]"
		[Register ("applicationLabel", "()Ljava/lang/String;", "GetApplicationLabelHandler")]
		public override unsafe string ApplicationLabel ()
		{
			if (id_applicationLabel == IntPtr.Zero)
				id_applicationLabel = JNIEnv.GetMethodID (class_ref, "applicationLabel", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_applicationLabel), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cloudPageRecipient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='cloudPageRecipient' and count(parameter)=0]"
		[Register ("cloudPageRecipient", "()Ljava/lang/Class;", "GetCloudPageRecipientHandler")]
		public override unsafe global::Java.Lang.Class CloudPageRecipient ()
		{
			if (id_cloudPageRecipient == IntPtr.Zero)
				id_cloudPageRecipient = JNIEnv.GetMethodID (class_ref, "cloudPageRecipient", "()Ljava/lang/Class;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cloudPageRecipient), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_cloudPagesEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='cloudPagesEnabled' and count(parameter)=0]"
		[Register ("cloudPagesEnabled", "()Z", "GetCloudPagesEnabledHandler")]
		public override unsafe bool CloudPagesEnabled ()
		{
			if (id_cloudPagesEnabled == IntPtr.Zero)
				id_cloudPagesEnabled = JNIEnv.GetMethodID (class_ref, "cloudPagesEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cloudPagesEnabled);
			} finally {
			}
		}

		static IntPtr id_gcmSenderId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='gcmSenderId' and count(parameter)=0]"
		[Register ("gcmSenderId", "()Ljava/lang/String;", "GetGcmSenderIdHandler")]
		public override unsafe string GcmSenderId ()
		{
			if (id_gcmSenderId == IntPtr.Zero)
				id_gcmSenderId = JNIEnv.GetMethodID (class_ref, "gcmSenderId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_gcmSenderId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_geofencingEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='geofencingEnabled' and count(parameter)=0]"
		[Register ("geofencingEnabled", "()Z", "GetGeofencingEnabledHandler")]
		public override unsafe bool GeofencingEnabled ()
		{
			if (id_geofencingEnabled == IntPtr.Zero)
				id_geofencingEnabled = JNIEnv.GetMethodID (class_ref, "geofencingEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_geofencingEnabled);
			} finally {
			}
		}

		static IntPtr id_notificationChannelName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='notificationChannelName' and count(parameter)=0]"
		[Register ("notificationChannelName", "()Ljava/lang/String;", "GetNotificationChannelNameHandler")]
		public override unsafe string NotificationChannelName ()
		{
			if (id_notificationChannelName == IntPtr.Zero)
				id_notificationChannelName = JNIEnv.GetMethodID (class_ref, "notificationChannelName", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_notificationChannelName), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_notificationRecipient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='notificationRecipient' and count(parameter)=0]"
		[Register ("notificationRecipient", "()Ljava/lang/Class;", "GetNotificationRecipientHandler")]
		public override unsafe global::Java.Lang.Class NotificationRecipient ()
		{
			if (id_notificationRecipient == IntPtr.Zero)
				id_notificationRecipient = JNIEnv.GetMethodID (class_ref, "notificationRecipient", "()Ljava/lang/Class;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_notificationRecipient), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_notificationSmallIconResId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='notificationSmallIconResId' and count(parameter)=0]"
		[Register ("notificationSmallIconResId", "()I", "GetNotificationSmallIconResIdHandler")]
		public override unsafe int NotificationSmallIconResId ()
		{
			if (id_notificationSmallIconResId == IntPtr.Zero)
				id_notificationSmallIconResId = JNIEnv.GetMethodID (class_ref, "notificationSmallIconResId", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_notificationSmallIconResId);
			} finally {
			}
		}

		static IntPtr id_openDirectRecipient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='openDirectRecipient' and count(parameter)=0]"
		[Register ("openDirectRecipient", "()Ljava/lang/Class;", "GetOpenDirectRecipientHandler")]
		public override unsafe global::Java.Lang.Class OpenDirectRecipient ()
		{
			if (id_openDirectRecipient == IntPtr.Zero)
				id_openDirectRecipient = JNIEnv.GetMethodID (class_ref, "openDirectRecipient", "()Ljava/lang/Class;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openDirectRecipient), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_piAnalyticsEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='piAnalyticsEnabled' and count(parameter)=0]"
		[Register ("piAnalyticsEnabled", "()Z", "GetPiAnalyticsEnabledHandler")]
		public override unsafe bool PiAnalyticsEnabled ()
		{
			if (id_piAnalyticsEnabled == IntPtr.Zero)
				id_piAnalyticsEnabled = JNIEnv.GetMethodID (class_ref, "piAnalyticsEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_piAnalyticsEnabled);
			} finally {
			}
		}

		static IntPtr id_proximityEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='proximityEnabled' and count(parameter)=0]"
		[Register ("proximityEnabled", "()Z", "GetProximityEnabledHandler")]
		public override unsafe bool ProximityEnabled ()
		{
			if (id_proximityEnabled == IntPtr.Zero)
				id_proximityEnabled = JNIEnv.GetMethodID (class_ref, "proximityEnabled", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_proximityEnabled);
			} finally {
			}
		}

		static IntPtr id_toBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MarketingCloudConfig']/method[@name='toBuilder' and count(parameter)=0]"
		[Register ("toBuilder", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;", "GetToBuilderHandler")]
		public override unsafe global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder ToBuilder ()
		{
			if (id_toBuilder == IntPtr.Zero)
				id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/salesforce/marketingcloud/MarketingCloudConfig$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MarketingCloudConfig.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
