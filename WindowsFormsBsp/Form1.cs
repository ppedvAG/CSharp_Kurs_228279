namespace WindowsFormsBsp
{
    enum TestEnum { Test1, Test2, Test3 }

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Btn_KlickMich.BackColor = Color.Aqua;

            Btn_KlickMich.Click += NochEinEventHandler;

            for (int i = 0; i < Enum.GetValues(typeof(TestEnum)).Length; i++)
            {
                Cbb_Enum.Items.Add((TestEnum)i);
            }

            Tbx_Input.Text = $"Hallo{Environment.NewLine}Moin";
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            Btn_KlickMich.Text = "Button wurde geklickt";
            this.BackColor = Color.Yellow;

            if (Cbx_Haken.Checked)
                (sender as Button).BackColor = Color.LightCoral;

            if (Lbx_Auswahl.SelectedItem != null)
                Btn_KlickMich.Text = Lbx_Auswahl.SelectedItem.ToString();

            if (Cbb_Enum.SelectedItem != null)
            {
                TestEnum enumVar = (TestEnum)Cbb_Enum.SelectedItem;
                Lbl_Output.Text = enumVar.ToString();
            }

            this.Text = Tbx_Input.Text;
        }

        private void NochEinEventHandler(object sender, EventArgs e) => (sender as Button).ForeColor = Color.White;

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                                "Möchtest du das Fenster wirklich schließen?",
                                "Beenden",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            ) == DialogResult.Yes)

                this.Close();

            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form neuesFenster = new MainWindow();

            neuesFenster.Text = "Neues Fenster";

            neuesFenster.Show();
        }

        private void neuesDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form neuesFenster = new MainWindow();

            neuesFenster.Text = "Neues Dialog-Fenster";
            (neuesFenster as MainWindow).Btn_Ok.Enabled = true;

            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "Es wurde auf OK geklickt";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}