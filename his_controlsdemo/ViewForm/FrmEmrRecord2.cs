﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EFWCoreLib.WinformFrame.Controller;

namespace TestControls
{
    public partial class FrmEmrRecord2 : BaseForm
    {
        public FrmEmrRecord2()
        {
            InitializeComponent();
        }

        private void FrmEmrRecord2_Load(object sender, EventArgs e)
        {
            emrRecord1.InitLoad(InvokeController("NewTestEmrTemplateDbHelper") as TestEmrTemplateDbHelper, new EMR.Controls.Action.EmrBindKeyData(1, "001", "儿科", "01", "张医生"));
        }
    }
}
