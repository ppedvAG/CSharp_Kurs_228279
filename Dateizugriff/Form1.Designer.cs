namespace Dateizugriff
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
            Tbx_Main = new TextBox();
            Btn_Save = new Button();
            Btn_Load = new Button();
            Btn_SavePersons = new Button();
            Btn_LoadPersons = new Button();
            SuspendLayout();
            // 
            // Tbx_Main
            // 
            Tbx_Main.AcceptsReturn = true;
            Tbx_Main.Location = new Point(62, 56);
            Tbx_Main.Multiline = true;
            Tbx_Main.Name = "Tbx_Main";
            Tbx_Main.Size = new Size(244, 278);
            Tbx_Main.TabIndex = 0;
            // 
            // Btn_Save
            // 
            Btn_Save.Location = new Point(401, 64);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(194, 46);
            Btn_Save.TabIndex = 1;
            Btn_Save.Text = "Speichern";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Load
            // 
            Btn_Load.Location = new Point(401, 116);
            Btn_Load.Name = "Btn_Load";
            Btn_Load.Size = new Size(194, 46);
            Btn_Load.TabIndex = 2;
            Btn_Load.Text = "Laden";
            Btn_Load.UseVisualStyleBackColor = true;
            Btn_Load.Click += Btn_Load_Click;
            // 
            // Btn_SavePersons
            // 
            Btn_SavePersons.Location = new Point(418, 226);
            Btn_SavePersons.Name = "Btn_SavePersons";
            Btn_SavePersons.Size = new Size(242, 46);
            Btn_SavePersons.TabIndex = 3;
            Btn_SavePersons.Text = "Speichere Personen";
            Btn_SavePersons.UseVisualStyleBackColor = true;
            Btn_SavePersons.Click += Btn_SavePersons_Click;
            // 
            // Btn_LoadPersons
            // 
            Btn_LoadPersons.Location = new Point(418, 278);
            Btn_LoadPersons.Name = "Btn_LoadPersons";
            Btn_LoadPersons.Size = new Size(242, 46);
            Btn_LoadPersons.TabIndex = 4;
            Btn_LoadPersons.Text = "Lade Personen";
            Btn_LoadPersons.UseVisualStyleBackColor = true;
            Btn_LoadPersons.Click += Btn_LoadPersons_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_LoadPersons);
            Controls.Add(Btn_SavePersons);
            Controls.Add(Btn_Load);
            Controls.Add(Btn_Save);
            Controls.Add(Tbx_Main);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tbx_Main;
        private Button Btn_Save;
        private Button Btn_Load;
        private Button Btn_SavePersons;
        private Button Btn_LoadPersons;
    }
}