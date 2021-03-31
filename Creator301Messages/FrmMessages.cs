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
               // layoutSTA.Visibility = LayoutVisibility.Always;
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
                layoutSTA.Visibility = LayoutVisibility.Always;
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
                layoutSTA.Visibility = LayoutVisibility.Always;
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
                layoutSTA.Visibility = LayoutVisibility.Always;
                layoutREC.Visibility = LayoutVisibility.Always;
                layoutZLG.Visibility = LayoutVisibility.Always;
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
                layoutSTA.Visibility = LayoutVisibility.Always;
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
                layoutSTA.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonZAHL.Checked)
            {
                checkButtonZAHL.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutINV_PNV.Visibility = LayoutVisibility.Always;
                layoutNAD.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutSTA.Visibility = LayoutVisibility.Always;
                layoutZPR.Visibility = LayoutVisibility.Always;
            }
            if (checkButtonSAMU.Checked)
            {
                checkButtonSAMU.Appearance.ForeColor = Color.Green;
                Ifchecked = true;
                layoutFKT.Visibility = LayoutVisibility.Always;
                layoutCUX.Visibility = LayoutVisibility.Always;
                layoutSTA.Visibility = LayoutVisibility.Always;
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
            comboBoxEditSpecialPerson.SelectedIndex = 0;
            textEditFileName.Text = "Nachricht" + DateTime.Now.ToString("yyyy-MM-dd");
            SAMUList = new List<SamuElement>();
            FABList = new List<FabElement>();
            NDGList = new List<NdgElement>();
            ENTList = new List<EntElement>();
            EADList = new List<EadElement>();
            PRZList = new List<PrzElement>();
            EZVList = new List<EzvElement>();
            LEIList = new List<LeiElement>();
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
        #region PVT Segment dorost shavad
        private string CreatePVTelement(ref int count)
        {
            string Messages = "";
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
        #region BDG Segment dorost shavad
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
        #region ENA Segment dorost shavad
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
        #region RED Segment dorost shavad
        private string CreateREDelement()
        {
            string Messages;
            Messages = TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}'", "RED", textEditTmp_RgNr.EditValue, dateEditTmp_RgDatum.DateTime.ToString("yyyyMMdd"),
                textEditTmp_RgBetrag.EditValue, textEditTmp_IKRefNr.EditValue,
                textEditTmp_RgArt.EditValue, textEditTmp_RgBetragZA.EditValue,
                textEditTmp_KHKV.EditValue, textEditTmp_IKZahlweg.EditValue));
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
        #region TXT Segment dorost shavad
        private string CreateTXTelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditTmp_TextANFMList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {

                    Messages += TrimEndMessage(String.Format("{0}+{1}'", "TXT", item));
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
            Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}'", "STA", textEditStandNr.EditValue, dateEditStandardDatum..DateTime.ToString("yyyyMMdd"), dateEditStandardDatum.DateTime.ToString("HHmm")));
            return Messages;
        }
        #endregion

        private string CreateRED_SAMUelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditSamuElementList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    SAMU = (SamuElement)item.Value;
                    Messages += TrimEndMessage(String.Format("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}'", "RED", SAMU.Rech_Nr, "", "", "", SAMU.Rech_Art, "", SAMU.Aufn_Nr));
                    count = count + 1;
                }
            }
            return Messages;
        }
        private string CreateRECFABelement(ref int count)
        {
            string Messages = "";

            foreach (CheckedListBoxItem item in checkedComboBoxEditREFABList.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {

                    Messages += TrimEndMessage(String.Format("{0}+{1}'", "FAB", item));
                    count = count + 1;
                }
            }
            return Messages;
        }
        //dorost shavad

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
                //DPV
                Messages += CreateDPVelement();
                //DAU
                Messages += CreateDAUelement();
                //ETL
                Messages += CreateETLNDGelement(ref Count);
                //EBG
                Messages += CreateEBGelement(ref Count);
                //FAB
                Messages += CreateFABelement(ref Count);
                //UNT
                Messages += CreateUNTelement(i, 7 + Count);

            }
            #endregion
            #region RECH Nachricht
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
                Messages += CreateRECelement();
                //ZLG
                Messages += CreateZLGelement();
                //RECFAB
                Messages += CreateRECFABelement(ref Count);
                //ENT
                Messages += CreateENTelement(ref Count);
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

                //PRZ
                Messages += CreatePRZelement(ref Count);
                //ENA

                //EZV
                Messages += CreateEZVelement(ref Count);
                //LEI
                Messages += CreateLEIelement(ref Count);
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
            checkedComboBoxEditTmp_ENTList.Properties.Items[checkedComboBoxEditTmp_ENTList.Properties.Items.Count - 1].Description = "ENT Art  : " + ENT.Ent_Art;
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

        private void simpleButtonADDREFABList_Click(object sender, EventArgs e)
        {
            checkedComboBoxEditREFABList.Properties.Items.Add(textEditREFAB.EditValue);
            checkedComboBoxEditREFABList.Properties.Items[checkedComboBoxEditREFABList.Properties.Items.Count - 1].Description = "" + textEditREFAB.EditValue;
            checkedComboBoxEditREFABList.Properties.Items[checkedComboBoxEditREFABList.Properties.Items.Count - 1].CheckState = CheckState.Checked;
        }





        #endregion

        private void textEdit60_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
