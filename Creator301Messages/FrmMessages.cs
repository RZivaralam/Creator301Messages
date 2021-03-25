#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraLayout.Utils;

using Microsoft.Win32;
using DevExpress.XtraEditors.Mask;

#endregion

namespace Creator301Messages
{
    public partial class FrmMessages : XtraForm
    {
        public FrmMessages()
        {
            InitializeComponent();
        }

        private void InitualizeTab()
        {
            layoutFKT.Visibility = LayoutVisibility.Never;
            layoutINV_PNV.Visibility = LayoutVisibility.Never;
            layoutNAD.Visibility = LayoutVisibility.Never;
            layoutDPV.Visibility = LayoutVisibility.Never;
            layoutAUF.Visibility = LayoutVisibility.Never;
            layoutDAU.Visibility = LayoutVisibility.Never;
            layoutETL_NDG.Visibility = LayoutVisibility.Never;
            layoutEBG.Visibility = LayoutVisibility.Never;
            layoutFAB.Visibility = LayoutVisibility.Never;
            layoutCUX.Visibility = LayoutVisibility.Never;
            layoutREC.Visibility = LayoutVisibility.Never;
            layoutZLG.Visibility = LayoutVisibility.Never;
            layoutRECFAB.Visibility = LayoutVisibility.Never;
            layoutENT.Visibility = LayoutVisibility.Never;
            layoutBNK.Visibility = LayoutVisibility.Never;
            layoutFHL.Visibility = LayoutVisibility.Never;
            layoutRECAO.Visibility = LayoutVisibility.Never;
            layoutZLGAO.Visibility = LayoutVisibility.Never;
            layoutRZA.Visibility = LayoutVisibility.Never;
            layoutBDG.Visibility = LayoutVisibility.Never;
            layoutPRZ.Visibility = LayoutVisibility.Never;
            layoutENA.Visibility = LayoutVisibility.Never;
            layoutEZV.Visibility = LayoutVisibility.Never;
            layoutLEI.Visibility = LayoutVisibility.Never;
            layoutRED.Visibility = LayoutVisibility.Never;
            layoutRED_SAMU.Visibility = LayoutVisibility.Never;
            layoutUWD.Visibility = LayoutVisibility.Never;
            checkButtonAUF.Appearance.ForeColor = Color.Black;
            checkButtonENTL.Appearance.ForeColor = Color.Black;
            checkButtonRECH.Appearance.ForeColor = Color.Black;
            checkButtonMBEG.Appearance.ForeColor = Color.Black;
            checkButtonINKA.Appearance.ForeColor = Color.Black;
            checkButtonVERL.Appearance.ForeColor = Color.Black;
            checkButtonANFM.Appearance.ForeColor = Color.Black;
            checkButtonAMBO.Appearance.ForeColor = Color.Black;
            checkButtonZGUT.Appearance.ForeColor = Color.Black;
            checkButtonKOUB.Appearance.ForeColor = Color.Black;
            checkButtonKAIN.Appearance.ForeColor = Color.Black;
            checkButtonZAOO.Appearance.ForeColor = Color.Black;
            checkButtonZAHL.Appearance.ForeColor = Color.Black;
            checkButtonSAMU.Appearance.ForeColor = Color.Black;
            checkButtonFEHL.Appearance.ForeColor = Color.Black;
        }
        private List<int> CreateCKZ(int[] RangesVKZ)
        {
            List<int> VKZ = new List<int>();
            VKZ.Clear();
            VKZ.AddRange(RangesVKZ);
            return VKZ;
        }
        private bool PreapreTab()
        {
            bool Ifchecked = false;
            List<int> VKZ = new List<int>();
            if (checkButtonAUF.Checked)
            {
                int[] RangesVKZ = { 10, 20, 30, 31, 32, 33, 34, 35 };
                FillTmpVKZ(CreateCKZ(RangesVKZ));
                checkButtonAUF.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutDPV.Visibility = LayoutVisibility.Always;
                layoutAUF.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonENTL.Checked)
            {
                checkButtonENTL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutDPV.Visibility = LayoutVisibility.Always;
                layoutDAU.Visibility = LayoutVisibility.Always;
                layoutETL_NDG.Visibility = LayoutVisibility.Always;
                layoutEBG.Visibility = LayoutVisibility.Always;
                layoutFAB.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonRECH.Checked)
            {
                checkButtonRECH.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutREC.Visibility = LayoutVisibility.Always;
                layoutZLG.Visibility = LayoutVisibility.Always;
                layoutRECFAB.Visibility = LayoutVisibility.Always;
                layoutENT.Visibility = LayoutVisibility.Always;
                layoutBNK.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonMBEG.Checked)
            {
                checkButtonMBEG.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonINKA.Checked)
            {
                checkButtonINKA.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonVERL.Checked)
            {
                checkButtonVERL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutDPV.Visibility = LayoutVisibility.Always;
                layoutDAU.Visibility = LayoutVisibility.Always;
                layoutFAB.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonANFM.Checked)
            {
                checkButtonANFM.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonAMBO.Checked)
            {
                checkButtonAMBO.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutDPV.Visibility = LayoutVisibility.Always;
                layoutRECAO.Visibility = LayoutVisibility.Always;
                layoutZLGAO.Visibility = LayoutVisibility.Always;
                layoutRZA.Visibility = LayoutVisibility.Always;
                layoutBDG.Visibility = LayoutVisibility.Always;
                layoutPRZ.Visibility = LayoutVisibility.Always;
                layoutENA.Visibility = LayoutVisibility.Always;
                layoutEZV.Visibility = LayoutVisibility.Always;
                layoutLEI.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonZGUT.Checked)
            {
                checkButtonZGUT.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutRED.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonKOUB.Checked)
            {
                checkButtonKOUB.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonKAIN.Checked)
            {
                checkButtonKAIN.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonZAOO.Checked)
            {
                checkButtonZAOO.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonZAHL.Checked)
            {
                checkButtonZAHL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonSAMU.Checked)
            {
                checkButtonSAMU.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutRED_SAMU.Visibility = LayoutVisibility.Never;
                layoutUWD.Visibility = LayoutVisibility.Never;

            }
            if (checkButtonFEHL.Checked)
            {
                checkButtonFEHL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutFHL.Visibility = LayoutVisibility.Always;
            }
            return Ifchecked;
        }
        private string TrimEndMessage(string Messages)
        {
            while (Messages.Substring(Messages.Length - 2) == "+'")
            {
                Messages = Messages.Remove(Messages.ToString().LastIndexOf('+'), 1);
            }
            return Messages;
        }
        private void FillTmpVKZ(List<int> VKZ)
        {
            foreach (var item in VKZ)
            {
                ComboBoxTmp_VKZ.Properties.Items.Add(item);
            }
            ComboBoxTmp_VKZ.SelectedIndex = 0;


        }
        private void ChangeCheckOutTab()
        {
            InitualizeTab();
            checkButtonAUF.Checked = (PreapreTab()) ? checkButtonAUF.Checked : true;
        }
        private void FrmMessages_Load(object sender, EventArgs e)
        {
            dateEditErstelldatum.EditValue = DateTime.Now;
            checkButtonAUF.Checked = true;
            comboBoxEditBegint.SelectedIndex = 0;
            textEditFileName.Text = "Nachricht" + DateTime.Now.ToString("yyyy-MM-dd");
            ChangeCheckOutTab();
        }
        private void CheckOutTab(object sender, EventArgs e)
        {
            ChangeCheckOutTab();
        }
        private string CreateUNB_UNAelement()
        {
            string Messages = TrimEndMessage( string.Format("{0}+{1}+{2}+{3}+{4}+{5}++{6}'", comboBoxEditBegint.Text, textEditSyntax_Nr.EditValue, textEditInput_IK.EditValue, textEditZiel_IK.EditValue, dateEditErstelldatum.DateTime.ToString("yyMMdd:HHmm"), textEditReferenz_Nr.EditValue, textEditFileName.EditValue));

            return Messages;
        }
        private string CreateUNHelement(string MessageType, int CountMessage)
        {
            string Messages;
            MessageType = MessageType + ":15:000:00";
            Messages = String.Format("{0}+{1}+{2}'", "UNH", string.Format("{0:00000}", CountMessage), MessageType);
            return Messages;
        }
        private string CreateFKTelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "FKT", ComboBoxTmp_VKZ.EditValue, textEditTmp_LfdNrGFall.EditValue, textEditTmp_IK.EditValue, textEditZiel_IKFKT.EditValue));
            return Messages;
        }
        private string CreateINVelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}'", "INV",
                    textEditTmp_KvNr.EditValue, textEditTmp_V_Status.EditValue, "", "", "", textEditTmp_AufnNr.EditValue, textEditTmp_KKNr.EditValue,
                    textEditTmp_Zuzahltage.EditValue, "", textEditTmp_VertragsKnz.EditValue));
            

            return Messages;
        }
        private string CreateNADelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}+{11}+{12}'", "NAD", textEditTmp_Nachname.EditValue, textEditTmp_Vorname.EditValue,
                    ComboEditAkt_G.EditValue, dateEditTmp_GDat.DateTime.ToString("yyyyMMdd"), textEditTmpStrasse.EditValue,
                    textEditTmpPLZ.EditValue, textEditTmpOrt.EditValue, textEditTmp_VSt.EditValue,
                    "", textEditAkt_Namenszusatz.EditValue, textEditAkt_Vorsatzwort.EditValue, textEditAkt_Anschriftenzusatz.EditValue));
            return Messages;
        }
        private string CreateDPVelement()
        {
            string Messages;
            string birthdayWithFormat = dateEditTmp_GDat.EditValue.ToString();
            birthdayWithFormat = dateEditTmp_GDat.EditValue.ToString().Substring(6, 4) + dateEditTmp_GDat.EditValue.ToString().Substring(3, 2) +
            dateEditTmp_GDat.EditValue.ToString().Substring(0, 2);
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}'", "DPV", ComboEditICD_Prefix.EditValue, ComboEditOPS_Prefix.EditValue));
            return Messages;
        }
        private string CreateAUFelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}+{11}'", "AUF", dateEditTmp_AufnTag.DateTime.ToString("yyyyMMdd"),
                dateEditTmp_AufnTag.DateTime.ToString("HHmm"), textEditTmp_AufnGrund.EditValue, textEditTmp_AufnFAB.EditValue, dateEditTmp_VorsDauer.DateTime.ToString("yyyyMMdd"),
                textEditTmp_EinwArzt.EditValue, textEditTmp_EinwArztBSNr.EditValue, textEditTmp_EinwIK.EditValue, textEditTmp_EinwStelle.EditValue,
                textEditTmp_EinwZArzt.EditValue, textEditTmp_AufnGewicht.EditValue));
            return Messages;
        }
        private string CreateEADelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}'", "EAD", textEditAufnahmediagnose.EditValue));
            return Messages;
        }
        private string CreateUNTelement( int CountMessage,int CountSegment)
        {
            string Messages;
            Messages = String.Format("{0}+{1}+{2}'", "UNT", CountSegment, string.Format("{0:00000}", CountMessage));
            return Messages;
        }
        private string CreateUNZelement(int CountMessage)
        {
            string Messages;
            Messages = String.Format("{0}+{1}+{2}'", "UNZ", string.Format("{0:00000}", CountMessage), textEditReferenz_Nr.EditValue);
            return Messages;
        }
        private string CreateInhaltMessage()
        {

            int i = 0;
            string Messages;
            Messages = CreateUNB_UNAelement();
            if (checkButtonAUF.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("AUFN", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //DPV
                Messages += CreateDPVelement();
                //AUF
                Messages += CreateAUFelement();
                //EAD
                Messages += CreateEADelement();
                //UNT
                Messages += CreateUNTelement(i, 8);
                

            }
            if (checkButtonENTL.Checked)
            {


            }
            if (checkButtonRECH.Checked)
            {

            }
            if (checkButtonMBEG.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("MBEG", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                

            }
            if (checkButtonINKA.Checked)
            {

            }
            if (checkButtonVERL.Checked)
            {

            }
            if (checkButtonANFM.Checked)
            {

            }
            if (checkButtonAMBO.Checked)
            {

            }
            if (checkButtonZGUT.Checked)
            {

            }
            if (checkButtonKOUB.Checked)
            {

            }
            if (checkButtonKAIN.Checked)
            {

            }
            if (checkButtonZAOO.Checked)
            {

            }
            if (checkButtonZAHL.Checked)
            {

            }
            if (checkButtonSAMU.Checked)
            {


            }
            if (checkButtonFEHL.Checked)
            {

            }
            Messages += CreateUNZelement(i);
            return Messages;

        }
        private void simpleButtonCreateMessage_Click(object sender, EventArgs e)
        {
            CreateFileMessages(CreateInhaltMessage(), textEditFileName.Text + ".txt");
        }
        private string MessagesFileName(string fileName)
        {
            string path = Application.StartupPath + "//data//";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path + fileName;
        }
        private void CreateFileMessages(string Zeile, string fileName)
        {
            try
            {
                if (!File.Exists(MessagesFileName(fileName)))
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(MessagesFileName(fileName)), true))
                    {
                        outputFile.WriteLine(Zeile);
                        outputFile.Close();
                    }
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void dateEditErstelldatum_Popup(object sender, EventArgs e)
        {
        }
    }
}
