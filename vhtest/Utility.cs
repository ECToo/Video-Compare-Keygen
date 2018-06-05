using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace vhtest
{
    public class Utility
    {
        protected int m_nKeyLength = 16;
        protected int m_nCrcBase = 116;
        protected int m_nCrcAdd = 19;
        public uint[] dfox = new uint[34];

        public byte[] StringToByteArray(String hex, int basec = 16)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), basec);
            return bytes;
        }
        public string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
        public string DFX_dividia(double dimensione, string stringa, string Divisore = "-")
        {
            return String.Join(Divisore, Enumerable.Range(0, (int)Math.Ceiling(stringa.Length / dimensione))
               .Select(i => new string(stringa
                   .Skip(i * (int)dimensione)
                   .Take((int)dimensione)
                   .ToArray())));
        }
        public bool ConvKey2(string strKey/*, Struct721* pStruct721_0*/)
        {

            int cnt = 0;
            if (strKey == null)
            {
                return false;
            }
            bool result;
            try
            {
                strKey = strKey.Replace("-", "");
                strKey = strKey.Replace(" ", "");
                if (strKey.Length != 35)
                {
                    return false;
                }
                uint num = 0u;
                uint num2 = 0u;
                //<Module>.smethod_744(pStruct721_0);
                for (int i = strKey.Length - 1; i >= 0; i--)
                {
                    char r = strKey[i];
                    int num3 = (int)r;
                    int num4;
                    if (num3 >= 79)
                    {
                        num4 = num3 - 57;
                    }
                    else if (num3 >= 73)
                    {
                        num4 = num3 - 56;
                    }
                    else if (num3 >= 65)
                    {
                        num4 = num3 - 55;
                    }
                    else
                    {
                        num4 = num3 - 48;
                    }
                    if (i >= strKey.Length - 1)
                    {
                        num = (uint)num4;
                    }
                    else
                    {
                        /*if (1 != < Module >.smethod_723(pStruct721_0, (Struct721*)pStruct721_0, 5))
                        {
                            return false;
                        }
                        if (1 != < Module >.smethod_722(pStruct721_0, (uint)num4))
                        {
                            return false;
                        }*/


                        dfox[cnt] = (uint)(num4);
                        num2 = (uint)(num4 + (int)num2);
                        cnt++;
                    }
                }
                num2 &= 31u;
                if (num == num2)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Trace.TraceError("Exception (traceline {0})\t{1}\n{2}", new object[]
                {
                    294,
                    ex.Message,
                    ex.StackTrace
                });
                result = false;
            }
            return result;
        }
        public bool ConvKey(string strKey, ref byte[] data)
        {
            if (strKey == null)
            {
                return false;
            }
            bool result;
            try
            {
                strKey = strKey.Replace("-", "");
                strKey = strKey.Replace(" ", "");
                if (strKey.Length < 4)
                {
                    return false;
                }
                data = new byte[Math.Min(strKey.Length, this.m_nKeyLength) / 2 - 1];
                uint num = 0u;
                uint num2 = (uint)this.m_nCrcBase;
                for (int i = 0; i <= data.Length; i++)
                {
                    int num3 = Convert.ToInt32(strKey.Substring(i * 2, 2), 16);
                    byte[] array = data;
                    if (i < array.Length)
                    {
                        array[i] = (byte)num3;
                        num2 = (uint)(this.m_nCrcAdd + (num3 ^ (int)num2));
                    }
                    else
                    {
                        num = (uint)num3;
                    }
                }
                num2 &= 255u;
                if (num != num2)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Trace.TraceError("Exception (traceline {0})\t{1}\n{2}", new object[]
                {
                    294,
                    ex.Message,
                    ex.StackTrace
                });
                result = false;
            }
            return result;
        }
        protected void FormatKey(byte[] data, ref string strKey)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int num = Math.Min(data.Length, this.m_nKeyLength / 2 - 1);
            uint num2 = (uint)this.m_nCrcBase;
            int num3 = 0;
            if (0 < num)
            {
                int nCrcAdd = this.m_nCrcAdd;
                do
                {
                    num2 = ((uint)data[num3] ^ num2) + (uint)nCrcAdd;
                    num3++;
                }
                while (num3 < num);
            }
            num2 &= 255u;
            int num4 = 0;
            if (0 < num)
            {
                do
                {
                    if ((num4 & 1) == 0 && num4 > 0)
                    {
                        stringBuilder.Append("-");
                    }
                    byte b = data[num4];
                    stringBuilder.Append(b.ToString("X2"));
                    num4++;
                }
                while (num4 < num);
            }
            uint num5 = num2;
            stringBuilder.Append(num5.ToString("X2"));
            strKey = stringBuilder.ToString();
        }
        public bool GetComputerKey(ref string strComputerKey)
        {
            bool result;
            try
            {
                string str = null;
                ulong num = 0UL;
                if (!this.GetSystemDiskSerialNumber(ref str, ref num))
                {
                    return false;
                }
                ulong num2 = num;
                string s = str + num2.ToString();
                byte[] data = MD5.Create().ComputeHash(Encoding.Default.GetBytes(s));
                this.FormatKey(data, ref strComputerKey);
                return true;
            }
            catch (Exception ex)
            {
                Trace.TraceError("Exception (traceline {0})\t{1}\n{2}", new object[]
                {
                    245,
                    ex.Message,
                    ex.StackTrace
                });
                result = false;
            }
            return result;
        }

        protected bool GetSystemDiskSerialNumber(ref string string_0, ref ulong ulong_0)
        {
            string_0 = "NoSN";
            ulong_0 = 1UL;
            try
            {
                string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2);
                ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID='" + str + "'").Get().GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        ManagementBaseObject managementBaseObject = enumerator.Current;
                        ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = ((ManagementObject)managementBaseObject).GetRelated("Win32_DiskPartition").GetEnumerator();
                        try
                        {
                            while (enumerator2.MoveNext())
                            {
                                ManagementBaseObject managementBaseObject2 = enumerator2.Current;
                                ManagementObjectCollection.ManagementObjectEnumerator enumerator3 = ((ManagementObject)managementBaseObject2).GetRelated("Win32_DiskDrive").GetEnumerator();
                                try
                                {
                                    while (enumerator3.MoveNext())
                                    {
                                        ManagementBaseObject managementBaseObject3 = enumerator3.Current;
                                        ManagementObject managementObject = (ManagementObject)managementBaseObject3;
                                        try
                                        {
                                            ulong_0 = (ulong)managementObject["Size"];
                                            object obj = null;
                                            try
                                            {
                                                if (obj == null)
                                                {
                                                    for (; ; )
                                                    {
                                                        IL_101:
                                                        int num = 437563971;
                                                        for (; ; )
                                                        {
                                                            switch (num ^ 437563970)
                                                            {
                                                                case 1:
                                                                    obj = managementObject["SerialNumber"];
                                                                    num = 437563970;
                                                                    continue;
                                                                case 2:
                                                                    goto IL_101;
                                                            }
                                                            goto Block_20;
                                                        }
                                                    }
                                                    Block_20:;
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            try
                                            {
                                                if (obj == null)
                                                {
                                                    obj = managementObject["Signature"];
                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                            if (obj != null)
                                            {
                                                for (; ; )
                                                {
                                                    IL_15A:
                                                    int num2 = 437563969;
                                                    for (; ; )
                                                    {
                                                        switch (num2 ^ 437563970)
                                                        {
                                                            case 0:
                                                                goto IL_15A;
                                                            case 1:
                                                                goto IL_161;
                                                            case 3:
                                                                string_0 = obj.ToString();
                                                                num2 = 437563971;
                                                                continue;
                                                        }
                                                        goto Block_17;
                                                    }
                                                }
                                                Block_17:
                                                continue;
                                                IL_161:
                                                return true;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                    }
                                }
                                finally
                                {
                                    if (enumerator3 != null)
                                    {
                                        for (; ; )
                                        {
                                            IL_1A4:
                                            int num3 = 437563971;
                                            for (; ; )
                                            {
                                                switch (num3 ^ 437563970)
                                                {
                                                    case 0:
                                                        goto IL_1A4;
                                                    case 1:
                                                        ((IDisposable)enumerator3).Dispose();
                                                        num3 = 437563968;
                                                        continue;
                                                }
                                                goto Block_27;
                                            }
                                        }
                                        Block_27:;
                                    }
                                }
                            }
                        }
                        finally
                        {
                            if (enumerator2 != null)
                            {
                                for (; ; )
                                {
                                    IL_1E2:
                                    int num4 = 437563968;
                                    for (; ; )
                                    {
                                        switch (num4 ^ 437563970)
                                        {
                                            case 0:
                                                goto IL_1E2;
                                            case 2:
                                                ((IDisposable)enumerator2).Dispose();
                                                num4 = 437563971;
                                                continue;
                                        }
                                        goto Block_30;
                                    }
                                }
                                Block_30:;
                            }
                        }
                    }
                }
                finally
                {
                    if (enumerator != null)
                    {
                        for (; ; )
                        {
                            IL_220:
                            int num5 = 437563971;
                            for (; ; )
                            {
                                switch (num5 ^ 437563970)
                                {
                                    case 0:
                                        goto IL_220;
                                    case 1:
                                        ((IDisposable)enumerator).Dispose();
                                        num5 = 437563968;
                                        continue;
                                }
                                goto Block_33;
                            }
                        }
                        Block_33:;
                    }
                }
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
