
namespace _307_Coursework
{
    partial class Form1
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
            System.Windows.Forms.Label assetIDLabel;
            System.Windows.Forms.Label systemNameLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label iPAddressLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label noteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectionBox = new System.Windows.Forms.CheckBox();
            this.assetsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2003115DataSet = new _307_Coursework.mssql2003115DataSet();
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
            this.assetsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.assetIDTextBox = new System.Windows.Forms.TextBox();
            this.systemNameTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.iPAddressTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assetsTableAdapter = new _307_Coursework.mssql2003115DataSetTableAdapters.AssetsTableAdapter();
            this.tableAdapterManager = new _307_Coursework.mssql2003115DataSetTableAdapters.TableAdapterManager();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.assetsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            assetIDLabel = new System.Windows.Forms.Label();
            systemNameLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            iPAddressLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingNavigator)).BeginInit();
            this.assetsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2003115DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assetIDLabel
            // 
            assetIDLabel.AutoSize = true;
            assetIDLabel.Location = new System.Drawing.Point(40, 288);
            assetIDLabel.Name = "assetIDLabel";
            assetIDLabel.Size = new System.Drawing.Size(50, 13);
            assetIDLabel.TabIndex = 4;
            assetIDLabel.Text = "Asset ID:";
            // 
            // systemNameLabel
            // 
            systemNameLabel.AutoSize = true;
            systemNameLabel.Location = new System.Drawing.Point(15, 314);
            systemNameLabel.Name = "systemNameLabel";
            systemNameLabel.Size = new System.Drawing.Size(75, 13);
            systemNameLabel.TabIndex = 6;
            systemNameLabel.Text = "System Name:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(48, 340);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 8;
            modelLabel.Text = "Model:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(238, 314);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 12;
            typeLabel.Text = "Type:";
            // 
            // iPAddressLabel
            // 
            iPAddressLabel.AutoSize = true;
            iPAddressLabel.Location = new System.Drawing.Point(214, 340);
            iPAddressLabel.Name = "iPAddressLabel";
            iPAddressLabel.Size = new System.Drawing.Size(58, 13);
            iPAddressLabel.TabIndex = 14;
            iPAddressLabel.Text = "IPAddress:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(199, 291);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(73, 13);
            manufacturerLabel.TabIndex = 15;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(384, 291);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 16;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(434, 314);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(33, 13);
            noteLabel.TabIndex = 18;
            noteLabel.Text = "Note:";
            // 
            // connectionBox
            // 
            this.connectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectionBox.AutoSize = true;
            this.connectionBox.Location = new System.Drawing.Point(12, 533);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(78, 17);
            this.connectionBox.TabIndex = 0;
            this.connectionBox.Text = "Connected";
            this.connectionBox.UseVisualStyleBackColor = true;
            this.connectionBox.CheckedChanged += new System.EventHandler(this.connectionBox_CheckedChanged);
            // 
            // assetsBindingNavigator
            // 
            this.assetsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assetsBindingNavigator.BindingSource = this.assetsBindingSource;
            this.assetsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assetsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assetsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assetsBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.assetsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assetsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assetsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assetsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assetsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assetsBindingNavigator.Name = "assetsBindingNavigator";
            this.assetsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assetsBindingNavigator.Size = new System.Drawing.Size(895, 25);
            this.assetsBindingNavigator.TabIndex = 2;
            this.assetsBindingNavigator.Text = "bindingNavigator1";
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
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "Assets";
            this.assetsBindingSource.DataSource = this.mssql2003115DataSet;
            // 
            // mssql2003115DataSet
            // 
            this.mssql2003115DataSet.DataSetName = "mssql2003115DataSet";
            this.mssql2003115DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // assetsBindingNavigatorSaveItem
            // 
            this.assetsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assetsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assetsBindingNavigatorSaveItem.Image")));
            this.assetsBindingNavigatorSaveItem.Name = "assetsBindingNavigatorSaveItem";
            this.assetsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.assetsBindingNavigatorSaveItem.Text = "Save Data";
            this.assetsBindingNavigatorSaveItem.Click += new System.EventHandler(this.assetsBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // assetIDTextBox
            // 
            this.assetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "AssetID", true));
            this.assetIDTextBox.Location = new System.Drawing.Point(93, 285);
            this.assetIDTextBox.Name = "assetIDTextBox";
            this.assetIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.assetIDTextBox.TabIndex = 5;
            // 
            // systemNameTextBox
            // 
            this.systemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "SystemName", true));
            this.systemNameTextBox.Location = new System.Drawing.Point(93, 311);
            this.systemNameTextBox.Name = "systemNameTextBox";
            this.systemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.systemNameTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(93, 337);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 9;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(278, 311);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 13;
            // 
            // iPAddressTextBox
            // 
            this.iPAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "IPAddress", true));
            this.iPAddressTextBox.Location = new System.Drawing.Point(278, 337);
            this.iPAddressTextBox.Name = "iPAddressTextBox";
            this.iPAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.iPAddressTextBox.TabIndex = 15;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(278, 288);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerTextBox.TabIndex = 16;
            // 
            // purchaseDateDateTimePicker
            // 
            this.purchaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.assetsBindingSource, "PurchaseDate", true));
            this.purchaseDateDateTimePicker.Location = new System.Drawing.Point(471, 287);
            this.purchaseDateDateTimePicker.Name = "purchaseDateDateTimePicker";
            this.purchaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchaseDateDateTimePicker.TabIndex = 17;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssetsTableAdapter = this.assetsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _307_Coursework.mssql2003115DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetsBindingSource, "Note", true));
            this.noteTextBox.Location = new System.Drawing.Point(471, 311);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(200, 20);
            this.noteTextBox.TabIndex = 19;
            // 
            // assetsDataGridView
            // 
            this.assetsDataGridView.AutoGenerateColumns = false;
            this.assetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.assetsDataGridView.DataSource = this.assetsBindingSource;
            this.assetsDataGridView.Location = new System.Drawing.Point(0, 38);
            this.assetsDataGridView.Name = "assetsDataGridView";
            this.assetsDataGridView.ReadOnly = true;
            this.assetsDataGridView.Size = new System.Drawing.Size(895, 220);
            this.assetsDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AssetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AssetID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SystemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SystemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IPAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "IPAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn8.HeaderText = "Note";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // InsertBTN
            // 
            this.InsertBTN.Location = new System.Drawing.Point(782, 529);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(75, 23);
            this.InsertBTN.TabIndex = 20;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = true;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(701, 529);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 21;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(620, 529);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 22;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 571);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.assetsDataGridView);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateTimePicker);
            this.Controls.Add(manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(iPAddressLabel);
            this.Controls.Add(this.iPAddressTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(systemNameLabel);
            this.Controls.Add(this.systemNameTextBox);
            this.Controls.Add(assetIDLabel);
            this.Controls.Add(this.assetIDTextBox);
            this.Controls.Add(this.assetsBindingNavigator);
            this.Controls.Add(this.connectionBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingNavigator)).EndInit();
            this.assetsBindingNavigator.ResumeLayout(false);
            this.assetsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2003115DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox connectionBox;
        private mssql2003115DataSet mssql2003115DataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private mssql2003115DataSetTableAdapters.AssetsTableAdapter assetsTableAdapter;
        private mssql2003115DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assetsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton assetsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox assetIDTextBox;
        private System.Windows.Forms.TextBox systemNameTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox iPAddressTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.DateTimePicker purchaseDateDateTimePicker;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DataGridView assetsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button DeleteBTN;
    }
}

