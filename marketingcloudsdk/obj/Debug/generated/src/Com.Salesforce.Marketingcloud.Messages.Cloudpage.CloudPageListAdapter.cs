using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Salesforce.Marketingcloud.Messages.Cloudpage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']"
	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageListAdapter", DoNotGenerateAcw=true)]
	public abstract partial class CloudPageListAdapter : global::Android.Widget.BaseAdapter, global::Android.Widget.IListAdapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/field[@name='DISPLAY_ALL']"
		[Register ("DISPLAY_ALL")]
		public const int DisplayAll = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/field[@name='DISPLAY_READ']"
		[Register ("DISPLAY_READ")]
		public const int DisplayRead = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/field[@name='DISPLAY_UNREAD']"
		[Register ("DISPLAY_UNREAD")]
		public const int DisplayUnread = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageListAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudPageListAdapter); }
		}

		protected CloudPageListAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisplay;
#pragma warning disable 0169
		static Delegate GetGetDisplayHandler ()
		{
			if (cb_getDisplay == null)
				cb_getDisplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplay);
			return cb_getDisplay;
		}

		static int n_GetDisplay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Display;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplay_I;
#pragma warning disable 0169
		static Delegate GetSetDisplay_IHandler ()
		{
			if (cb_setDisplay_I == null)
				cb_setDisplay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplay_I);
			return cb_setDisplay_I;
		}

		static void n_SetDisplay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Display = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplay;
		static IntPtr id_setDisplay_I;
		public virtual unsafe int Display {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='getDisplay' and count(parameter)=0]"
			[Register ("getDisplay", "()I", "GetGetDisplayHandler")]
			get {
				if (id_getDisplay == IntPtr.Zero)
					id_getDisplay = JNIEnv.GetMethodID (class_ref, "getDisplay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplay", "(I)V", "GetSetDisplay_IHandler")]
			set {
				if (id_setDisplay_I == IntPtr.Zero)
					id_setDisplay_I = JNIEnv.GetMethodID (class_ref, "setDisplay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplay", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_Handler ()
		{
			if (cb_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ == null)
				cb_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_);
			return cb_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
		}

		static void n_DeleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.messages.cloudpage.CloudPageMessage']]"
		[Register ("deleteMessage", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V", "GetDeleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_Handler")]
		public virtual unsafe void DeleteMessage (global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0)
		{
			if (id_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ == IntPtr.Zero)
				id_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_onCloudPagesChanged_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnCloudPagesChanged_Ljava_util_List_Handler ()
		{
			if (cb_onCloudPagesChanged_Ljava_util_List_ == null)
				cb_onCloudPagesChanged_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCloudPagesChanged_Ljava_util_List_);
			return cb_onCloudPagesChanged_Ljava_util_List_;
		}

		static void n_OnCloudPagesChanged_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCloudPagesChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCloudPagesChanged_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='onCloudPagesChanged' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.salesforce.marketingcloud.messages.cloudpage.CloudPageMessage&gt;']]"
		[Register ("onCloudPagesChanged", "(Ljava/util/List;)V", "GetOnCloudPagesChanged_Ljava_util_List_Handler")]
		public virtual unsafe void OnCloudPagesChanged (global::System.Collections.Generic.IList<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> p0)
		{
			if (id_onCloudPagesChanged_Ljava_util_List_ == IntPtr.Zero)
				id_onCloudPagesChanged_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onCloudPagesChanged", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloudPagesChanged_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCloudPagesChanged", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
#pragma warning disable 0169
		static Delegate GetSetMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_Handler ()
		{
			if (cb_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ == null)
				cb_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_);
			return cb_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
		}

		static void n_SetMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageRead (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.salesforce.marketingcloud.messages.cloudpage']/class[@name='CloudPageListAdapter']/method[@name='setMessageRead' and count(parameter)=1 and parameter[1][@type='com.salesforce.marketingcloud.messages.cloudpage.CloudPageMessage']]"
		[Register ("setMessageRead", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V", "GetSetMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_Handler")]
		public virtual unsafe void SetMessageRead (global::Com.Salesforce.Marketingcloud.Messages.Cloudpage.CloudPageMessage p0)
		{
			if (id_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ == IntPtr.Zero)
				id_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_ = JNIEnv.GetMethodID (class_ref, "setMessageRead", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageRead_Lcom_salesforce_marketingcloud_messages_cloudpage_CloudPageMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageRead", "(Lcom/salesforce/marketingcloud/messages/cloudpage/CloudPageMessage;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/salesforce/marketingcloud/messages/cloudpage/CloudPageListAdapter", DoNotGenerateAcw=true)]
	internal partial class CloudPageListAdapterInvoker : CloudPageListAdapter {

		public CloudPageListAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudPageListAdapterInvoker); }
		}

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (convertView);
				__args [2] = new JValue (parent);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
