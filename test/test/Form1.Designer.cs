namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t1 = new DevExpress.XtraEditors.TextEdit();
            this.t2 = new DevExpress.XtraEditors.TextEdit();
            this.t3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.t1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "total";
            // 
            // t1
            // 
            this.t1.EditValue = 0;
            this.t1.Location = new System.Drawing.Point(58, 15);
            this.t1.Name = "t1";
            this.t1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.t1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.t1.Properties.Mask.EditMask = "d";
            this.t1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.t1.Properties.NullText = "0";
            this.t1.Size = new System.Drawing.Size(103, 20);
            this.t1.TabIndex = 6;
            this.t1.EditValueChanged += new System.EventHandler(this.t1_EditValueChanged);
            this.t1.Enter += new System.EventHandler(this.t1_KeyPress);
            // 
            // t2
            // 
            this.t2.EditValue = 0;
            this.t2.Location = new System.Drawing.Point(58, 51);
            this.t2.Name = "t2";
            this.t2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.t2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.t2.Properties.Mask.EditMask = "d";
            this.t2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.t2.Properties.NullText = "0";
            this.t2.Size = new System.Drawing.Size(103, 20);
            this.t2.TabIndex = 7;
            this.t2.EditValueChanged += new System.EventHandler(this.t2_EditValueChanged);
            this.t2.Enter += new System.EventHandler(this.t2_KeyPress);
            // 
            // t3
            // 
            this.t3.EditValue = 0;
            this.t3.Location = new System.Drawing.Point(58, 88);
            this.t3.Name = "t3";
            this.t3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.t3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.t3.Properties.Mask.EditMask = "d";
            this.t3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.t3.Properties.NullText = "0";
            this.t3.Size = new System.Drawing.Size(103, 20);
            this.t3.TabIndex = 8;
            this.t3.EditValueChanged += new System.EventHandler(this.t3_EditValueChanged);
            this.t3.Enter += new System.EventHandler(this.t3_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.t1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit t1;
        private DevExpress.XtraEditors.TextEdit t2;
        private DevExpress.XtraEditors.TextEdit t3;

    }
}

