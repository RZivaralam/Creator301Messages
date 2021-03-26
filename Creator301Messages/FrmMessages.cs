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
        private SamuElement SAMU;
        private List<SamuElement> SAMUList;
        private FabElement FAB;
        private List<FabElement> FABList;
        #region Preapre Tabs
        private void InitualizeTab()
        {
            layoutFKT.Visibility = LayoutVisibility.Never;
            layoutINV_PNV.Visibility = LayoutVisibility.Never;
            layoutNAD.Visibility = LayoutVisibility.Never;
            layoutDPV.Visibility = LayoutVisibility.Never;
            layoutAUF.Visibility = LayoutVisibility.Never;
            layoutDAU.Visibility = LayoutVisibility.Never;
            layoutEAD.Visibility = LayoutVisibility.Never;
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
            layoutPVV.Visibility = LayoutVisibility.Never;
            layoutPVT.Visibility = LayoutVisibility.Never;
            layoutZPR.Visibility = LayoutVisibility.Never;
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
                layoutPVV.Visibility = LayoutVisibility.Always;
                layoutPVT.Visibility = LayoutVisibility.Always;
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
                layoutTXT.Visibility = LayoutVisibility.Always;
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
                layoutTXT.Visibility = LayoutVisibility.Always;
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
                layoutZPR.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonSAMU.Checked)
            {
                checkButtonSAMU.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutRED_SAMU.Visibility = LayoutVisibility.Always;
                layoutUWD.Visibility = LayoutVisibility.Always;

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
            PreapreTab();
           // checkButtonAUF.Checked = (PreapreTab()) ? checkButtonAUF.Checked : true;
        }
        private void FrmMessages_Load(object sender, EventArgs e)
        {
            dateEditErstelldatum.EditValue = DateTime.Now;
            checkButtonAUF.Checked = true;
            comboBoxEditBegint.SelectedIndex = 0;
            comboBoxEditTMP_Currency.SelectedIndex = 0;
            textEditFileName.Text = "Nachricht" + DateTime.Now.ToString("yyyy-MM-dd");
            SAMUList = new List<SamuElement>();
            FABList = new List<FabElement>();
            ChangeCheckOutTab();
        }
        private void CheckOutTab(object sender, EventArgs e)
        {
            ChangeCheckOutTab();
        }
        #endregion
        #region Create Message Content
        private string TrimEndMessage(string Messages)
        {
            while (Messages.Substring(Messages.Length - 2) == "+'")
            {
                Messages = Messages.Remove(Messages.ToString().LastIndexOf('+'), 1);
            }
            return Messages;
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
        private string CreateUNTelement(int CountMessage, int CountSegment)
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
        private string CreateFKTelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "FKT", ComboBoxTmp_VKZ.EditValue, textEditTmp_LfdNrGFall.EditValue, textEditZiel_IKFKT.EditValue, textEditTmp_IK.EditValue));
            return Messages;
        }
        private string CreateFKTWBelement()
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
        private string CreateEADelement(ref int count)
        {
            string Messages="";
            foreach (CheckedListBoxItem item in CheckedCombiEditAufnahmediagnose.Properties.Items)
            {
                if(item.CheckState == CheckState.Checked)
                {
                    Messages += TrimEndMessage(String.Format("{0}+{1}'", "EAD", item));
                    count = count + 1;
                }
            }
            return Messages;
        }
        private string CreatePVVelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "PVT",textEditInfo.EditValue , textEditRechnungsNR.EditValue, dateEditRechnungDatum.DateTime.ToString("yyyyMMdd")));
            return Messages;
        }
        private string CreateREDelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}'", "RED", textEditTmp_RgNr.EditValue, dateEditTmp_RgDatum.DateTime.ToString("yyyyMMdd"), textEditTmp_RgBetrag.EditValue,"",
                textEditTmp_RgArt.EditValue,"","", textEditTmp_IKZahlweg.EditValue));
            return Messages;
        }
        private string CreateCUXelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}'", "CUX", comboBoxEditTMP_Currency.EditValue.ToString().Substring(0,3)));
            return Messages;
        }
        private string CreatePVTelement(ref int count)
        {
            string Messages="";
            foreach (CheckedListBoxItem item in checkedComboBoxEditPrfTextList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    Messages = TrimEndMessage(String.Format("{0}+{1}'", "PVT", item));
                    count = count + 1;
                }
            }
            return Messages;
        }
        private string CreateRED_SAMUelement(ref int count)
        {
            string Messages = "";
            
            foreach (CheckedListBoxItem item in checkedComboBoxEditSamuElementList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    SAMU =(SamuElement) item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}'", "RED",SAMU.Rech_Nr ,"","","",SAMU.Rech_Art,"",SAMU.Aufn_Nr));
                    count = count + 1;
                }
            }
            return Messages;
        }
        private string CreateTXTelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_TextANFMList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    
                    Messages += TrimEndMessage(String.Format("{0}+{1}'", "TXT",item));
                    count = count + 1;
                }
            }
            return Messages;
        }
        private string CreateFABelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditFABList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    FAB = (FabElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "FAB", FAB.fab_FAbt,FAB.fab_DGLok, FAB.fab_SekDLok));
                    count = count + 1;
                }
            }
            return Messages;
        }
        private string CreateUWDelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "UWD","","","", textEditTmp_SammelbelegNr.EditValue));
            return Messages;
        }
        private string CreateZPRelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}'", "ZPR",textEditZPR_Betrag.EditValue, textEditZPR_PV.EditValue));
            return Messages;
        }
        private string CreateDAUelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}'", "DAU",  dateEditTmp_AufnTagDAU.DateTime.ToString("yyyyMMdd"),
                dateEditTmp_EntlTag.DateTime.ToString("yyyyMMdd"), textEditTmp_NF_Diag_1.EditValue, textEditTmp_NF_Diag_2.EditValue, 
                textEditTmp_NF_ab.EditValue, textEditTmp_BeatmStd.EditValue));
            return Messages;
        }
        private string CreateKOSelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "KOS","", textEditKOS_KUEM.EditValue,"", textEditKOS_Bis.EditValue));
            return Messages;
        }
        #endregion
        #region Create the whole Messages
        private string CreateInhaltMessage()
        {

            int i = 0;
            int Count = 0;
            string Messages;
            Messages = CreateUNB_UNAelement();
            #region AufN Nachricht
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
                Messages += CreateEADelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 8+ Count);

            }
            #endregion
    
            if (checkButtonENTL.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("ENTL", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //DPV
                Messages += CreateDPVelement();
                //DAU
                Messages += CreateDAUelement();
                //ETL
                //EBG
                //FAB
                Messages += CreateFABelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 7 + Count);

            }
            if (checkButtonRECH.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("ENTL", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //CUX
                Messages += CreateCUXelement();
                //REC
                //ZLG
                //RECFAB
                //ENT
                //BNK
                //UNT
                Messages += CreateUNTelement(i, 7 + Count);

            }
            #region MBEG Nachricht
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
                //UNT
                Messages += CreateUNTelement(i, 5);
            }
            #endregion
            #region INKA Nachricht
            if (checkButtonINKA.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("INKA", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //PVV
                Messages += CreatePVVelement();
                //PVT
                Messages += CreatePVTelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 6+Count);
            }
            #endregion
            #region VERL Nachricht
            if (checkButtonVERL.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("VERL", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //DPV
                Messages += CreateDPVelement();
                //DAU
                Messages += CreateDAUelement();
                //FAB
                Messages += CreateFABelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 7 + Count);
            }
            #endregion
            #region ANFM Nachricht
            if (checkButtonANFM.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("ANFM", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //TXT
                Messages += CreateTXTelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 5+Count);
            }
            #endregion
            if (checkButtonAMBO.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("ENTL", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //CUX
                Messages += CreateCUXelement();
                //DPV
                Messages += CreateDPVelement();
                //RECAO
                //ZLGAO
                //RZA
                //BDG
                //PRZ
                //ENA
                //EZV
                //LEI
                //UNT
                Messages += CreateUNTelement(i, 7 + Count);

            }
            #region ZGUT Nachricht
            if (checkButtonZGUT.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("ZGUT", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //CUX
                Messages += CreateCUXelement();
                //RED
                Messages += CreateREDelement();
                //UNT
                Messages += CreateUNTelement(i, 7);
            }
            #endregion
            #region KOUB Nachricht
            if (checkButtonKOUB.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("KOUB", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //KOS
                Messages += CreateKOSelement();
                //TXT
                Messages += CreateTXTelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 6+Count);
            }
            #endregion
            #region KIAN Nachricht
            if (checkButtonKAIN.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("KAIN", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //UNT
                Messages += CreateUNTelement(i, 5);
            }
            #endregion
            #region ZAOO Nachricht
            if (checkButtonZAOO.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("ZAOO", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //CUX
                Messages += CreateCUXelement();
                //UNT
                Messages += CreateUNTelement(i, 6);
            }
            #endregion
            #region ZAHL Nachricht
            if (checkButtonZAHL.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("ZAHL", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //CUX
                Messages += CreateCUXelement();
                //ZPR
                Messages += CreateZPRelement();
                //UNT
                Messages += CreateUNTelement(i, 7);
            }
            #endregion
            #region SAMU Nachricht
            if (checkButtonSAMU.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("SAMU", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //CUX
                Messages += CreateCUXelement();
                //RED_SAMU
                Count = 0;
                Messages += CreateRED_SAMUelement(ref Count);
                //UWD
                Messages += CreateUWDelement();
                //UNT
                Messages += CreateUNTelement(i, 5+Count);

            }
            #endregion
            #region FEHL Nachricht
            if (checkButtonFEHL.Checked)
            {
                i = i + 1;
                Messages += CreateUNHelement("FEHL", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
///muss ändern
                //UNT
                Messages += CreateUNTelement(i, 5);
            }
            #endregion
            Messages += CreateUNZelement(i);
            return Messages;

        }
        #endregion
        #region Save Message in File
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
        #endregion
        #region List Function
        private void simpleButtonADD_Click(object sender, EventArgs e)
        {
            SAMU = new SamuElement();
            SAMU.Aufn_Nr = textEditAufn_Nr.EditValue.ToString();
            SAMU.Rech_Nr= textEditRech_Nr.EditValue.ToString();
            SAMU.Rech_Art = textEditRech_Art.EditValue.ToString();
            checkedComboBoxEditSamuElementList.Properties.Items.Add(SAMU);
            SAMUList.Add(SAMU);
            checkedComboBoxEditSamuElementList.Properties.Items[checkedComboBoxEditSamuElementList.Properties.Items.Count - 1].Description = "Rech_Nr : " + SAMU.Rech_Nr + " Aufn_Nr : " + SAMU.Aufn_Nr;
            checkedComboBoxEditSamuElementList.Properties.Items[0].CheckState = CheckState.Checked;
        }

        private void simpleButtonADDdiagnose_Click(object sender, EventArgs e)
        {
            CheckedCombiEditAufnahmediagnose.Properties.Items.Add(textEditlayoutControlItemAufnahmediagnose.EditValue);
            CheckedCombiEditAufnahmediagnose.Properties.Items[CheckedCombiEditAufnahmediagnose.Properties.Items.Count - 1].Description = ""+textEditlayoutControlItemAufnahmediagnose.EditValue;
            CheckedCombiEditAufnahmediagnose.Properties.Items[CheckedCombiEditAufnahmediagnose.Properties.Items.Count - 1].CheckState = CheckState.Checked;
        }

        private void simpleButtonADDTextANFM_Click(object sender, EventArgs e)
        {
            checkedComboBoxEditTmp_TextANFMList.Properties.Items.Add(memoEditTmp_TextANFM.EditValue);
            checkedComboBoxEditTmp_TextANFMList.Properties.Items[checkedComboBoxEditTmp_TextANFMList.Properties.Items.Count - 1].Description =""+  memoEditTmp_TextANFM.EditValue;
            checkedComboBoxEditTmp_TextANFMList.Properties.Items[checkedComboBoxEditTmp_TextANFMList.Properties.Items.Count - 1].CheckState = CheckState.Checked;
        }

        private void simpleButtonADDPrfText_Click(object sender, EventArgs e)
        {
            checkedComboBoxEditPrfTextList.Properties.Items.Add(memoEditPrfText.EditValue);
            checkedComboBoxEditPrfTextList.Properties.Items[checkedComboBoxEditPrfTextList.Properties.Items.Count - 1].Description = "" + memoEditPrfText.EditValue;
            checkedComboBoxEditPrfTextList.Properties.Items[checkedComboBoxEditPrfTextList.Properties.Items.Count - 1].CheckState = CheckState.Checked;
        }

        private void simpleButtonADDFAB_Click(object sender, EventArgs e)
        {
            FAB = new FabElement();
            FAB.fab_FAbt = textEditfab_FAbt.EditValue.ToString();
            FAB.fab_DGLok = textEditfab_DG.EditValue.ToString();
            FAB.fab_SekDLok = textEditfab_SekD.EditValue.ToString();
            checkedComboBoxEditFABList.Properties.Items.Add(FAB);
            FABList.Add(FAB);
            checkedComboBoxEditFABList.Properties.Items[checkedComboBoxEditFABList.Properties.Items.Count - 1].Description = "Abteilung : " + FAB.fab_FAbt ;
            checkedComboBoxEditFABList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        #endregion
    }
}
