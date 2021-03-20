using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
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
            lb_players.ItemsSource = playerList.playersList;
            age_array();
            cb_age.ItemsSource = Age;
            
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
            if (string.IsNullOrEmpty(tb_lName.Text) || string.IsNullOrEmpty(tb_fName.Text) || string.IsNullOrWhiteSpace(tb_lName.Text) || string.IsNullOrWhiteSpace(tb_fName.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                Player player = new Player(tb_fName.Text, tb_lName.Text, (int)cb_age.SelectedItem, sd_weight.Value);
                playerList.AddPlayer(player);
            }  

            
        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {
            if (lb_players.SelectedItem == null)
            {
                MessageBox.Show("Wybierz pozycję, która chcesz usunąć z listy!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
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
                else
                {
                    Player player = new Player(tb_fName.Text, tb_lName.Text, (int)cb_age.SelectedItem, sd_weight.Value);
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


        }

        private void lb_players_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_players.SelectedIndex == -1)
            {
                lb_players.SelectedIndex =0;
            }
            else
            {
                string[] dataPlayer;
                string player = lb_players.Items.GetItemAt(lb_players.SelectedIndex).ToString().Replace(",", "");
                dataPlayer = player.Split(' ');
                tb_fName.Text = dataPlayer[0];
                tb_lName.Text = dataPlayer[1];
                cb_age.SelectedItem = Convert.ToInt32(dataPlayer[3]);
                sd_weight.Value = Convert.ToDouble(dataPlayer[5]) / 10;
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
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFABADB3");
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
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFABADB3");
                tb_fName.BorderThickness = new Thickness(1);
                tb_fName.BorderBrush = mySolidColorBrush;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            xml = new XmlSerializer(typeof(PlayersList));
            TextWriter stream = new StreamWriter("Players.xml");
            xml.Serialize(stream, playerList);
            stream.Close();
        }
    }   
    

}

