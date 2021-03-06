﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DnD_SoloPlayers
{
    public partial class PS_Edit : Form
    {
        public PS_Edit()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            XmlDocument playerSheet = new XmlDocument();
            playerSheet.Load(filename: "xml\\playersheet.xml");

            XmlNodeList playerSheetNameNodeList = playerSheet.GetElementsByTagName("name");
            XmlNodeList playerSheetLevelNodeList = playerSheet.GetElementsByTagName("level");
            XmlNodeList playerSheetAcNodeList = playerSheet.GetElementsByTagName("ac");
            XmlNodeList playerSheetClassNodeList = playerSheet.GetElementsByTagName("class");
            XmlNodeList playerSheetRaceNodeList = playerSheet.GetElementsByTagName("race");
            XmlNodeList playerSheetStrNodeList = playerSheet.GetElementsByTagName("str");
            XmlNodeList playerSheetDexNodeList = playerSheet.GetElementsByTagName("dex");
            XmlNodeList playerSheetConNodeList = playerSheet.GetElementsByTagName("con");
            XmlNodeList playerSheetIntNodeList = playerSheet.GetElementsByTagName("int");
            XmlNodeList playerSheetWisNodeList = playerSheet.GetElementsByTagName("wis");
            XmlNodeList playerSheetChaNodeList = playerSheet.GetElementsByTagName("cha");

                foreach (XmlNode node in playerSheetNameNodeList)
                {
                    PS_Edit_Name.Text = node.InnerText;
                }

                foreach (XmlNode node in playerSheetLevelNodeList)
                {
                    if(node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Level.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Level.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetAcNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Ac.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Ac.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetClassNodeList)
                {
                    PS_Edit_Class.Text = node.InnerText;
                }

                foreach (XmlNode node in playerSheetRaceNodeList)
                {
                    PS_Edit_Race.Text = node.InnerText;
                }

                foreach (XmlNode node in playerSheetStrNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Str.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Str.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetDexNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Dex.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Dex.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetConNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Con.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Con.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetIntNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Int.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Int.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetWisNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Wis.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Wis.Value = Int32.Parse(node.InnerText);
                    }
                }

                foreach (XmlNode node in playerSheetChaNodeList)
                {
                    if (node.InnerText.Equals("") || node.InnerText.Equals(" "))
                    {
                        PS_Edit_Cha.Value = 0;
                    }
                    else
                    {
                        PS_Edit_Cha.Value = Int32.Parse(node.InnerText);
                    }
                }
            }

        private void PS_Edit_Save_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument playerSheet = new XmlDocument();
                playerSheet.Load(filename: "xml\\playersheet.xml");

                XmlNodeList playerSheetNameNodeList = playerSheet.GetElementsByTagName("name");
                XmlNodeList playerSheetLevelNodeList = playerSheet.GetElementsByTagName("level");
                XmlNodeList playerSheetAcNodeList = playerSheet.GetElementsByTagName("ac");
                XmlNodeList playerSheetClassNodeList = playerSheet.GetElementsByTagName("class");
                XmlNodeList playerSheetRaceNodeList = playerSheet.GetElementsByTagName("race");
                XmlNodeList playerSheetStrNodeList = playerSheet.GetElementsByTagName("str");
                XmlNodeList playerSheetDexNodeList = playerSheet.GetElementsByTagName("dex");
                XmlNodeList playerSheetConNodeList = playerSheet.GetElementsByTagName("con");
                XmlNodeList playerSheetIntNodeList = playerSheet.GetElementsByTagName("int");
                XmlNodeList playerSheetWisNodeList = playerSheet.GetElementsByTagName("wis");
                XmlNodeList playerSheetChaNodeList = playerSheet.GetElementsByTagName("cha");

                string name = PS_Edit_Name.Text;
                string level = Convert.ToString(PS_Edit_Level.Value);
                string ac = Convert.ToString(PS_Edit_Ac.Value);
                string charclass = PS_Edit_Class.Text;
                string race = PS_Edit_Race.Text;
                string str = Convert.ToString(PS_Edit_Str.Value);
                string dex = Convert.ToString(PS_Edit_Dex.Value);
                string con = Convert.ToString(PS_Edit_Con.Value);
                string charint = Convert.ToString(PS_Edit_Int.Value);
                string wis = Convert.ToString(PS_Edit_Wis.Value);
                string cha = Convert.ToString(PS_Edit_Cha.Value);

                foreach (XmlNode node in playerSheetNameNodeList)
                {
                    node.InnerText = name;
                }

                foreach (XmlNode node in playerSheetLevelNodeList)
                {
                    node.InnerText = level;
                }

                foreach (XmlNode node in playerSheetAcNodeList)
                {
                    node.InnerText = ac;
                }

                foreach (XmlNode node in playerSheetClassNodeList)
                {
                    node.InnerText = charclass;
                }

                foreach (XmlNode node in playerSheetRaceNodeList)
                {
                    node.InnerText = race;
                }

                foreach (XmlNode node in playerSheetStrNodeList)
                {
                    node.InnerText = str;
                }

                foreach (XmlNode node in playerSheetDexNodeList)
                {
                    node.InnerText = dex;
                }

                foreach (XmlNode node in playerSheetConNodeList)
                {
                    node.InnerText = con;
                }

                foreach (XmlNode node in playerSheetIntNodeList)
                {
                    node.InnerText = charint;
                }

                foreach (XmlNode node in playerSheetWisNodeList)
                {
                    node.InnerText = wis;
                }

                foreach (XmlNode node in playerSheetChaNodeList)
                {
                    node.InnerText = cha;
                }

                playerSheet.Save(filename: "xml\\playersheet.xml");

                new P_Sheet().Show();
                this.Close();
            }
            catch
            {

            }
        }
    }
}
