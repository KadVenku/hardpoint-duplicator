namespace eaw.hardpointduplicator
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
            resources.ApplyResources(this.MainFormMainBoxSplitContainer, "MainFormMainBoxSplitContainer");
            this.MainFormMainBoxSplitContainer.Name = "MainFormMainBoxSplitContainer";
            // 
            // MainFormMainBoxSplitContainer.Panel1
            // 
            this.MainFormMainBoxSplitContainer.Panel1.Controls.Add(this.Panel1TableLayoutPanel);
            // 
            // MainFormMainBoxSplitContainer.Panel2
            // 
            this.MainFormMainBoxSplitContainer.Panel2.Controls.Add(this.Panel2TableLayoutPanel);
            // 
            // Panel1TableLayoutPanel
            // 
            resources.ApplyResources(this.Panel1TableLayoutPanel, "Panel1TableLayoutPanel");
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
            this.Panel1TableLayoutPanel.Name = "Panel1TableLayoutPanel";
            // 
            // IsTurretCheckBox
            // 
            resources.ApplyResources(this.IsTurretCheckBox, "IsTurretCheckBox");
            this.Panel1TableLayoutPanel.SetColumnSpan(this.IsTurretCheckBox, 2);
            this.IsTurretCheckBox.Name = "IsTurretCheckBox";
            this.IsTurretCheckBox.UseVisualStyleBackColor = true;
            this.IsTurretCheckBox.CheckedChanged += new System.EventHandler(this.IsTurretCheckBox_CheckedChanged);
            // 
            // Generate70CheckBox
            // 
            resources.ApplyResources(this.Generate70CheckBox, "Generate70CheckBox");
            this.Panel1TableLayoutPanel.SetColumnSpan(this.Generate70CheckBox, 2);
            this.Generate70CheckBox.Name = "Generate70CheckBox";
            this.Generate70CheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateR90CheckBox
            // 
            resources.ApplyResources(this.GenerateR90CheckBox, "GenerateR90CheckBox");
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateR90CheckBox, 2);
            this.GenerateR90CheckBox.Name = "GenerateR90CheckBox";
            this.GenerateR90CheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateR270CheckBox
            // 
            resources.ApplyResources(this.GenerateR270CheckBox, "GenerateR270CheckBox");
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateR270CheckBox, 2);
            this.GenerateR270CheckBox.Name = "GenerateR270CheckBox";
            this.GenerateR270CheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateButton, 2);
            resources.ApplyResources(this.GenerateButton, "GenerateButton");
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // GenerateR360CheckBox
            // 
            resources.ApplyResources(this.GenerateR360CheckBox, "GenerateR360CheckBox");
            this.Panel1TableLayoutPanel.SetColumnSpan(this.GenerateR360CheckBox, 2);
            this.GenerateR360CheckBox.Name = "GenerateR360CheckBox";
            this.GenerateR360CheckBox.UseVisualStyleBackColor = true;
            // 
            // HardpointCountNumericUpDown
            // 
            resources.ApplyResources(this.HardpointCountNumericUpDown, "HardpointCountNumericUpDown");
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
            this.HardpointCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HardPointBaseNameTextBox
            // 
            resources.ApplyResources(this.HardPointBaseNameTextBox, "HardPointBaseNameTextBox");
            this.HardPointBaseNameTextBox.Name = "HardPointBaseNameTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Panel2TableLayoutPanel
            // 
            resources.ApplyResources(this.Panel2TableLayoutPanel, "Panel2TableLayoutPanel");
            this.Panel2TableLayoutPanel.Controls.Add(this.HardpointCodeRichTextBox, 0, 0);
            this.Panel2TableLayoutPanel.Controls.Add(this.ReplacementTextBox, 1, 1);
            this.Panel2TableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.Panel2TableLayoutPanel.Name = "Panel2TableLayoutPanel";
            // 
            // HardpointCodeRichTextBox
            // 
            this.Panel2TableLayoutPanel.SetColumnSpan(this.HardpointCodeRichTextBox, 2);
            resources.ApplyResources(this.HardpointCodeRichTextBox, "HardpointCodeRichTextBox");
            this.HardpointCodeRichTextBox.Name = "HardpointCodeRichTextBox";
            // 
            // ReplacementTextBox
            // 
            resources.ApplyResources(this.ReplacementTextBox, "ReplacementTextBox");
            this.ReplacementTextBox.Name = "ReplacementTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainFormMainBoxSplitContainer);
            this.Name = "MainForm";
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