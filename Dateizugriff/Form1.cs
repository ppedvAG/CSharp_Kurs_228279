using Newtonsoft.Json;

namespace Dateizugriff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;

            try
            {
                using (reader = new StreamReader("Textdatei.txt"))
                {
                    string result = reader.ReadToEnd();

                    MessageBox.Show("Laden erfolgreich");

                    Tbx_Main.Text = result;
                }
            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "Testdatei.txt";

            saveDialog.InitialDirectory = "C:\\";
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;

                try
                {
                    writer = new StreamWriter(saveDialog.FileName);

                    writer.WriteLine(Tbx_Main.Text);

                    writer.Write("ENDE DES STRINGS");

                    MessageBox.Show("Speichern erfolgreich");
                }
                catch
                {
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
                finally
                {
                    //if (writer != null)
                    writer?.Close();
                }
            }

        }

        private void Btn_SavePersons_Click(object sender, EventArgs e)
        {
            List<Person> liste = new List<Person>()
            {
                new Person(){Name = "Anna Nass", Alter = 45},
                new Arbeitnehmer(){Name = "Rainer Zufall", Alter= 34, Abteilung="Marketing"}
            };

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("personen.txt");

                for (int i = 0; i < liste.Count; i++)
                {
                    string umgewandeltePerson = JsonConvert.SerializeObject(liste[i], settings);

                    writer.WriteLine(umgewandeltePerson);
                }


                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Speichern fehlgeschlagen");
            }
            finally
            {
                //if (writer != null)
                writer?.Close();
            }
        }

        private void Btn_LoadPersons_Click(object sender, EventArgs e)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            StreamReader reader = null;

            try
            {
                using (reader = new StreamReader("personen.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string personAlsString  = reader.ReadLine();

                        Person person = JsonConvert.DeserializeObject<Person>(personAlsString, settings);

                        MessageBox.Show($"{person.GetType().ToString()}: {person.Name}");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Alter { get; set; }
    }

    public class Arbeitnehmer : Person
    {
        public string Abteilung { get; set; }
    }
}