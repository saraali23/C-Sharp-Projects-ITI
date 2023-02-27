namespace Task
{
    partial class DetaledView
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
            this.lbl_pub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pubCombo = new System.Windows.Forms.ComboBox();
            this.txt_titleId = new System.Windows.Forms.TextBox();
            this.txt_titlePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_titleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_titleType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pub
            // 
            this.lbl_pub.AutoSize = true;
            this.lbl_pub.Location = new System.Drawing.Point(51, 296);
            this.lbl_pub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pub.Name = "lbl_pub";
            this.lbl_pub.Size = new System.Drawing.Size(92, 25);
            this.lbl_pub.TabIndex = 20;
            this.lbl_pub.Text = "Publishers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Title Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "TitleId";
            // 
            // pubCombo
            // 
            this.pubCombo.FormattingEnabled = true;
            this.pubCombo.Location = new System.Drawing.Point(225, 296);
            this.pubCombo.Name = "pubCombo";
            this.pubCombo.Size = new System.Drawing.Size(182, 33);
            this.pubCombo.TabIndex = 16;
            // 
            // txt_titleId
            // 
            this.txt_titleId.Location = new System.Drawing.Point(237, 64);
            this.txt_titleId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_titleId.Name = "txt_titleId";
            this.txt_titleId.Size = new System.Drawing.Size(155, 31);
            this.txt_titleId.TabIndex = 14;
            this.txt_titleId.Text = "NAN";
            // 
            // txt_titlePrice
            // 
            this.txt_titlePrice.Location = new System.Drawing.Point(237, 233);
            this.txt_titlePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_titlePrice.Name = "txt_titlePrice";
            this.txt_titlePrice.Size = new System.Drawing.Size(155, 31);
            this.txt_titlePrice.TabIndex = 24;
            this.txt_titlePrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Title Name";
            // 
            // txt_titleName
            // 
            this.txt_titleName.Location = new System.Drawing.Point(237, 118);
            this.txt_titleName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_titleName.Name = "txt_titleName";
            this.txt_titleName.Size = new System.Drawing.Size(155, 31);
            this.txt_titleName.TabIndex = 25;
            this.txt_titleName.Text = "NAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Type";
            // 
            // txt_titleType
            // 
            this.txt_titleType.Location = new System.Drawing.Point(237, 177);
            this.txt_titleType.Margin = new System.Windows.Forms.Padding(4);
            this.txt_titleType.Name = "txt_titleType";
            this.txt_titleType.Size = new System.Drawing.Size(155, 31);
            this.txt_titleType.TabIndex = 27;
            this.txt_titleType.Text = "NAN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exexute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetaledView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_titleType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_titleName);
            this.Controls.Add(this.txt_titlePrice);
            this.Controls.Add(this.lbl_pub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pubCombo);
            this.Controls.Add(this.txt_titleId);
            this.Name = "DetaledView";
            this.Text = "DetaledView";
            this.Load += new System.EventHandler(this.DetaledView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_pub;
        private Label label2;
        private Label label1;
        private ComboBox pubCombo;
        private TextBox txt_titleId;
        private TextBox txt_titlePrice;
        private Label label4;
        private TextBox txt_titleName;
        private Label label6;
        private TextBox txt_titleType;
        private Button button1;
        private Button button2;
    }
}