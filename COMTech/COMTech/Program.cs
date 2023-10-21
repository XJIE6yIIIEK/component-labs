using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace COMTech {
	//{20A46794-1D8C-4EC6-86F6-C4668EAD96E3}
	//DEFINE_GUID(IID_ICreateCar,
	//0x20a46794, 0x1d8c, 0x4ec6, 0x86, 0xf6, 0xc4, 0x66, 0x8e, 0xad, 0x96, 0xe3);
	[ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("20A46794-1D8C-4EC6-86F6-C4668EAD96E3")]
	public interface ICreateCar {
		void SetPetName(string petName);
		[DispId(7)]
		void SetMaxSpeed(int maxSp);
	}

	//{E8B4AF01-BBFE-42D9-9941-949E774F0867}
	//DEFINE_GUID(IID_IStats,
	//0xe8b4af01, 0xbbfe, 0x42d9, 0x99, 0x41, 0x94, 0x9e, 0x77, 0x4f, 0x8, 0x67);
	[ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("E8B4AF01-BBFE-42D9-9941-949E774F0867")]
	public interface IStats {
		void DisplayStats();
		void GetPetName(ref string petName);
	}

	//{6E774298-5B40-466C-82B6-287BB1823BE3}
	//DEFINE_GUID(IID_IEngine,
	//0x6e774298, 0x5b40, 0x466c, 0x82, 0xb6, 0x28, 0x7b, 0xb1, 0x82, 0x3b, 0xe3);
	[ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6E774298-5B40-466C-82B6-287BB1823BE3")]
	public interface IEngine {
		void SpeedUp();
		void GetMaxSpeed(ref int curSpeed);
		void GetCurSpeed(ref int maxSpeed);
	}

	class Program {
		static void Main(string[] args) {
			Type comType = Type.GetTypeFromCLSID(new Guid("42E000B0-7709-4257-A6E6-8492DC62CAEF"));
			dynamic comObject = Activator.CreateInstance(comType);
			object createCarInterface = comObject as ICreateCar;

			object[] parameters = new object[] { 20 };
			object result = (typeof(ICreateCar)).InvokeMember("SetMaxSpeed", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, createCarInterface, parameters);
		}
	}
}
