using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace Players
{
    [XmlRoot("ListOfPlayers")]
    public class PlayersList
    {
        [XmlArray("Players")]

        [XmlArrayItem("Player",typeof( Player))]
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
        public void SortList()
        {
            playersList= new ObservableCollection<Player>(playersList.OrderBy(x => x.Fname).ToList());
            
        }

    }
}
