namespace StaproConfigSplitter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMealTypes = new System.Windows.Forms.TextBox();
            this.bSplit = new System.Windows.Forms.Button();
            this.tbWards = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdditions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbMealTypes = new System.Windows.Forms.RichTextBox();
            this.rtbWards = new System.Windows.Forms.RichTextBox();
            this.rtbDiets = new System.Windows.Forms.RichTextBox();
            this.rtbAdditions = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbAdditions);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDiets);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbWards);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bSplit);
            this.panel1.Controls.Add(this.tbMealTypes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MealTypes";
            // 
            // tbMealTypes
            // 
            this.tbMealTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMealTypes.Location = new System.Drawing.Point(124, 9);
            this.tbMealTypes.Name = "tbMealTypes";
            this.tbMealTypes.Size = new System.Drawing.Size(662, 20);
            this.tbMealTypes.TabIndex = 1;
            // 
            // bSplit
            // 
            this.bSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSplit.Location = new System.Drawing.Point(805, 12);
            this.bSplit.Name = "bSplit";
            this.bSplit.Size = new System.Drawing.Size(75, 95);
            this.bSplit.TabIndex = 2;
            this.bSplit.Text = "SPLIT";
            this.bSplit.UseVisualStyleBackColor = true;
            this.bSplit.Click += new System.EventHandler(this.bSplit_Click);
            // 
            // tbWards
            // 
            this.tbWards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWards.Location = new System.Drawing.Point(124, 35);
            this.tbWards.Name = "tbWards";
            this.tbWards.Size = new System.Drawing.Size(662, 20);
            this.tbWards.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wards";
            // 
            // tbDiets
            // 
            this.tbDiets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiets.Location = new System.Drawing.Point(124, 61);
            this.tbDiets.Name = "tbDiets";
            this.tbDiets.Size = new System.Drawing.Size(662, 20);
            this.tbDiets.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diets";
            // 
            // tbAdditions
            // 
            this.tbAdditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdditions.Location = new System.Drawing.Point(124, 87);
            this.tbAdditions.Name = "tbAdditions";
            this.tbAdditions.Size = new System.Drawing.Size(662, 20);
            this.tbAdditions.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additions";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 412);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbMealTypes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MealTypes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtbWards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbDiets);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(884, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Diets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbAdditions);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(884, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Additions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbMealTypes
            // 
            this.rtbMealTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMealTypes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbMealTypes.Location = new System.Drawing.Point(3, 3);
            this.rtbMealTypes.Name = "rtbMealTypes";
            this.rtbMealTypes.Size = new System.Drawing.Size(878, 380);
            this.rtbMealTypes.TabIndex = 0;
            this.rtbMealTypes.Text = "";
            // 
            // rtbWards
            // 
            this.rtbWards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbWards.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbWards.Location = new System.Drawing.Point(3, 3);
            this.rtbWards.Name = "rtbWards";
            this.rtbWards.Size = new System.Drawing.Size(878, 380);
            this.rtbWards.TabIndex = 1;
            this.rtbWards.Text = "";
            // 
            // rtbDiets
            // 
            this.rtbDiets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDiets.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbDiets.Location = new System.Drawing.Point(3, 3);
            this.rtbDiets.Name = "rtbDiets";
            this.rtbDiets.Size = new System.Drawing.Size(878, 380);
            this.rtbDiets.TabIndex = 1;
            this.rtbDiets.Text = "";
            // 
            // rtbAdditions
            // 
            this.rtbAdditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAdditions.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbAdditions.Location = new System.Drawing.Point(3, 3);
            this.rtbAdditions.Name = "rtbAdditions";
            this.rtbAdditions.Size = new System.Drawing.Size(878, 380);
            this.rtbAdditions.TabIndex = 1;
            this.rtbAdditions.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stapro Config Splitter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAdditions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSplit;
        private System.Windows.Forms.TextBox tbMealTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbMealTypes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbWards;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbDiets;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtbAdditions;
    }
}

