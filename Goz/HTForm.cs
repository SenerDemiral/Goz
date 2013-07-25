using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Goz
{
    public partial class HTForm : DevExpress.XtraEditors.XtraForm
    {
        public HTForm()
        {
            InitializeComponent();

            //FillTanimlar();
        }

        private void hTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            this.Validate();
            this.hTBindingSource.EndEdit();
            this.hTTableAdapter.Update(this.gozDataSet.HT);

        }


        private void HTForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gozDataSet.HT' table. You can move, or remove it, as needed.
            //this.hTTableAdapter.Fill(this.gozDataSet.HT);

        }

        private void searchTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchText();
                e.Handled = true;
            }
        }

        private void searchText()
        {
            this.hTTableAdapter.FillBySearch(this.gozDataSet.HT, searchTextEdit.Text);

        }

        private void HTgridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            int HTId = (int)queriesTableAdapter.GET_PK("HT");
            HTgridView.SetRowCellValue(e.RowHandle, colHTID, HTId);
        }

        private void tibbiBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
            int HTId = (int)HTgridView.GetFocusedRowCellValue(colHTID);
            //string Ad = HTgridView.GetFocusedRowCellValue(colAD). ?? "";
            HTTextForm htTxtfrm;
            //            if (htTxtfrm == null)
            htTxtfrm = new HTTextForm();

            htTxtfrm.HTId = HTId;
            htTxtfrm.HastaInfo = string.Format("{0} {1} #{2} {3} {4:dMMMyyyy}",
                HTgridView.GetFocusedRowCellValue(colAD),
                HTgridView.GetFocusedRowCellValue(colSOYAD),
                HTgridView.GetFocusedRowCellValue(colHTID),
                HTgridView.GetFocusedRowCellDisplayText(colCINSIYET),
                HTgridView.GetFocusedRowCellValue(colDGMTRH));

            htTxtfrm.ShowDialog();
            htTxtfrm.Dispose();
        }

/*
        private async void FillTanimlar()
        {
            //Her iki sekilde de OK
            //await DoWork(); // Fill Table
            //alertControl1.Show(this, "Background ops", "Tanımlar okunuyor");
            await System.Threading.Tasks.TaskEx.Run(() =>
            {
                HTTextForm htTxtfrm = new HTTextForm();
                htTxtfrm.Dispose();
            });
        }*/
    }
}