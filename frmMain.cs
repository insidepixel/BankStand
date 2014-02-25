using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

/* TO DO:
 * Nothing in Form 1 for now
 */

namespace BankStand
{
    public partial class frmMain : Form
    {
        //GE Lookup variables
        ArrayList Itemlist = new ArrayList();
        ArrayList results = new ArrayList();
        int itemID = 0;
        int iconLargeNumber = 0;

        public frmMain()
        {
            InitializeComponent();
            string[] images = { "overall", "attack", "defence", "strength", "hitpoints", "ranged", "prayer", "magic", "cooking", "woodcutting", "fletching", "fishing", "firemaking", "crafting", "smithing", "mining", "herblore", "agility", "thieving", "slayer", "farming", "runecrafting", "hunter", "construction", "summoning", "dungeoneering", "divination" };
            foreach (string target in images)
            {
                dgvHighScores.Rows.Add(Properties.Resources.ResourceManager.GetObject(target), "", "", "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ItemListPath = Application.StartupPath + @"\Data\ItemList.txt";
            if (File.Exists(ItemListPath))
            {
                StreamReader file = new StreamReader(ItemListPath);
                for (int i = 1; i < File.ReadLines(ItemListPath).Count(); i++)
                {
                    Itemlist.Add(file.ReadLine());
                }
            }
            else
            {
                MessageBox.Show("Could not find item list file.\nGE Lookup will be unavailable.", "Unable to find text file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string iconLargePath = "http://services.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=253";
            WebClient getNumber = new WebClient();
            getNumber.DownloadStringCompleted += getNumber_DownloadStringCompleted;
            getNumber.DownloadStringAsync(new Uri(iconLargePath));
            getNumber.Dispose();
        }

        private void getNumber_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            //Very inconvenient way of handling this, will change later
            string s;
            if (e.Error == null)
            {
                s = e.Result;
                s = Regex.Replace(s, @"[^0-9,]", "");
                string[] geData = s.Split(',');
                char[] iNumber = s.ToCharArray();
                string finalNumber = "";
                for (int i = 0; i < 4; i++)
                {
                    finalNumber += iNumber[i].ToString();
                }
                iconLargeNumber = Convert.ToInt32(finalNumber);
            }
            else
            {
                iconLargeNumber = 4305;
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                results.Clear();
                lbResults.Items.Clear();
                for (int i = 0; i < Itemlist.Count; i++)
                {
                    if (Itemlist[i].ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                    {
                        lbResults.Items.Add(Itemlist[i].ToString().Remove(Itemlist[i].ToString().IndexOf(char.Parse("|"))));
                        results.Add(Itemlist[i].ToString().Substring(Itemlist[i].ToString().IndexOf(char.Parse("|")), Itemlist[i].ToString().Length - Itemlist[i].ToString().IndexOf(char.Parse("|"))));
                    }
                } 
            }
        }

        private void btnHSLookup_Click(object sender, EventArgs e)
        {
            btnHSLookup.Enabled = false;
            string url = "http://hiscore.runescape.com/index_lite.ws?player=" + tbHSName.Text;
            WebClient HSLookup = new WebClient();
            HSLookup.DownloadStringCompleted += HSLookup_DownloadStringCompleted;
            HSLookup.DownloadStringAsync(new Uri(url));
            HSLookup.Dispose();
        }

        private void HSLookup_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string s;
            if (e.Error == null)
            {
                s = e.Result;
                s = Regex.Replace(s, @"\s", ",");
                string[] HSData = s.Split(',');
                for (int rowNo = 0; rowNo < dgvHighScores.RowCount; rowNo++)
                {
                    for (int columnNo = 1; columnNo < dgvHighScores.ColumnCount; columnNo++)
                    {
                        dgvHighScores.Rows[rowNo].Cells[columnNo].Value = String.Format("{0:N0}", long.Parse(HSData[rowNo * 2 + columnNo + (rowNo - 1)]));
                    }
                }
                dgvHighScores.Refresh();
            }
            else
            {
                MessageBox.Show(e.Error.ToString());
            }
            btnHSLookup.Enabled = true;
        }

        private void dataGridview1_SelectionChanged(object sender, EventArgs e)
        {
            this.dgvHighScores.ClearSelection();
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                lblName.Text = lbResults.SelectedItem.ToString();  //itemID.ToString();
                itemID = int.Parse(results[lbResults.SelectedIndex].ToString().TrimStart(char.Parse("|")));
                getData(itemID);
            }
        }
        private void getData(int Id)
        {
            StringBuilder sb = new StringBuilder();
            Stream resStream = null;
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create("http://services.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + Id.ToString());

                HttpWebResponse response = (HttpWebResponse)
                        request.GetResponse();
                resStream = response.GetResponseStream();
            string tempString = null;
            int number = 0;

            byte[] buf = new byte[8192];
            do
            {
                number = resStream.Read(buf, 0, buf.Length);

                if (number != 0)
                {
                    tempString = Encoding.ASCII.GetString(buf, 0, number);

                    sb.Append(tempString);
                }
            }
            while (number > 0);
            string json = sb.ToString();
            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

            var data = serializer.Deserialize(json, typeof(object));
            dynamic obj = serializer.Deserialize(json, typeof(object));
            string mem = obj.item.members;
            pbItem.ImageLocation = "http://services.runescape.com/m=itemdb_rs/" + iconLargeNumber + "_obj_big.gif?id=" + Id.ToString();
            if (mem == "true")
            {
                lblMembers.Text = "Members: Yes";
            }
            else
            {
                lblMembers.Text = "Members: No";
            }
            lblCurPrice.Text = "Price: " + obj.item.current.price;
            lblTodayChange.Text = obj.item.today.price.ToString();
            lbl30Change.Text = obj.item.day30.change.ToString();
            lbl90Change.Text = obj.item.day90.change.ToString();
            lbl180Change.Text = obj.item.day180.change.ToString();
        }

        private void skillCalculatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculator calculators = new frmCalculator();
            if(!calculators.Visible)
            {
                calculators.Show();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://www.runescape.com/game");
        }

        private void cbSlayerMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSlayerResults.Items.Clear();
            lbSlayerResults.Refresh();
            string smPath = Application.StartupPath + @"\Data\Slayer\Masters\" + cbSlayerMaster.SelectedItem.ToString() + ".txt";
            if(File.Exists(smPath))
            {
                StreamReader sr = new StreamReader(smPath);
                {
                    for (int i = 1; i < File.ReadLines(smPath).Count(); i++)
                    {
                        lbSlayerResults.Items.Add(sr.ReadLine());
                    }
                }
                sr.Dispose();
            }
            else
            {
                MessageBox.Show("Couldn't find file for " + cbSlayerMaster.SelectedItem.ToString() + ".\nPlease verify the file exists at" + smPath);
            }
        }

        private void lbSlayerResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            string monPath = Application.StartupPath + @"\Data\Slayer\Monsters\" + lbSlayerResults.SelectedItem.ToString() + ".txt";
            if(File.Exists(monPath))
            {
                StreamReader sr = new StreamReader(monPath);
                //The first line of the monster file should be all the statistics of the monster
                string monInfo = sr.ReadLine();
                string[] monArray = monInfo.Split('|');
                string labelText = "";
                labelText += "Combat level: " + monArray[0];
                labelText += "\nXP Per Kill: " + monArray[1] + " (+ " + monArray[2] + " Constitution XP)";
                labelText += "\nSlayer Level: " + monArray[3];
                labelText += "\nSlayer XP: " + monArray[4];
                labelText += "\nHitpoints: " + monArray[5];
                labelText += "\nMax Hit: " + monArray[6];
                labelText += "\nImmune to poison? " + monArray[7];
                labelText += "\nImmune to stun? " + monArray[8];
                labelText += "\nAggressive? " + monArray[9];
                labelText += "\nPoisonous? " + monArray[10];
                labelText += "\nAttack Style: " + monArray[11];
                labelText += "\nWeakness: " + monArray[12];
                //That's all the formatting we need, time to loop through the rest for useful text for the end user
                //Tips include things such as any slayer gear the player needs, useful for new players
                string tipLine;
                while((tipLine = sr.ReadLine()) != null)
                {
                    labelText += "\n" + tipLine;
                }
                lblSlayMon.Text = labelText;
                sr.Close();
                sr.Dispose();
            }
            else
            {
                MessageBox.Show("Unable to find monster file for " + lbSlayerResults.SelectedItem.ToString() + "\nPlease verify it exists at " + monPath);
            }
        }
    }
}