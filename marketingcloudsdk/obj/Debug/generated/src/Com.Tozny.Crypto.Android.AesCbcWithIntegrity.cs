using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tozny.Crypto.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']"
	[global::Android.Runtime.Register ("com/tozny/crypto/android/AesCbcWithIntegrity", DoNotGenerateAcw=true)]
	public partial class AesCbcWithIntegrity : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/field[@name='BASE64_FLAGS']"
		[Register ("BASE64_FLAGS")]
		public const int Base64Flags = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']"
		[global::Android.Runtime.Register ("com/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac", DoNotGenerateAcw=true)]
		public partial class CipherTextIvMac : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CipherTextIvMac); }
			}

			protected CipherTextIvMac (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayBarrayBarrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']/constructor[@name='AesCbcWithIntegrity.CipherTextIvMac' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register (".ctor", "([B[B[B)V", "")]
			public unsafe CipherTextIvMac (byte[] p0, byte[] p1, byte[] p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (CipherTextIvMac)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B[B[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B[B[B)V", __args);
						return;
					}

					if (id_ctor_arrayBarrayBarrayB == IntPtr.Zero)
						id_ctor_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B[B[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBarrayBarrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBarrayBarrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']/constructor[@name='AesCbcWithIntegrity.CipherTextIvMac' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe CipherTextIvMac (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (CipherTextIvMac)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getCipherText;
#pragma warning disable 0169
			static Delegate GetGetCipherTextHandler ()
			{
				if (cb_getCipherText == null)
					cb_getCipherText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCipherText);
				return cb_getCipherText;
			}

			static IntPtr n_GetCipherText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetCipherText ());
			}
#pragma warning restore 0169

			static IntPtr id_getCipherText;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']/method[@name='getCipherText' and count(parameter)=0]"
			[Register ("getCipherText", "()[B", "GetGetCipherTextHandler")]
			public virtual unsafe byte[] GetCipherText ()
			{
				if (id_getCipherText == IntPtr.Zero)
					id_getCipherText = JNIEnv.GetMethodID (class_ref, "getCipherText", "()[B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCipherText), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCipherText", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_getIv;
#pragma warning disable 0169
			static Delegate GetGetIvHandler ()
			{
				if (cb_getIv == null)
					cb_getIv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIv);
				return cb_getIv;
			}

			static IntPtr n_GetIv (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetIv ());
			}
#pragma warning restore 0169

			static IntPtr id_getIv;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']/method[@name='getIv' and count(parameter)=0]"
			[Register ("getIv", "()[B", "GetGetIvHandler")]
			public virtual unsafe byte[] GetIv ()
			{
				if (id_getIv == IntPtr.Zero)
					id_getIv = JNIEnv.GetMethodID (class_ref, "getIv", "()[B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIv), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIv", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_getMac;
#pragma warning disable 0169
			static Delegate GetGetMacHandler ()
			{
				if (cb_getMac == null)
					cb_getMac = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMac);
				return cb_getMac;
			}

			static IntPtr n_GetMac (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetMac ());
			}
#pragma warning restore 0169

			static IntPtr id_getMac;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']/method[@name='getMac' and count(parameter)=0]"
			[Register ("getMac", "()[B", "GetGetMacHandler")]
			public virtual unsafe byte[] GetMac ()
			{
				if (id_getMac == IntPtr.Zero)
					id_getMac = JNIEnv.GetMethodID (class_ref, "getMac", "()[B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMac), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMac", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static IntPtr id_ivCipherConcat_arrayBarrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.CipherTextIvMac']/method[@name='ivCipherConcat' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
			[Register ("ivCipherConcat", "([B[B)[B", "")]
			public static unsafe byte[] IvCipherConcat (byte[] p0, byte[] p1)
			{
				if (id_ivCipherConcat_arrayBarrayB == IntPtr.Zero)
					id_ivCipherConcat_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "ivCipherConcat", "([B[B)[B");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_ivCipherConcat_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes']"
		[global::Android.Runtime.Register ("com/tozny/crypto/android/AesCbcWithIntegrity$PrngFixes", DoNotGenerateAcw=true)]
		public sealed partial class PrngFixes : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom']"
			[global::Android.Runtime.Register ("com/tozny/crypto/android/AesCbcWithIntegrity$PrngFixes$LinuxPRNGSecureRandom", DoNotGenerateAcw=true)]
			public partial class LinuxPRNGSecureRandom : global::Java.Security.SecureRandomSpi {

				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/tozny/crypto/android/AesCbcWithIntegrity$PrngFixes$LinuxPRNGSecureRandom", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (LinuxPRNGSecureRandom); }
				}

				protected LinuxPRNGSecureRandom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom']/constructor[@name='AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe LinuxPRNGSecureRandom ()
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						if (((object) this).GetType () != typeof (LinuxPRNGSecureRandom)) {
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

				static Delegate cb_engineGenerateSeed_I;
#pragma warning disable 0169
				static Delegate GetEngineGenerateSeed_IHandler ()
				{
					if (cb_engineGenerateSeed_I == null)
						cb_engineGenerateSeed_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_EngineGenerateSeed_I);
					return cb_engineGenerateSeed_I;
				}

				static IntPtr n_EngineGenerateSeed_I (IntPtr jnienv, IntPtr native__this, int p0)
				{
					global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.NewArray (__this.EngineGenerateSeed (p0));
				}
#pragma warning restore 0169

				static IntPtr id_engineGenerateSeed_I;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom']/method[@name='engineGenerateSeed' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("engineGenerateSeed", "(I)[B", "GetEngineGenerateSeed_IHandler")]
				protected override unsafe byte[] EngineGenerateSeed (int p0)
				{
					if (id_engineGenerateSeed_I == IntPtr.Zero)
						id_engineGenerateSeed_I = JNIEnv.GetMethodID (class_ref, "engineGenerateSeed", "(I)[B");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (p0);

						if (((object) this).GetType () == ThresholdType)
							return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGenerateSeed_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
						else
							return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineGenerateSeed", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					} finally {
					}
				}

				static Delegate cb_engineNextBytes_arrayB;
#pragma warning disable 0169
				static Delegate GetEngineNextBytes_arrayBHandler ()
				{
					if (cb_engineNextBytes_arrayB == null)
						cb_engineNextBytes_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EngineNextBytes_arrayB);
					return cb_engineNextBytes_arrayB;
				}

				static void n_EngineNextBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
					__this.EngineNextBytes (p0);
					if (p0 != null)
						JNIEnv.CopyArray (p0, native_p0);
				}
#pragma warning restore 0169

				static IntPtr id_engineNextBytes_arrayB;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom']/method[@name='engineNextBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
				[Register ("engineNextBytes", "([B)V", "GetEngineNextBytes_arrayBHandler")]
				protected override unsafe void EngineNextBytes (byte[] p0)
				{
					if (id_engineNextBytes_arrayB == IntPtr.Zero)
						id_engineNextBytes_arrayB = JNIEnv.GetMethodID (class_ref, "engineNextBytes", "([B)V");
					IntPtr native_p0 = JNIEnv.NewArray (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_engineNextBytes_arrayB, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineNextBytes", "([B)V"), __args);
					} finally {
						if (p0 != null) {
							JNIEnv.CopyArray (native_p0, p0);
							JNIEnv.DeleteLocalRef (native_p0);
						}
					}
				}

				static Delegate cb_engineSetSeed_arrayB;
#pragma warning disable 0169
				static Delegate GetEngineSetSeed_arrayBHandler ()
				{
					if (cb_engineSetSeed_arrayB == null)
						cb_engineSetSeed_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EngineSetSeed_arrayB);
					return cb_engineSetSeed_arrayB;
				}

				static void n_EngineSetSeed_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
					__this.EngineSetSeed (p0);
					if (p0 != null)
						JNIEnv.CopyArray (p0, native_p0);
				}
#pragma warning restore 0169

				static IntPtr id_engineSetSeed_arrayB;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes.LinuxPRNGSecureRandom']/method[@name='engineSetSeed' and count(parameter)=1 and parameter[1][@type='byte[]']]"
				[Register ("engineSetSeed", "([B)V", "GetEngineSetSeed_arrayBHandler")]
				protected override unsafe void EngineSetSeed (byte[] p0)
				{
					if (id_engineSetSeed_arrayB == IntPtr.Zero)
						id_engineSetSeed_arrayB = JNIEnv.GetMethodID (class_ref, "engineSetSeed", "([B)V");
					IntPtr native_p0 = JNIEnv.NewArray (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_engineSetSeed_arrayB, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineSetSeed", "([B)V"), __args);
					} finally {
						if (p0 != null) {
							JNIEnv.CopyArray (native_p0, p0);
							JNIEnv.DeleteLocalRef (native_p0);
						}
					}
				}

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tozny/crypto/android/AesCbcWithIntegrity$PrngFixes", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PrngFixes); }
			}

			internal PrngFixes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.PrngFixes']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "")]
			public static unsafe void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()V");
				try {
					JNIEnv.CallStaticVoidMethod  (class_ref, id_a);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.SecretKeys']"
		[global::Android.Runtime.Register ("com/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys", DoNotGenerateAcw=true)]
		public partial class SecretKeys : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SecretKeys); }
			}

			protected SecretKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljavax_crypto_SecretKey_Ljavax_crypto_SecretKey_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.SecretKeys']/constructor[@name='AesCbcWithIntegrity.SecretKeys' and count(parameter)=2 and parameter[1][@type='javax.crypto.SecretKey'] and parameter[2][@type='javax.crypto.SecretKey']]"
			[Register (".ctor", "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V", "")]
			public unsafe SecretKeys (global::Javax.Crypto.ISecretKey p0, global::Javax.Crypto.ISecretKey p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (SecretKeys)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V", __args);
						return;
					}

					if (id_ctor_Ljavax_crypto_SecretKey_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
						id_ctor_Ljavax_crypto_SecretKey_Ljavax_crypto_SecretKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljavax/crypto/SecretKey;Ljavax/crypto/SecretKey;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljavax_crypto_SecretKey_Ljavax_crypto_SecretKey_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljavax_crypto_SecretKey_Ljavax_crypto_SecretKey_, __args);
				} finally {
				}
			}

			static Delegate cb_getConfidentialityKey;
#pragma warning disable 0169
			static Delegate GetGetConfidentialityKeyHandler ()
			{
				if (cb_getConfidentialityKey == null)
					cb_getConfidentialityKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfidentialityKey);
				return cb_getConfidentialityKey;
			}

			static IntPtr n_GetConfidentialityKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ConfidentialityKey);
			}
#pragma warning restore 0169

			static Delegate cb_setConfidentialityKey_Ljavax_crypto_SecretKey_;
#pragma warning disable 0169
			static Delegate GetSetConfidentialityKey_Ljavax_crypto_SecretKey_Handler ()
			{
				if (cb_setConfidentialityKey_Ljavax_crypto_SecretKey_ == null)
					cb_setConfidentialityKey_Ljavax_crypto_SecretKey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfidentialityKey_Ljavax_crypto_SecretKey_);
				return cb_setConfidentialityKey_Ljavax_crypto_SecretKey_;
			}

			static void n_SetConfidentialityKey_Ljavax_crypto_SecretKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Crypto.ISecretKey p0 = (global::Javax.Crypto.ISecretKey)global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ConfidentialityKey = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getConfidentialityKey;
			static IntPtr id_setConfidentialityKey_Ljavax_crypto_SecretKey_;
			public virtual unsafe global::Javax.Crypto.ISecretKey ConfidentialityKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.SecretKeys']/method[@name='getConfidentialityKey' and count(parameter)=0]"
				[Register ("getConfidentialityKey", "()Ljavax/crypto/SecretKey;", "GetGetConfidentialityKeyHandler")]
				get {
					if (id_getConfidentialityKey == IntPtr.Zero)
						id_getConfidentialityKey = JNIEnv.GetMethodID (class_ref, "getConfidentialityKey", "()Ljavax/crypto/SecretKey;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfidentialityKey), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfidentialityKey", "()Ljavax/crypto/SecretKey;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.SecretKeys']/method[@name='setConfidentialityKey' and count(parameter)=1 and parameter[1][@type='javax.crypto.SecretKey']]"
				[Register ("setConfidentialityKey", "(Ljavax/crypto/SecretKey;)V", "GetSetConfidentialityKey_Ljavax_crypto_SecretKey_Handler")]
				set {
					if (id_setConfidentialityKey_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
						id_setConfidentialityKey_Ljavax_crypto_SecretKey_ = JNIEnv.GetMethodID (class_ref, "setConfidentialityKey", "(Ljavax/crypto/SecretKey;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConfidentialityKey_Ljavax_crypto_SecretKey_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfidentialityKey", "(Ljavax/crypto/SecretKey;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getIntegrityKey;
#pragma warning disable 0169
			static Delegate GetGetIntegrityKeyHandler ()
			{
				if (cb_getIntegrityKey == null)
					cb_getIntegrityKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntegrityKey);
				return cb_getIntegrityKey;
			}

			static IntPtr n_GetIntegrityKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IntegrityKey);
			}
#pragma warning restore 0169

			static Delegate cb_setIntegrityKey_Ljavax_crypto_SecretKey_;
#pragma warning disable 0169
			static Delegate GetSetIntegrityKey_Ljavax_crypto_SecretKey_Handler ()
			{
				if (cb_setIntegrityKey_Ljavax_crypto_SecretKey_ == null)
					cb_setIntegrityKey_Ljavax_crypto_SecretKey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntegrityKey_Ljavax_crypto_SecretKey_);
				return cb_setIntegrityKey_Ljavax_crypto_SecretKey_;
			}

			static void n_SetIntegrityKey_Ljavax_crypto_SecretKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __this = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Crypto.ISecretKey p0 = (global::Javax.Crypto.ISecretKey)global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.IntegrityKey = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getIntegrityKey;
			static IntPtr id_setIntegrityKey_Ljavax_crypto_SecretKey_;
			public virtual unsafe global::Javax.Crypto.ISecretKey IntegrityKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.SecretKeys']/method[@name='getIntegrityKey' and count(parameter)=0]"
				[Register ("getIntegrityKey", "()Ljavax/crypto/SecretKey;", "GetGetIntegrityKeyHandler")]
				get {
					if (id_getIntegrityKey == IntPtr.Zero)
						id_getIntegrityKey = JNIEnv.GetMethodID (class_ref, "getIntegrityKey", "()Ljavax/crypto/SecretKey;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntegrityKey), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntegrityKey", "()Ljavax/crypto/SecretKey;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity.SecretKeys']/method[@name='setIntegrityKey' and count(parameter)=1 and parameter[1][@type='javax.crypto.SecretKey']]"
				[Register ("setIntegrityKey", "(Ljavax/crypto/SecretKey;)V", "GetSetIntegrityKey_Ljavax_crypto_SecretKey_Handler")]
				set {
					if (id_setIntegrityKey_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
						id_setIntegrityKey_Ljavax_crypto_SecretKey_ = JNIEnv.GetMethodID (class_ref, "setIntegrityKey", "(Ljavax/crypto/SecretKey;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntegrityKey_Ljavax_crypto_SecretKey_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntegrityKey", "(Ljavax/crypto/SecretKey;)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tozny/crypto/android/AesCbcWithIntegrity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AesCbcWithIntegrity); }
		}

		protected AesCbcWithIntegrity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/constructor[@name='AesCbcWithIntegrity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AesCbcWithIntegrity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AesCbcWithIntegrity)) {
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

		static IntPtr id_constantTimeEq_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='constantTimeEq' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("constantTimeEq", "([B[B)Z", "")]
		public static unsafe bool ConstantTimeEq (byte[] p0, byte[] p1)
		{
			if (id_constantTimeEq_arrayBarrayB == IntPtr.Zero)
				id_constantTimeEq_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "constantTimeEq", "([B[B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_constantTimeEq_arrayBarrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_decrypt_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='com.tozny.crypto.android.AesCbcWithIntegrity.CipherTextIvMac'] and parameter[2][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys']]"
		[Register ("decrypt", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)[B", "")]
		public static unsafe byte[] Decrypt (global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac p0, global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p1)
		{
			if (id_decrypt_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ == IntPtr.Zero)
				id_decrypt_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='decryptString' and count(parameter)=2 and parameter[1][@type='com.tozny.crypto.android.AesCbcWithIntegrity.CipherTextIvMac'] and parameter[2][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys']]"
		[Register ("decryptString", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Ljava/lang/String;", "")]
		public static unsafe string DecryptString (global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac p0, global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p1)
		{
			if (id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ == IntPtr.Zero)
				id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ = JNIEnv.GetStaticMethodID (class_ref, "decryptString", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='decryptString' and count(parameter)=3 and parameter[1][@type='com.tozny.crypto.android.AesCbcWithIntegrity.CipherTextIvMac'] and parameter[2][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys'] and parameter[3][@type='java.lang.String']]"
		[Register ("decryptString", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DecryptString (global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac p0, global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p1, string p2)
		{
			if (id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_ == IntPtr.Zero)
				id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decryptString", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decryptString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_CipherTextIvMac_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_encrypt_arrayBLcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys']]"
		[Register ("encrypt", "([BLcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac Encrypt (byte[] p0, global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p1)
		{
			if (id_encrypt_arrayBLcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ == IntPtr.Zero)
				id_encrypt_arrayBLcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "([BLcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac __ret = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_arrayBLcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys']]"
		[Register ("encrypt", "(Ljava/lang/String;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac Encrypt (string p0, global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p1)
		{
			if (id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/lang/String;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac __ret = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='encrypt' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys'] and parameter[3][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;Ljava/lang/String;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac Encrypt (string p0, global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p1, string p2)
		{
			if (id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/lang/String;Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;Ljava/lang/String;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$CipherTextIvMac;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac __ret = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.CipherTextIvMac> (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_lang_String_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_generateIv;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='generateIv' and count(parameter)=0]"
		[Register ("generateIv", "()[B", "")]
		public static unsafe byte[] GenerateIv ()
		{
			if (id_generateIv == IntPtr.Zero)
				id_generateIv = JNIEnv.GetStaticMethodID (class_ref, "generateIv", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateIv), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_generateKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='generateKey' and count(parameter)=0]"
		[Register ("generateKey", "()Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys GenerateKey ()
		{
			if (id_generateKey == IntPtr.Zero)
				id_generateKey = JNIEnv.GetStaticMethodID (class_ref, "generateKey", "()Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKey), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_generateKeyFromPassword_Ljava_lang_String_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='generateKeyFromPassword' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("generateKeyFromPassword", "(Ljava/lang/String;[BI)Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys GenerateKeyFromPassword (string p0, byte[] p1, int p2)
		{
			if (id_generateKeyFromPassword_Ljava_lang_String_arrayBI == IntPtr.Zero)
				id_generateKeyFromPassword_Ljava_lang_String_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "generateKeyFromPassword", "(Ljava/lang/String;[BI)Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKeyFromPassword_Ljava_lang_String_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_generateKeyFromPassword_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='generateKeyFromPassword' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("generateKeyFromPassword", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys GenerateKeyFromPassword (string p0, string p1, int p2)
		{
			if (id_generateKeyFromPassword_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_generateKeyFromPassword_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "generateKeyFromPassword", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKeyFromPassword_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_generateMac_arrayBLjavax_crypto_SecretKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='generateMac' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='javax.crypto.SecretKey']]"
		[Register ("generateMac", "([BLjavax/crypto/SecretKey;)[B", "")]
		public static unsafe byte[] GenerateMac (byte[] p0, global::Javax.Crypto.ISecretKey p1)
		{
			if (id_generateMac_arrayBLjavax_crypto_SecretKey_ == IntPtr.Zero)
				id_generateMac_arrayBLjavax_crypto_SecretKey_ = JNIEnv.GetStaticMethodID (class_ref, "generateMac", "([BLjavax/crypto/SecretKey;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateMac_arrayBLjavax_crypto_SecretKey_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_generateSalt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='generateSalt' and count(parameter)=0]"
		[Register ("generateSalt", "()[B", "")]
		public static unsafe byte[] GenerateSalt ()
		{
			if (id_generateSalt == IntPtr.Zero)
				id_generateSalt = JNIEnv.GetStaticMethodID (class_ref, "generateSalt", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateSalt), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_keyString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='keyString' and count(parameter)=1 and parameter[1][@type='com.tozny.crypto.android.AesCbcWithIntegrity.SecretKeys']]"
		[Register ("keyString", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Ljava/lang/String;", "")]
		public static unsafe string KeyString (global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys p0)
		{
			if (id_keyString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ == IntPtr.Zero)
				id_keyString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_ = JNIEnv.GetStaticMethodID (class_ref, "keyString", "(Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_keyString_Lcom_tozny_crypto_android_AesCbcWithIntegrity_SecretKeys_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_keys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='keys' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("keys", "(Ljava/lang/String;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;", "")]
		public static unsafe global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys Keys (string p0)
		{
			if (id_keys_Ljava_lang_String_ == IntPtr.Zero)
				id_keys_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "keys", "(Ljava/lang/String;)Lcom/tozny/crypto/android/AesCbcWithIntegrity$SecretKeys;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys __ret = global::Java.Lang.Object.GetObject<global::Com.Tozny.Crypto.Android.AesCbcWithIntegrity.SecretKeys> (JNIEnv.CallStaticObjectMethod  (class_ref, id_keys_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saltString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tozny.crypto.android']/class[@name='AesCbcWithIntegrity']/method[@name='saltString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saltString", "([B)Ljava/lang/String;", "")]
		public static unsafe string SaltString (byte[] p0)
		{
			if (id_saltString_arrayB == IntPtr.Zero)
				id_saltString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "saltString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saltString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
