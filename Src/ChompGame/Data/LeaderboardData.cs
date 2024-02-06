using System.Collections.Generic;

namespace GameManager
{
	class LeaderboardData
	{
		public List<LeaderboardItem> Items { get; set; }

		public LeaderboardData()
		{
			Items = new List<LeaderboardItem>();
		}
	}
}
