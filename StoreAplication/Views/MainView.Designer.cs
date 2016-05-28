namespace StoreAplication.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this._menuToolStrip = new System.Windows.Forms.ToolStrip();
            this._productToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this._productObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this._nameOlvColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._costOlvColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._amountOlvColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._menuToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._productObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuToolStrip
            // 
            this._menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._productToolStripDropDownButton,
            this._closeToolStripButton});
            this._menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this._menuToolStrip.Name = "_menuToolStrip";
            this._menuToolStrip.Size = new System.Drawing.Size(777, 25);
            this._menuToolStrip.TabIndex = 1;
            this._menuToolStrip.Text = "toolStrip1";
            // 
            // _productToolStripDropDownButton
            // 
            this._productToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._productToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this._productToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("_productToolStripDropDownButton.Image")));
            this._productToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._productToolStripDropDownButton.Name = "_productToolStripDropDownButton";
            this._productToolStripDropDownButton.Size = new System.Drawing.Size(62, 22);
            this._productToolStripDropDownButton.Text = "Товары";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // _closeToolStripButton
            // 
            this._closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_closeToolStripButton.Image")));
            this._closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._closeToolStripButton.Name = "_closeToolStripButton";
            this._closeToolStripButton.Size = new System.Drawing.Size(45, 22);
            this._closeToolStripButton.Text = "Выход";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._productObjectListView);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 305);
            this.panel1.TabIndex = 2;
            // 
            // _productObjectListView
            // 
            this._productObjectListView.AllColumns.Add(this._nameOlvColumn);
            this._productObjectListView.AllColumns.Add(this._costOlvColumn);
            this._productObjectListView.AllColumns.Add(this._amountOlvColumn);
            this._productObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nameOlvColumn,
            this._costOlvColumn,
            this._amountOlvColumn});
            this._productObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productObjectListView.Location = new System.Drawing.Point(0, 0);
            this._productObjectListView.Name = "_productObjectListView";
            this._productObjectListView.ShowGroups = false;
            this._productObjectListView.Size = new System.Drawing.Size(753, 305);
            this._productObjectListView.TabIndex = 0;
            this._productObjectListView.UseCompatibleStateImageBehavior = false;
            this._productObjectListView.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 38);
            this.panel2.TabIndex = 3;
            // 
            // _nameOlvColumn
            // 
            this._nameOlvColumn.AspectName = "Name";
            this._nameOlvColumn.CellPadding = null;
            this._nameOlvColumn.Text = "Name";
            // 
            // _costOlvColumn
            // 
            this._costOlvColumn.AspectName = "Cost";
            this._costOlvColumn.CellPadding = null;
            this._costOlvColumn.Text = "Cost";
            // 
            // _amountOlvColumn
            // 
            this._amountOlvColumn.AspectName = "Amount";
            this._amountOlvColumn.CellPadding = null;
            this._amountOlvColumn.Text = "Amount";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._menuToolStrip);
            this.Name = "MainView";
            this.Text = "MainView";
            this._menuToolStrip.ResumeLayout(false);
            this._menuToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._productObjectListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _menuToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton _productToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton _closeToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private BrightIdeasSoftware.ObjectListView _productObjectListView;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.OLVColumn _nameOlvColumn;
        private BrightIdeasSoftware.OLVColumn _costOlvColumn;
        private BrightIdeasSoftware.OLVColumn _amountOlvColumn;
    }
}