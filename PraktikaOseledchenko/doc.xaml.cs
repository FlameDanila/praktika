using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;
using word = Microsoft.Office.Interop.Word;


namespace PraktikaOseledchenko
{
    /// <summary>
    /// Логика взаимодействия для doc.xaml
    /// </summary>
    public partial class doc : Window
    {
        public doc()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            listViev.ItemsSource = App.db.Films.ToList();
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            List<Films> filmsList = App.db.Films.ToList();

            var names = filmsList.Select(n => n.name).ToList();
            var durations = filmsList.Select(n => n.duration).ToList();
            var cost = filmsList.Select(n => n.cost).ToList();
            var adults = filmsList.Select(n => n.adultOnly).ToList();
            var ids = filmsList.Select(n => n.id).ToList();

            for (int i = 0; i < filmsList.Count; i++)
            {
                Log log = new Log(names[i].ToString(), durations[i].ToString(), cost[i], adults[i], ids[i]);

                XmlSerializer xml = new XmlSerializer(typeof(Log));

                using (FileStream fs = new FileStream("Films.xml", FileMode.OpenOrCreate))
                {
                    xml.Serialize(fs, log);
                }
            }

            var application = new word.Application();
            word.Document document = application.Documents.Add();

            foreach (var i in filmsList)
            {
                word.Paragraph nameParagraph = document.Paragraphs.Add();
                word.Range nameRange = nameParagraph.Range;

                nameRange.Text = i.name + " Стоимость = " + i.cost + " Длительность = " + i.duration;
                nameRange.InsertParagraphAfter();

                nameRange.Text = i.name + " Стоимость = " + i.cost + " Длительность = " + i.duration;
                nameRange.InsertParagraphAfter();

                nameRange.Text = i.name + " Стоимость = " + i.cost + " Длительность = " + i.duration;
                nameRange.InsertParagraphAfter();
            }

            application.Visible = true;

            document.SaveAs2(@"C:/Users/Danila/source/repos/PraktikaOseledchenko/PraktikaOseledchenko/bin/Debug/Films.doc", FileMode.OpenOrCreate);
        }
    }
}
