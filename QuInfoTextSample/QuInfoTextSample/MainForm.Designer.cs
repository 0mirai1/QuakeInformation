
namespace QuInfoTextSample
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.QuInfoTimer = new System.Windows.Forms.Timer(this.components);
            this.EpicenterLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MaxintLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.MagnitubeLabel = new System.Windows.Forms.Label();
            this.CityInfoRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuInfoTimer
            // 
            this.QuInfoTimer.Enabled = true;
            this.QuInfoTimer.Interval = 5000;
            this.QuInfoTimer.Tick += new System.EventHandler(this.QuInfoTimer_Tick);
            // 
            // EpicenterLabel
            // 
            this.EpicenterLabel.AutoSize = true;
            this.EpicenterLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EpicenterLabel.Location = new System.Drawing.Point(12, 62);
            this.EpicenterLabel.Name = "EpicenterLabel";
            this.EpicenterLabel.Size = new System.Drawing.Size(59, 13);
            this.EpicenterLabel.TabIndex = 0;
            this.EpicenterLabel.Text = "震源地名";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(45, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "タイトル";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 35);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(59, 13);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "発生時刻";
            // 
            // MaxintLabel
            // 
            this.MaxintLabel.AutoSize = true;
            this.MaxintLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxintLabel.Location = new System.Drawing.Point(12, 89);
            this.MaxintLabel.Name = "MaxintLabel";
            this.MaxintLabel.Size = new System.Drawing.Size(59, 13);
            this.MaxintLabel.TabIndex = 3;
            this.MaxintLabel.Text = "最大震度";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DepthLabel.Location = new System.Drawing.Point(12, 115);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(29, 13);
            this.DepthLabel.TabIndex = 4;
            this.DepthLabel.Text = "深さ";
            // 
            // MagnitubeLabel
            // 
            this.MagnitubeLabel.AutoSize = true;
            this.MagnitubeLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MagnitubeLabel.Location = new System.Drawing.Point(12, 142);
            this.MagnitubeLabel.Name = "MagnitubeLabel";
            this.MagnitubeLabel.Size = new System.Drawing.Size(76, 13);
            this.MagnitubeLabel.TabIndex = 5;
            this.MagnitubeLabel.Text = "マグニチュード";
            // 
            // CityInfoRichTextBox1
            // 
            this.CityInfoRichTextBox1.Location = new System.Drawing.Point(15, 176);
            this.CityInfoRichTextBox1.Name = "CityInfoRichTextBox1";
            this.CityInfoRichTextBox1.ReadOnly = true;
            this.CityInfoRichTextBox1.Size = new System.Drawing.Size(536, 164);
            this.CityInfoRichTextBox1.TabIndex = 6;
            this.CityInfoRichTextBox1.Text = "";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(203, 10);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(51, 12);
            this.CommentLabel.TabIndex = 7;
            this.CommentLabel.Text = "comment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 352);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CityInfoRichTextBox1);
            this.Controls.Add(this.MagnitubeLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.MaxintLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EpicenterLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer QuInfoTimer;
        private System.Windows.Forms.Label EpicenterLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MaxintLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label MagnitubeLabel;
        private System.Windows.Forms.RichTextBox CityInfoRichTextBox1;
        private System.Windows.Forms.Label CommentLabel;
    }
}

