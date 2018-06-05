using System;
using System.Security.Cryptography;

namespace vhtest
{
    public class NewAlgo
    {
        private Utility ut = new Utility();

        public string Generate(byte lic, string ck)
        {
            byte[] array = null;
            string c = "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";//35 digit of serial
            if (!ut.ConvKey(ck, ref array))
            {
                return "";
            }
            /*Struct721 @struct;
			<Module>.smethod_744(&@struct);*/
            if (!ut.ConvKey2(c/*, &@struct*/))
            {
                return "";
            };
            /*Struct721 struct2;
			<Module>.smethod_744(&struct2);
			if (1 != <Module>.smethod_743(&struct2, (Struct721*)(&@struct), 56))
			{
				return false;
			}
			Struct721 struct3;
			<Module>.smethod_744(&struct3);
			if (<Module>.smethod_742(&struct3, (Struct721*)(&@struct)) == null)
			{
				return false;
			}
			if (1 != <Module>.smethod_741(&struct3, 56))
			{
				return false;
			}*/
            byte[] array2 = new byte[7];
            /*Struct728 struct4;
			initblk(ref struct4, 0, 16);
			if ((<Module>.smethod_740((Struct721*)(&struct3)) + 7) / 8 > 16)
			{
				return false;
			}*/
            int num = 7;//< Module >.smethod_739((Struct721*)(&struct3), (byte*)(&struct4)); 0 to 7
            int num2 = array2.Length;
            if (num > num2 || num < 0)
            {
                return "";
            }
            int num3 = num2 - num;
            for (int i = 0; i < num3; i++)
            {
                array2[i] = 0;
            }
            for (int j = 0; j < num; j++)
            {
                array2[j + num3] = (byte)ut.dfox[j];
            }
            byte[] array3 = new byte[array2.Length];
            if (!this.method_11(array2, array3))
            {
                return "";
            }
            uint num4 = (uint)(((int)array3[2] << 8 | (int)array3[1]) << 8 | (int)array3[0]);
            /*Struct721 struct5;
			<Module>.smethod_744(&struct5);
			bool result;*/
            uint num5 = (uint)(((int)array3[2] << 8 | (int)array3[1]) << 8 | (int)array3[0]);
            HashAlgorithm hashAlgorithm = SHA1.Create();
            byte[] array4 = new byte[16];
            array4[0] = 86;
            array4[1] = 67;
            Array.Copy(array2, 0, array4, 2, array2.Length);
            Array.Copy(array, 0, array4, array2.Length + 2, array.Length);
            byte[] array5 = hashAlgorithm.ComputeHash(array4);
            /*Struct720 struct8;
			initblk(ref struct8, 0, 64);
			if (array5 == null || array5.Length > 64)
			{
				return false;
			}
			for (int k = 0; k < array5.Length; k++)
			{
				*(k + ref struct8) = array5[k];
			}*/
            uint num10 = (uint)((int)array3[4] << 8 | (int)array3[3]);
            num10 &= 31u;
            if (num10 != 10u && num10 != 15u && num10 != 20u)
            {
                return "";
            }
            return "";
        }
        protected bool method_11(byte[] byte_0, byte[] byte_1)
        {
            int num = byte_0.Length;
            if (byte_1.Length < num)
            {
                return false;
            }
            int num2 = 120;
            int num3 = num - 1;
            if (num3 >= 0)
            {
                do
                {
                    byte b = byte_0[num3];
                    int num4 = (int)b;
                    byte_1[num3] = (byte)((num2 >> 2) * (num2 >> 1) ^ (int)(b + 106));
                    num2 = (num4 * 3 + num3 & 65535) + num2;
                    num3--;
                }
                while (num3 >= 0);
            }
            num2 = 69;
            int num5 = 0;
            if (0 < byte_0.Length)
            {
                do
                {
                    byte b2 = byte_1[num5];
                    int num6 = (int)b2;
                    byte_1[num5] = (byte)((num2 >> 2) * (num2 >> 1) ^ (int)(b2 - 33));
                    num2 = (num6 * 3 + num5 & 65535) + num2;
                    num5++;
                }
                while (num5 < byte_0.Length);
            }
            return true;
        }
    }
}
