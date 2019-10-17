namespace PMQL
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.btnQLThanhVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnThemTV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSuaTV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnXoaTV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnXuatExcelTV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnInTV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.tileBar2 = new DevExpress.XtraBars.Navigation.TileBar();
            this.panelThongTin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.accordionControl1.Controls.Add(this.accordionContentContainer2);
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnQLThanhVien,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsFooter.ActiveGroupDisplayMode = DevExpress.XtraBars.Navigation.ActiveGroupDisplayMode.GroupHeaderAndContent;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(259, 545);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(238, 94);
            this.accordionContentContainer1.TabIndex = 2;
            // 
            // accordionContentContainer2
            // 
            this.accordionContentContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Size = new System.Drawing.Size(238, 94);
            this.accordionContentContainer2.TabIndex = 4;
            // 
            // btnQLThanhVien
            // 
            this.btnQLThanhVien.ContentContainer = this.accordionContentContainer1;
            this.btnQLThanhVien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnThemTV,
            this.btnSuaTV,
            this.btnXoaTV,
            this.btnXuatExcelTV,
            this.btnInTV});
            this.btnQLThanhVien.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.btnQLThanhVien.ImageOptions.Image = global::PMQL.Properties.Resources.usergroup_32x321;
            this.btnQLThanhVien.Name = "btnQLThanhVien";
            this.btnQLThanhVien.Text = "QUẢN LÝ THÀNH VIÊN";
            this.btnQLThanhVien.Click += new System.EventHandler(this.BtnQLThanhVien_Click);
            // 
            // btnThemTV
            // 
            this.btnThemTV.ImageOptions.SvgImage = global::PMQL.Properties.Resources.newemployee;
            this.btnThemTV.Name = "btnThemTV";
            this.btnThemTV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnThemTV.Text = "Thêm thành viên";
            this.btnThemTV.Click += new System.EventHandler(this.BtnThemTV_Click);
            // 
            // btnSuaTV
            // 
            this.btnSuaTV.ImageOptions.SvgImage = global::PMQL.Properties.Resources.actions_edit1;
            this.btnSuaTV.Name = "btnSuaTV";
            this.btnSuaTV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSuaTV.Text = "Sửa thông tin thành viên";
            // 
            // btnXoaTV
            // 
            this.btnXoaTV.ImageOptions.SvgImage = global::PMQL.Properties.Resources.del;
            this.btnXoaTV.Name = "btnXoaTV";
            this.btnXoaTV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnXoaTV.Text = "Xóa thành viên";
            // 
            // btnXuatExcelTV
            // 
            this.btnXuatExcelTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcelTV.ImageOptions.Image")));
            this.btnXuatExcelTV.Name = "btnXuatExcelTV";
            this.btnXuatExcelTV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnXuatExcelTV.Text = "Xuất Excel";
            // 
            // btnInTV
            // 
            this.btnInTV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInTV.ImageOptions.SvgImage")));
            this.btnInTV.Name = "btnInTV";
            this.btnInTV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnInTV.Text = "In ";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ContentContainer = this.accordionContentContainer2;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.accordionControlElement7});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.Image = global::PMQL.Properties.Resources.calendar_32x32;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "QUẢN LÝ ĐIỂM DANH";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left)});
            this.accordionControlElement6.ImageOptions.SvgImage = global::PMQL.Properties.Resources.opencalendar;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Thêm điểm danh";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.ImageOptions.SvgImage = global::PMQL.Properties.Resources.editquery;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Sửa điểm danh";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1052, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // tileBar2
            // 
            this.tileBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileBar2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar2.Location = new System.Drawing.Point(1038, 30);
            this.tileBar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tileBar2.Name = "tileBar2";
            this.tileBar2.Padding = new System.Windows.Forms.Padding(26, 9, 26, 9);
            this.tileBar2.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar2.Size = new System.Drawing.Size(14, 545);
            this.tileBar2.TabIndex = 4;
            this.tileBar2.Text = "tileBar2";
            // 
            // panelThongTin
            // 
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Location = new System.Drawing.Point(259, 30);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(779, 545);
            this.panelThongTin.TabIndex = 5;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 575);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.tileBar2);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrangChu";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Phần mềm quản lý thành viên CLB";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnQLThanhVien;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnThemTV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSuaTV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnXoaTV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.TileBar tileBar2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnInTV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnXuatExcelTV;
        private System.Windows.Forms.Panel panelThongTin;
    }
}