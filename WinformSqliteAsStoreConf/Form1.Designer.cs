
namespace WinformSqliteAsStoreConf
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
            this.BtnWriteKey = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReadMysqlPort = new System.Windows.Forms.TextBox();
            this.TxtReadMysqlUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtReadMysqlUsername = new System.Windows.Forms.TextBox();
            this.TxtReadMysqlPassword = new System.Windows.Forms.TextBox();
            this.TxtReadMysqlDBName = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnWriteKey
            // 
            this.BtnWriteKey.Location = new System.Drawing.Point(11, 145);
            this.BtnWriteKey.Name = "BtnWriteKey";
            this.BtnWriteKey.Size = new System.Drawing.Size(100, 23);
            this.BtnWriteKey.TabIndex = 0;
            this.BtnWriteKey.Text = "Write";
            this.BtnWriteKey.UseVisualStyleBackColor = true;
            this.BtnWriteKey.Click += new System.EventHandler(this.BtnWriteKey_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtReadMysqlDBName);
            this.groupBox3.Controls.Add(this.TxtReadMysqlPassword);
            this.groupBox3.Controls.Add(this.BtnWriteKey);
            this.groupBox3.Controls.Add(this.TxtReadMysqlUsername);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BtnRead);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtReadMysqlPort);
            this.groupBox3.Controls.Add(this.TxtReadMysqlUrl);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 186);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read and Write Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "MySQL URL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "MySQL Username";
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(117, 145);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(100, 23);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "MySQL Port";
            // 
            // TxtReadMysqlPort
            // 
            this.TxtReadMysqlPort.Location = new System.Drawing.Point(117, 47);
            this.TxtReadMysqlPort.Name = "TxtReadMysqlPort";
            this.TxtReadMysqlPort.Size = new System.Drawing.Size(100, 20);
            this.TxtReadMysqlPort.TabIndex = 1;
            // 
            // TxtReadMysqlUrl
            // 
            this.TxtReadMysqlUrl.Location = new System.Drawing.Point(117, 23);
            this.TxtReadMysqlUrl.Name = "TxtReadMysqlUrl";
            this.TxtReadMysqlUrl.Size = new System.Drawing.Size(100, 20);
            this.TxtReadMysqlUrl.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File configuration : dbsettings.db";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "MySQL Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "MySQL DBName";
            // 
            // TxtReadMysqlUsername
            // 
            this.TxtReadMysqlUsername.Location = new System.Drawing.Point(117, 71);
            this.TxtReadMysqlUsername.Name = "TxtReadMysqlUsername";
            this.TxtReadMysqlUsername.Size = new System.Drawing.Size(100, 20);
            this.TxtReadMysqlUsername.TabIndex = 9;
            // 
            // TxtReadMysqlPassword
            // 
            this.TxtReadMysqlPassword.Location = new System.Drawing.Point(117, 95);
            this.TxtReadMysqlPassword.Name = "TxtReadMysqlPassword";
            this.TxtReadMysqlPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtReadMysqlPassword.TabIndex = 10;
            // 
            // TxtReadMysqlDBName
            // 
            this.TxtReadMysqlDBName.Location = new System.Drawing.Point(117, 119);
            this.TxtReadMysqlDBName.Name = "TxtReadMysqlDBName";
            this.TxtReadMysqlDBName.Size = new System.Drawing.Size(100, 20);
            this.TxtReadMysqlDBName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 229);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWriteKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtReadMysqlPort;
        private System.Windows.Forms.TextBox TxtReadMysqlUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtReadMysqlDBName;
        private System.Windows.Forms.TextBox TxtReadMysqlPassword;
        private System.Windows.Forms.TextBox TxtReadMysqlUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

