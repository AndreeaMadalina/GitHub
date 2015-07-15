namespace StudentOrganizarFinalVersion
{
    partial class List
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
            this.CreateStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UpdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.GridControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.EditStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.DeleteButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.EditButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl2)).BeginInit();
            this.GridControl2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Location = new System.Drawing.Point(3, 17);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(75, 23);
            this.CreateStudentButton.TabIndex = 1;
            this.CreateStudentButton.Text = "Create New";
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // GridControl
            // 
            this.GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl.Location = new System.Drawing.Point(3, 46);
            this.GridControl.MainView = this.gridView3;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(658, 356);
            this.GridControl.TabIndex = 0;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView1});
            this.GridControl.Click += new System.EventHandler(this.GridControl_Click);
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.GridControl;
            this.gridView3.Name = "gridView3";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(84, 17);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GridControl2
            // 
            this.GridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl2.Location = new System.Drawing.Point(12, 12);
            this.GridControl2.Name = "GridControl2";
            this.GridControl2.SelectedTabPage = this.xtraTabPage1;
            this.GridControl2.Size = new System.Drawing.Size(667, 430);
            this.GridControl2.TabIndex = 4;
            this.GridControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.DeleteButton);
            this.xtraTabPage1.Controls.Add(this.EditStudentButton);
            this.xtraTabPage1.Controls.Add(this.GridControl);
            this.xtraTabPage1.Controls.Add(this.CreateStudentButton);
            this.xtraTabPage1.Controls.Add(this.UpdateButton);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(661, 402);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(246, 17);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Location = new System.Drawing.Point(165, 17);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(75, 23);
            this.EditStudentButton.TabIndex = 0;
            this.EditStudentButton.Text = "Edit";
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.DeleteButton2);
            this.xtraTabPage2.Controls.Add(this.EditButton2);
            this.xtraTabPage2.Controls.Add(this.simpleButton3);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(661, 402);
            this.xtraTabPage2.Text = "xtraTabPage2";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // DeleteButton2
            // 
            this.DeleteButton2.Location = new System.Drawing.Point(248, 14);
            this.DeleteButton2.Name = "DeleteButton2";
            this.DeleteButton2.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton2.TabIndex = 6;
            this.DeleteButton2.Text = "Delete";
            // 
            // EditButton2
            // 
            this.EditButton2.Location = new System.Drawing.Point(166, 15);
            this.EditButton2.Name = "EditButton2";
            this.EditButton2.Size = new System.Drawing.Size(75, 23);
            this.EditButton2.TabIndex = 5;
            this.EditButton2.Text = "Edit";
            this.EditButton2.Click += new System.EventHandler(this.EditButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(84, 15);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Update";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(3, 15);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Create New";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 44);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(658, 355);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.GridControl2);
            this.Name = "List";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl2)).EndInit();
            this.GridControl2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CreateStudentButton;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton UpdateButton;
        private DevExpress.XtraTab.XtraTabControl GridControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton EditStudentButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton2;
        private DevExpress.XtraEditors.SimpleButton EditButton2;
    }
}