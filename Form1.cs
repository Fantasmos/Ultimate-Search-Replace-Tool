using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateTXTReplaceTool
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            CreateTextBoxRow("Search", "Replace");

            Console.WriteLine("DATA");
        }

        void UpdateForm (List<string> Searches, List<string> Replaces, TableLayoutPanel TableToupdate)
        {
            TableToupdate.Controls.Clear();
            for (int i = 0; i < Math.Max(Searches.Count, Replaces.Count); i++)
            {
                if (Searches.Count <= i)
                {
                    CreateTextBoxRow("EMPTY", Replaces[i]);
                }
                else if (Replaces.Count <= i)
                {
                    CreateTextBoxRow(Searches[i], "EMPTY");
                }
                else
                {
                    CreateTextBoxRow(Searches[i], Replaces[i]);
                }
            }
        }

        void CreateTextBoxRow (string LHS , string RHS)
        {
            TextBox LHSString = new TextBox();
            LHSString.Text = LHS;
            LHSString.Width = ((SearchReplaceTable.Width / 2)) - 7;
            SearchReplaceTable.Controls.Add(LHSString);

            TextBox RHSString = new TextBox();
            RHSString.Width = ((SearchReplaceTable.Width / 2)) - 7;
            RHSString.Text = RHS;
            SearchReplaceTable.Controls.Add(RHSString);


            Button RemoveButton = new Button();
            RemoveButton.Click += RemoveButton_Click;
            RemoveButton.Text = "Remove";
            SearchReplaceTable.Controls.Add(RemoveButton);
        }

        void SaveFile()
        {
            if (System.IO.File.Exists(InputTextbox.Text)) 
            {
                string OutPutFilePath = OutputTexbox.Text;
                System.IO.File.Delete(OutPutFilePath);
                System.IO.StreamReader file = new System.IO.StreamReader(InputTextbox.Text);
                string line = "";
                int counter = 0;

                while ((line = file.ReadLine()) != null)
                {
                    for (int i = 0; i < SearchReplaceTable.RowCount + 2; i++)
                    {
                        string search = SearchReplaceTable.GetControlFromPosition(0, i).Text;
                        string replace = SearchReplaceTable.GetControlFromPosition(1, i).Text;
                        line = line.Replace(search, replace);
                    }

                    counter++;

                    using (StreamWriter sw = System.IO.File.AppendText(OutPutFilePath))
                    {
                        sw.WriteLine(line);
                    }                        
                }

            }

            
        }
        /// <summary>
        /// Removes the row of the button in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            TableLayoutPanel table = (TableLayoutPanel)ClickedButton.Parent;
            int RowOfClickedButton = table.GetPositionFromControl(ClickedButton).Row;

            for (int i = 0; i < 3; i++)
            {
                Control Location = table.GetControlFromPosition(0, RowOfClickedButton);
                table.Controls.Remove(Location);
            }
        }



        /// <summary>
        /// Adds each line in the input file to the string list, returns an empty list if the file is invalid
        /// </summary>
        /// <param name="File Location, the location of the file"></param>
        /// <returns></returns>
        List<string> BuildStringCollection (string FileLocation)
        {
            List<string> StringsToReplace = new List<string>();

            if (System.IO.File.Exists(FileLocation)) //Wrong level of abstraction here? Maybe it should go lower
            {

                System.IO.StreamReader file = new System.IO.StreamReader(FileLocation);
                string line;
                int counter = 0;

                while ((line = file.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line) == false)
                    {
                        StringsToReplace.Add(line);
                    }
                    
                    counter++;
                }
            }

            return StringsToReplace;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.AddExtension = false;
            
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OutputTexbox.Text = SaveFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("An error has occured, this is an invalid file!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                InputTextbox.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("An error has occured, this is an invalid file!");
            }
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            List<string> Searches = BuildStringCollection(TemplateTextBox.Text);  
            List<string> Replaces = GetColumn(1);
            UpdateForm(Searches, Replaces, SearchReplaceTable);
        }

        private void UpdateTable()
        {
            List<string> Searches = BuildStringCollection(TemplateTextBox.Text);
            List<string> Replaces = BuildStringCollection(ReplaceTextBox.Text);
            UpdateForm(Searches, Replaces, SearchReplaceTable);
        }

        private void TemplateButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TemplateTextBox.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("An error has occured, this is an invalid file!");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CreateTextBoxRow("Search", "Replace");
        }

        private void TemplateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTexbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFile();

            MessageBox.Show("Done attempting to save the file!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(OutputTexbox.Text);
            }
            catch
            {
                MessageBox.Show("No file exists!");
            }
        }

        void SaveTextToFile (string FullString)
        {
            Stream myStream = null;

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.DefaultExt = "txt";
            SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.AddExtension = true;
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string OutPutFilePath = SaveFileDialog1.FileName;
                System.IO.File.Delete(OutPutFilePath);
                System.IO.File.WriteAllText(OutPutFilePath, FullString);
                MessageBox.Show("Completed!");
            }
            else
            {
                MessageBox.Show("An error has occured, this is an invalid file!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string FullString = "";

            foreach (string entry in GetColumn(1))
            {
                FullString += entry +'\n';
            }
            SaveTextToFile(FullString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List<string> GetColumn(int col)
        {
            List<string> searches = new List<string>();
            for (int i = 0; i < SearchReplaceTable.Controls.Count / 3; i++)
            {
                searches.Add(SearchReplaceTable.GetControlFromPosition(col, i).Text);
            }
            return searches;
        }
        List<string> GetSearches()
        {
            return GetColumn(1);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string FullString = "";

            foreach (string entry in GetColumn(1))
            {
                FullString += entry + '\n';
            }
            SaveTextToFile(FullString);
        }

        private void SearchReplaceTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Replaces_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ReplaceTextBox.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("An error has occured, this is an invalid file!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> Searches = GetColumn(0);
            List<string> Replaces = BuildStringCollection(ReplaceTextBox.Text);
            UpdateForm(Searches, Replaces, SearchReplaceTable);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
