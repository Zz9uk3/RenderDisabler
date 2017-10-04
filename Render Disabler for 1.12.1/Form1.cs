using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Magic;
using System.Diagnostics;
using System.Linq;

namespace Render_Disabler_for_1._12._1
{
    public partial class Form1 : Form
    {
        BlackMagic wow = new BlackMagic();
        public Form1()
        {
            InitializeComponent();
        }

        private void bScanForProcess_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Process[] pWowProcesses = Process.GetProcessesByName("WoW");
            foreach (Process p in pWowProcesses)
            {
                wow.Open(p.Id);
                dataGridView1.Rows.Add(wow.ReadUInt(0x00C7B2A4) == 0 ? true : false, p.Id.ToString(), wow.ReadASCIIString((uint)0x827D88 + (uint)wow.MainModule.BaseAddress, 10).Trim());
            }
        }

        private bool ProcessExists(int id)
        {
            return Process.GetProcesses().Any(x => x.Id == id);
        }

        private void bUpdateRenderState_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (ProcessExists(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value)))
                {
                    wow.OpenProcessAndThread(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                    if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                    {
                        wow.WriteUInt(0x00C7B2A4, 0);
                    }
                    else
                    {
                        wow.WriteUInt(0x00C7B2A4, 0x0F110B73);
                    }
                }
            }
        }
    }
}
