namespace StickyNote
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Font = new System.Drawing.Font("MS UI Gothic", 6F);
            this.BTN_ADD.Location = new System.Drawing.Point(12, 12);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(28, 28);
            this.BTN_ADD.TabIndex = 1;
            this.BTN_ADD.Text = "＋";
            this.BTN_ADD.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Font = new System.Drawing.Font("MS UI Gothic", 6F);
            this.BTN_EXIT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_EXIT.Location = new System.Drawing.Point(463, 12);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(25, 25);
            this.BTN_EXIT.TabIndex = 2;
            this.BTN_EXIT.Text = "×";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 40);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sticky Note";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_EXIT;
    }
}

