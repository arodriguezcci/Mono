using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hoho.Android.Usbserial.Driver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']"
	[global::Android.Runtime.Register ("com/hoho/android/usbserial/driver/CdcAcmSerialDriver", DoNotGenerateAcw=true)]
	public partial class CdcAcmSerialDriver : global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hoho/android/usbserial/driver/CdcAcmSerialDriver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CdcAcmSerialDriver); }
		}

		protected CdcAcmSerialDriver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/constructor[@name='CdcAcmSerialDriver' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDevice'] and parameter[2][@type='android.hardware.usb.UsbDeviceConnection']]"
		[Register (".ctor", "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V", "")]
		public CdcAcmSerialDriver (global::Android.Hardware.Usb.UsbDevice p0, global::Android.Hardware.Usb.UsbDeviceConnection p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CdcAcmSerialDriver)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_ == IntPtr.Zero)
				id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getSupportedDevices;
		public static global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, int[]> SupportedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/method[@name='getSupportedDevices' and count(parameter)=0]"
			[Register ("getSupportedDevices", "()Ljava/util/Map;", "GetGetSupportedDevicesHandler")]
			get {
				if (id_getSupportedDevices == IntPtr.Zero)
					id_getSupportedDevices = JNIEnv.GetStaticMethodID (class_ref, "getSupportedDevices", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, int[]>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSupportedDevices), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public override void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_open);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()V"));
		}

		static Delegate cb_read_arrayBI;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIHandler ()
		{
			if (cb_read_arrayBI == null)
				cb_read_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Read_arrayBI);
			return cb_read_arrayBI;
		}

		static int n_Read_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/method[@name='read' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("read", "([BI)I", "GetRead_arrayBIHandler")]
		public override int Read (byte[] p0, int p1)
		{
			if (id_read_arrayBI == IntPtr.Zero)
				id_read_arrayBI = JNIEnv.GetMethodID (class_ref, "read", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayBI, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([BI)I"), new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setBaudRate_I;
#pragma warning disable 0169
		static Delegate GetSetBaudRate_IHandler ()
		{
			if (cb_setBaudRate_I == null)
				cb_setBaudRate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SetBaudRate_I);
			return cb_setBaudRate_I;
		}

		static int n_SetBaudRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetBaudRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBaudRate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/method[@name='setBaudRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBaudRate", "(I)I", "GetSetBaudRate_IHandler")]
		public override int SetBaudRate (int p0)
		{
			if (id_setBaudRate_I == IntPtr.Zero)
				id_setBaudRate_I = JNIEnv.GetMethodID (class_ref, "setBaudRate", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_setBaudRate_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaudRate", "(I)I"), new JValue (p0));
		}

		static Delegate cb_write_arrayBI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIHandler ()
		{
			if (cb_write_arrayBI == null)
				cb_write_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Write_arrayBI);
			return cb_write_arrayBI;
		}

		static int n_Write_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.CdcAcmSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='CdcAcmSerialDriver']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("write", "([BI)I", "GetWrite_arrayBIHandler")]
		public override int Write (byte[] p0, int p1)
		{
			if (id_write_arrayBI == IntPtr.Zero)
				id_write_arrayBI = JNIEnv.GetMethodID (class_ref, "write", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_write_arrayBI, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([BI)I"), new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
