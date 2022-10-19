namespace CompanyCodingTest2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnMenu1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu5 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listBoxControl1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnMenu5);
            this.panelControl1.Controls.Add(this.btnMenu3);
            this.panelControl1.Controls.Add(this.btnMenu4);
            this.panelControl1.Controls.Add(this.btnMenu2);
            this.panelControl1.Controls.Add(this.btnMenu1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 405);
            this.panelControl1.TabIndex = 0;
            // 
            // btnMenu1
            // 
            this.btnMenu1.Location = new System.Drawing.Point(45, 12);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(75, 23);
            this.btnMenu1.TabIndex = 1;
            this.btnMenu1.Text = "메뉴 1";
            // 
            // btnMenu2
            // 
            this.btnMenu2.Location = new System.Drawing.Point(148, 12);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(75, 23);
            this.btnMenu2.TabIndex = 1;
            this.btnMenu2.Text = "메뉴 2";
            // 
            // btnMenu3
            // 
            this.btnMenu3.Location = new System.Drawing.Point(10, 62);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(75, 23);
            this.btnMenu3.TabIndex = 1;
            this.btnMenu3.Text = "메뉴 3";
            // 
            // btnMenu4
            // 
            this.btnMenu4.Location = new System.Drawing.Point(106, 61);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(75, 23);
            this.btnMenu4.TabIndex = 1;
            this.btnMenu4.Text = "메뉴 4";
            // 
            // btnMenu5
            // 
            this.btnMenu5.Location = new System.Drawing.Point(202, 61);
            this.btnMenu5.Name = "btnMenu5";
            this.btnMenu5.Size = new System.Drawing.Size(75, 23);
            this.btnMenu5.TabIndex = 1;
            this.btnMenu5.Text = "메뉴 5";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(11, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(262, 37);
            this.labelControl1.TabIndex = 2;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(10, 147);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(267, 246);
            this.listBoxControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 405);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnMenu5;
        private DevExpress.XtraEditors.SimpleButton btnMenu3;
        private DevExpress.XtraEditors.SimpleButton btnMenu4;
        private DevExpress.XtraEditors.SimpleButton btnMenu2;
        private DevExpress.XtraEditors.SimpleButton btnMenu1;
    }
}

