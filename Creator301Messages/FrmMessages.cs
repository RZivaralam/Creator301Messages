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
        private RedElement RED;
        private List<RedElement> REDList;
        private FabElement FAB;
        private List<FabElement> FABList;
        private NdgElement NDG;
        private List<NdgElement> NDGList;
        private EntElement ENT;
        private List<EntElement> ENTList;
        private EadElement EAD;
        private List<EadElement> EADList;
        private PrzElement PRZ;
        private List<PrzElement> PRZList;
        private EzvElement EZV;
        private List<EzvElement> EZVList;
        private LeiElement LEI;
        private List<LeiElement> LEIList;
        private PvtElement PVT;
        private List<PvtElement> PVTList;
        private BdgElement BDG;
        private List<BdgElement> BDGList;
        private EnaElement ENA;
        private List<EnaElement> ENAList;
        private TxtElement TXT;
        private List<TxtElement> TXTList;
        private RelElement REL;
        private List<RelElement> RELList;
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
            layoutENT.Visibility = LayoutVisibility.Never;
            layoutBNK.Visibility = LayoutVisibility.Never;
            layoutFHL.Visibility = LayoutVisibility.Never;
            layoutRZA.Visibility = LayoutVisibility.Never;
            layoutBDG.Visibility = LayoutVisibility.Never;
            layoutPRZ.Visibility = LayoutVisibility.Never;
            layoutENA.Visibility = LayoutVisibility.Never;
            layoutEZV.Visibility = LayoutVisibility.Never;
            layoutLEI.Visibility = LayoutVisibility.Never;
            layoutRED.Visibility = LayoutVisibility.Never;
            layoutRED.Visibility = LayoutVisibility.Never;
            layoutUWD.Visibility = LayoutVisibility.Never;
            layoutPVV.Visibility = LayoutVisibility.Never;
            layoutPVT.Visibility = LayoutVisibility.Never;
            layoutZPR.Visibility = LayoutVisibility.Never;
            layoutSTA.Visibility = LayoutVisibility.Never;
            layoutKOS.Visibility = LayoutVisibility.Never;
            layoutTXT.Visibility = LayoutVisibility.Never;
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
            #region AUFN Nachricht
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
                layoutEAD.Visibility = LayoutVisibility.Always; //20x möglich
            }
            #endregion
            #region ENTL Nachricht
            if (checkButtonENTL.Checked)
            {
                checkButtonENTL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutSTA.Visibility = LayoutVisibility.Always; //99x möglich
                layoutDPV.Visibility = LayoutVisibility.Always; 
                layoutDAU.Visibility = LayoutVisibility.Always;
                layoutETL_NDG.Visibility = LayoutVisibility.Always; //ETL–NDG 999x möglich NDG 40x möglich
                layoutEBG.Visibility = LayoutVisibility.Always; //2x möglich
                layoutFAB.Visibility = LayoutVisibility.Always; //999x möglich
            }
            #endregion
            #region RECH Nachricht
            if (checkButtonRECH.Checked)
            {
                checkButtonRECH.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutSTA.Visibility = LayoutVisibility.Always; //99x möglich
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutREC.Visibility = LayoutVisibility.Always;
                layoutZLG.Visibility = LayoutVisibility.Always;
                layoutFAB.Visibility = LayoutVisibility.Always; //30x möglich
                layoutENT.Visibility = LayoutVisibility.Always; //98x möglich
                layoutBNK.Visibility = LayoutVisibility.Always;
            }
            #endregion
            #region MBEG Nachricht
            if (checkButtonMBEG.Checked)
            {
                checkButtonMBEG.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutTXT.Visibility = LayoutVisibility.Always; //10x möglich
            }
            #endregion
            #region AMBO Nachricht
            if (checkButtonINKA.Checked)
            {
                checkButtonINKA.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutPVV.Visibility = LayoutVisibility.Always; //10x möglich
                layoutPVT.Visibility = LayoutVisibility.Always; //25x möglich
            }
            #endregion
            #region VERL Nachricht
            if (checkButtonVERL.Checked)
            {
                checkButtonVERL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutDPV.Visibility = LayoutVisibility.Always;
                layoutDAU.Visibility = LayoutVisibility.Always;
                layoutFAB.Visibility = LayoutVisibility.Always; //10x möglich
            }
            #endregion
            #region ANFM Nachricht
            if (checkButtonANFM.Checked)
            {
                checkButtonANFM.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutTXT.Visibility = LayoutVisibility.Always; //10x möglich
            }
            #endregion
            #region AMBO Nachricht
            if (checkButtonAMBO.Checked)
            {
                checkButtonAMBO.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutDPV.Visibility = LayoutVisibility.Always;
                layoutREC.Visibility = LayoutVisibility.Always;
                layoutZLG.Visibility = LayoutVisibility.Always;
                layoutRZA.Visibility = LayoutVisibility.Always;
                layoutBDG.Visibility = LayoutVisibility.Always;  //99x möglich
                layoutPRZ.Visibility = LayoutVisibility.Always; //99x möglich
                layoutENA.Visibility = LayoutVisibility.Always; //99x möglich
                layoutEZV.Visibility = LayoutVisibility.Always; //99x möglich
                layoutLEI.Visibility = LayoutVisibility.Always; //999x möglich
            }
            #endregion
            #region ZGUT Nachricht
            if (checkButtonZGUT.Checked)
            {
                checkButtonZGUT.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutRED.Visibility = LayoutVisibility.Always; //1x möglich
            }
            #endregion
            #region KOUB Nachricht
            if (checkButtonKOUB.Checked)
            {
                checkButtonKOUB.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutKOS.Visibility = LayoutVisibility.Always;
                layoutTXT.Visibility = LayoutVisibility.Always;
            }
            #endregion
            #region KAIN Nachricht
            if (checkButtonKAIN.Checked)
            {
                checkButtonKAIN.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutPVV.Visibility = LayoutVisibility.Always; //10x möglich
                layoutPVT.Visibility = LayoutVisibility.Always; //25x möglich
            }
            #endregion
            #region ZAOO Nachricht
            if (checkButtonZAOO.Checked)
            {
                checkButtonZAOO.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutREC.Visibility = LayoutVisibility.Always;
                layoutZPR.Visibility = LayoutVisibility.Always;
                layoutZLG.Visibility = LayoutVisibility.Always;
                layoutENA.Visibility = LayoutVisibility.Always; //999x möglich
                layoutEZV.Visibility = LayoutVisibility.Always; //30x möglich
            }
            #endregion
            #region ZAHL Nachricht
            if (checkButtonZAHL.Checked)
            {
                checkButtonZAHL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutZLG.Visibility = LayoutVisibility.Always;
                layoutZPR.Visibility = LayoutVisibility.Always;
                layoutENT.Visibility = LayoutVisibility.Always; //99x möglich
            }
            #endregion
            #region SAMU Nachricht
            if (checkButtonSAMU.Checked)
            {
                checkButtonSAMU.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutRED.Visibility = LayoutVisibility.Always; //99999x möglic
                layoutREL.Visibility = LayoutVisibility.Always; //999x möglich
                layoutUWD.Visibility = LayoutVisibility.Always;

            }
            #endregion
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
            comboBoxEditSpecialPerson.SelectedIndex = 0;
            textEditFileName.Text = "Nachricht" + DateTime.Now.ToString("yyyy-MM-dd");
            REDList = new List<RedElement>();
            FABList = new List<FabElement>();
            NDGList = new List<NdgElement>();
            ENTList = new List<EntElement>();
            EADList = new List<EadElement>();
            PRZList = new List<PrzElement>();
            EZVList = new List<EzvElement>();
            LEIList = new List<LeiElement>();
            PVTList = new List<PvtElement>();
            BDGList = new List<BdgElement>();
            ENAList = new List<EnaElement>();
            TXTList = new List<TxtElement>();
            RELList = new List<RelElement>();
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
        #region UNA Segment
        private string CreateUNB_UNAelement()
        {
            string Messages = TrimEndMessage( string.Format("{0}+{1}+{2}+{3}+{4}+{5}++{6}'", comboBoxEditBegint.Text, textEditSyntax_Nr.EditValue, textEditInput_IK.EditValue, textEditZiel_IK.EditValue, dateEditErstelldatum.DateTime.ToString("yyMMdd:HHmm"), textEditReferenz_Nr.EditValue, textEditFileName.EditValue));

            return Messages;
        }
        #endregion
        #region UNH Segment
        private string CreateUNHelement(string MessageType, int CountMessage)
        {
            string Messages;
            MessageType = MessageType + ":15:000:00";
            Messages = String.Format("{0}+{1}+{2}'", "UNH", string.Format("{0:00000}", CountMessage), MessageType);
            return Messages;
        }
        #endregion
        #region UNT Segment
        private string CreateUNTelement(int CountMessage, int CountSegment)
        {
            string Messages;
            Messages = String.Format("{0}+{1}+{2}'", "UNT", CountSegment, string.Format("{0:00000}", CountMessage));
            return Messages;
        }
        #endregion
        #region UNZ Segment
        private string CreateUNZelement(int CountMessage)
        {
            string Messages;
            Messages = String.Format("{0}+{1}+{2}'", "UNZ", string.Format("{0:00000}", CountMessage), textEditReferenz_Nr.EditValue);
            return Messages;
        }
        #endregion
        #region FKT Segment
        private string CreateFKTelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "FKT", ComboBoxTmp_VKZ.EditValue, textEditTmp_LfdNrGFall.EditValue, textEditZiel_IKFKT.EditValue, textEditTmp_IK.EditValue));
            return Messages;
        }
        #endregion
        #region FKT backway Segment
        private string CreateFKTWBelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "FKT", ComboBoxTmp_VKZ.EditValue, textEditTmp_LfdNrGFall.EditValue, textEditTmp_IK.EditValue, textEditZiel_IKFKT.EditValue));
            return Messages;
        }
        #endregion
        #region INV Segment
        private string CreateINVelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}'", "INV",
                    textEditTmp_KvNr.EditValue, textEditTmp_V_Status.EditValue, comboBoxEditSpecialPerson.EditValue.ToString().Substring(0,2), textEditDMP.EditValue, textEditTmp_AufnNr.EditValue, textEditTmp_KKNr.EditValue,
                    textEditFallnr.EditValue, textEditAktSignKK.EditValue, dateEditTmp_Zuzahltage.EditValue, textEditAktSignKK.EditValue));
            

            return Messages;
        }
        #endregion
        #region NAD Segment
        private string CreateNADelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}+{11}+{12}'", "NAD", textEditTmp_Nachname.EditValue, textEditTmp_Vorname.EditValue,
                    ComboEditAkt_G.EditValue, dateEditTmp_GDat.DateTime.ToString("yyyyMMdd"), textEditTmpStrasse.EditValue,
                    textEditTmpPLZ.EditValue, textEditTmpOrt.EditValue, textEditTmp_VSt.EditValue,
                    textEditInterLand.EditValue, textEditAkt_Namenszusatz.EditValue, textEditAkt_Vorsatzwort.EditValue, textEditAkt_Anschriftenzusatz.EditValue));
            return Messages;
        }
        #endregion
        #region DPV Segment
        private string CreateDPVelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}'", "DPV", ComboEditICD_Prefix.EditValue, ComboEditOPS_Prefix.EditValue));
            return Messages;
        }
        #endregion
        #region AUF Segment
        private string CreateAUFelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}+{11}'", "AUF", dateEditTmp_AufnTag.DateTime.ToString("yyyyMMdd"),
                dateEditTmp_AufnTag.DateTime.ToString("HHmm"), textEditTmp_AufnGrund.EditValue, textEditTmp_AufnFAB.EditValue, dateEditTmp_VorsDauer.DateTime.ToString("yyyyMMdd"),
                textEditTmp_EinwArzt.EditValue, textEditTmp_EinwArztBSNr.EditValue, textEditTmp_EinwIK.EditValue, textEditTmp_EinwStelle.EditValue,
                textEditTmp_EinwZArzt.EditValue, textEditTmp_AufnGewicht.EditValue));
            return Messages;
        }
        #endregion
        #region EAD Segment
        private string CreateEADelement(ref int count)
        {
            string Messages = "";
            foreach (CheckedListBoxItem item in CheckedCombiEditAufnahmediagnose.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    EAD = (EadElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "EAD", EAD.Aufnahmediagnose, EAD.SEAufnahmediagnose,
                        EAD.EinDiagnose, EAD.SEEinDiagnose));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region PVV Segment
        private string CreatePVVelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "PVV",textEditInfo.EditValue , textEditRechnungsNR.EditValue, dateEditRechnungDatum.DateTime.ToString("yyyyMMdd")));
            return Messages;
        }
        #endregion
        #region PVT Segment 
        private string CreatePVTelement(ref int count)
        {
            string Messages = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEditPrfTextList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    PVT = (PvtElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}'", "PVT", PVT.prfvText, PVT.prfvH,
                        PVT.prfHSek, PVT.PrfN, PVT.prfNSek,PVT.prfPrZ));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region CUX Segment
        private string CreateCUXelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}'", "CUX", comboBoxEditTMP_Currency.EditValue.ToString().Substring(0, 3)));
            return Messages;
        }
        #endregion
        #region DAU Segment
        private string CreateDAUelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}'", "DAU", dateEditTmp_AufnTagDAU.DateTime.ToString("yyyyMMdd"),
                dateEditTmp_EntlTag.DateTime.ToString("yyyyMMdd"), textEditTmp_NF_Diag_1.EditValue, textEditTmp_NF_Diag_2.EditValue,
                textEditTmp_NF_ab.EditValue, textEditTmp_BeatmStd.EditValue));
            return Messages;
        }
        #endregion
        #region ETL / NDG Segment
        private string CreateETLNDGelement(ref int count)
        {
            string Messages = "";
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}'", "ETL", dateEditetl_Datum.DateTime.ToString("yyyyMMdd"),
                dateEditetl_Datum.DateTime.ToString("HHmm"), textEditetl_Grund.EditValue, textEditetl_FAbt.EditValue,
                textEditetl_HDlok, textEditetl_SekDlok.EditValue, textEditetl_aufnIK.EditValue));
            count = count + 1;

            foreach (CheckedListBoxItem item in checkedComboBoxEditNDGList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    NDG = (NdgElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}'", "NDG", NDG.ndg_NDLok, NDG.ndg_SekDLok));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region EBG Segment
        private string CreateEBGelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_EBGList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {

                    Messages += TrimEndMessage(String.Format("{0}+{1}'", "EBG", item));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region FAB Segment
        private string CreateFABelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditFABList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    FAB = (FabElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}'", "FAB", FAB.fab_FAbt, FAB.fab_DGLok, FAB.fab_SekDLok, FAB.fab_ZDG,
                        FAB.fab_ZSekD, FAB.fab_OPT, FAB.fab_OP));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region STA Segment
        private string CreateSTAelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditFABList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    FAB = (FabElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}'", "FAB", FAB.fab_FAbt, FAB.fab_DGLok, FAB.fab_SekDLok, FAB.fab_ZDG,
                        FAB.fab_ZSekD, FAB.fab_OPT, FAB.fab_OP));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region REC Segment
        private string CreateRECelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}'", "REC", textEditTmp_RgNrREC.EditValue, dateEditTmp_RgDatumREC.DateTime.ToString("yyyyMMdd"),
                textEditTmp_RgArtREC.EditValue, dateEditTmp_AufnTagREC.DateTime.ToString("yyyyMMdd"), textEditTmp_RgBetragREC.EditValue,
                textEditTmp_DebNrREC.EditValue, textEditTmp_RefNrREC.EditValue, textEditTmp_IKZahlwegREC.EditValue, textEditHonorSu.EditValue, textEditPau.EditValue));
            return Messages;
        }
        #endregion
        #region ZLG Segment
        private string CreateZLGelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}'", "ZLG", textEditTmp_Zuzahlbetrag.EditValue, textEditTmp_Zuzahlkennzeichen.EditValue));
            return Messages;
        }
        #endregion
        #region ENT Segment
        private string CreateENTelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_ENTList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    ENT = (EntElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}'", "ENT", ENT.Ent_Art, ENT.Ent_Betrag, ENT.Ent_von, ENT.Ent_bis,
                        ENT.Ent_Anz, ENT.Ent_TgOhne, ENT.Ent_TagWundh));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region BNK Segment
        private string CreateBNKelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}'", "BNK", textEditAkt_IBAN.EditValue, textEditAkt_BIC.EditValue));
            return Messages;
        }
        #endregion
        #region RZA Segment
        private string CreateRZAelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}+{11}+{12}'", "RZA", textEditFAB_für_Diag.EditValue,
                textEditTmp_Arztnr.EditValue, textEditTmp_EinwArztBSNrA.EditValue, textEditTmp_Zahnarztnr.EditValue, textEditTmp_EinwDiag1.EditValue,
                textEditTmp_EinwDiag2.EditValue, textEditTmp_NrBelegarzt.EditValue, textEditTmp_NrKooparzt.EditValue, textEditTmp_BSNr.EditValue,
                dateEditAkt_ASV_Ueberweisungsdatum.DateTime.ToString("yyyyMMdd"), textEditAkt_KV_Bezirk.EditValue, dateEditAkt_EBM_Verion.DateTime.ToString("yyyyMMdd")));
            return Messages;
        }
        #endregion
        #region BDG Segment
        private string CreateBDGelement(ref int count)
        {
            string Messages = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEditBDGList.Properties.Items)
            {

                if (item.CheckState == CheckState.Checked)
                {
                    BDG = (BdgElement)item.Value;
                    Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}'", "BDG", BDG.BDiagnose, BDG.SEKD, BDG.DiagArt, BDG.TeamFiktion,
                                BDG.StandNR, BDG.FabHSA, BDG.FirstDay));
                    count = count + 1;
                }
            }
            return Messages;


    }
        #endregion
        #region PRZ Segment
        private string CreatePRZelement(ref int count)
        {
            string Messages = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEditPRZList.Properties.Items)
            {

                if (item.CheckState == CheckState.Checked)
                {
                    PRZ = (PrzElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "PRZ", PRZ.prz_Kode, PRZ.prz_Tag, PRZ.prz_LSpende));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region ENA Segment
        private string CreateENAelement(ref int count)
        {
            string Messages = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEditBDGList.Properties.Items)
            {

                if (item.CheckState == CheckState.Checked)
                {
                    ENA = (EnaElement)item.Value;
                    Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}+{10}+{11}+{12}+{13}+{14}'", "ENA", ENA.entArt, ENA.entEBM, ENA.RecGrund, ENA.Honor,ENA.TagB,
                                    ENA.PunkZ,ENA.PunkW,ENA.entBetrag,ENA.entZahl,ENA.Doppel,ENA.TeamFiktion,ENA.TeamEben,ENA.GeCodi,ENA.GeAnzahl));
                    count = count + 1;
                }
            }
            return Messages;

    }
        #endregion
        #region EZV Segment
        private string CreateEZVelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_EZV.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    EZV = (EzvElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}'", "EZV", EZV.ent_Betrag, EZV.ent_Erläuterung, EZV.ent_Text, EZV.ent_Anzahl,
                        EZV.ent_Tag, EZV.ent_Anteil));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region LEI Segment
        private string CreateLEIelement(ref int count)
        {
            string Messages = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_LEIList.Properties.Items)
            {

                if (item.CheckState == CheckState.Checked)
                {
                    LEI = (LeiElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "LEI", LEI.lei_Art, LEI.lei_Schluessel, LEI.lei_Tag));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region RED Segment 
        private string CreateREDelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditRecList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    RED = (RedElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}'", "RED", RED.rechNR, RED.rechDate, RED.rechBetrag, RED.refNRKK,
                        RED.recArt, RED.recBetragZahl, RED.KHkennzeichnen,RED.IKZahlungWeg));
                    count = count + 1;
                }
            }
            return Messages;

        }
        #endregion
        #region UWD Segment
        private string CreateUWDelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "UWD", textEditTmp_SammelbelegBeitrag.EditValue,
                textEditTmp_SammelRgBeitrag.EditValue, textEditTmp_IKBeitrag.EditValue, textEditTmp_SammelbelegNr.EditValue));
            return Messages;
        }
        #endregion
        #region ZPR Segment
        private string CreateZPRelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}'", "ZPR",textEditZPR_Betrag.EditValue, textEditZPR_PV.EditValue, textEditHonorBE.EditValue, textEditPauschal.EditValue));
            return Messages;
        }
        #endregion
        #region TXT Segment
        private string CreateTXTelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_TextANFMList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    TXT = (TxtElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "TXT", TXT.MediBeg, TXT.Kosten, TXT.Anforderung));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region REL Segment
        private string CreateRELelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditRelList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    REL = (RelElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}'", "REL", REL.RecNr, REL.recBetrag, REL.RecartRel, REL.RecBetragZ, REL.BetragAuf, REL.IKVer));
                    count = count + 1;
                }
            }
            return Messages;
        }
        #endregion
        #region KOS Segment
        private string CreateKOSelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}'", "KOS", dateEditKOSDatum.DateTime.ToString("yyyyMMdd"),
                textEditKOS_KUEM.EditValue, dateEditKOS_AB.DateTime.ToString("yyyyMMdd"), dateEditKOS_Bis.DateTime.ToString("yyyyMMdd"), textEditKOSZTag.EditValue, textEditHighT.EditValue));
            return Messages;
        }
        #endregion
        #region STA Segment
        private string CreateSTAelement()
        {
            string Messages = "";
            Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "STA", textEditStandNr.EditValue, dateEditStandardDatum.DateTime.ToString("yyyyMMdd"), dateEditStandardDatum.DateTime.ToString("HHmm")));
            return Messages;
        }
        #endregion

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
                Count = 0;
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
                Messages += CreateEADelement(ref Count);  //20
                //UNT
                Messages += CreateUNTelement(i, 7+ Count);

            }
            #endregion
            #region ENTL Nachricht
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
                //STA
                Messages += CreateSTAelement(ref Count); //99
                //DPV
                Messages += CreateDPVelement();
                //DAU
                Messages += CreateDAUelement();
                //ETL
                Messages += CreateETLNDGelement(ref Count); //999 40
                //EBG
                Messages += CreateEBGelement(ref Count); //2
                //FAB
                Messages += CreateFABelement(ref Count); //999
                //UNT
                Messages += CreateUNTelement(i, 7 + Count);

            }
            #endregion
            #region RECH Nachricht
            if (checkButtonRECH.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("RECH", i);
                //FKT
                Messages += CreateFKTelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //STA
                Messages += CreateSTAelement(ref Count); //99
                //CUX
                Messages += CreateCUXelement();
                //REC
                Messages += CreateRECelement();
                //ZLG
                Messages += CreateZLGelement();
                //RECFAB
                Messages += CreateFABelement(ref Count); //30
                //ENT
                Messages += CreateENTelement(ref Count); //98
                //BNK
                Messages += CreateBNKelement();
                //UNT
                Messages += CreateUNTelement(i, 9 + Count);

            }
            #endregion
            #region MBEG Nachricht
            if (checkButtonMBEG.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("MBEG", i);
                //FKT
                Messages += CreateFKTelement();
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
                Messages += CreatePVVelement(); //10
                //PVT
                Messages += CreatePVTelement(ref Count); //25
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
                Messages += CreateFABelement(ref Count); //10
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
                Messages += CreateTXTelement(ref Count); //10
                //UNT
                Messages += CreateUNTelement(i, 5+Count);
            }
            #endregion
            #region AMBO Nachricht
            if (checkButtonAMBO.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("AMBO", i);
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
                Messages += CreateRECelement();
                //ZLGAO
                Messages += CreateZLGelement();
                //RZA
                Messages += CreateRZAelement();
                //BDG
                Messages += CreateBDGelement(ref Count); //99
                //PRZ
                Messages += CreatePRZelement(ref Count); //99
                //ENA
                Messages += CreateENAelement(ref Count); //999
                //EZV
                Messages += CreateEZVelement(ref Count); //99
                //LEI
                Messages += CreateLEIelement(ref Count); //999
                //UNT
                Messages += CreateUNTelement(i, 10 + Count);

            }
            #endregion
            #region ZGUT Nachricht
            if (checkButtonZGUT.Checked)
            {
                i = i + 1;
                Count = 0;
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
                Messages += CreateREDelement(ref Count); //1
                //UNT
                Messages += CreateUNTelement(i, 6+Count);
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
                Messages += CreateTXTelement(ref Count); //10
                //UNT
                Messages += CreateUNTelement(i, 6+Count);
            }
            #endregion
            #region KIAN Nachricht
            if (checkButtonKAIN.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("KAIN", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //PVT
                Messages += CreatePVTelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 5);
            }
            #endregion
            #region ZAOO Nachricht
            if (checkButtonZAOO.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("ZAOO", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //INV
                Messages += CreateINVelement();
                //NAD
                Messages += CreateNADelement();
                //CUX
                Messages += CreateCUXelement();
                //REC
                Messages += CreateRECelement();
                //ZPR
                Messages += CreateZPRelement();
                //ZLG
                Messages += CreateZLGelement();
                //ENA
                Messages += CreateENAelement(ref Count); //999
                //EZV
                Messages += CreateEZVelement(ref Count); //30
                //UNT
                Messages += CreateUNTelement(i,9+Count);
            }
            #endregion
            #region ZAHL Nachricht
            if (checkButtonZAHL.Checked)
            {
                Count = 0;
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
                //REC
                Messages += CreateRECelement();
                //ZLG
                Messages += CreateZLGelement();
                //ZPR
                Messages += CreateZPRelement();
                //ENT
                Messages += CreateENTelement(ref Count); //99
                //UNT
                Messages += CreateUNTelement(i, 9+Count);
            }
            #endregion
            #region SAMU Nachricht
            if (checkButtonSAMU.Checked)
            {
                i = i + 1;
                Count = 0;
                Messages += CreateUNHelement("SAMU", i);
                //FKT Way Back
                Messages += CreateFKTWBelement();
                //CUX
                Messages += CreateCUXelement();
                //RED
                Messages += CreateREDelement(ref Count); ////99999x 
                //REL
                Messages += CreateRELelement(ref Count); ///999
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
        private void simpleButtonADDTmp_EZV_Click(object sender, EventArgs e)
        {
            EZV = new EzvElement();
            EZV.ent_Betrag = textEditENZent_Betrag.EditValue.ToString();
            EZV.ent_Erläuterung = textEditENZent_Erläuterung.EditValue.ToString();
            EZV.ent_Text = textEditENZent_Text.EditValue.ToString();
            EZV.ent_Anzahl = textEditENZent_Anzahl.EditValue.ToString();
            EZV.ent_Tag = dateEditENZent_Tag.DateTime.ToString("yyyyMMdd");
            EZV.ent_Anteil = textEditENZent_Anteil.EditValue.ToString();
            checkedComboBoxEditTmp_EZV.Properties.Items.Add(EZV);
            EZVList.Add(EZV);
            checkedComboBoxEditTmp_EZV.Properties.Items[checkedComboBoxEditTmp_EZV.Properties.Items.Count - 1].Description = "Erläuterung : " + EZV.ent_Erläuterung;
            checkedComboBoxEditTmp_EZV.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDdiagnose_Click(object sender, EventArgs e)
        {
            EAD = new EadElement();
            EAD.Aufnahmediagnose = textEditAufnahmediagnose.EditValue.ToString();
            EAD.SEAufnahmediagnose = textEditSEAufnahmediagnose.EditValue.ToString();
            EAD.EinDiagnose = textEditEinDiagnose.EditValue.ToString();
            EAD.SEEinDiagnose = textEditSEEinDiagnose.EditValue.ToString();
            CheckedCombiEditAufnahmediagnose.Properties.Items.Add(EAD);
            EADList.Add(EAD);
            CheckedCombiEditAufnahmediagnose.Properties.Items[CheckedCombiEditAufnahmediagnose.Properties.Items.Count - 1].Description = "Aufnahmediagnose : " + EAD.Aufnahmediagnose;
            CheckedCombiEditAufnahmediagnose.Properties.Items[0].CheckState = CheckState.Checked;
        }


        private void simpleButtonADDFAB_Click(object sender, EventArgs e)
        {
            FAB = new FabElement();
            FAB.fab_FAbt = textEditfab_FAbt.EditValue.ToString();
            FAB.fab_DGLok = textEditfab_DG.EditValue.ToString();
            FAB.fab_SekDLok = textEditfab_SekD.EditValue.ToString();
            FAB.fab_ZDG = textEditfab_ZDG.EditValue.ToString();
            FAB.fab_ZSekD = textEditfab_ZSekD.EditValue.ToString();
            FAB.fab_OPT = dateEditfab_OPT.DateTime.ToString("yyyyMMdd");
            FAB.fab_OP = textEditfab_OP.EditValue.ToString();
            checkedComboBoxEditFABList.Properties.Items.Add(FAB);
            FABList.Add(FAB);
            checkedComboBoxEditFABList.Properties.Items[checkedComboBoxEditFABList.Properties.Items.Count - 1].Description = "Abteilung : " + FAB.fab_FAbt ;
            checkedComboBoxEditFABList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDTmp_LEIList_Click(object sender, EventArgs e)
        {
            LEI = new LeiElement();
            LEI.lei_Art = textEditlei_Art.EditValue.ToString();
            LEI.lei_Schluessel = textEditlei_Schluessel.EditValue.ToString();
            LEI.lei_Tag = dateEditlei_Tag.DateTime.ToString("yyyyMMdd");
            checkedComboBoxEditTmp_LEIList.Properties.Items.Add(LEI);
            LEIList.Add(LEI);
            checkedComboBoxEditTmp_LEIList.Properties.Items[checkedComboBoxEditTmp_LEIList.Properties.Items.Count - 1].Description = "Leistungsart  : " + LEI.lei_Art;
            checkedComboBoxEditTmp_LEIList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDNDG_Click(object sender, EventArgs e)
        {
            NDG = new NdgElement();
            NDG.ndg_NDLok = textEditndg_NDLok.EditValue.ToString();
            NDG.ndg_SekDLok = textEditdg_SekDLok.EditValue.ToString();
            checkedComboBoxEditNDGList.Properties.Items.Add(NDG);
            NDGList.Add(NDG);
            checkedComboBoxEditNDGList.Properties.Items[checkedComboBoxEditNDGList.Properties.Items.Count - 1].Description = "Nebendiagnose  : " + NDG.ndg_NDLok;
            checkedComboBoxEditNDGList.Properties.Items[0].CheckState = CheckState.Checked;
        }

        private void simpleButtonTmp_ENTList_Click(object sender, EventArgs e)
        {
            ENT = new EntElement();
            ENT.Ent_Art = textEditEnt_Art.EditValue.ToString();
            ENT.Ent_Betrag = textEditEnt_Betrag.EditValue.ToString();
            ENT.Ent_von = dateEditEnt_von.DateTime.ToString("yyyyMMdd");
            ENT.Ent_bis = dateEditEnt_bis.DateTime.ToString("yyyyMMdd");
            ENT.Ent_Anz = textEditEnt_Anz.EditValue.ToString();
            ENT.Ent_TgOhne = textEditEnt_TgOhne.EditValue.ToString();
            ENT.Ent_TagWundh = textEditEnt_TagWundh.EditValue.ToString();
            checkedComboBoxEditTmp_ENTList.Properties.Items.Add(ENT);
            ENTList.Add(ENT);
            checkedComboBoxEditTmp_ENTList.Properties.Items[checkedComboBoxEditTmp_ENTList.Properties.Items.Count - 1].Description = "Entgeltart  : " + ENT.Ent_Art;
            checkedComboBoxEditTmp_ENTList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonPRZList_Click(object sender, EventArgs e)
        {
            PRZ = new PrzElement();
            PRZ.prz_Kode = textEditTMPprz_Kode.EditValue.ToString();
            PRZ.prz_Tag = dateEditTMPprz_Tag.DateTime.ToString("yyyyMMdd");
            PRZ.prz_LSpende = textEditTMPprz_LSpende.EditValue.ToString();
            checkedComboBoxEditPRZList.Properties.Items.Add(PRZ);
            PRZList.Add(PRZ);
            checkedComboBoxEditPRZList.Properties.Items[checkedComboBoxEditPRZList.Properties.Items.Count - 1].Description = "Prozedurenschlüssel und Lokalisation  : " + PRZ.prz_Kode;
            checkedComboBoxEditPRZList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDTmp_EBGList_Click(object sender, EventArgs e)
        {
            checkedComboBoxEditTmp_EBGList.Properties.Items.Add(dateEditTmp_EBG.DateTime.ToString("yyyyMMdd"));
            checkedComboBoxEditTmp_EBGList.Properties.Items[checkedComboBoxEditTmp_EBGList.Properties.Items.Count - 1].Description = "" + dateEditTmp_EBG.DateTime.ToString("yyyyMMdd");
            checkedComboBoxEditTmp_EBGList.Properties.Items[checkedComboBoxEditTmp_EBGList.Properties.Items.Count - 1].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDPrfText_Click(object sender, EventArgs e)
        {
            PVT = new PvtElement();
            PVT.prfvText = memoEditText.EditValue.ToString();
            PVT.prfvH = textEditPrfvH.EditValue.ToString();
            PVT.prfHSek = textEditHDSEk.EditValue.ToString();
            PVT.PrfN = textEditPrfN.EditValue.ToString();
            PVT.prfNSek = textEditNDSEk.EditValue.ToString();
            PVT.prfPrZ = textEditPrfP.EditValue.ToString();
            checkedComboBoxEditPrfTextList.Properties.Items.Add(PVT);
            PVTList.Add(PVT);
            checkedComboBoxEditPrfTextList.Properties.Items[checkedComboBoxEditPrfTextList.Properties.Items.Count - 1].Description = "PrüfvV-Hauptdiagnose  : " + PVT.prfvH;
            checkedComboBoxEditPrfTextList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonREDListADD_Click(object sender, EventArgs e)
        {
            RED = new RedElement();
            RED.rechNR = textEditrechNR.EditValue.ToString();
            RED.rechDate = dateEditrechDate.DateTime.ToString("yyyyMMdd"); 
            RED.rechBetrag = textEditrechBetrag.EditValue.ToString();
            RED.refNRKK = textEditrefNRKK.EditValue.ToString();
            RED.recArt = textEditrecArt.EditValue.ToString();
            RED.recBetragZahl = textEditrecBetragZahl.EditValue.ToString();
            RED.KHkennzeichnen = textEditKHkennzeichnen.EditValue.ToString();
            RED.IKZahlungWeg=textEditIKZahlungWeg.EditValue.ToString();
            checkedComboBoxEditRecList.Properties.Items.Add(RED);
            REDList.Add(RED);
            checkedComboBoxEditRecList.Properties.Items[checkedComboBoxEditRecList.Properties.Items.Count - 1].Description = "Rechnungsnummer  : " + RED.rechNR;
            checkedComboBoxEditRecList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonBDGADD_Click(object sender, EventArgs e)
        {
            BDG = new BdgElement();
            BDG.BDiagnose = textEditTmpBDiagnose.EditValue.ToString();
            BDG.SEKD = textEditTmpSEK.EditValue.ToString();
            BDG.DiagArt = textEditTmpArt.EditValue.ToString();
            BDG.TeamFiktion = textEditTmpTeam.EditValue.ToString();
            BDG.StandNR = textEditTmpStandNr.EditValue.ToString();
            BDG.FabHSA = textEditTmpHSA.EditValue.ToString();
            checkedComboBoxEditBDGList.Properties.Items.Add(BDG);
            BDGList.Add(BDG);
            checkedComboBoxEditBDGList.Properties.Items[checkedComboBoxEditBDGList.Properties.Items.Count - 1].Description = "Behandlungsdiagnose  : " + BDG.BDiagnose;
            checkedComboBoxEditBDGList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDENA_Click(object sender, EventArgs e)
        {
            ENA = new EnaElement();
            ENA.entArt = textEditentArt.EditValue.ToString();
            ENA.entEBM = textEditentEBM.EditValue.ToString();
            ENA.RecGrund = textEditRecGrund.EditValue.ToString();
            ENA.Honor = textEditHonor.EditValue.ToString();
            ENA.TagB = dateEditTagB.EditValue.ToString();
            ENA.PunkZ = textEditPunkZ.EditValue.ToString();
            ENA.PunkW = textEditPunkW.EditValue.ToString();
            ENA.entBetrag = textEditentBetrag.EditValue.ToString();
            ENA.entZahl = textEditentZahl.EditValue.ToString();
            ENA.Doppel = textEditDoppel.EditValue.ToString();
            ENA.TeamFiktion = textEditTeamFiktion.EditValue.ToString();
            ENA.TeamEben = textEditTeamEben.EditValue.ToString();
            ENA.GeCodi = textEditGeCodi.EditValue.ToString();
            ENA.GeAnzahl = textEditGeAnzahl.EditValue.ToString();
            checkedComboBoxEditENAList.Properties.Items.Add(ENA);
            ENAList.Add(ENA);
            checkedComboBoxEditENAList.Properties.Items[checkedComboBoxEditENAList.Properties.Items.Count - 1].Description = "Entgeltart  : " + ENA.entArt;
            checkedComboBoxEditENAList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonADDTextANFM_Click(object sender, EventArgs e)
        {
            TXT = new TxtElement();
            TXT.MediBeg = memoEditMediBeg.EditValue.ToString();
            TXT.Kosten = textEditKosten.EditValue.ToString();
            TXT.Anforderung = textEditAnforderung.EditValue.ToString();
            checkedComboBoxEditTmp_TextANFMList.Properties.Items.Add(TXT);
            TXTList.Add(TXT);
            checkedComboBoxEditTmp_TextANFMList.Properties.Items[checkedComboBoxEditTmp_TextANFMList.Properties.Items.Count - 1].Description = "Anforderung Medizinische Begründung  : " + TXT.Anforderung;
            checkedComboBoxEditTmp_TextANFMList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        private void simpleButtonAddRel_Click(object sender, EventArgs e)
        {
            REL = new RelElement();
            REL.RecNr = textEditRecNr.EditValue.ToString();
            REL.recBetrag = textEditrecBetrag.EditValue.ToString();
            REL.RecartRel = textEditRecartRel.EditValue.ToString();
            REL.RecBetragZ = textEditRecBetragZ.EditValue.ToString();
            REL.BetragAuf = textEditBetragAuf.EditValue.ToString();
            REL.IKVer = textEditIKVer.EditValue.ToString();
            checkedComboBoxEditRelList.Properties.Items.Add(REL);
            RELList.Add(REL);
            checkedComboBoxEditRelList.Properties.Items[checkedComboBoxEditRelList.Properties.Items.Count - 1].Description = "Rechnungsnummer  : " + REL.RecNr;
            checkedComboBoxEditRelList.Properties.Items[0].CheckState = CheckState.Checked;
        }
        #endregion


    }
}
