namespace StickyMemo
{
    partial class StickyMemo
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
            this.InputMemo = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.ColorDialog();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputMemo
            // 
            this.InputMemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InputMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputMemo.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputMemo.Location = new System.Drawing.Point(0, 0);
            this.InputMemo.Multiline = true;
            this.InputMemo.Name = "InputMemo";
            this.InputMemo.Size = new System.Drawing.Size(500, 500);
            this.InputMemo.TabIndex = 0;
            this.InputMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputMemo_KeyDown);
            this.InputMemo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.InputMemo_MouseDoubleClick);
            this.InputMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InputMemo_MouseDown);
            this.InputMemo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InputMemo_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(450, 461);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(43, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "×";
            this.CloseButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // StickyMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.InputMemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StickyMemo";
            this.Opacity = 0.7D;
            this.Text = "StickyMemo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputMemo;
        private System.Windows.Forms.ColorDialog Color;
        private System.Windows.Forms.Label CloseButton;
    }
}

