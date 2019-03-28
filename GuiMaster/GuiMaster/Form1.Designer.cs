namespace GuiMaster
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
            this.pnl_Text = new System.Windows.Forms.Panel();
            this.tBox_Text = new System.Windows.Forms.TextBox();
            this.lbl_textCount = new System.Windows.Forms.Label();
            this.gBox_Font = new System.Windows.Forms.GroupBox();
            this.rBtn_ComicSans = new System.Windows.Forms.RadioButton();
            this.rBtn_Arial = new System.Windows.Forms.RadioButton();
            this.rBtn_MSSF = new System.Windows.Forms.RadioButton();
            this.cBox_Colours = new System.Windows.Forms.ComboBox();
            this.gBox_Dock = new System.Windows.Forms.GroupBox();
            this.rButton_None = new System.Windows.Forms.RadioButton();
            this.rButton_Right = new System.Windows.Forms.RadioButton();
            this.rButton_Left = new System.Windows.Forms.RadioButton();
            this.rButton_Down = new System.Windows.Forms.RadioButton();
            this.rButton_Up = new System.Windows.Forms.RadioButton();
            this.numeric_Size = new System.Windows.Forms.NumericUpDown();
            this.chBox_ReadOnly = new System.Windows.Forms.CheckBox();
            this.chBox_Enabled = new System.Windows.Forms.CheckBox();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btn_progBar = new System.Windows.Forms.Button();
            this.lBox01 = new System.Windows.Forms.ListBox();
            this.btn_listBox = new System.Windows.Forms.Button();
            this.lbl_NumOfWords = new System.Windows.Forms.Label();
            this.panel_Mouse = new System.Windows.Forms.Panel();
            this.lbl_MouseMove = new System.Windows.Forms.Label();
            this.pnl_Text.SuspendLayout();
            this.gBox_Font.SuspendLayout();
            this.gBox_Dock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Text
            // 
            this.pnl_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Text.Controls.Add(this.tBox_Text);
            this.pnl_Text.Location = new System.Drawing.Point(12, 12);
            this.pnl_Text.Name = "pnl_Text";
            this.pnl_Text.Size = new System.Drawing.Size(252, 231);
            this.pnl_Text.TabIndex = 0;
            // 
            // tBox_Text
            // 
            this.tBox_Text.Location = new System.Drawing.Point(39, 77);
            this.tBox_Text.Multiline = true;
            this.tBox_Text.Name = "tBox_Text";
            this.tBox_Text.Size = new System.Drawing.Size(182, 71);
            this.tBox_Text.TabIndex = 0;
            this.tBox_Text.TextChanged += new System.EventHandler(this.tBox_Text_TextChanged);
            // 
            // lbl_textCount
            // 
            this.lbl_textCount.AutoSize = true;
            this.lbl_textCount.Location = new System.Drawing.Point(270, 12);
            this.lbl_textCount.Name = "lbl_textCount";
            this.lbl_textCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_textCount.TabIndex = 1;
            this.lbl_textCount.Text = "Count";
            // 
            // gBox_Font
            // 
            this.gBox_Font.Controls.Add(this.rBtn_ComicSans);
            this.gBox_Font.Controls.Add(this.rBtn_Arial);
            this.gBox_Font.Controls.Add(this.rBtn_MSSF);
            this.gBox_Font.Location = new System.Drawing.Point(270, 28);
            this.gBox_Font.Name = "gBox_Font";
            this.gBox_Font.Size = new System.Drawing.Size(133, 100);
            this.gBox_Font.TabIndex = 2;
            this.gBox_Font.TabStop = false;
            this.gBox_Font.Text = "Font";
            // 
            // rBtn_ComicSans
            // 
            this.rBtn_ComicSans.AutoSize = true;
            this.rBtn_ComicSans.Location = new System.Drawing.Point(6, 66);
            this.rBtn_ComicSans.Name = "rBtn_ComicSans";
            this.rBtn_ComicSans.Size = new System.Drawing.Size(81, 17);
            this.rBtn_ComicSans.TabIndex = 2;
            this.rBtn_ComicSans.Text = "Comic Sans";
            this.rBtn_ComicSans.UseVisualStyleBackColor = true;
            this.rBtn_ComicSans.CheckedChanged += new System.EventHandler(this.rBtn_ComicSans_CheckedChanged);
            // 
            // rBtn_Arial
            // 
            this.rBtn_Arial.AutoSize = true;
            this.rBtn_Arial.Location = new System.Drawing.Point(6, 43);
            this.rBtn_Arial.Name = "rBtn_Arial";
            this.rBtn_Arial.Size = new System.Drawing.Size(45, 17);
            this.rBtn_Arial.TabIndex = 1;
            this.rBtn_Arial.Text = "Arial";
            this.rBtn_Arial.UseVisualStyleBackColor = true;
            this.rBtn_Arial.CheckedChanged += new System.EventHandler(this.rBtn_Arial_CheckedChanged);
            // 
            // rBtn_MSSF
            // 
            this.rBtn_MSSF.AutoSize = true;
            this.rBtn_MSSF.Checked = true;
            this.rBtn_MSSF.Location = new System.Drawing.Point(6, 20);
            this.rBtn_MSSF.Name = "rBtn_MSSF";
            this.rBtn_MSSF.Size = new System.Drawing.Size(119, 17);
            this.rBtn_MSSF.TabIndex = 0;
            this.rBtn_MSSF.TabStop = true;
            this.rBtn_MSSF.Text = "Microsoft Sans Serif";
            this.rBtn_MSSF.UseVisualStyleBackColor = true;
            this.rBtn_MSSF.CheckedChanged += new System.EventHandler(this.rBtn_MSSF_CheckedChanged);
            // 
            // cBox_Colours
            // 
            this.cBox_Colours.FormattingEnabled = true;
            this.cBox_Colours.Location = new System.Drawing.Point(270, 176);
            this.cBox_Colours.Name = "cBox_Colours";
            this.cBox_Colours.Size = new System.Drawing.Size(121, 21);
            this.cBox_Colours.TabIndex = 4;
            this.cBox_Colours.Text = "Colours";
            this.cBox_Colours.SelectedIndexChanged += new System.EventHandler(this.cBox_Colours_SelectedIndexChanged);
            // 
            // gBox_Dock
            // 
            this.gBox_Dock.Controls.Add(this.rButton_None);
            this.gBox_Dock.Controls.Add(this.rButton_Right);
            this.gBox_Dock.Controls.Add(this.rButton_Left);
            this.gBox_Dock.Controls.Add(this.rButton_Down);
            this.gBox_Dock.Controls.Add(this.rButton_Up);
            this.gBox_Dock.Location = new System.Drawing.Point(270, 213);
            this.gBox_Dock.Name = "gBox_Dock";
            this.gBox_Dock.Size = new System.Drawing.Size(133, 148);
            this.gBox_Dock.TabIndex = 5;
            this.gBox_Dock.TabStop = false;
            this.gBox_Dock.Text = "Dock";
            // 
            // rButton_None
            // 
            this.rButton_None.AutoSize = true;
            this.rButton_None.Checked = true;
            this.rButton_None.Location = new System.Drawing.Point(6, 112);
            this.rButton_None.Name = "rButton_None";
            this.rButton_None.Size = new System.Drawing.Size(51, 17);
            this.rButton_None.TabIndex = 4;
            this.rButton_None.TabStop = true;
            this.rButton_None.Text = "None";
            this.rButton_None.UseVisualStyleBackColor = true;
            this.rButton_None.CheckedChanged += new System.EventHandler(this.rButton_None_CheckedChanged);
            // 
            // rButton_Right
            // 
            this.rButton_Right.AutoSize = true;
            this.rButton_Right.Location = new System.Drawing.Point(6, 89);
            this.rButton_Right.Name = "rButton_Right";
            this.rButton_Right.Size = new System.Drawing.Size(50, 17);
            this.rButton_Right.TabIndex = 3;
            this.rButton_Right.Text = "Right";
            this.rButton_Right.UseVisualStyleBackColor = true;
            this.rButton_Right.CheckedChanged += new System.EventHandler(this.rButton_Right_CheckedChanged);
            // 
            // rButton_Left
            // 
            this.rButton_Left.AutoSize = true;
            this.rButton_Left.Location = new System.Drawing.Point(6, 66);
            this.rButton_Left.Name = "rButton_Left";
            this.rButton_Left.Size = new System.Drawing.Size(43, 17);
            this.rButton_Left.TabIndex = 2;
            this.rButton_Left.Text = "Left";
            this.rButton_Left.UseVisualStyleBackColor = true;
            this.rButton_Left.CheckedChanged += new System.EventHandler(this.rButton_Left_CheckedChanged);
            // 
            // rButton_Down
            // 
            this.rButton_Down.AutoSize = true;
            this.rButton_Down.Location = new System.Drawing.Point(6, 43);
            this.rButton_Down.Name = "rButton_Down";
            this.rButton_Down.Size = new System.Drawing.Size(53, 17);
            this.rButton_Down.TabIndex = 1;
            this.rButton_Down.Text = "Down";
            this.rButton_Down.UseVisualStyleBackColor = true;
            this.rButton_Down.CheckedChanged += new System.EventHandler(this.rButton_Down_CheckedChanged);
            // 
            // rButton_Up
            // 
            this.rButton_Up.AutoSize = true;
            this.rButton_Up.Location = new System.Drawing.Point(6, 20);
            this.rButton_Up.Name = "rButton_Up";
            this.rButton_Up.Size = new System.Drawing.Size(39, 17);
            this.rButton_Up.TabIndex = 0;
            this.rButton_Up.Text = "Up";
            this.rButton_Up.UseVisualStyleBackColor = true;
            this.rButton_Up.CheckedChanged += new System.EventHandler(this.rButton_Up_CheckedChanged);
            // 
            // numeric_Size
            // 
            this.numeric_Size.Location = new System.Drawing.Point(270, 140);
            this.numeric_Size.Name = "numeric_Size";
            this.numeric_Size.Size = new System.Drawing.Size(120, 20);
            this.numeric_Size.TabIndex = 6;
            this.numeric_Size.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numeric_Size.ValueChanged += new System.EventHandler(this.numeric_Size_ValueChanged);
            // 
            // chBox_ReadOnly
            // 
            this.chBox_ReadOnly.AutoSize = true;
            this.chBox_ReadOnly.Location = new System.Drawing.Point(13, 256);
            this.chBox_ReadOnly.Name = "chBox_ReadOnly";
            this.chBox_ReadOnly.Size = new System.Drawing.Size(76, 17);
            this.chBox_ReadOnly.TabIndex = 7;
            this.chBox_ReadOnly.Text = "Read-Only";
            this.chBox_ReadOnly.UseVisualStyleBackColor = true;
            this.chBox_ReadOnly.CheckedChanged += new System.EventHandler(this.chBox_ReadOnly_CheckedChanged);
            // 
            // chBox_Enabled
            // 
            this.chBox_Enabled.AutoSize = true;
            this.chBox_Enabled.Location = new System.Drawing.Point(13, 279);
            this.chBox_Enabled.Name = "chBox_Enabled";
            this.chBox_Enabled.Size = new System.Drawing.Size(100, 17);
            this.chBox_Enabled.TabIndex = 8;
            this.chBox_Enabled.Text = "Enable Controls";
            this.chBox_Enabled.UseVisualStyleBackColor = true;
            this.chBox_Enabled.CheckedChanged += new System.EventHandler(this.chBox_Enabled_CheckedChanged);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(438, 11);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(350, 350);
            this.pBox.TabIndex = 9;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 315);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(169, 23);
            this.progBar.TabIndex = 10;
            // 
            // btn_progBar
            // 
            this.btn_progBar.Location = new System.Drawing.Point(187, 315);
            this.btn_progBar.Name = "btn_progBar";
            this.btn_progBar.Size = new System.Drawing.Size(77, 23);
            this.btn_progBar.TabIndex = 11;
            this.btn_progBar.Text = "Click Me";
            this.btn_progBar.UseVisualStyleBackColor = true;
            this.btn_progBar.Click += new System.EventHandler(this.btn_progBar_Click);
            // 
            // lBox01
            // 
            this.lBox01.FormattingEnabled = true;
            this.lBox01.Location = new System.Drawing.Point(12, 356);
            this.lBox01.Name = "lBox01";
            this.lBox01.Size = new System.Drawing.Size(77, 186);
            this.lBox01.TabIndex = 12;
            this.lBox01.SelectedValueChanged += new System.EventHandler(this.lBox01_SelectedValueChanged);
            // 
            // btn_listBox
            // 
            this.btn_listBox.Location = new System.Drawing.Point(106, 356);
            this.btn_listBox.Name = "btn_listBox";
            this.btn_listBox.Size = new System.Drawing.Size(75, 23);
            this.btn_listBox.TabIndex = 13;
            this.btn_listBox.Text = "Get Words";
            this.btn_listBox.UseVisualStyleBackColor = true;
            this.btn_listBox.Click += new System.EventHandler(this.btn_listBox_Click);
            // 
            // lbl_NumOfWords
            // 
            this.lbl_NumOfWords.AutoSize = true;
            this.lbl_NumOfWords.Location = new System.Drawing.Point(103, 392);
            this.lbl_NumOfWords.Name = "lbl_NumOfWords";
            this.lbl_NumOfWords.Size = new System.Drawing.Size(75, 13);
            this.lbl_NumOfWords.TabIndex = 14;
            this.lbl_NumOfWords.Text = "Select a word!";
            // 
            // panel_Mouse
            // 
            this.panel_Mouse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Mouse.Location = new System.Drawing.Point(270, 367);
            this.panel_Mouse.Name = "panel_Mouse";
            this.panel_Mouse.Size = new System.Drawing.Size(278, 175);
            this.panel_Mouse.TabIndex = 15;
            this.panel_Mouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Mouse_MouseMove);
            // 
            // lbl_MouseMove
            // 
            this.lbl_MouseMove.AutoSize = true;
            this.lbl_MouseMove.Location = new System.Drawing.Point(555, 528);
            this.lbl_MouseMove.Name = "lbl_MouseMove";
            this.lbl_MouseMove.Size = new System.Drawing.Size(98, 13);
            this.lbl_MouseMove.TabIndex = 16;
            this.lbl_MouseMove.Text = "Mouse Coordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lbl_MouseMove);
            this.Controls.Add(this.panel_Mouse);
            this.Controls.Add(this.lbl_NumOfWords);
            this.Controls.Add(this.btn_listBox);
            this.Controls.Add(this.lBox01);
            this.Controls.Add(this.btn_progBar);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.chBox_Enabled);
            this.Controls.Add(this.chBox_ReadOnly);
            this.Controls.Add(this.numeric_Size);
            this.Controls.Add(this.gBox_Dock);
            this.Controls.Add(this.cBox_Colours);
            this.Controls.Add(this.gBox_Font);
            this.Controls.Add(this.lbl_textCount);
            this.Controls.Add(this.pnl_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_Text.ResumeLayout(false);
            this.pnl_Text.PerformLayout();
            this.gBox_Font.ResumeLayout(false);
            this.gBox_Font.PerformLayout();
            this.gBox_Dock.ResumeLayout(false);
            this.gBox_Dock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Text;
        private System.Windows.Forms.TextBox tBox_Text;
        private System.Windows.Forms.Label lbl_textCount;
        private System.Windows.Forms.GroupBox gBox_Font;
        private System.Windows.Forms.RadioButton rBtn_ComicSans;
        private System.Windows.Forms.RadioButton rBtn_Arial;
        private System.Windows.Forms.RadioButton rBtn_MSSF;
        private System.Windows.Forms.ComboBox cBox_Colours;
        private System.Windows.Forms.GroupBox gBox_Dock;
        private System.Windows.Forms.RadioButton rButton_None;
        private System.Windows.Forms.RadioButton rButton_Right;
        private System.Windows.Forms.RadioButton rButton_Left;
        private System.Windows.Forms.RadioButton rButton_Down;
        private System.Windows.Forms.RadioButton rButton_Up;
        private System.Windows.Forms.NumericUpDown numeric_Size;
        private System.Windows.Forms.CheckBox chBox_ReadOnly;
        private System.Windows.Forms.CheckBox chBox_Enabled;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btn_progBar;
        private System.Windows.Forms.ListBox lBox01;
        private System.Windows.Forms.Button btn_listBox;
        private System.Windows.Forms.Label lbl_NumOfWords;
        private System.Windows.Forms.Panel panel_Mouse;
        private System.Windows.Forms.Label lbl_MouseMove;
    }
}

