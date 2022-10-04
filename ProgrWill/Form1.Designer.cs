
namespace ProgrWill
{
    partial class ProgrWill
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
            this.dgChildren = new System.Windows.Forms.DataGridView();
            this.ChildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAltName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpouse = new System.Windows.Forms.TextBox();
            this.btGenDoc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNameExcIndiv = new System.Windows.Forms.TextBox();
            this.tbPersRepr1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersRepr2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPersRepr3 = new System.Windows.Forms.TextBox();
            this.grBxCremBurial = new System.Windows.Forms.GroupBox();
            this.rbCremation = new System.Windows.Forms.RadioButton();
            this.rbBurial = new System.Windows.Forms.RadioButton();
            this.dTmDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildren)).BeginInit();
            this.grBxCremBurial.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgChildren
            // 
            this.dgChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChildren.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChildName,
            this.BirthDate});
            this.dgChildren.Location = new System.Drawing.Point(156, 173);
            this.dgChildren.Name = "dgChildren";
            this.dgChildren.Size = new System.Drawing.Size(471, 150);
            this.dgChildren.TabIndex = 0;
            // 
            // ChildName
            // 
            this.ChildName.HeaderText = "Name";
            this.ChildName.Name = "ChildName";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.Name = "BirthDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(248, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 20);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alternate Name:";
            // 
            // tbAltName
            // 
            this.tbAltName.Location = new System.Drawing.Point(248, 38);
            this.tbAltName.Name = "tbAltName";
            this.tbAltName.Size = new System.Drawing.Size(155, 20);
            this.tbAltName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "County:";
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(248, 64);
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(155, 20);
            this.tbCounty.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spouse:";
            // 
            // tbSpouse
            // 
            this.tbSpouse.Location = new System.Drawing.Point(248, 90);
            this.tbSpouse.Name = "tbSpouse";
            this.tbSpouse.Size = new System.Drawing.Size(155, 20);
            this.tbSpouse.TabIndex = 8;
            // 
            // btGenDoc
            // 
            this.btGenDoc.Location = new System.Drawing.Point(328, 599);
            this.btGenDoc.Name = "btGenDoc";
            this.btGenDoc.Size = new System.Drawing.Size(98, 23);
            this.btGenDoc.TabIndex = 9;
            this.btGenDoc.Text = "Generate document";
            this.btGenDoc.UseVisualStyleBackColor = true;
            this.btGenDoc.Click += new System.EventHandler(this.btGenDoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Children";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name of Excluded Individual:";
            // 
            // tbNameExcIndiv
            // 
            this.tbNameExcIndiv.Location = new System.Drawing.Point(308, 337);
            this.tbNameExcIndiv.Name = "tbNameExcIndiv";
            this.tbNameExcIndiv.Size = new System.Drawing.Size(170, 20);
            this.tbNameExcIndiv.TabIndex = 12;
            // 
            // tbPersRepr1
            // 
            this.tbPersRepr1.Location = new System.Drawing.Point(308, 364);
            this.tbPersRepr1.Name = "tbPersRepr1";
            this.tbPersRepr1.Size = new System.Drawing.Size(170, 20);
            this.tbPersRepr1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Personal Representative 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Personal Representative 1:";
            // 
            // tbPersRepr2
            // 
            this.tbPersRepr2.Location = new System.Drawing.Point(308, 391);
            this.tbPersRepr2.Name = "tbPersRepr2";
            this.tbPersRepr2.Size = new System.Drawing.Size(170, 20);
            this.tbPersRepr2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Personal Representative 3:";
            // 
            // tbPersRepr3
            // 
            this.tbPersRepr3.Location = new System.Drawing.Point(308, 416);
            this.tbPersRepr3.Name = "tbPersRepr3";
            this.tbPersRepr3.Size = new System.Drawing.Size(170, 20);
            this.tbPersRepr3.TabIndex = 19;
            // 
            // grBxCremBurial
            // 
            this.grBxCremBurial.Controls.Add(this.rbBurial);
            this.grBxCremBurial.Controls.Add(this.rbCremation);
            this.grBxCremBurial.Location = new System.Drawing.Point(159, 459);
            this.grBxCremBurial.Name = "grBxCremBurial";
            this.grBxCremBurial.Size = new System.Drawing.Size(267, 58);
            this.grBxCremBurial.TabIndex = 20;
            this.grBxCremBurial.TabStop = false;
            this.grBxCremBurial.Text = "Cremation or Burial?";
            // 
            // rbCremation
            // 
            this.rbCremation.AutoSize = true;
            this.rbCremation.Checked = true;
            this.rbCremation.Location = new System.Drawing.Point(60, 20);
            this.rbCremation.Name = "rbCremation";
            this.rbCremation.Size = new System.Drawing.Size(72, 17);
            this.rbCremation.TabIndex = 0;
            this.rbCremation.TabStop = true;
            this.rbCremation.Text = "Cremation";
            this.rbCremation.UseVisualStyleBackColor = true;
            // 
            // rbBurial
            // 
            this.rbBurial.AutoSize = true;
            this.rbBurial.Location = new System.Drawing.Point(160, 20);
            this.rbBurial.Name = "rbBurial";
            this.rbBurial.Size = new System.Drawing.Size(51, 17);
            this.rbBurial.TabIndex = 1;
            this.rbBurial.TabStop = true;
            this.rbBurial.Text = "Burial";
            this.rbBurial.UseVisualStyleBackColor = true;
            // 
            // dTmDate
            // 
            this.dTmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTmDate.Location = new System.Drawing.Point(219, 537);
            this.dTmDate.Name = "dTmDate";
            this.dTmDate.Size = new System.Drawing.Size(200, 20);
            this.dTmDate.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Date:";
            // 
            // ProgrWill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dTmDate);
            this.Controls.Add(this.grBxCremBurial);
            this.Controls.Add(this.tbPersRepr3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPersRepr2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPersRepr1);
            this.Controls.Add(this.tbNameExcIndiv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btGenDoc);
            this.Controls.Add(this.tbSpouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCounty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAltName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgChildren);
            this.Name = "ProgrWill";
            this.Text = "ProgrWill";
            ((System.ComponentModel.ISupportInitialize)(this.dgChildren)).EndInit();
            this.grBxCremBurial.ResumeLayout(false);
            this.grBxCremBurial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAltName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSpouse;
        private System.Windows.Forms.Button btGenDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNameExcIndiv;
        private System.Windows.Forms.TextBox tbPersRepr1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPersRepr2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPersRepr3;
        private System.Windows.Forms.GroupBox grBxCremBurial;
        private System.Windows.Forms.RadioButton rbBurial;
        private System.Windows.Forms.RadioButton rbCremation;
        private System.Windows.Forms.DateTimePicker dTmDate;
        private System.Windows.Forms.Label label10;
    }
}

