using EventDataAnalyzer_HHP.Data.RawData;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDataAnalyzer_HHP.UI
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();

            
        }

        String EventFilePath { get; set; } = "";

        private void Txt_Filepath_MouseClick(object sender, MouseEventArgs e)
        {


            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // |Xlsx(*.xlsx)|*.xlsx
                ofd.Filter = "Excel|*.xls|(Xlsx)| *.xlsx;";
                ofd.Multiselect = false;
                ofd.Title = "Select the Event data excel file of HHP loco";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    EventFilePath = ofd.FileName;
                }

                Txt_Filepath.Text = EventFilePath;
            }  
        }

        private void Txt_Filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            GetHHPeventDetailList Glist = new GetHHPeventDetailList(eventFileInfo: Txt_Filepath.Text,
                pressureConversion: Chk_IsPsi.Checked,
                startRecordTime: Dtp_ReadFrom.Value,
                endRecordTime: Dtp_ReadTo.Value,
                rowBeign: 1,
                columnBegin: 0,
                dataSheetName: "12028");

            Dgv_ImportEvent.DataSource = Glist.Get_HHPeventdataTask();

        }

        private void Chk_IsPsi_CheckStateChanged(object sender, EventArgs e)
        {
            if (Chk_IsPsi.Checked)
            {
                foreach (var dgvRows in Dgv_ImportEvent.Rows)
                {
                    
                }
            }
        }
    }
}
