namespace EpisodeTimer
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
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMinDuration = new System.Windows.Forms.Label();
            this.lblMaxDuration = new System.Windows.Forms.Label();
            this.btnMinDuration = new System.Windows.Forms.Button();
            this.btnMaxDuration = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.btnHotkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(12, 9);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(337, 108);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "000:00";
            // 
            // lblMinDuration
            // 
            this.lblMinDuration.AutoSize = true;
            this.lblMinDuration.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMinDuration.Location = new System.Drawing.Point(355, 9);
            this.lblMinDuration.Name = "lblMinDuration";
            this.lblMinDuration.Size = new System.Drawing.Size(40, 13);
            this.lblMinDuration.TabIndex = 1;
            this.lblMinDuration.Text = "000:00";
            // 
            // lblMaxDuration
            // 
            this.lblMaxDuration.AutoSize = true;
            this.lblMaxDuration.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaxDuration.Location = new System.Drawing.Point(355, 61);
            this.lblMaxDuration.Name = "lblMaxDuration";
            this.lblMaxDuration.Size = new System.Drawing.Size(40, 13);
            this.lblMaxDuration.TabIndex = 2;
            this.lblMaxDuration.Text = "000:00";
            // 
            // btnMinDuration
            // 
            this.btnMinDuration.Location = new System.Drawing.Point(355, 25);
            this.btnMinDuration.Name = "btnMinDuration";
            this.btnMinDuration.Size = new System.Drawing.Size(56, 23);
            this.btnMinDuration.TabIndex = 3;
            this.btnMinDuration.Text = "Set Min";
            this.btnMinDuration.UseVisualStyleBackColor = true;
            // 
            // btnMaxDuration
            // 
            this.btnMaxDuration.Location = new System.Drawing.Point(355, 77);
            this.btnMaxDuration.Name = "btnMaxDuration";
            this.btnMaxDuration.Size = new System.Drawing.Size(56, 23);
            this.btnMaxDuration.TabIndex = 4;
            this.btnMaxDuration.Text = "Set Max";
            this.btnMaxDuration.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(30, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 41);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(355, 138);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(228, 120);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(45, 13);
            this.lblHotkey.TabIndex = 7;
            this.lblHotkey.Text = "HotKey:";
            // 
            // btnHotkey
            // 
            this.btnHotkey.Location = new System.Drawing.Point(231, 138);
            this.btnHotkey.Name = "btnHotkey";
            this.btnHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnHotkey.TabIndex = 8;
            this.btnHotkey.Text = "Set Hotkey";
            this.btnHotkey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 173);
            this.Controls.Add(this.btnHotkey);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnMaxDuration);
            this.Controls.Add(this.btnMinDuration);
            this.Controls.Add(this.lblMaxDuration);
            this.Controls.Add(this.lblMinDuration);
            this.Controls.Add(this.lblDuration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Episode Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMinDuration;
        private System.Windows.Forms.Label lblMaxDuration;
        private System.Windows.Forms.Button btnMinDuration;
        private System.Windows.Forms.Button btnMaxDuration;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.Button btnHotkey;
    }
}

