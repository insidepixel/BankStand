using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/* TODO
 * Decide method for switching out the data in the calculator, 
 */

namespace BankStand
{
    public partial class frmCalculator : Form
    {
        int[] XPForLevel = { 0, 83, 174, 276, 388, 512, 650, 801, 969, 1154, 1358, 1584, 1833, 2107, 2411, 2746, 3115, 3523, 3973, 4470, 5018, 5624, 6291, 7028, 7842, 8740, 9730, 10824, 12031, 13363, 14833, 16456, 18247, 20224, 22406, 24815, 27473, 30408, 33648, 37224, 41171, 45529, 50339, 55649, 61512, 67983, 75127, 83014, 91721, 101333, 111945, 123660, 136594, 150872, 166636, 184040, 203254, 224466, 247886, 273742, 302288, 333804, 368599, 407015, 449428, 496254, 547953, 605032, 668051, 737627, 814445, 899257, 992895, 1096278, 1210421, 1336443, 1475581, 1629200, 1798808, 1986068, 2192818, 2421087, 2673114, 2951373, 3258594, 3597792, 3972294, 4385776, 4842295, 5346332, 5902831, 6517253, 7195629, 7944614, 8771558, 9684577, 10692629, 11805606, 13034431, 14391160, 15889108, 17542976, 19368991, 21385072, 23611005, 26068631, 28782068, 31777942, 35085653, 38737660, 42769799, 47221639, 52136868, 57563717, 63555442, 70170839, 77474827, 85539081, 94442736, 104273166 };
        int curLevel = 0;
        int curXP = 0;
        int reqXP = 0;
        int curSkill = 6;
        int virLevel = 0;
        int wantedLevel = 0;
        public frmCalculator()
        {
            InitializeComponent();
            cbSkills.SelectedIndex = 13;
            dgvCalculator.Rows.Add("Test", "No", "0", "500", "");
        }

        #region Looking up players
        private void btnCalcLookup_Click(object sender, EventArgs e)
        {
            btnCalcLookup.Enabled = false;
            PlayerLookup();
        }
        private void CalcLookup_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string s;
            if (e.Error == null)
            {
                s = e.Result;
                s = Regex.Replace(s, @"\s", ",");
                string[] CalcData = s.Split(',');
                curLevel = int.Parse(CalcData[(curSkill * 3) + 1]);
                curXP = int.Parse(CalcData[(curSkill * 3) + 2]);
                virLevel = getLevel(curXP);
                reqXP = (XPForLevel[virLevel-1] - curXP);
                tbCurXP.Text = curXP.ToString();
                if (virLevel + 1 < 120)
                {
                    tbWantedLevel.Text = (virLevel + 1).ToString();
                }
                else
                {
                    tbWantedLevel.Text = 120.ToString();
                }
                wantedLevel = int.Parse(tbWantedLevel.Text);
                UpdateStats();
            }
            btnCalcLookup.Enabled = true;
        }
        public void PlayerLookup()
        {
            string url = "http://hiscore.runescape.com/index_lite.ws?player=" + tbUsername.Text;
            WebClient CalcLookup = new WebClient();
            CalcLookup.DownloadStringCompleted += CalcLookup_DownloadStringCompleted;
            CalcLookup.DownloadStringAsync(new Uri(url));
            CalcLookup.Dispose();
        }
        #endregion

        private int getLevel(int curXP)
        {
            for (int i = 0; i < XPForLevel.Length; i++)
            {
                if(XPForLevel[i] > curXP)
                {
                    return i;
                }
            }
            return 120;
        }

        #region Wanted Level Textbox
        private void tbWantedLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbWantedLevel_TextChanged(object sender, EventArgs e)
        {
            if (tbWantedLevel.Text.Length > 0)
            {
                try
                {
                    if (int.Parse(tbWantedLevel.Text) > 120)
                    {
                        tbWantedLevel.Text = "120";
                    }
                }
                catch (FormatException)
                {
                    tbWantedLevel.Text = "0";
                }
                finally
                {
                    wantedLevel = int.Parse(tbWantedLevel.Text);
                }
            }
            else
            {
                wantedLevel = 0;
            }
            UpdateStats();
        }
        #endregion

        #region Current XP Textbox
        private void tbCurXP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void tbCurXP_TextChanged(object sender, EventArgs e)
        {
            if (tbCurXP.Text.Length > 0)
            {
                try
                {
                    if (int.Parse(tbCurXP.Text) > 200000000)
                    {
                        tbCurXP.Text = "200000000";
                    }
                }
                catch (FormatException)
                {
                    tbCurXP.Text = "0";
                }
                finally
                {
                    curXP = int.Parse(tbCurXP.Text);
                }
            }
            else
            {
                curXP = 0;
            }
            UpdateStats();
        }
        #endregion

        public void UpdateStats()
        {
            if (wantedLevel > 0)
            {
                lblLvlXP.Text = String.Format("{0:N0}", XPForLevel[wantedLevel - 1]).ToString();
            }
            else
            {
                lblLvlXP.Text = "0";
            }
            if (curXP >= 0 && wantedLevel > 0)
            {
                reqXP = ((XPForLevel[wantedLevel - 1]) - curXP);
                lblReqXP.Text = "Required XP: " + String.Format("{0:N0}", reqXP).ToString();
            }
            else if (wantedLevel <= 0)
            {
                reqXP = ((XPForLevel[0]) - curXP);
                lblReqXP.Text = "Required XP: " + String.Format("{0:N0}", reqXP).ToString();
            }
            if (curXP >= 13034431)
            {
                curLevel = 99;
                virLevel = getLevel(curXP);
            }
            else
            {
                curLevel = getLevel(curXP);
                virLevel = curLevel;
            }
            if (virLevel > curLevel)
            {
                lblCurLvl.Text = "Level: " + curLevel + " (" + virLevel + ")";
            }
            else
            {
                lblCurLvl.Text = "Level: " + curLevel;
            }
            //Foreach loop for each column, divide ReqXP by the column that
            //displays how much experience the action gives
            for (int i = 0; i < dgvCalculator.RowCount; i++)
            {
                int actionXP = int.Parse(dgvCalculator.Rows[i].Cells[3].Value.ToString());
                dgvCalculator.Rows[i].Cells[4].Value = String.Format("{0:N0}", ((reqXP + actionXP - 1) / actionXP));
            }
            //When dividing 2 integers the result is always rounded down to avoid formatting errors
            //The formula ((reqXP + actionXP - 1) / actionXP) provides the expected result
        }

        private void cbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Switching out data will be handled in here, most likely using a .mdf with 1 table per skill.
            switch (cbSkills.SelectedIndex)
            {
                case 0:
                    curSkill = 17;
                    break;
                case 1:
                    curSkill = 23;
                    break;
                case 2:
                    curSkill = 8;
                    break;
                case 3:
                    curSkill = 13;
                    break;
                case 4:
                    curSkill = 26;
                    break;
                case 5:
                    curSkill = 20;
                    break;
                case 6:
                    curSkill = 12;
                    break;
                case 7:
                    curSkill = 11;
                    break;
                case 8:
                    curSkill = 10;
                    break;
                case 9:
                    curSkill = 16;
                    break;
                case 10:
                    curSkill = 22;
                    break;
                case 11:
                    curSkill = 7;
                    break;
                case 12:
                    curSkill = 15;
                    break;
                case 13:
                    curSkill = 6;
                    break;
                case 14:
                    curSkill = 21;
                    break;
                case 15:
                    curSkill = 14;
                    break;
                case 16:
                    curSkill = 24;
                    break;
                case 17:
                    curSkill = 18;
                    break;
                case 18:
                    curSkill = 9;
                    break;
                default:
                    MessageBox.Show("Congratulations, you broke the skill selector!");
                    break;
            }
            if(tbUsername.Text.Length > 0)
            {
                PlayerLookup();
            }
        }

        private void chbOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chbOnTop.Checked;
        }
    }
}
