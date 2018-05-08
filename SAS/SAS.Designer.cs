﻿namespace SAS
{
    partial class SAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAS));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.printPanel = new System.Windows.Forms.Panel();
            this.rightTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.SASImage = new System.Windows.Forms.PictureBox();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Label();
            this.areaCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SASImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthTextBox
            // 
            this.monthTextBox.BackColor = System.Drawing.Color.Gold;
            this.monthTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.monthTextBox.Location = new System.Drawing.Point(1093, 71);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(47, 23);
            this.monthTextBox.TabIndex = 6;
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.Gold;
            this.yearTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yearTextBox.Location = new System.Drawing.Point(992, 71);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(37, 23);
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.BackColor = System.Drawing.Color.Gold;
            this.employeeNumberTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.employeeNumberTextBox.Location = new System.Drawing.Point(127, 39);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(236, 23);
            this.employeeNumberTextBox.TabIndex = 2;
            this.employeeNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.employeeNumberTextBox.TextChanged += new System.EventHandler(this.employeeNumberTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Gold;
            this.nameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameTextBox.Location = new System.Drawing.Point(127, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 23);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // printPanel
            // 
            this.printPanel.Controls.Add(this.rightTableLayout);
            this.printPanel.Controls.Add(this.leftTableLayout);
            this.printPanel.Controls.Add(this.nameTextBox);
            this.printPanel.Controls.Add(this.employeeNumberTextBox);
            this.printPanel.Controls.Add(this.areaTextBox);
            this.printPanel.Controls.Add(this.yearTextBox);
            this.printPanel.Controls.Add(this.monthTextBox);
            this.printPanel.Controls.Add(this.SASImage);
            this.printPanel.Location = new System.Drawing.Point(12, 52);
            this.printPanel.Name = "printPanel";
            this.printPanel.Size = new System.Drawing.Size(1271, 811);
            this.printPanel.TabIndex = 15;
            // 
            // rightTableLayout
            // 
            this.rightTableLayout.BackColor = System.Drawing.Color.White;
            this.rightTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.rightTableLayout.ColumnCount = 8;
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.rightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.rightTableLayout.ForeColor = System.Drawing.Color.Red;
            this.rightTableLayout.Location = new System.Drawing.Point(546, 172);
            this.rightTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rightTableLayout.Name = "rightTableLayout";
            this.rightTableLayout.RowCount = 16;
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightTableLayout.Size = new System.Drawing.Size(534, 498);
            this.rightTableLayout.TabIndex = 8;
            // 
            // leftTableLayout
            // 
            this.leftTableLayout.BackColor = System.Drawing.Color.White;
            this.leftTableLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.leftTableLayout.ColumnCount = 8;
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.leftTableLayout.ForeColor = System.Drawing.Color.Red;
            this.leftTableLayout.Location = new System.Drawing.Point(46, 172);
            this.leftTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.leftTableLayout.Name = "leftTableLayout";
            this.leftTableLayout.RowCount = 16;
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftTableLayout.Size = new System.Drawing.Size(490, 498);
            this.leftTableLayout.TabIndex = 7;
            // 
            // areaTextBox
            // 
            this.areaTextBox.BackColor = System.Drawing.Color.Gold;
            this.areaTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.areaTextBox.Location = new System.Drawing.Point(1035, 39);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(186, 23);
            this.areaTextBox.TabIndex = 3;
            this.areaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.areaTextBox.TextChanged += new System.EventHandler(this.areaTextBox_TextChanged);
            // 
            // SASImage
            // 
            this.SASImage.BackgroundImage = global::SAS.Properties.Resources.sas_blank;
            this.SASImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SASImage.InitialImage = null;
            this.SASImage.Location = new System.Drawing.Point(3, 3);
            this.SASImage.Name = "SASImage";
            this.SASImage.Size = new System.Drawing.Size(1268, 811);
            this.SASImage.TabIndex = 1;
            this.SASImage.TabStop = false;
            this.SASImage.Click += new System.EventHandler(this.SASImage_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(1178, 869);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "V1.1 Oliver Morgan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.BackColor = System.Drawing.SystemColors.Info;
            this.Report.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Report.Location = new System.Drawing.Point(195, 21);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(324, 16);
            this.Report.TabIndex = 17;
            this.Report.Text = "Complete all highlighted fields then press Start.";
            // 
            // areaCombo
            // 
            this.areaCombo.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.areaCombo.FormattingEnabled = true;
            this.areaCombo.Location = new System.Drawing.Point(1105, 18);
            this.areaCombo.Name = "areaCombo";
            this.areaCombo.Size = new System.Drawing.Size(175, 24);
            this.areaCombo.TabIndex = 1;
            this.areaCombo.SelectedIndexChanged += new System.EventHandler(this.areaCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(961, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Load Area Schools:";
            // 
            // SAS
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1295, 888);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.areaCombo);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SAS";
            this.Text = "SAS Entry Form";
            this.printPanel.ResumeLayout(false);
            this.printPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SASImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel printPanel;
        private System.Windows.Forms.TableLayoutPanel leftTableLayout;
        private System.Windows.Forms.PictureBox SASImage;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.TableLayoutPanel rightTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.ComboBox areaCombo;
        private System.Windows.Forms.Label label2;
    }
}