using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary
{
	public enum PackageType
	{
		init = 0,
		login,
		send
	}

	public enum PackageSenError
	{
		notOk = 0,
		ok
	}

	[Serializable]
	public class Package
    {
		public int length, type;

		public Package()
		{
			length = 0;
			type = 0;
		}

		public static byte[] serialize(object o)
		{
			MemoryStream memoryS = new MemoryStream(1024 * 4);
			BinaryFormatter binaryF = new BinaryFormatter();
			binaryF.Serialize(memoryS, o);
			return memoryS.ToArray();
		}

		public static Object desserialize(byte[] bt)
		{
			MemoryStream memoryS = new MemoryStream(1024 * 4);
			foreach (byte b in bt)
			{
				memoryS.WriteByte(b);
			}

			memoryS.Position = 0;
			BinaryFormatter binaryF = new BinaryFormatter();
			Object obj = binaryF.Deserialize(memoryS);
			memoryS.Close();
			return obj;
		}
	}

	[Serializable]
	public class Initialize : Package
	{
		public int data = 0;
	}

	[Serializable]
	public class Login : Package
	{
		public string strId;

		public Login()
		{
			strId = null;
		}
	}

	// 핵심 코드
	[Serializable]
	public class Send: Package
	{
		public string answer;
		public Send()
		{
			answer = null;
		}
	}
}
