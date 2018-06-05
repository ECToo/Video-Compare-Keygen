using System;
using System.Security.Cryptography;

namespace vhtest
{
    public class OldAlgo
    {
        protected int m_nKeyLength = 16;
        protected int m_nCrcBase = 116;
        protected int m_nCrcAdd = 19;
        protected byte[] xor = { 0xEA, 0xE7, 0x36, 0x86, 0x17, 0xCA, 0x28 };
        private Utility ut = new Utility();
        public string Generate(byte lic, string ck)
        {
            HashAlgorithm hashAlgorithm = MD5.Create();
            uint nXorLicense = (uint)new Random().Next();
            //LicenseType licenseType = (LicenseType)nXorLicense;
            //uint nLimiteDate = 0u;
            string strComputerKey = ck;
            byte[] dfox = ut.StringToByteArray(strComputerKey.Replace("-", ""));
            byte[] dfox2 = new byte[dfox.Length - 1 + 5];
            dfox2[0] = 86;
            dfox2[1] = 67;
            Array.Copy(dfox, 0, dfox2, 2, dfox.Length - 1);
            dfox2[9] = lic;
            dfox2[10] = 0xff;
            dfox2[11] = 0x00;
            byte[] dfox3 = hashAlgorithm.ComputeHash(dfox2);
            byte[] dfox4 = new byte[dfox.Length];
            dfox4[0] = lic;
            dfox4[1] = 0xff;
            dfox4[2] = 0x00;
            Array.Copy(dfox3, 0, dfox4, 3, 4);
            int dnum2 = 0;
            do
            {
                dfox4[dnum2] ^= xor[dnum2];
                dnum2++;
            }
            while (dnum2 < dfox4.Length - 1);
            string attiv = ut.ByteArrayToString(dfox4).Substring(0, 14);
            uint ddnum2 = (uint)this.m_nCrcBase;
            for (int i = 0; i <= dfox4.Length - 2; i++)
            {
                int num3 = Convert.ToInt32(attiv.Substring(i * 2, 2), 16);
                ddnum2 = (uint)(this.m_nCrcAdd + (num3 ^ (int)ddnum2));
            }
            ddnum2 &= 255u;
            attiv = (attiv + ddnum2.ToString("X2")).ToUpper();
            return ut.DFX_dividia(4, attiv);
            //Test
            /*string strLicenseKey = textBox3.Text;
            byte[] array = null;
            byte[] array2 = null;
            if (!this.ConvKey(strComputerKey, ref array) || !this.ConvKey(strLicenseKey, ref array2))
            {
                MessageBox.Show("Errore");
                return;
            }
            int num2 = 0;
            do
            {
                array2[num2] ^= xor[num2];
                num2++;
            }
            while (num2 < array2.Length);

            byte[] array3 = new byte[array.Length + 5];
            array3[0] = 86;
            array3[1] = 67;
            Array.Copy(array, 0, array3, 2, array.Length);
            Array.Copy(array2, 0, array3, array.Length + 2, 3);
            byte[] array4 = hashAlgorithm.ComputeHash(array3);
            int num5 = 0;
            int num6 = array2.Length - 3;
            if (0 < num6)
            {
                while (array4[num5] == array2[num5 + 3])
                {
                    num5++;
                    if (num5 >= num6)
                    {
                        goto IL_16F;
                    }
                }
                MessageBox.Show("Errore");
                return;
            }
            IL_16F:
            uint num7 = (uint)array2[0];
            if (num7 != 10u && num7 != 15u && num7 != 20u)
            {
                MessageBox.Show("Errore");
                return;
            }
            licenseType = (LicenseType)(num7 ^ nXorLicense);
            uint num8 = (uint)((int)array2[2] << 16 | (int)array2[1]);
            nLimiteDate = num8;
            //MessageBox.Show((num8 <= 1200u).ToString());
            return;*/
        }
    }
}
