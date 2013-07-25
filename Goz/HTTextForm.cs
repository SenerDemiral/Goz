using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;

namespace Goz
{
    public partial class HTTextForm : DevExpress.XtraEditors.XtraForm
    {
        public int HTId;
        public string HastaInfo;

        public HTTextForm()
        {
            InitializeComponent();
        }

        private void Save()
        {
            this.Validate();
            this.hT_TXT_GETBindingSource.EndEdit();
            int nor = this.hT_TXT_GETTableAdapter.Update(this.gozDataSet.HT_TXT_GET);
        }

        private void Fill()
        {
            try
            {
                int nor = this.hT_TXT_GETTableAdapter.Fill(this.gozDataSet.HT_TXT_GET, HTId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void HTTextForm_Load(object sender, EventArgs e)
        {
            this.Text = HastaInfo;
            Fill();

            richEditControl1.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A4;
            richEditControl1.Document.Sections[0].Margins.Left = 10;
            richEditControl1.Document.Sections[0].Margins.Right = 10;
            richEditControl1.Document.Sections[0].Margins.Top = 10;
            richEditControl1.Document.Sections[0].Margins.Bottom = 10;
            richEditControl1.Document.DefaultCharacterProperties.FontSize = 10;
            richEditControl1.Document.DefaultCharacterProperties.FontName = "Arial";

            // Add a header to the document
            Section firstSection = richEditControl1.Document.Sections[0];
            SubDocument doc = firstSection.BeginUpdateHeader();
            doc.InsertText(doc.CreatePosition(doc.Range.Start.ToInt()), HastaInfo+"\n");
            firstSection.EndUpdateHeader(doc);

            // Add new Style
            CharacterStyle cstyle = richEditControl1.Document.CharacterStyles["MyCStyle"];
            if (cstyle == null)
            {
                cstyle = richEditControl1.Document.CharacterStyles.CreateNew();
                cstyle.Name = "MyCStyle";
                cstyle.Parent = richEditControl1.Document.CharacterStyles["Default Paragraph Font"];
                cstyle.ForeColor = Color.DarkOrange;
                cstyle.Strikeout = StrikeoutType.Double;
                cstyle.FontName = "Verdana";
                richEditControl1.Document.CharacterStyles.Add(cstyle);
            }

            /*
            Section firstSection = richEditControl1.Document.Sections[0];
            SubDocument doc = firstSection.BeginUpdateHeader(HeaderFooterType.First);
            
            DocumentRange range = doc.InsertText(doc.CreatePosition(0), " PAGE NUMBER ");
            //Field fld = doc.Fields.Add(range.End, "PAGE \\* ARABICDASH");
            //doc.Fields.Update();
            richEditControl1.Document.Sections[0].EndUpdateHeader(doc);
            richEditControl1.Document.Sections[0].DifferentFirstPage = true;*/
            /*
            SubDocument doc = richEditControl1.Document.Sections[0].BeginUpdateHeader(DevExpress.XtraRichEdit.API.Native.HeaderFooterType.First);
            doc.InsertText(doc.CreatePosition(0), " PAGE NUMBER ");
            //doc.InsertText(doc.CreatePosition(doc.Range.End.ToInt()), "asdfasdfasdfas");
            //doc.InsertRtfText(doc.CreatePosition(doc.Range.End.ToInt()), @"{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 test}\par}");
            richEditControl1.Document.Sections[0].EndUpdateHeader(doc);*/
        }

        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
            richEditControl1.Modified = false;  //Disable SaveToFile behaviour
        }

        private void HTTextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richEditControl1.Modified)
            {
                var dr = XtraMessageBox.Show("Döküman değiştirilmiş,\nKaydetmek için Yes\nKaydetmeden çıkmak için No\nDökümanda kalmak istiyorsanız Cancel\nTuşuna basın.", "Tıbbi Bilgiler", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    Save();
                else if (dr == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}