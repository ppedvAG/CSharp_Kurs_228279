namespace WindowsFormsBsp
{
    partial class MainWindow
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
            Btn_KlickMich = new Button();
            Cbx_Haken = new CheckBox();
            Cbb_Enum = new ComboBox();
            Lbx_Auswahl = new ListBox();
            Lbl_Output = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            Tbx_Input = new TextBox();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            neuesFensterToolStripMenuItem = new ToolStripMenuItem();
            neuesDialogFensterToolStripMenuItem = new ToolStripMenuItem();
            schließenToolStripMenuItem = new ToolStripMenuItem();
            Btn_Ok = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            Btn_KlickMich.BackColor = Color.Violet;
            Btn_KlickMich.Location = new Point(158, 119);
            Btn_KlickMich.Name = "Btn_KlickMich";
            Btn_KlickMich.Size = new Size(259, 118);
            Btn_KlickMich.TabIndex = 0;
            Btn_KlickMich.Text = "Klick Mich";
            Btn_KlickMich.UseVisualStyleBackColor = false;
            Btn_KlickMich.Click += Btn_KlickMich_Click;
            // 
            // Cbx_Haken
            // 
            Cbx_Haken.AutoSize = true;
            Cbx_Haken.Location = new Point(748, 195);
            Cbx_Haken.Name = "Cbx_Haken";
            Cbx_Haken.Size = new Size(150, 36);
            Cbx_Haken.TabIndex = 1;
            Cbx_Haken.Text = "Ist Richtig";
            Cbx_Haken.UseVisualStyleBackColor = true;
            // 
            // Cbb_Enum
            // 
            Cbb_Enum.FormattingEnabled = true;
            Cbb_Enum.Location = new Point(609, 378);
            Cbb_Enum.Name = "Cbb_Enum";
            Cbb_Enum.Size = new Size(242, 40);
            Cbb_Enum.TabIndex = 2;
            // 
            // Lbx_Auswahl
            // 
            Lbx_Auswahl.FormattingEnabled = true;
            Lbx_Auswahl.ItemHeight = 32;
            Lbx_Auswahl.Items.AddRange(new object[] { "Item1", "Item2", "Item3" });
            Lbx_Auswahl.Location = new Point(298, 391);
            Lbx_Auswahl.Name = "Lbx_Auswahl";
            Lbx_Auswahl.Size = new Size(240, 164);
            Lbx_Auswahl.TabIndex = 3;
            // 
            // Lbl_Output
            // 
            Lbl_Output.AutoSize = true;
            Lbl_Output.Location = new Point(716, 560);
            Lbl_Output.Name = "Lbl_Output";
            Lbl_Output.Size = new Size(364, 32);
            Lbl_Output.TabIndex = 4;
            Lbl_Output.Text = "Dies ist ein String in einem Label";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(150, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(184, 36);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(150, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(184, 36);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(150, 140);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(184, 36);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(884, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 200);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(1043, 116);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(184, 36);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Visible = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(1041, 164);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(184, 36);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Tbx_Input
            // 
            Tbx_Input.AcceptsReturn = true;
            Tbx_Input.AcceptsTab = true;
            Tbx_Input.Location = new Point(491, 50);
            Tbx_Input.Multiline = true;
            Tbx_Input.Name = "Tbx_Input";
            Tbx_Input.Size = new Size(200, 181);
            Tbx_Input.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1360, 40);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öffnenToolStripMenuItem, schließenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(90, 36);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuesFensterToolStripMenuItem, neuesDialogFensterToolStripMenuItem });
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            öffnenToolStripMenuItem.Size = new Size(250, 44);
            öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // neuesFensterToolStripMenuItem
            // 
            neuesFensterToolStripMenuItem.Name = "neuesFensterToolStripMenuItem";
            neuesFensterToolStripMenuItem.Size = new Size(379, 44);
            neuesFensterToolStripMenuItem.Text = "Neues Fenster";
            neuesFensterToolStripMenuItem.Click += neuesFensterToolStripMenuItem_Click;
            // 
            // neuesDialogFensterToolStripMenuItem
            // 
            neuesDialogFensterToolStripMenuItem.Name = "neuesDialogFensterToolStripMenuItem";
            neuesDialogFensterToolStripMenuItem.Size = new Size(379, 44);
            neuesDialogFensterToolStripMenuItem.Text = "Neues Dialog-Fenster";
            neuesDialogFensterToolStripMenuItem.Click += neuesDialogFensterToolStripMenuItem_Click;
            // 
            // schließenToolStripMenuItem
            // 
            schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            schließenToolStripMenuItem.Size = new Size(250, 44);
            schließenToolStripMenuItem.Text = "Schließen";
            schließenToolStripMenuItem.Click += schließenToolStripMenuItem_Click;
            // 
            // Btn_Ok
            // 
            Btn_Ok.Enabled = false;
            Btn_Ok.Location = new Point(238, 638);
            Btn_Ok.Name = "Btn_Ok";
            Btn_Ok.Size = new Size(150, 46);
            Btn_Ok.TabIndex = 13;
            Btn_Ok.Text = "OK";
            Btn_Ok.UseVisualStyleBackColor = true;
            Btn_Ok.Click += Btn_Ok_Click;
            // 
            // MainWindow
            // 
            AcceptButton = Btn_KlickMich;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 739);
            Controls.Add(Btn_Ok);
            Controls.Add(Tbx_Input);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(groupBox1);
            Controls.Add(Lbl_Output);
            Controls.Add(Lbx_Auswahl);
            Controls.Add(Cbb_Enum);
            Controls.Add(Cbx_Haken);
            Controls.Add(Btn_KlickMich);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Mein tolles Fenster";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_KlickMich;
        private CheckBox Cbx_Haken;
        private ComboBox Cbb_Enum;
        private ListBox Lbx_Auswahl;
        private Label Lbl_Output;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private TextBox Tbx_Input;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripMenuItem neuesFensterToolStripMenuItem;
        private ToolStripMenuItem neuesDialogFensterToolStripMenuItem;
        private ToolStripMenuItem schließenToolStripMenuItem;
        private Button Btn_Ok;
    }
}