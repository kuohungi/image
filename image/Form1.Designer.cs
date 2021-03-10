
namespace image
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFile = new System.Windows.Forms.Button();
            this.original = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.value_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(45, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 442);
            this.panel1.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(160)))));
            this.openFile.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openFile.Location = new System.Drawing.Point(478, 45);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(326, 54);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "開啟圖檔";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // original
            // 
            this.original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.original.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.original.Location = new System.Drawing.Point(655, 141);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(149, 54);
            this.original.TabIndex = 0;
            this.original.Text = "原圖";
            this.original.UseVisualStyleBackColor = false;
            this.original.Click += new System.EventHandler(this.Original_Click);
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.gray.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gray.Location = new System.Drawing.Point(655, 225);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(149, 54);
            this.gray.TabIndex = 2;
            this.gray.Text = "灰階";
            this.gray.UseVisualStyleBackColor = false;
            this.gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.red.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.red.Location = new System.Drawing.Point(478, 141);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(149, 54);
            this.red.TabIndex = 3;
            this.red.Text = "紅階";
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.Red_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.green.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.green.Location = new System.Drawing.Point(478, 225);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(149, 54);
            this.green.TabIndex = 4;
            this.green.Text = "綠階";
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.Green_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.blue.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.blue.Location = new System.Drawing.Point(478, 309);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(149, 54);
            this.blue.TabIndex = 5;
            this.blue.Text = "藍階";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // turn
            // 
            this.turn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.turn.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.turn.Location = new System.Drawing.Point(655, 309);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(149, 54);
            this.turn.TabIndex = 6;
            this.turn.Text = "反轉";
            this.turn.UseVisualStyleBackColor = false;
            this.turn.Click += new System.EventHandler(this.Turn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(478, 401);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(326, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(545, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "閾值：";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("微軟正黑體", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.value_label.ForeColor = System.Drawing.Color.White;
            this.value_label.Location = new System.Drawing.Point(650, 458);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(50, 28);
            this.value_label.TabIndex = 9;
            this.value_label.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(862, 532);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.green);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.original);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "影像處理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button original;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button turn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label value_label;
    }
}

