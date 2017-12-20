using System;

namespace UltimateTXTReplaceTool
{
    partial class Form1
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
            this.InputButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.TemplateTextBox = new System.Windows.Forms.TextBox();
            this.TemplateButton = new System.Windows.Forms.Button();
            this.OutputTexbox = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.TopBox = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.Replaces = new System.Windows.Forms.Button();
            this.TableUpdater = new System.Windows.Forms.Button();
            this.BottomBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchReplaceTable = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ClipBoardText = new System.Windows.Forms.TextBox();
            this.TopBox.SuspendLayout();
            this.BottomBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(6, 19);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 20);
            this.InputButton.TabIndex = 0;
            this.InputButton.Text = "Input File";
            this.InputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(87, 20);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(416, 20);
            this.InputTextbox.TabIndex = 1;
            this.InputTextbox.TextChanged += new System.EventHandler(this.InputTextbox_TextChanged);
            // 
            // TemplateTextBox
            // 
            this.TemplateTextBox.Location = new System.Drawing.Point(87, 20);
            this.TemplateTextBox.Name = "TemplateTextBox";
            this.TemplateTextBox.Size = new System.Drawing.Size(344, 20);
            this.TemplateTextBox.TabIndex = 2;
            this.TemplateTextBox.TextChanged += new System.EventHandler(this.TemplateTextBox_TextChanged);
            // 
            // TemplateButton
            // 
            this.TemplateButton.Location = new System.Drawing.Point(6, 19);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(75, 20);
            this.TemplateButton.TabIndex = 3;
            this.TemplateButton.Text = "Template";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // OutputTexbox
            // 
            this.OutputTexbox.Location = new System.Drawing.Point(87, 49);
            this.OutputTexbox.Name = "OutputTexbox";
            this.OutputTexbox.Size = new System.Drawing.Size(416, 20);
            this.OutputTexbox.TabIndex = 4;
            this.OutputTexbox.TextChanged += new System.EventHandler(this.OutputTexbox_TextChanged);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(6, 49);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(75, 20);
            this.Output.TabIndex = 5;
            this.Output.Text = "Output";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.button3_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(514, 47);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TopBox
            // 
            this.TopBox.Controls.Add(this.button6);
            this.TopBox.Controls.Add(this.button5);
            this.TopBox.Controls.Add(this.ReplaceTextBox);
            this.TopBox.Controls.Add(this.Replaces);
            this.TopBox.Controls.Add(this.TableUpdater);
            this.TopBox.Controls.Add(this.TemplateTextBox);
            this.TopBox.Controls.Add(this.TemplateButton);
            this.TopBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TopBox.Location = new System.Drawing.Point(0, 0);
            this.TopBox.Name = "TopBox";
            this.TopBox.Size = new System.Drawing.Size(604, 120);
            this.TopBox.TabIndex = 7;
            this.TopBox.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(437, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Update Table";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(437, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Update Replaces";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Location = new System.Drawing.Point(87, 50);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(344, 20);
            this.ReplaceTextBox.TabIndex = 5;
            this.ReplaceTextBox.TextChanged += new System.EventHandler(this._TextChanged_1);
            // 
            // Replaces
            // 
            this.Replaces.Location = new System.Drawing.Point(6, 50);
            this.Replaces.Name = "Replaces";
            this.Replaces.Size = new System.Drawing.Size(75, 20);
            this.Replaces.TabIndex = 6;
            this.Replaces.Text = "Replaces";
            this.Replaces.UseVisualStyleBackColor = true;
            this.Replaces.Click += new System.EventHandler(this.Replaces_Click);
            // 
            // TableUpdater
            // 
            this.TableUpdater.Location = new System.Drawing.Point(437, 19);
            this.TableUpdater.Name = "TableUpdater";
            this.TableUpdater.Size = new System.Drawing.Size(155, 23);
            this.TableUpdater.TabIndex = 4;
            this.TableUpdater.Text = "Update Searches";
            this.TableUpdater.UseVisualStyleBackColor = true;
            this.TableUpdater.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // BottomBox
            // 
            this.BottomBox.Controls.Add(this.button2);
            this.BottomBox.Controls.Add(this.OutputTexbox);
            this.BottomBox.Controls.Add(this.InputTextbox);
            this.BottomBox.Controls.Add(this.InputButton);
            this.BottomBox.Controls.Add(this.Output);
            this.BottomBox.Controls.Add(this.Save);
            this.BottomBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBox.Location = new System.Drawing.Point(0, 536);
            this.BottomBox.Name = "BottomBox";
            this.BottomBox.Size = new System.Drawing.Size(604, 78);
            this.BottomBox.TabIndex = 8;
            this.BottomBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchReplaceTable
            // 
            this.SearchReplaceTable.AutoScroll = true;
            this.SearchReplaceTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchReplaceTable.ColumnCount = 3;
            this.SearchReplaceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.SearchReplaceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.SearchReplaceTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SearchReplaceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchReplaceTable.Location = new System.Drawing.Point(0, 120);
            this.SearchReplaceTable.MaximumSize = new System.Drawing.Size(589, 350);
            this.SearchReplaceTable.Name = "SearchReplaceTable";
            this.SearchReplaceTable.RowCount = 1;
            this.SearchReplaceTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchReplaceTable.Size = new System.Drawing.Size(589, 350);
            this.SearchReplaceTable.TabIndex = 9;
            this.SearchReplaceTable.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchReplaceTable_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 11;
            this.button3.Text = "Searches";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 12;
            this.button4.Text = "Replaces";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClipBoardText
            // 
            this.ClipBoardText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClipBoardText.Location = new System.Drawing.Point(6, 517);
            this.ClipBoardText.Name = "ClipBoardText";
            this.ClipBoardText.ReadOnly = true;
            this.ClipBoardText.Size = new System.Drawing.Size(100, 13);
            this.ClipBoardText.TabIndex = 13;
            this.ClipBoardText.Text = "Resave File";
            this.ClipBoardText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(604, 614);
            this.Controls.Add(this.ClipBoardText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchReplaceTable);
            this.Controls.Add(this.BottomBox);
            this.Controls.Add(this.TopBox);
            this.Name = "Form1";
            this.Text = "Ultimate Search Replace Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopBox.ResumeLayout(false);
            this.TopBox.PerformLayout();
            this.BottomBox.ResumeLayout(false);
            this.BottomBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _TextChanged_1(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.TextBox TemplateTextBox;
        private System.Windows.Forms.Button TemplateButton;
        private System.Windows.Forms.TextBox OutputTexbox;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox TopBox;
        private System.Windows.Forms.GroupBox BottomBox;
        private System.Windows.Forms.TableLayoutPanel SearchReplaceTable;
        private System.Windows.Forms.Button TableUpdater;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ClipBoardText;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.Button Replaces;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

