using System.Collections.ObjectModel;

namespace Players
{
    class PlayersList
    {
        public ObservableCollection<Player> playersList;
        public PlayersList()
        {
            playersList = new ObservableCollection<Player>();
        }
        public void AddPlayer(Player player)
        {
            playersList.Add(player);
        }
        public void RemovePlayer(int index)
        {
            playersList.RemoveAt(index);
        }
        public void ModifyPlayer(int index, Player player)
        {
            RemovePlayer(index);
            playersList.Insert(index, player);

        }

    }
}
