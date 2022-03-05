namespace CopyPractice
{
    partial class FileRename
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstLoadFiles = new System.Windows.Forms.ListBox();
            this.txtInputDir = new System.Windows.Forms.TextBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "フォルダを選択";
            // 
            // lstLoadFiles
            // 
            this.lstLoadFiles.FormattingEnabled = true;
            this.lstLoadFiles.ItemHeight = 18;
            this.lstLoadFiles.Location = new System.Drawing.Point(75, 258);
            this.lstLoadFiles.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstLoadFiles.Name = "lstLoadFiles";
            this.lstLoadFiles.Size = new System.Drawing.Size(726, 616);
            this.lstLoadFiles.TabIndex = 1;
            this.lstLoadFiles.SelectedIndexChanged += new System.EventHandler(this.lstLoadFiles_SelectedIndexChanged);
            // 
            // txtInputDir
            // 
            this.txtInputDir.Location = new System.Drawing.Point(75, 96);
            this.txtInputDir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInputDir.Name = "txtInputDir";
            this.txtInputDir.Size = new System.Drawing.Size(561, 25);
            this.txtInputDir.TabIndex = 2;
            this.txtInputDir.Text = "aaaaaaaaaaiiiiiiiiiioooooooooo";
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(702, 96);
            this.btnRef.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(102, 28);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "参照";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(75, 156);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(142, 28);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "読み込み";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(525, 908);
            this.btnRename.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(278, 34);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "ファイル名を最終更新日に変更";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(72, 915);
            this.lblFileCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(131, 18);
            this.lblFileCount.TabIndex = 6;
            this.lblFileCount.Text = "ファイル件数表示";
            // 
            // FileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 993);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.txtInputDir);
            this.Controls.Add(this.lstLoadFiles);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FileRename";
            this.Text = "ファイル名変更";
            this.Shown += new System.EventHandler(this.FileRename_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLoadFiles;
        private System.Windows.Forms.TextBox txtInputDir;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label lblFileCount;
    }
}

