using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Guild
{
    public partial class Guild
    {
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();

        }
       
        private List<Player> roster;


        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get { return this.roster.Count; }
        }

        public void AddPlayer(Player player)
        {
            if (this.roster.Count + 1 <= Capacity && !this.roster.Contains(player))
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            bool result = false;
            Player foundPlayer = this.roster.FirstOrDefault(x => x.Name == name);

            if (foundPlayer != null)
            {
                this.roster.Remove(foundPlayer);
                return true;
            }

            
            return result;
        }

        public void PromotePlayer(string name)
        {
            Player foundPlayer = this.roster.FirstOrDefault(x => x.Name == name);

            if (foundPlayer.Rank != "Member")
            {
                foundPlayer.Rank = "Member";
            }


        }

        public void DemotePlayer(string name)
        {
            Player foundPlayer = this.roster.FirstOrDefault(x => x.Name == name);

            if (foundPlayer.Rank != "Trial")
            {
                foundPlayer.Rank = "Trial";
            }
        }


        public Player[] KickPlayersByClass(string cl)
        {
            Player[] result = this.roster.Where(x => x.Class == cl).ToArray();
            this.roster.RemoveAll(x => x.Class == cl);
            return result;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }

       
    }
}








