namespace KTGK_QLVPP
{
    partial class MH_In_DSSP
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
            this.crvBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvBaoCao
            // 
            this.crvBaoCao.ActiveViewIndex = -1;
            this.crvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCao.Location = new System.Drawing.Point(1, 1);
            this.crvBaoCao.Name = "crvBaoCao";
            this.crvBaoCao.Size = new System.Drawing.Size(799, 530);
            this.crvBaoCao.TabIndex = 0;
            // 
            // MH_In_DSSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 532);
            this.Controls.Add(this.crvBaoCao);
            this.Name = "MH_In_DSSP";
            this.Text = "MH_In_DSSP";
            this.Load += new System.EventHandler(this.MH_In_DSSP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCao;
    }
}