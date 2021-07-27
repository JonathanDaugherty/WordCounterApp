
namespace WordCounterApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_createWordList = new System.Windows.Forms.Button();
            this.btn_sortWords = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Count = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Load a Text File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Split the File into Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Count the Frequency of each Word";
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(12, 37);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(137, 38);
            this.btn_chooseFile.TabIndex = 3;
            this.btn_chooseFile.Text = "Choose a File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 81);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 479);
            this.textBox1.TabIndex = 5;
            // 
            // btn_createWordList
            // 
            this.btn_createWordList.Location = new System.Drawing.Point(320, 37);
            this.btn_createWordList.Name = "btn_createWordList";
            this.btn_createWordList.Size = new System.Drawing.Size(173, 38);
            this.btn_createWordList.TabIndex = 6;
            this.btn_createWordList.Text = "Create Word List";
            this.btn_createWordList.UseVisualStyleBackColor = true;
            this.btn_createWordList.Click += new System.EventHandler(this.btn_createWordList_Click);
            // 
            // btn_sortWords
            // 
            this.btn_sortWords.Location = new System.Drawing.Point(320, 81);
            this.btn_sortWords.Name = "btn_sortWords";
            this.btn_sortWords.Size = new System.Drawing.Size(122, 41);
            this.btn_sortWords.TabIndex = 7;
            this.btn_sortWords.Text = "Sort Words";
            this.btn_sortWords.UseVisualStyleBackColor = true;
            this.btn_sortWords.Click += new System.EventHandler(this.btn_sortWords_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(320, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 479);
            this.listBox1.TabIndex = 8;
            // 
            // btn_Count
            // 
            this.btn_Count.Location = new System.Drawing.Point(636, 40);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(112, 34);
            this.btn_Count.TabIndex = 9;
            this.btn_Count.Text = "Count";
            this.btn_Count.UseVisualStyleBackColor = true;
            this.btn_Count.Click += new System.EventHandler(this.btn_Count_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(636, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 479);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 640);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Count);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_sortWords);
            this.Controls.Add(this.btn_createWordList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_createWordList;
        private System.Windows.Forms.Button btn_sortWords;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Count;
        private System.Windows.Forms.ListView listView1;
    }
}

