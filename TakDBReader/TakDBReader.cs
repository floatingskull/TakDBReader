using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Data.SQLite;

namespace TakDBReader
{
    public partial class TakDBReaderForm : Form
    {
        private SQLiteConnection connection;
        private int totalgames;
        private int subtotalgames;
        private int whitewingames;
        private int blackwingames;
        private int drawwingames;
        private int roadwingames;
        private int flatwingames;
        private int resignwingames;

        private const int UL = 0;
        private const int UR = 1;
        private const int BR = 2;
        private const int BL = 3;

        private const string tablename = "SELECT * FROM games";
        private const string whitewin = "(result='R-0' or result='F-0' or result='1-0')";
        private const string blackwin = "(result='0-R' or result='0-F' or result='0-1')";
        private const string drawwin = "(result='1/2-1/2')";
        private const string roadwin = "(result='0-R' or result='R-0')";
        private const string flatwin = "(result='0-F' or result='F-0')";
        private const string resignwin = "(result='0-1' or result='1-0')";

        public TakDBReaderForm()
        {
            InitializeComponent();
            whiteplayerhb.SelectedIndex = 2;
            blackplayerhb.SelectedIndex = 2;
            openings.SelectedIndex = 0;
            gametype.SelectedIndex = 4;
            resulttype.SelectedIndex = 6;
            for (int i = 0; i < sizes.Items.Count; i++)
                sizes.SetSelected(i, true);
        }

        ~TakDBReaderForm()
        {
            connection.Close();
        }

        private int SendQuery(string commandString)
        {
            SQLiteCommand command = new SQLiteCommand(commandString, connection);

            SQLiteDataReader reader = command.ExecuteReader();

            int value = 0;

            while (reader.Read())
            {
                value++;
            }
            
            reader.Dispose();

            return value;
        }

        private string BuildQuery()
        {
            return BuildQuery("");
        }

        private string BuildQuery(string input)
        {
            string query = tablename + " WHERE ";

            if (input.Length > 0)
                query += input + " AND ";

            query += GetPlayers();

            query += GetSizes();

            if(restrictdates.CheckState == CheckState.Checked)
                query += GetDates();

            query += GetOpening();

            query += GetResult();

            //Notation has to be the last portion of the query
            query += GetNotation();

            return (query);
        }

        private string GetPlayers()
        {
            string output = "";

            //restrict player_white
            switch (whiteplayerhb.SelectedIndex)
            {
                case(0):
                    output += "NOT (player_white like '%bot' or player_white like 'stakbot_') AND ";
                    break;
                case(1):
                    output += "(player_white like '%bot' or player_white like 'stakbot_') AND ";
                    break;
            }

            //restrict player_black
            switch (blackplayerhb.SelectedIndex)
            {
                case (0):
                    output += "NOT (player_black like '%bot' or player_black like 'stakbot_') AND ";
                    break;
                case (1):
                    output += "(player_black like '%bot' or player_black like 'stakbot_') AND ";
                    break;
            }

            //restrict type of game (i.e. bots and human status)
            switch (gametype.SelectedIndex)
            {
                case (0):
                    output += "(NOT (player_white like '%bot' or player_white like 'stakbot_') AND NOT (player_black like '%bot' or player_black like 'stakbot_')) AND ";
                    break;
                case (1):
                    output += "((NOT (player_white like '%bot' or player_white like 'stakbot_') AND (player_black like '%bot' or player_black like 'stakbot_')) OR "
                        + "((player_white like '%bot' or player_white like 'stakbot_') AND NOT (player_black like '%bot' or player_black like 'stakbot_'))) AND ";
                    break;
                case (2):
                    output += "((player_white like '%bot' or player_white like 'stakbot_') AND (player_black like '%bot' or player_black like 'stakbot_')) AND ";
                    break;
                case (3):
                    output += "NOT ((player_white like '%bot' or player_white like 'stakbot_') AND (player_black like '%bot' or player_black like 'stakbot_')) AND ";
                    break;
            }

            //Narrow to a specific user
            if (SelectUser.CheckState == CheckState.Checked)
            {
                output += "(player_black like '" + UserText.Text + "' or player_white like '" + UserText.Text + "') AND ";
            }

            return output;
        }

        private string GetDates()
        {
            var from = (datefrom.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            var to = (dateto.Value - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            
            
            string output = "(date > ";
            output += from.ToString();
            output += " AND date < ";
            output += to.ToString();
            output += ") AND ";

            //MessageBox.Show(output);
            return output;
        }

        private string GetNotation()
        {
            string moves = "";
            for(int i = 0; i < Convert.ToInt32(minmovesinput.Value); i++)
                moves += "____";

            return ("(notation LIKE '" + moves + "%')"); 
        }

        private string GetSizes()
        {
            string output = "(";

            for (int i = 0; i < sizes.Items.Count; i++)
            {
                if (sizes.GetSelected(i))
                {
                    if (output.Length > 1)
                        output += " OR ";

                    output += "size=" + (i+3);
                }
            }

            if (output.Length > 1)
            {
                output += ") AND ";
                return output;
            }
            else return "";
        }

        private string GetOpening()
        {
            string output = "(";

            if (openings.SelectedIndex > 0)
            {
                for (int i = 0; i < sizes.Items.Count; i++)
                {
                    if (sizes.GetSelected(i))
                    {
                        int size = i;

                        if (output.Length > 1)
                            output += " OR ";

                        switch (openings.SelectedIndex)
                        {
                            case (1):
                                {
                                    //Both in Corner
                                    output += "((notation LIKE '__" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '__" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BL, size) + "%')";

                                    output += "AND (notation LIKE '_______" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BL, size) + "%'))";
                                }
                                break;
                            case (2):
                                {
                                    //Neither in Corner
                                    output += "NOT ((notation LIKE '__" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '__" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BL, size) + "%')";

                                    output += "OR (notation LIKE '_______" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BL, size) + "%'))";
                                }
                                break;
                            case (3):
                                {
                                    //Only Black in Corner
                                    output += "((notation LIKE '__" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '__" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BL, size) + "%')";

                                    output += "AND NOT (notation LIKE '_______" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BL, size) + "%'))";
                                }
                                break;
                            case (4):
                                {
                                    //Only White in Corner
                                    output += "((notation LIKE '_______" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BL, size) + "%')";

                                    output += "AND NOT (notation LIKE '__" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '__" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BL, size) + "%'))";
                                }
                                break;
                            case (5):
                                {
                                    //Adjacent Corners
                                    output += "(((notation LIKE '__" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '__" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BL, size) + "%')";

                                    output += "AND (notation LIKE '_______" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BL, size) + "%'))";

                                    output += "AND NOT ((notation LIKE '__" + GetCorner(UL, size) + "%' AND notation LIKE '_______" + GetCorner(BR, size) + "%')"
                                        + " OR (notation LIKE '__" + GetCorner(UR, size) + "%' AND notation LIKE '_______" + GetCorner(BL, size) + "%')"
                                        + " OR (notation LIKE '__" + GetCorner(BR, size) + "%' AND notation LIKE '_______" + GetCorner(UL, size) + "%')"
                                        + " OR (notation LIKE '__" + GetCorner(BL, size) + "%' AND notation LIKE '_______" + GetCorner(UR, size) + "%')))";
                                }
                                break;
                            case (6):
                                {
                                    //Opposite Corners
                                    output += "((notation LIKE '__" + GetCorner(UL, size) + "%' AND notation LIKE '_______" + GetCorner(BR, size) + "%')"
                                        + " OR (notation LIKE '__" + GetCorner(UR, size) + "%' AND notation LIKE '_______" + GetCorner(BL, size) + "%')"
                                        + " OR (notation LIKE '__" + GetCorner(BR, size) + "%' AND notation LIKE '_______" + GetCorner(UL, size) + "%')"
                                        + " OR (notation LIKE '__" + GetCorner(BL, size) + "%' AND notation LIKE '_______" + GetCorner(UR, size) + "%'))";
                                }
                                break;
                            case (7):
                                {
                                    //Black Center
                                    if (size % 2 == 0)
                                    {
                                        int column = (size + 4) / 2;
                                        output += "(notation LIKE '__" + GetRow(column) + column.ToString() + "%')";
                                    }
                                    else
                                    {
                                        int column = (size + 3) / 2;
                                        output += "((notation LIKE '__" + GetRow(column) + column.ToString() + "%')"
                                            + "OR (notation LIKE '__" + GetRow(column + 1) + column.ToString() + "%')"
                                            + "OR (notation LIKE '__" + GetRow(column) + (column + 1).ToString() + "%')"
                                            + "OR (notation LIKE '__" + GetRow(column + 1) + (column + 1).ToString() + "%'))";
                                    }

                                }
                                break;
                            case (8):
                                {
                                    //Black Center, White Corner
                                    if (size % 2 == 0)
                                    {
                                        int column = (size + 4) / 2;
                                        output += "((notation LIKE '__" + GetRow(column) + column.ToString() + "%')";
                                    }
                                    else
                                    {
                                        int column = (size + 3) / 2;
                                        output += "(((notation LIKE '__" + GetRow(column) + column.ToString() + "%')"
                                            + "OR (notation LIKE '__" + GetRow(column + 1) + column.ToString() + "%')"
                                            + "OR (notation LIKE '__" + GetRow(column) + (column + 1).ToString() + "%')"
                                            + "OR (notation LIKE '__" + GetRow(column + 1) + (column + 1).ToString() + "%'))";
                                    }

                                    output += " AND (notation LIKE '_______" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '_______" + GetCorner(BL, size) + "%'))";
                                }
                                break;
                            case (9):
                                {
                                    //White Center
                                    if (size % 2 == 0)
                                    {
                                        int column = (size + 4) / 2;
                                        output += "(notation LIKE '_______" + GetRow(column) + column.ToString() + "%')";
                                    }
                                    else
                                    {
                                        int column = (size + 3) / 2;
                                        output += "((notation LIKE '_______" + GetRow(column) + column.ToString() + "%')"
                                            + "OR (notation LIKE '_______" + GetRow(column + 1) + column.ToString() + "%')"
                                            + "OR (notation LIKE '_______" + GetRow(column) + (column + 1).ToString() + "%')"
                                            + "OR (notation LIKE '_______" + GetRow(column + 1) + (column + 1).ToString() + "%'))";
                                    }

                                }
                                break;
                            case (10):
                                {
                                    //White Center, Black Corner
                                    if (size % 2 == 0)
                                    {
                                        int column = (size + 4) / 2;
                                        output += "((notation LIKE '_______" + GetRow(column) + column.ToString() + "%')";
                                    }
                                    else
                                    {
                                        int column = (size + 3) / 2;
                                        output += "(((notation LIKE '_______" + GetRow(column) + column.ToString() + "%')"
                                            + "OR (notation LIKE '_______" + GetRow(column + 1) + column.ToString() + "%')"
                                            + "OR (notation LIKE '_______" + GetRow(column) + (column + 1).ToString() + "%')"
                                            + "OR (notation LIKE '_______" + GetRow(column + 1) + (column + 1).ToString() + "%'))";
                                    }

                                    output += " AND (notation LIKE '__" + GetCorner(UL, size)
                                        + "%' OR notation LIKE '__" + GetCorner(UR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BR, size)
                                        + "%' OR notation LIKE '__" + GetCorner(BL, size) + "%'))";
                                }
                                break;
                        }
                    }
                }
            }

            if (output.Length > 1)
            {
                output += ") AND ";
                return output;
            }
            else return "";
        }

        private string GetResult()
        {
            string output = "";

            switch (resulttype.SelectedIndex)
            {
                case (0):
                    output += whitewin + " AND ";
                    break;
                case (1):
                    output += blackwin + " AND ";
                    break;
                case (2):
                    output += drawwin + " AND ";
                    break;
                case (3):
                    output += roadwin + " AND ";
                    break;
                case (4):
                    output += flatwin + " AND ";
                    break;
                case (5):
                    output += resignwin + " AND ";
                    break;
            }

            return output;
        }

        private string GetRow(int num)
        {
            string row = "";

            switch (num)
            {
                case (1): row = "A"; break;
                case (2): row = "B"; break;
                case (3): row = "C"; break;
                case (4): row = "D"; break;
                case (5): row = "E"; break;
                case (6): row = "F"; break;
                case (7): row = "G"; break;
                case (8): row = "H"; break;
            }

            return row;
        }

        private string GetCorner(int corner, int size)
        {
            size += 3;

            switch (corner)
            {
                case (UL): 
                    return ("A1");
                case (UR):
                    return ("A" + size.ToString());
                case (BR):
                    return (GetRow(size) + size.ToString());
                case (BL):
                    return (GetRow(size) + "1");
                default :
                    return "";
            }
        }

        private void PopulateInfo()
        {
            totalgames = SendQuery(tablename);
            numgameslabel.Text = totalgames.ToString();
            gamespercent.Text = GetPercent(totalgames, totalgames);

            subtotalgames = SendQuery(BuildQuery());
            selectedgameslabel.Text = subtotalgames.ToString();
            selectedgamespercent.Text = GetPercent(subtotalgames, totalgames);

            whitewingames = SendQuery(BuildQuery(whitewin));
            blackwingames = SendQuery(BuildQuery(blackwin));
            drawwingames = SendQuery(BuildQuery(drawwin));
            roadwingames = SendQuery(BuildQuery(roadwin));
            flatwingames = SendQuery(BuildQuery(flatwin));
            resignwingames = SendQuery(BuildQuery(resignwin));

            whitewinslabel.Text = whitewingames.ToString();
            blackwinslabel.Text = blackwingames.ToString();
            drawslabel.Text = drawwingames.ToString();
            roadwinslabel.Text = roadwingames.ToString();
            flatwinslabel.Text = flatwingames.ToString();
            resignationlabel.Text = resignwingames.ToString();

            whitewinspercent.Text = GetPercent(whitewingames);
            blackwinspercent.Text = GetPercent(blackwingames);
            drawwinspercent.Text = GetPercent(drawwingames);
            roadwinspercent.Text = GetPercent(roadwingames);
            flatwinspercent.Text = GetPercent(flatwingames);
            resignwinspercent.Text = GetPercent(resignwingames);

            if (resulttype.SelectedIndex >= 2)
            {
                if (whitewingames >= blackwingames)
                {
                    fpa.Text = GetPercent((whitewingames - blackwingames) / 2);
                }
                else
                {
                    fpa.Text = "-" + GetPercent((blackwingames - whitewingames) / 2);
                }
            }
            else fpa.Text = "NA";

        }

        private string GetPercent(double val)
        {
            double output = (val * 100 / subtotalgames);
            output = Math.Round(output, 2);
            return (output.ToString() + "%");
        }

        private string GetPercent(double val, int num)
        {
            double output = (val * 100 / num);
            output = Math.Round(output, 2);
            return (output.ToString() + "%");
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "Database files (*.db)|*.db";

            string path;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = openFileDialog1.FileName;
                    connection = new SQLiteConnection("Data Source=" + path + ";");
                    connection.Open();
                    openfilelabel.Text = path;

                    PopulateInfo();
                    RefreshButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open file. Original error: " + ex.Message);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PopulateInfo();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void restrictdates_CheckedChanged(object sender, EventArgs e)
        {
            if (restrictdates.CheckState == CheckState.Checked)
            {
                datefrom.Enabled = true;
                dateto.Enabled = true;
                datefromtext.Enabled = true;
                datetotext.Enabled = true;
            }
            else if (restrictdates.CheckState == CheckState.Unchecked)
            {
                datefrom.Enabled = false;
                dateto.Enabled = false;
                datefromtext.Enabled = false;
                datetotext.Enabled = false;
            }
        }

        private void SelectUser_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectUser.CheckState == CheckState.Checked)
            {
                UserText.Enabled = true;
            }
            else if (SelectUser.CheckState == CheckState.Unchecked)
            {
                UserText.Enabled = false;
            }
        }
    }
}
