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

using Microsoft.Win32;

#endregion

namespace Creator301Messages
{
    public partial class FrmMessages : XtraForm
    {
        public FrmMessages()
        {
            InitializeComponent();
        }
    }
}
