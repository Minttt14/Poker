namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFund = new System.Windows.Forms.Label();
            this.lblOdds = new System.Windows.Forms.Label();
            this.lblReceive = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(26, 24);
            this.grpPoker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpPoker.Size = new System.Drawing.Size(1051, 320);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(26, 537);
            this.grpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpButton.Name = "grpButton";
            this.grpButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpButton.Size = new System.Drawing.Size(1051, 160);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(546, 56);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(483, 72);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCheck.Enabled = false;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(355, 56);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(178, 72);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeCard.Location = new System.Drawing.Point(204, 56);
            this.btnChangeCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(139, 72);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = false;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDealCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDealCard.Location = new System.Drawing.Point(46, 56);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(145, 72);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = false;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFund);
            this.groupBox1.Controls.Add(this.btnBet);
            this.groupBox1.Controls.Add(this.txtBet);
            this.groupBox1.Controls.Add(this.lblBet);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(26, 356);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1051, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "下注";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1.Location = new System.Drawing.Point(52, 76);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 40);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "總資金";
            // 
            // txtBet
            // 
            this.txtBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBet.Location = new System.Drawing.Point(603, 70);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(255, 50);
            this.txtBet.TabIndex = 3;
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBet.Location = new System.Drawing.Point(449, 76);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(145, 40);
            this.lblBet.TabIndex = 2;
            this.lblBet.Text = "押注金額";
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBet.Location = new System.Drawing.Point(889, 55);
            this.btnBet.Margin = new System.Windows.Forms.Padding(6);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(127, 77);
            this.btnBet.TabIndex = 4;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReceive);
            this.groupBox2.Controls.Add(this.lblOdds);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(26, 709);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1051, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "結果";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2.Location = new System.Drawing.Point(392, 67);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(145, 40);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "獲得金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "賠率";
            // 
            // lblFund
            // 
            this.lblFund.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFund.Location = new System.Drawing.Point(171, 73);
            this.lblFund.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFund.Name = "lblFund";
            this.lblFund.Size = new System.Drawing.Size(269, 48);
            this.lblFund.TabIndex = 5;
            this.lblFund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdds
            // 
            this.lblOdds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOdds.ForeColor = System.Drawing.Color.Red;
            this.lblOdds.Location = new System.Drawing.Point(142, 66);
            this.lblOdds.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOdds.Name = "lblOdds";
            this.lblOdds.Size = new System.Drawing.Size(178, 48);
            this.lblOdds.TabIndex = 6;
            this.lblOdds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceive
            // 
            this.lblReceive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceive.ForeColor = System.Drawing.Color.Red;
            this.lblReceive.Location = new System.Drawing.Point(546, 64);
            this.lblReceive.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(301, 48);
            this.lblReceive.TabIndex = 7;
            this.lblReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 876);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.grpButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFund;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Label lblOdds;
    }
}