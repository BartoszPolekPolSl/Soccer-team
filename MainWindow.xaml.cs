using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Xml.Serialization;

namespace Players
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XmlSerializer xml;
        PlayersList playerList = new PlayersList();
        public MainWindow()
        {
            
            InitializeComponent();
            Deserialize();
            lb_players.ItemsSource = playerList.playersList;
            age_array();
            cb_age.ItemsSource = Age;
            if (App.XBtnFlag==false)
            {
                loadStateOfApp();
            }      
        }
        
        public List<int> Age = new List<int>();
        void age_array()
        {

            for (int i = 1; i <= 100; i++)
            {
                Age.Add(i);
            }
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_lName.Text) || string.IsNullOrEmpty(tb_fName.Text) || string.IsNullOrWhiteSpace(tb_lName.Text) || string.IsNullOrWhiteSpace(tb_fName.Text) || string.IsNullOrEmpty(tb_height.Text) || string.IsNullOrWhiteSpace(tb_height.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int height;
                if (int.TryParse(tb_height.Text, out height))
                {
                    Player player = new Player(tb_fName.Text, tb_lName.Text, (int)cb_age.SelectedItem, sd_weight.Value, height);
                    bool ifExist=true;

                    foreach (var p in playerList.playersList)
                    {
                        if (player.Equals(p))
                        {
                            ifExist = false;
                            break;
                        }
                        
                    }
                    if (ifExist==false)
                    {
                        MessageBox.Show("Piłkarz już istnieje!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        playerList.AddPlayer(player);
                    }
                }
                else
                {
                    MessageBox.Show("Podałeś niepoprawny wzrost!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }  
        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {
            if (playerList.playersList.Count == 0)
            {
                MessageBox.Show("Lista jest pusta!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (lb_players.SelectedItem == null)
            {
                MessageBox.Show("Wybierz pozycję, która chcesz usunąć z listy!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (MessageBox.Show("Czy chcesz usunąć wybranego piłkarza?", "Usuwanie piłkarza", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int index = lb_players.SelectedIndex;
                lb_players.SelectedIndex -= 1;
                playerList.RemovePlayer(index);            
            }   
        }

        private void bt_modify_Click(object sender, RoutedEventArgs e)
        {

            int index = lb_players.SelectedIndex;
            if (string.IsNullOrEmpty(tb_lName.Text) || string.IsNullOrEmpty(tb_fName.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (playerList.playersList.Count==0)
                {
                    MessageBox.Show("Lista jest pusta!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if(MessageBox.Show("Czy chcesz zmodyfikować wybranego piłkarza?", "Modyfikowanie piłkarza", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    int height;
                    if (int.TryParse(tb_height.Text, out height))
                    {
                        Player player = new Player(tb_fName.Text, tb_lName.Text, (int)cb_age.SelectedItem, sd_weight.Value, height);
                        bool ifExist = true;

                        foreach (var p in playerList.playersList)
                        {
                            if (player.Equals(p))
                            {
                                ifExist = false;
                                break;
                            }
                        }
                        if (ifExist == false)
                        {
                            MessageBox.Show("Piłkarz już istnieje!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            if (lb_players.SelectedIndex == 0)
                            {
                                lb_players.SelectedIndex += 1;
                                playerList.ModifyPlayer(index, player);
                                lb_players.SelectedIndex -= 1;
                            }
                            else
                            {
                                lb_players.SelectedIndex -= 1;
                                playerList.ModifyPlayer(index, player);
                                lb_players.SelectedIndex += 1;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podałeś niepoprawny wzrost!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void lb_players_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_players.SelectedIndex == -1)
            {
                lb_players.SelectedIndex =0;
            }
            else
            {
                tb_fName.Foreground = Brushes.Black;
                tb_lName.Foreground = Brushes.Black;
                tb_height.Foreground = Brushes.Black;
                Player player = playerList.playersList[lb_players.SelectedIndex];
                tb_fName.Text = player.Fname;
                tb_lName.Text = player.Lname;
                cb_age.SelectedItem = player.Age;
                sd_weight.Value = player.Weight;
                tb_height.Text = player.Height.ToString();
            }
        }

        private void tb_lName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tb_lName.Text=="")
            {
                tb_lName.BorderThickness = new Thickness(5);
                tb_lName.BorderBrush = Brushes.Red;
            }
            else
            {
                var mySolidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFABADB3");
                tb_lName.BorderThickness = new Thickness(1);
                tb_lName.BorderBrush = mySolidColorBrush;
            }
        }

        private void tb_fName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_fName.Text == "")
            {
                tb_fName.BorderThickness = new Thickness(5);
                tb_fName.BorderBrush = Brushes.Red;
            }
            else
            {
                
                var mySolidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFABADB3");
                tb_fName.BorderThickness = new Thickness(1);
                tb_fName.BorderBrush = mySolidColorBrush;
            }
        }
        private void tb_height_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_height.Text == "")
            {
                tb_height.BorderThickness = new Thickness(5);
                tb_height.BorderBrush = Brushes.Red;
            }
            else
            {
                
                var mySolidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFABADB3");
                tb_height.BorderThickness = new Thickness(1);
                tb_height.BorderBrush = mySolidColorBrush;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            xml = new XmlSerializer(typeof(PlayersList));
            TextWriter stream = new StreamWriter("Players.xml");
            xml.Serialize(stream, playerList);
            stream.Close();
        }

        private void Deserialize()
        {
            if (File.Exists("Players.xml"))
            {
                xml = new XmlSerializer(typeof(PlayersList));
                TextReader stream = new StreamReader("Players.xml");
                playerList = (PlayersList)xml.Deserialize(stream);
                stream.Close();
            }

        }

        private void tb_fName_GotFocus(object sender, RoutedEventArgs e)
        {
            if(tb_fName.Text=="Podaj imię")
            {
                tb_fName.Foreground = Brushes.Black;
                tb_fName.Text = "";
            }
        }

        private void tb_lName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tb_lName.Text == "Podaj nazwisko")
            {
                tb_lName.Foreground = Brushes.Black;
                tb_lName.Text = "";
            }
        }

        private void tb_height_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tb_height.Text == "Podaj wzrost")
            {
                tb_height.Foreground = Brushes.Black;
                tb_height.Text = "";
            }
        }

        private void bt_sort_Click(object sender, RoutedEventArgs e)
        {
            playerList.SortList();
            lb_players.ItemsSource = playerList.playersList;


        }

        private void bt_changeLangVersion_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbItem = (ComboBoxItem)cb_ChangeLan.SelectedItem;
            string version = cbItem.Tag.ToString();
            saveStateOfApp();
            App.ChangeCulture(version);

        }
        public void saveStateOfApp()
        {
            var settings = Properties.Settings.Default;
            settings.xWindowPosition = this.Left;
            settings.yWindowPosition = this.Top;
            settings.tbxName = tb_fName.Text;
            settings.tbxSurname = tb_lName.Text;
            settings.cbChangeLanSelectedIndex = cb_ChangeLan.SelectedIndex;
            settings.cbAgeSelectedIndex = cb_age.SelectedIndex;
            settings.sdWeightValue = sd_weight.Value;
            settings.tbxHeight = tb_height.Text;
            settings.Save();
        }
        public void loadStateOfApp()
        {
            var settings = Properties.Settings.Default;
            //cbChangeLan.SelectedIndex = ustawienia.cbChangeLanSelectedIndex;

            //ComboBoxItem cb = (ComboBoxItem)cbChangeLan.Items[1];
            var culture = Thread.CurrentThread.CurrentCulture.Name;
            switch (culture)
            {
                case "pl-PL": cb_ChangeLan.SelectedIndex = 0; break;
                case "en-US": cb_ChangeLan.SelectedIndex = 1; break;
                default: cb_ChangeLan.SelectedIndex = -1; break;
            }
            tb_fName.Text = settings.tbxName;
            tb_lName.Text = settings.tbxSurname;
            tb_height.Text = settings.tbxHeight;
            cb_age.SelectedIndex = settings.cbAgeSelectedIndex;
            sd_weight.Value = settings.sdWeightValue;
            this.Left = settings.xWindowPosition;
            this.Top = settings.yWindowPosition;
            tb_fName.Foreground = Brushes.Black;
            tb_lName.Foreground = Brushes.Black;
            tb_height.Foreground = Brushes.Black;
        }
    }   
}

