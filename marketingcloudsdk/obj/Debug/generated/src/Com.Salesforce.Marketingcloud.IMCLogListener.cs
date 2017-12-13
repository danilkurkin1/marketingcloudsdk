using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCLogListener.AndroidLogListener']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MCLogListener$AndroidLogListener", DoNotGenerateAcw=true)]
	public partial class MCLogListenerAndroidLogListener : global::Java.Lang.Object, global::Com.Salesforce.Marketingcloud.IMCLogListener {


		public static class InterfaceConsts {

			// The following are fields from: com.salesforce.marketingcloud.MCLogListener

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public const int Debug = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const int Error = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='INFO']"
			[Register ("INFO")]
			public const int Info = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public const int Verbose = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='WARN']"
			[Register ("WARN")]
			public const int Warn = (int) 5;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/MCLogListener$AndroidLogListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MCLogListenerAndroidLogListener); }
		}

		protected MCLogListenerAndroidLogListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCLogListener.AndroidLogListener']/constructor[@name='MCLogListener.AndroidLogListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MCLogListenerAndroidLogListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MCLogListenerAndroidLogListener)) {
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

		static Delegate cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOut_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Salesforce.Marketingcloud.MCLogListenerAndroidLogListener __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.MCLogListenerAndroidLogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Out (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCLogListener.AndroidLogListener']/method[@name='out' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
		[Register ("out", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOut_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Out (int p0, string p1, string p2, global::Java.Lang.Throwable p3)
		{
			if (id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "out", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "out", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	[Register ("com/salesforce/marketingcloud/MCLogListener", DoNotGenerateAcw=true)]
	public abstract class MCLogListener : Java.Lang.Object {

		internal MCLogListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const int Debug = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public const int Verbose = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 5;
	}

	[Register ("com/salesforce/marketingcloud/MCLogListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MCLogListener' type. This type will be removed in a future release.")]
	public abstract class MCLogListenerConsts : MCLogListener {

		private MCLogListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']"
	[Register ("com/salesforce/marketingcloud/MCLogListener", "", "Com.Salesforce.Marketingcloud.IMCLogListenerInvoker")]
	public partial interface IMCLogListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/interface[@name='MCLogListener']/method[@name='out' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
		[Register ("out", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOut_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Salesforce.Marketingcloud.IMCLogListenerInvoker, marketingcloudsdk")]
		void Out ([global::Android.Runtime.IntDef (Type = "Com.Salesforce.Marketingcloud.IMCLogListener", Fields = new string [] {"Verbose", "Debug", "Info", "Warn", "Error"})]int p0, string p1, string p2, global::Java.Lang.Throwable p3);

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MCLogListener", DoNotGenerateAcw=true)]
	internal class IMCLogListenerInvoker : global::Java.Lang.Object, IMCLogListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/salesforce/marketingcloud/MCLogListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMCLogListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMCLogListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMCLogListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.salesforce.marketingcloud.MCLogListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMCLogListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOut_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Salesforce.Marketingcloud.IMCLogListener __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.IMCLogListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Out (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void Out ([global::Android.Runtime.IntDef (Type = "Com.Salesforce.Marketingcloud.IMCLogListener", Fields = new string [] {"Verbose", "Debug", "Info", "Warn", "Error"})]int p0, string p1, string p2, global::Java.Lang.Throwable p3)
		{
			if (id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "out", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_out_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class MCLogEventArgs : global::System.EventArgs {

		public MCLogEventArgs (int p0, string p1, string p2, global::Java.Lang.Throwable p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		global::Java.Lang.Throwable p3;
		public global::Java.Lang.Throwable P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/salesforce/marketingcloud/MCLogListenerImplementor")]
	internal sealed partial class IMCLogListenerImplementor : global::Java.Lang.Object, IMCLogListener {

		object sender;

		public IMCLogListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/salesforce/marketingcloud/MCLogListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MCLogEventArgs> Handler;
#pragma warning restore 0649

		public void Out ([global::Android.Runtime.IntDef (Type = "Com.Salesforce.Marketingcloud.IMCLogListener", Fields = new string [] {"Verbose", "Debug", "Info", "Warn", "Error"})]int p0, string p1, string p2, global::Java.Lang.Throwable p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MCLogEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IMCLogListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
