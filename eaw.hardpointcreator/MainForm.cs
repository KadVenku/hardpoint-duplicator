using eaw.hardpointcreator.shared.localisation;
using eaw.hardpointduplicator.core.definitions;
using eaw.hardpointduplicator.core.exception;
using eaw.hardpointduplicator.shared.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eaw.hardpointduplicator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetTurretCheckBoxesEnabledState(false);
        }

        private void IsTurretCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetTurretCheckBoxesEnabledState(IsTurretCheckBox.Checked);
        }

        private void SetTurretCheckBoxesEnabledState(bool isEnabled)
        {
            Generate70CheckBox.Enabled = isEnabled;
            GenerateR90CheckBox.Enabled = isEnabled;
            GenerateR270CheckBox.Enabled = isEnabled;
            GenerateR360CheckBox.Enabled = isEnabled;
            HardPointBaseNameTextBox.Enabled = isEnabled;
        }

        private string GetReplacementLiteral()
        {
            if (string.IsNullOrEmpty(ReplacementTextBox.Text) || string.IsNullOrWhiteSpace(ReplacementTextBox.Text))
            {
                throw new MissingReplacementPatternException(Strings.MissingReplacementPattern);
            }
            return ReplacementTextBox.Text;
        }

        private string GetHardpointCode()
        {
            if (string.IsNullOrEmpty(HardpointCodeRichTextBox.Text) || string.IsNullOrWhiteSpace(HardpointCodeRichTextBox.Text))
            {
                throw new MissingHardpointCodeException(Strings.MissingHardpointCode);
            }
            return HardpointCodeRichTextBox.Text;
        }

        private string GetHardPointBaseName()
        {
            if (string.IsNullOrEmpty(HardPointBaseNameTextBox.Text) || string.IsNullOrWhiteSpace(HardPointBaseNameTextBox.Text))
            {
                throw new MissingHardpointBaseNameException(Strings.MissingHardpointBaseName);
            }
            return HardPointBaseNameTextBox.Text;
        }

        private int GetHardpointCountToCreate()
        {
            return decimal.ToInt32(HardpointCountNumericUpDown.Value);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                UseWaitCursor = true;
                string replacementLiteral = GetReplacementLiteral();
                string hardpointCode = GetHardpointCode();
                int hardpointCount = GetHardpointCountToCreate();
                List<string> hardpointTable;
                if (IsTurretCheckBox.Checked)
                {
                    hardpointTable = CreateTurretHpList(hardpointCode, replacementLiteral, hardpointCount,
                        GetHardPointBaseName());
                }
                else
                {
                    hardpointTable =
                        HardPointGeneratorService.GenerateHpVariants(hardpointCode, replacementLiteral, hardpointCount);
                }
                FileWriterService.WriteToFile(hardpointTable);
                UseWaitCursor = false;
                MessageBox.Show(Strings.SuccessfullyCreadedMessage, Strings.Success, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (MissingReplacementPatternException missingReplacementPatternException)
            {
                UseWaitCursor = false;
                MessageBox.Show(missingReplacementPatternException.ToString(), Strings.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MissingHardpointCodeException missingHardpointCodeException)
            {
                UseWaitCursor = false;
                MessageBox.Show(missingHardpointCodeException.ToString(), Strings.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MissingHardpointBaseNameException missingHardpointBaseNameException)
            {
                UseWaitCursor = false;
                MessageBox.Show(missingHardpointBaseNameException.ToString(), Strings.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.ToString(), Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> CreateTurretHpList(string hardpointCode, string replacementLiteral, int hardpointCount, string hardPointBaseName)
        {
            List<string> hardpointTable = new List<string>();
            hardpointTable.AddRange(HardPointGeneratorService.GenerateHpVariants(hardpointCode, replacementLiteral, hardpointCount, hardPointBaseName, RotationDefinitions.RotationArc.RDefault));
            if (Generate70CheckBox.Checked)
            {
                hardpointTable.AddRange(HardPointGeneratorService.GenerateHpVariants(hardpointCode, replacementLiteral, hardpointCount, hardPointBaseName, RotationDefinitions.RotationArc.R70));
            }
            if (GenerateR90CheckBox.Checked)
            {
                hardpointTable.AddRange(HardPointGeneratorService.GenerateHpVariants(hardpointCode, replacementLiteral, hardpointCount, hardPointBaseName, RotationDefinitions.RotationArc.R90));
            }
            if (GenerateR270CheckBox.Checked)
            {
                hardpointTable.AddRange(HardPointGeneratorService.GenerateHpVariants(hardpointCode, replacementLiteral, hardpointCount, hardPointBaseName, RotationDefinitions.RotationArc.R270));
            }
            if (GenerateR360CheckBox.Checked)
            {
                hardpointTable.AddRange(HardPointGeneratorService.GenerateHpVariants(hardpointCode, replacementLiteral, hardpointCount, hardPointBaseName, RotationDefinitions.RotationArc.R360));
            }

            return hardpointTable;
        }
    }
}
