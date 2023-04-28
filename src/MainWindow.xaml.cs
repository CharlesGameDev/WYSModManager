using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WYSModManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int selectedWindow;

        public MainWindow()
        {
            InitializeComponent();
            selectedWindow = 0;
            LoadModsList();
        }

        void LoadModsList()
        {
            List<ModMetadata>? items;
            using (StreamReader r = new StreamReader("modlist.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ModMetadata>>(json);
            }
            if (items == null || items.Count == 0) return;

            ListBoxItem itemTemplate = (ListBoxItem)ModsList.Items[0];
            ModsList.Items.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                ModsList.Items.Add(itemTemplate);
            }
        }

        private void ButtonBrowseMods_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonInstalledMods_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEnabledMods_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
