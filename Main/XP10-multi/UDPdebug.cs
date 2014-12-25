using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP10_multi
{
    public partial class UDPdebug : Form
    {
        public UDPdebug()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UDPdebug_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_clear_Click(object sender, EventArgs e)
        {
            TB_message.Clear();
        }

        private void BT_reset_Click(object sender, EventArgs e)
        {
            TB_destIP.Clear();
            TB_destPort.Clear();
            TB_listPort.Clear();
            TB_message.Clear();
            TB_status.Clear();
        }

        private void TB_message_TextChanged(object sender, EventArgs e)
        {
            
        }        
    }
}
