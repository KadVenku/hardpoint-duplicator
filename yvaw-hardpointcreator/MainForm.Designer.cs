namespace yvaw_hardpointcreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormMainBoxSplitContainer = new System.Windows.Forms.SplitContainer();
            this.Panel1TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IsTurretCheckBox = new System.Windows.Forms.CheckBox();
            this.Generate70CheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateR90CheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateR270CheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.GenerateR360CheckBox = new System.Windows.Forms.CheckBox();
            this.HardpointCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HardPointBaseNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel2TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HardpointCodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ReplacementTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormMainBoxSplitContainer)).BeginInit();
            this.MainFormMainBoxSplitContainer.Panel1.SuspendLayout();
            this.MainFormMainBoxSplitContainer.Panel2.SuspendLayout();
            this.MainFormMainBoxSplitContainer.SuspendLayout();
            this.Panel1TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardpointCountNumericUpDown)).BeginInit();
            this.Panel2TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMainBoxSplitContainer
            // 
            this.MainFormMainBoxSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormMainBoxSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainFormMainBoxSplitContainer.Name = "MainFormMainBoxSplitContainer";
            // 
            // MainFormMainBoxSplitContainer.Panel1
            // 
            this.MainFormMainBoxSplitContainer.Panel1.Controls.Add(this.Panel1TableLayoutPanel);
            // 
            // MainFormMainBoxSplitContainer.Panel2
            // 
            this.MainFormMainBoxSplitContainer.Panel2.Controls.Add(this.Panel2TableLayoutPanel);
            this.MainFormMainBoxSplitContainer.Size = new System.Drawing.Size(784, 561);
            this.MainFormMainBoxSplitContainer.SplitterDistance = 261;
            this.MainFormMainBoxSplitContainer.TabIndex = 0;
            // 
            // Panel1TableLayoutPanel
            // 
            this.Panel1TableLayoutPanel.ColumnCount = 2;
            this.Panel1TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Panel1TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Panel1TableLayoutPanel.Controls.Add(this.IsTurretCheckBox, 0, 0);
            this.Panel1TableLayoutPanel.Controls.Add(this.Generate70CheckBox, 0, 1);
            this.Panel1TableLayoutPanel.Controls.Add(this.GenerateR90CheckBox, 0, 2);
            this.Panel1TableLayoutPanel.Controls.Add(this.GenerateR270CheckBox, 0, 3);
            this.Panel1TableLayoutPanel.Controls.Add(this.GenerateButton, 0, 7);
            this.Panel1TableLayoutPanel.Controls.Add(this.GenerateR360CheckBox, 0, 4);
            this.Panel1TableLayoutPanel.Controls.Add(this.HardpointCountNumericUpDown, 1, 6);
            this.Panel1TableLayoutPanel.Controls.Add(this.HardPointBaseNameTextBox, 1, 5);
            this.Panel1TableLayoutPanel.Controls.Add(this.label1, 0, 5);
            this.Panel1TableLayoutPanel.Controls.Add(this.label2, 0, 6);
            this.Panel1TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Panel1TableLayoutPanel.Name = "Panel1TableLayoutPanel";
            this.Panel1TableLayoutPanel.RowCount = 8;
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Panel1TableLayoutPanel.Size = new System.Drawing.Size(261, 561);
            this.Panel1TableLayoutPanel.TabIndex = 0;
            // 
            // IsTurretCheckBox
            // 
            this.IsTurretCheckBox.AutoSize = true;
            this.Panel1TableLayoutPanel.SetColumnSpan(this.IsTurretCheckBox, 2);
            this.IsTurretCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IsTurretCheckBox.Location = new System.Drawing.Point(3, 3);
            this.IsTurretCheckBox.Name = "IsTurretCheckBox";
            this.IsTurretCheckBox.Size = new System.Drawing.Size(255, 17);
            this.IsTurretCheckBox.TabIndex = 0;
            this.IsTurretCheckBox.Text = "Hardpoint is a turret";
            this.IsTurretCheckBox.UseVisualStyleBackColor = true;
            this.IsTurretCheckBox.CheckedChanged += new System.EventHandler(this.IsTurretCheckBox_CheckedChanged);
            // 
            // Generate70CheckBox
            // 
            this.Generate70CheckBox.AutoSize = true;
            this.Panel1TableLayoutPanel.SetColumnSpan(this.Generate70CheckBox, 2);
            this.Generate70CheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Generate70CheckBox.Enabled = false;
            this.Generate70CheckBox.Location = new System.Drawing.Point(3, 26);
            this.Generate70CheckBox.Name = "Generate70CheckBox";
            this.Generate70CheckBox.Size = new System.Drawing.Size(255, 17);
            this.Generate70CheckBox.TabIndex = 1;
            this.Generate70CheckBox.Text = "Generate 70° rotation arc turret variants.";
            this.Generate70CheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateR90CheckBox
            // 
            this.GenerateR90CheckBox.AutoSize = true;
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateR90CheckBox, 2);
            this.GenerateR90CheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateR90CheckBox.Enabled = false;
            this.GenerateR90CheckBox.Location = new System.Drawing.Point(3, 49);
            this.GenerateR90CheckBox.Name = "GenerateR90CheckBox";
            this.GenerateR90CheckBox.Size = new System.Drawing.Size(255, 17);
            this.GenerateR90CheckBox.TabIndex = 2;
            this.GenerateR90CheckBox.Text = "Generate 90° rotation arc turret variants.";
            this.GenerateR90CheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateR270CheckBox
            // 
            this.GenerateR270CheckBox.AutoSize = true;
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateR270CheckBox, 2);
            this.GenerateR270CheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateR270CheckBox.Enabled = false;
            this.GenerateR270CheckBox.Location = new System.Drawing.Point(3, 72);
            this.GenerateR270CheckBox.Name = "GenerateR270CheckBox";
            this.GenerateR270CheckBox.Size = new System.Drawing.Size(255, 17);
            this.GenerateR270CheckBox.TabIndex = 3;
            this.GenerateR270CheckBox.Text = "Generate 270° rotation arc turret variants.";
            this.GenerateR270CheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateButton, 2);
            this.GenerateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateButton.Location = new System.Drawing.Point(3, 535);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(255, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate hardpoint variants";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // GenerateR360CheckBox
            // 
            this.GenerateR360CheckBox.AutoSize = true;
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateR360CheckBox, 2);
            this.GenerateR360CheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateR360CheckBox.Enabled = false;
            this.GenerateR360CheckBox.Location = new System.Drawing.Point(3, 95);
            this.GenerateR360CheckBox.Name = "GenerateR360CheckBox";
            this.GenerateR360CheckBox.Size = new System.Drawing.Size(255, 17);
            this.GenerateR360CheckBox.TabIndex = 5;
            this.GenerateR360CheckBox.Text = "Generate 360° rotation arc turret variants.";
            this.GenerateR360CheckBox.UseVisualStyleBackColor = true;
            // 
            // HardpointCountNumericUpDown
            // 
            this.HardpointCountNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardpointCountNumericUpDown.Location = new System.Drawing.Point(107, 164);
            this.HardpointCountNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.HardpointCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HardpointCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HardpointCountNumericUpDown.Name = "HardpointCountNumericUpDown";
            this.HardpointCountNumericUpDown.Size = new System.Drawing.Size(151, 20);
            this.HardpointCountNumericUpDown.TabIndex = 6;
            this.HardpointCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HardPointBaseNameTextBox
            // 
            this.HardPointBaseNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardPointBaseNameTextBox.Location = new System.Drawing.Point(107, 118);
            this.HardPointBaseNameTextBox.Name = "HardPointBaseNameTextBox";
            this.HardPointBaseNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.HardPointBaseNameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "HardPoint base name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 23, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "HardPoint creation count:";
            // 
            // Panel2TableLayoutPanel
            // 
            this.Panel2TableLayoutPanel.ColumnCount = 2;
            this.Panel2TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel2TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel2TableLayoutPanel.Controls.Add(this.HardpointCodeRichTextBox, 0, 0);
            this.Panel2TableLayoutPanel.Controls.Add(this.ReplacementTextBox, 1, 1);
            this.Panel2TableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.Panel2TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Panel2TableLayoutPanel.Name = "Panel2TableLayoutPanel";
            this.Panel2TableLayoutPanel.RowCount = 2;
            this.Panel2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Panel2TableLayoutPanel.Size = new System.Drawing.Size(519, 561);
            this.Panel2TableLayoutPanel.TabIndex = 0;
            // 
            // HardpointCodeRichTextBox
            // 
            this.Panel2TableLayoutPanel.SetColumnSpan(this.HardpointCodeRichTextBox, 2);
            this.HardpointCodeRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HardpointCodeRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.HardpointCodeRichTextBox.Name = "HardpointCodeRichTextBox";
            this.HardpointCodeRichTextBox.Size = new System.Drawing.Size(513, 530);
            this.HardpointCodeRichTextBox.TabIndex = 0;
            this.HardpointCodeRichTextBox.Text = "";
            // 
            // ReplacementTextBox
            // 
            this.ReplacementTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReplacementTextBox.Location = new System.Drawing.Point(118, 539);
            this.ReplacementTextBox.Name = "ReplacementTextBox";
            this.ReplacementTextBox.Size = new System.Drawing.Size(398, 20);
            this.ReplacementTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 541);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Replacement pattern:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainFormMainBoxSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardpoint Creator";
            this.MainFormMainBoxSplitContainer.Panel1.ResumeLayout(false);
            this.MainFormMainBoxSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormMainBoxSplitContainer)).EndInit();
            this.MainFormMainBoxSplitContainer.ResumeLayout(false);
            this.Panel1TableLayoutPanel.ResumeLayout(false);
            this.Panel1TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardpointCountNumericUpDown)).EndInit();
            this.Panel2TableLayoutPanel.ResumeLayout(false);
            this.Panel2TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainFormMainBoxSplitContainer;
        private System.Windows.Forms.TableLayoutPanel Panel2TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel Panel1TableLayoutPanel;
        private System.Windows.Forms.CheckBox IsTurretCheckBox;
        private System.Windows.Forms.CheckBox Generate70CheckBox;
        private System.Windows.Forms.CheckBox GenerateR90CheckBox;
        private System.Windows.Forms.CheckBox GenerateR270CheckBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.RichTextBox HardpointCodeRichTextBox;
        private System.Windows.Forms.TextBox ReplacementTextBox;
        private System.Windows.Forms.CheckBox GenerateR360CheckBox;
        private System.Windows.Forms.NumericUpDown HardpointCountNumericUpDown;
        private System.Windows.Forms.TextBox HardPointBaseNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}