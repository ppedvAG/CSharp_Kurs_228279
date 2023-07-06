namespace WindowsFormsBsp
{
    //Bsp-Enum
    enum TestEnum { Test1, Test2, Test3 }

    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MainWindow : Form
    {
        //Konstruktor f�r das Form (Fenster)
        public MainWindow()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Neuzuweisung einer Property des Buttons
            Btn_KlickMich.BackColor = Color.Aqua;

            //Hinzuf�gen eines weiteren EventHandlers zum Button.Click-Event
            Btn_KlickMich.Click += NochEinEventHandler;

            for (int i = 0; i < Enum.GetValues(typeof(TestEnum)).Length; i++)
            {
                //Bef�llung der ComboBox mit Enum-Elementen
                Cbb_Enum.Items.Add((TestEnum)i);
            }

            //Neuzuweisung einer Property der TextBox
            Tbx_Input.Text = $"Hallo{Environment.NewLine}Moin";
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'KlickMich" reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Neuzuweisung einer Eigenschaft des Buttons
            Btn_KlickMich.Text = "Button wurde geklickt";

            //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.Yellow;

            //Pr�fung, ob in der ComboBox ein Element angew�hlt wurde
            if (Cbx_Haken.Checked)
                //Neuzuweisung einer Eigenschaft des Buttons �ber den sender-Parameter
                (sender as Button).BackColor = Color.LightCoral;

            //Pr�fung, ob in der ListBox ein Element angew�hlt wurde
            if (Lbx_Auswahl.SelectedItem != null)
                //�bertrag des Elements in den Button.Text
                Btn_KlickMich.Text = Lbx_Auswahl.SelectedItem.ToString();

            //Pr�fung, ob in der ComboBox ein Element angew�hlt wurde
            if (Cbb_Enum.SelectedItem != null)
            {
                //�bertrag des Elements in das Label
                TestEnum enumVar = (TestEnum)Cbb_Enum.SelectedItem;
                Lbl_Output.Text = enumVar.ToString();
            }

            //�bertrag des TextBoxTexts in den Titel des Forms
            this.Text = Tbx_Input.Text;
        }

        //Weiterer Event-Handler, der im Konstruktor dem Button.Click-Event zugrordnet wurde (f�rbt Button-Text ein)
        private void NochEinEventHandler(object sender, EventArgs e) => (sender as Button).ForeColor = Color.White;

        private void schlie�enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Pr�fung des geklickten Buttons
            if (MessageBox.Show(
                                "M�chtest du das Fenster wirklich schlie�en?",
                                "Beenden",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            ) == DialogResult.Yes)

                //Schlie�end des Fensters
                this.Close();

            //Schlie�end der Applikation
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form neuesFenster = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            neuesFenster.Text = "Neues Fenster";
            //�ffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void neuesDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form neuesFenster = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            neuesFenster.Text = "Neues Dialog-Fenster";
            (neuesFenster as MainWindow).Btn_Ok.Enabled = true;
            //�ffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und �berpr�fung des zur�ckgegebenen DialogResults (s.u.)
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "Es wurde auf OK geklickt";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults des DialogFensters (wird von ShowDialog zur�ckgegeben)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}