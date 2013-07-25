namespace Goz
{
    partial class HTForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTForm));
            this.gozDataSet = new Goz.GozDataSet();
            this.hTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTableAdapter = new Goz.GozDataSetTableAdapters.HTTableAdapter();
            this.hTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hTGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tibbiBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HTgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCINSIYET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cinsiyetRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDGMTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgmTrhDepositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTEL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.queriesTableAdapter = new Goz.GozDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gozDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTBindingNavigator)).BeginInit();
            this.hTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HTgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinsiyetRepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmTrhDepositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmTrhDepositoryItemDateEdit.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gozDataSet
            // 
            this.gozDataSet.DataSetName = "GozDataSet";
            this.gozDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hTBindingSource
            // 
            this.hTBindingSource.DataMember = "HT";
            this.hTBindingSource.DataSource = this.gozDataSet;
            // 
            // hTTableAdapter
            // 
            this.hTTableAdapter.ClearBeforeFill = true;
            // 
            // hTBindingNavigator
            // 
            this.hTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hTBindingNavigator.BindingSource = this.hTBindingSource;
            this.hTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hTBindingNavigatorSaveItem});
            this.hTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hTBindingNavigator.Name = "hTBindingNavigator";
            this.hTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hTBindingNavigator.Size = new System.Drawing.Size(995, 25);
            this.hTBindingNavigator.TabIndex = 0;
            this.hTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hTBindingNavigatorSaveItem
            // 
            this.hTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hTBindingNavigatorSaveItem.Image")));
            this.hTBindingNavigatorSaveItem.Name = "hTBindingNavigatorSaveItem";
            this.hTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hTBindingNavigatorSaveItem.Text = "Save Data";
            this.hTBindingNavigatorSaveItem.Click += new System.EventHandler(this.hTBindingNavigatorSaveItem_Click);
            // 
            // hTGridControl
            // 
            this.hTGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.hTGridControl.DataSource = this.hTBindingSource;
            this.hTGridControl.Location = new System.Drawing.Point(12, 36);
            this.hTGridControl.MainView = this.HTgridView;
            this.hTGridControl.Name = "hTGridControl";
            this.hTGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cinsiyetRepositoryItemImageComboBox,
            this.telRepositoryItemTextEdit,
            this.dgmTrhDepositoryItemDateEdit});
            this.hTGridControl.Size = new System.Drawing.Size(971, 399);
            this.hTGridControl.TabIndex = 1;
            this.hTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HTgridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tibbiBilgileriToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(151, 26);
            // 
            // tibbiBilgileriToolStripMenuItem
            // 
            this.tibbiBilgileriToolStripMenuItem.Name = "tibbiBilgileriToolStripMenuItem";
            this.tibbiBilgileriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tibbiBilgileriToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tibbiBilgileriToolStripMenuItem.Text = "Tıbbi Bilgileri";
            this.tibbiBilgileriToolStripMenuItem.Click += new System.EventHandler(this.tibbiBilgileriToolStripMenuItem_Click);
            // 
            // HTgridView
            // 
            this.HTgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHTID,
            this.colTCKNO,
            this.colAD,
            this.colSOYAD,
            this.colCINSIYET,
            this.colDGMTRH,
            this.colADRES,
            this.colTEL1,
            this.colTEL2,
            this.colTEL3,
            this.colEMAIL});
            this.HTgridView.GridControl = this.hTGridControl;
            this.HTgridView.Name = "HTgridView";
            this.HTgridView.OptionsView.ColumnAutoWidth = false;
            this.HTgridView.OptionsView.EnableAppearanceEvenRow = true;
            this.HTgridView.OptionsView.ShowFooter = true;
            this.HTgridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.HTgridView_InitNewRow);
            // 
            // colHTID
            // 
            this.colHTID.FieldName = "HTID";
            this.colHTID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colHTID.Name = "colHTID";
            this.colHTID.OptionsColumn.AllowEdit = false;
            this.colHTID.OptionsColumn.AllowFocus = false;
            this.colHTID.OptionsColumn.FixedWidth = true;
            this.colHTID.Visible = true;
            this.colHTID.VisibleIndex = 0;
            this.colHTID.Width = 50;
            // 
            // colTCKNO
            // 
            this.colTCKNO.Caption = "TCKimNo";
            this.colTCKNO.FieldName = "TCKNO";
            this.colTCKNO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTCKNO.Name = "colTCKNO";
            this.colTCKNO.OptionsColumn.FixedWidth = true;
            this.colTCKNO.Visible = true;
            this.colTCKNO.VisibleIndex = 1;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 2;
            this.colAD.Width = 100;
            // 
            // colSOYAD
            // 
            this.colSOYAD.Caption = "Soyad";
            this.colSOYAD.FieldName = "SOYAD";
            this.colSOYAD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSOYAD.Name = "colSOYAD";
            this.colSOYAD.Visible = true;
            this.colSOYAD.VisibleIndex = 3;
            this.colSOYAD.Width = 100;
            // 
            // colCINSIYET
            // 
            this.colCINSIYET.Caption = "Cinsiyet";
            this.colCINSIYET.ColumnEdit = this.cinsiyetRepositoryItemImageComboBox;
            this.colCINSIYET.FieldName = "CINSIYET";
            this.colCINSIYET.Name = "colCINSIYET";
            this.colCINSIYET.Visible = true;
            this.colCINSIYET.VisibleIndex = 4;
            this.colCINSIYET.Width = 52;
            // 
            // cinsiyetRepositoryItemImageComboBox
            // 
            this.cinsiyetRepositoryItemImageComboBox.AutoHeight = false;
            this.cinsiyetRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cinsiyetRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kadın", "K", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Erkek", "E", -1)});
            this.cinsiyetRepositoryItemImageComboBox.Name = "cinsiyetRepositoryItemImageComboBox";
            // 
            // colDGMTRH
            // 
            this.colDGMTRH.Caption = "DğmTrh";
            this.colDGMTRH.ColumnEdit = this.dgmTrhDepositoryItemDateEdit;
            this.colDGMTRH.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colDGMTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDGMTRH.FieldName = "DGMTRH";
            this.colDGMTRH.Name = "colDGMTRH";
            this.colDGMTRH.Visible = true;
            this.colDGMTRH.VisibleIndex = 5;
            this.colDGMTRH.Width = 80;
            // 
            // dgmTrhDepositoryItemDateEdit
            // 
            this.dgmTrhDepositoryItemDateEdit.AutoHeight = false;
            this.dgmTrhDepositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dgmTrhDepositoryItemDateEdit.Mask.EditMask = "dd.MM.yyyy";
            this.dgmTrhDepositoryItemDateEdit.Mask.UseMaskAsDisplayFormat = true;
            this.dgmTrhDepositoryItemDateEdit.Name = "dgmTrhDepositoryItemDateEdit";
            this.dgmTrhDepositoryItemDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colADRES
            // 
            this.colADRES.Caption = "Adres";
            this.colADRES.FieldName = "ADRES";
            this.colADRES.Name = "colADRES";
            this.colADRES.Visible = true;
            this.colADRES.VisibleIndex = 9;
            this.colADRES.Width = 120;
            // 
            // colTEL1
            // 
            this.colTEL1.Caption = "Tel1";
            this.colTEL1.ColumnEdit = this.telRepositoryItemTextEdit;
            this.colTEL1.FieldName = "TEL1";
            this.colTEL1.Name = "colTEL1";
            this.colTEL1.Visible = true;
            this.colTEL1.VisibleIndex = 6;
            this.colTEL1.Width = 90;
            // 
            // telRepositoryItemTextEdit
            // 
            this.telRepositoryItemTextEdit.AutoHeight = false;
            this.telRepositoryItemTextEdit.Mask.EditMask = "(\\(\\d\\d\\d\\))?\\d{1,3}-\\d\\d-\\d\\d";
            this.telRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.telRepositoryItemTextEdit.Mask.UseMaskAsDisplayFormat = true;
            this.telRepositoryItemTextEdit.Name = "telRepositoryItemTextEdit";
            // 
            // colTEL2
            // 
            this.colTEL2.Caption = "Tel2";
            this.colTEL2.ColumnEdit = this.telRepositoryItemTextEdit;
            this.colTEL2.FieldName = "TEL2";
            this.colTEL2.Name = "colTEL2";
            this.colTEL2.Visible = true;
            this.colTEL2.VisibleIndex = 7;
            this.colTEL2.Width = 90;
            // 
            // colTEL3
            // 
            this.colTEL3.Caption = "Tel3";
            this.colTEL3.ColumnEdit = this.telRepositoryItemTextEdit;
            this.colTEL3.FieldName = "TEL3";
            this.colTEL3.Name = "colTEL3";
            this.colTEL3.Visible = true;
            this.colTEL3.VisibleIndex = 8;
            this.colTEL3.Width = 90;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "eMail";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 10;
            this.colEMAIL.Width = 90;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchTextEdit);
            this.layoutControl1.Controls.Add(this.hTGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(995, 447);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchTextEdit
            // 
            this.searchTextEdit.Location = new System.Drawing.Point(32, 12);
            this.searchTextEdit.Name = "searchTextEdit";
            this.searchTextEdit.Size = new System.Drawing.Size(951, 20);
            this.searchTextEdit.StyleController = this.layoutControl1;
            this.searchTextEdit.TabIndex = 4;
            this.searchTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextEdit_KeyPress);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(995, 447);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.searchTextEdit;
            this.layoutControlItem1.CustomizationFormText = "Ara";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(975, 24);
            this.layoutControlItem1.Text = "Ara";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(17, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.hTGridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(975, 403);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // HTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 472);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.hTBindingNavigator);
            this.Name = "HTForm";
            this.Text = "HTForm";
            this.Load += new System.EventHandler(this.HTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gozDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTBindingNavigator)).EndInit();
            this.hTBindingNavigator.ResumeLayout(false);
            this.hTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HTgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinsiyetRepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmTrhDepositoryItemDateEdit.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmTrhDepositoryItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GozDataSet gozDataSet;
        private System.Windows.Forms.BindingSource hTBindingSource;
        private GozDataSetTableAdapters.HTTableAdapter hTTableAdapter;
        private System.Windows.Forms.BindingNavigator hTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hTBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl hTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView HTgridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKNO;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colCINSIYET;
        private DevExpress.XtraGrid.Columns.GridColumn colDGMTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL2;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL3;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit searchTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cinsiyetRepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit telRepositoryItemTextEdit;
        private GozDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tibbiBilgileriToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dgmTrhDepositoryItemDateEdit;
    }
}