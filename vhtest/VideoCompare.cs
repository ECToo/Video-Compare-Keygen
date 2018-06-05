using System;
using System.Windows.Forms;

namespace vhtest
{
    public partial class Form1 : Form
    {
        public enum LicenseType
        {
            ProEdition = 20,
            ExpertEdition = 15,
            HomeEdition = 10,
            Unvalid = 0,
            Free
        }
        private NewAlgo na = new NewAlgo();
        private OldAlgo oa = new OldAlgo();
        private Utility ut = new Utility();
        private byte lic = new byte();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strComputerKey = "";
            ut.GetComputerKey(ref strComputerKey);
            tci.Text = strComputerKey;
            esegui();
        }
        private void rh_CheckedChanged(object sender, EventArgs e)
        {
            esegui();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            esegui();
        }
        private void esegui()
        {
            if (rp.Checked)
                lic = 0x14;
            else if (re.Checked)
                lic = 0xF;
            else if (rh.Checked)
                lic = 0xA;
            if (!c106.Checked)
            {
                tSerial.Text = oa.Generate(lic, tci.Text);
            }
            else
            {
                //TODo New Algo for v1.06 >
                tSerial.Text = na.Generate(lic, tci.Text);
                MessageBox.Show("In Todo...");
            }
        }
        private void c106_CheckedChanged(object sender, EventArgs e)
        {
            esegui();
        }
    }
}
