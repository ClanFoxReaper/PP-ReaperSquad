using PhoenixPoint.Modding;

namespace ReaperSquad
{
	/// <summary>
	/// ModConfig is mod settings that players can change from within the game.
	/// Config is only editable from players in main menu.
	/// Only one config can exist per mod assembly.
	/// Config is serialized on disk as json.
	/// </summary>
	public class ReaperSquadConfig : ModConfig
	{
		/// Only public fields are serialized.
		/// Supported types for in-game UI are:
		[ConfigField(null, "Кількість очок навичок")] public int SkillpointsPerLevel = 20;

        public int MaxStrength = 35;
		public int MaxWill = 20;
		public int MaxSpeed = 20;
		public int Stamina = 40;
		public int PersonalAbilitiesCount = 3;
		[ConfigField(null, "Легка")]public int SoldierSkillPointsPerMissionEasy = 12;
		[ConfigField(null, "Нормально")] public int SoldierSkillPointsPerMissionNormal = 10;
		[ConfigField(null, "Важка")] public int SoldierSkillPointsPerMissionHard = 8;
		[ConfigField(null, "Дуже Важка")] public int SoldierSkillPointsPerMissionVeryHard = 5;
	}
}
