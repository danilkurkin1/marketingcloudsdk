using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/MCInitContentProvider", DoNotGenerateAcw=true)]
	public sealed partial class MCInitContentProvider : global::Android.Content.ContentProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/MCInitContentProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MCInitContentProvider); }
		}

		internal MCInitContentProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/constructor[@name='MCInitContentProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MCInitContentProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MCInitContentProvider)) {
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

		static IntPtr id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public override unsafe int Delete (global::Android.Net.Uri p0, string p1, string[] p2)
		{
			if (id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_delete_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_getType_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/method[@name='getType' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getType", "(Landroid/net/Uri;)Ljava/lang/String;", "")]
		public override unsafe string GetType (global::Android.Net.Uri p0)
		{
			if (id_getType_Landroid_net_Uri_ == IntPtr.Zero)
				id_getType_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_insert_Landroid_net_Uri_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues']]"
		[Register ("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", "")]
		public override unsafe global::Android.Net.Uri Insert (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1)
		{
			if (id_insert_Landroid_net_Uri_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insert_Landroid_net_Uri_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_insert_Landroid_net_Uri_Landroid_content_ContentValues_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()Z", "")]
		public override unsafe bool OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCreate);
			} finally {
			}
		}

		static IntPtr id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/method[@name='query' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "")]
		public override unsafe global::Android.Database.ICursor Query (global::Android.Net.Uri p0, string[] p1, string p2, string[] p3, string p4)
		{
			if (id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				global::Android.Database.ICursor __ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Landroid_net_Uri_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud']/class[@name='MCInitContentProvider']/method[@name='update' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public override unsafe int Update (global::Android.Net.Uri p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
		{
			if (id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_update_Landroid_net_Uri_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
