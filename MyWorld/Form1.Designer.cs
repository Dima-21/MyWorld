namespace MyWorld
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
            this.components = new System.ComponentModel.Container();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextHuman = new System.Windows.Forms.TextBox();
            this.TextWarriors = new System.Windows.Forms.TextBox();
            this.TextMoney = new System.Windows.Forms.TextBox();
            this.TrackSell = new System.Windows.Forms.TrackBar();
            this.TrackHire = new System.Windows.Forms.TrackBar();
            this.TrackSend = new System.Windows.Forms.TrackBar();
            this.BSell = new System.Windows.Forms.Button();
            this.BHire = new System.Windows.Forms.Button();
            this.BSend = new System.Windows.Forms.Button();
            this.LSell = new System.Windows.Forms.Label();
            this.LHire = new System.Windows.Forms.Label();
            this.LSend = new System.Windows.Forms.Label();
            this.LStats = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(13, 13);
            this.ProgressBar.Maximum = 1000;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(308, 23);
            this.ProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Люди:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Воины:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "$:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Продать людей:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Нанять воинов:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "Послать в атаку:";
            // 
            // TextHuman
            // 
            this.TextHuman.Location = new System.Drawing.Point(83, 51);
            this.TextHuman.Name = "TextHuman";
            this.TextHuman.ReadOnly = true;
            this.TextHuman.Size = new System.Drawing.Size(100, 20);
            this.TextHuman.TabIndex = 7;
            // 
            // TextWarriors
            // 
            this.TextWarriors.Location = new System.Drawing.Point(83, 82);
            this.TextWarriors.Name = "TextWarriors";
            this.TextWarriors.ReadOnly = true;
            this.TextWarriors.Size = new System.Drawing.Size(100, 20);
            this.TextWarriors.TabIndex = 8;
            // 
            // TextMoney
            // 
            this.TextMoney.Location = new System.Drawing.Point(83, 119);
            this.TextMoney.Name = "TextMoney";
            this.TextMoney.ReadOnly = true;
            this.TextMoney.Size = new System.Drawing.Size(100, 20);
            this.TextMoney.TabIndex = 9;
            // 
            // TrackSell
            // 
            this.TrackSell.Location = new System.Drawing.Point(89, 161);
            this.TrackSell.Name = "TrackSell";
            this.TrackSell.Size = new System.Drawing.Size(165, 45);
            this.TrackSell.TabIndex = 10;
            this.TrackSell.TickFrequency = 10;
            this.TrackSell.Scroll += new System.EventHandler(this.TrackSell_Scroll);
            // 
            // TrackHire
            // 
            this.TrackHire.Location = new System.Drawing.Point(89, 212);
            this.TrackHire.Name = "TrackHire";
            this.TrackHire.Size = new System.Drawing.Size(165, 45);
            this.TrackHire.TabIndex = 11;
            this.TrackHire.Scroll += new System.EventHandler(this.TrackHire_Scroll);
            // 
            // TrackSend
            // 
            this.TrackSend.Location = new System.Drawing.Point(89, 262);
            this.TrackSend.Name = "TrackSend";
            this.TrackSend.Size = new System.Drawing.Size(165, 45);
            this.TrackSend.TabIndex = 12;
            this.TrackSend.Scroll += new System.EventHandler(this.TrackSend_Scroll);
            // 
            // BSell
            // 
            this.BSell.Location = new System.Drawing.Point(260, 161);
            this.BSell.Name = "BSell";
            this.BSell.Size = new System.Drawing.Size(48, 23);
            this.BSell.TabIndex = 13;
            this.BSell.Text = "OK";
            this.BSell.UseVisualStyleBackColor = true;
            this.BSell.Click += new System.EventHandler(this.BSell_Click);
            // 
            // BHire
            // 
            this.BHire.Location = new System.Drawing.Point(260, 214);
            this.BHire.Name = "BHire";
            this.BHire.Size = new System.Drawing.Size(48, 23);
            this.BHire.TabIndex = 14;
            this.BHire.Text = "OK";
            this.BHire.UseVisualStyleBackColor = true;
            this.BHire.Click += new System.EventHandler(this.BHire_Click);
            // 
            // BSend
            // 
            this.BSend.Location = new System.Drawing.Point(260, 262);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(61, 23);
            this.BSend.TabIndex = 15;
            this.BSend.Text = "Послать";
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // LSell
            // 
            this.LSell.AutoSize = true;
            this.LSell.Location = new System.Drawing.Point(233, 145);
            this.LSell.Name = "LSell";
            this.LSell.Size = new System.Drawing.Size(13, 13);
            this.LSell.TabIndex = 16;
            this.LSell.Text = "0";
            // 
            // LHire
            // 
            this.LHire.AutoSize = true;
            this.LHire.Location = new System.Drawing.Point(233, 196);
            this.LHire.Name = "LHire";
            this.LHire.Size = new System.Drawing.Size(13, 13);
            this.LHire.TabIndex = 17;
            this.LHire.Text = "0";
            // 
            // LSend
            // 
            this.LSend.AutoSize = true;
            this.LSend.Location = new System.Drawing.Point(233, 246);
            this.LSend.Name = "LSend";
            this.LSend.Size = new System.Drawing.Size(13, 13);
            this.LSend.TabIndex = 18;
            this.LSend.Text = "0";
            // 
            // LStats
            // 
            this.LStats.AutoSize = true;
            this.LStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LStats.ForeColor = System.Drawing.Color.Red;
            this.LStats.Location = new System.Drawing.Point(194, 51);
            this.LStats.Name = "LStats";
            this.LStats.Size = new System.Drawing.Size(0, 20);
            this.LStats.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BStart
            // 
            this.BStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(211, 82);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(97, 40);
            this.BStart.TabIndex = 20;
            this.BStart.Text = "Новая игра";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Visible = false;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 332);
            this.Controls.Add(this.BStart);
            this.Controls.Add(this.LStats);
            this.Controls.Add(this.LSend);
            this.Controls.Add(this.LHire);
            this.Controls.Add(this.LSell);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.BHire);
            this.Controls.Add(this.BSell);
            this.Controls.Add(this.TrackSend);
            this.Controls.Add(this.TrackHire);
            this.Controls.Add(this.TrackSell);
            this.Controls.Add(this.TextMoney);
            this.Controls.Add(this.TextWarriors);
            this.Controls.Add(this.TextHuman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar);
            this.Name = "Form1";
            this.Text = "My World";
            ((System.ComponentModel.ISupportInitialize)(this.TrackSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextHuman;
        private System.Windows.Forms.TextBox TextWarriors;
        private System.Windows.Forms.TextBox TextMoney;
        private System.Windows.Forms.TrackBar TrackSell;
        private System.Windows.Forms.TrackBar TrackHire;
        private System.Windows.Forms.TrackBar TrackSend;
        private System.Windows.Forms.Button BSell;
        private System.Windows.Forms.Button BHire;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Label LSell;
        private System.Windows.Forms.Label LHire;
        private System.Windows.Forms.Label LSend;
        private System.Windows.Forms.Label LStats;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BStart;
    }
}

