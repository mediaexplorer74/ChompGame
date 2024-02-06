using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;

namespace GameManager
{
	public static class AudioManager
	{
		public enum Cue
		{
			MenuUpDown,
			MenuSelect,
			Start,

			MonsterWalk,
			MonsterEat,

			TitleScreenMusic,
			GetReadyMusic,
			GameplayMusic,
			PlayerEaten,
			LevelCompleted,
			GameOver,
		};

		public static Dictionary<Cue,SoundEffect> SoundEffects;
		public static Dictionary<Cue,SoundEffectInstance> SoundEffectInstances;

		static AudioManager()
		{
			SoundEffects = new Dictionary<Cue,SoundEffect>
			{
				{ Cue.Start,        Game1.Instance.Content.Load<SoundEffect>("sfx\\StartButton") },
				{ Cue.MenuSelect,	Game1.Instance.Content.Load<SoundEffect>("sfx\\MenuSelect")  },
				{ Cue.MenuUpDown,	Game1.Instance.Content.Load<SoundEffect>("sfx\\MenuUpDown")  },

				{ Cue.MonsterWalk,	Game1.Instance.Content.Load<SoundEffect>("sfx\\MonsterWalk") },
				{ Cue.MonsterEat,	Game1.Instance.Content.Load<SoundEffect>("sfx\\MonsterEat") },
				{ Cue.PlayerEaten,  Game1.Instance.Content.Load<SoundEffect>("sfx\\PlayerEaten") },

				{ Cue.TitleScreenMusic, Game1.Instance.Content.Load<SoundEffect>("sfx\\music\\TitleScreen") },
				{ Cue.GetReadyMusic,	Game1.Instance.Content.Load<SoundEffect>("sfx\\music\\GetReady")    },
				{ Cue.GameplayMusic,    Game1.Instance.Content.Load<SoundEffect>("sfx\\music\\Gameplay")    },
				{ Cue.LevelCompleted,   Game1.Instance.Content.Load<SoundEffect>("sfx\\music\\LevelComplete")},
				{ Cue.GameOver,         Game1.Instance.Content.Load<SoundEffect>("sfx\\music\\GameOver")    },
			};

			SoundEffectInstances = new Dictionary<Cue,SoundEffectInstance>
			{
				{ Cue.TitleScreenMusic, SoundEffects[Cue.TitleScreenMusic].CreateInstance() },
				{ Cue.GetReadyMusic, SoundEffects[Cue.GetReadyMusic].CreateInstance() },
				{ Cue.GameplayMusic, SoundEffects[Cue.GameplayMusic].CreateInstance() },
				{ Cue.PlayerEaten, SoundEffects[Cue.PlayerEaten].CreateInstance() },
				{ Cue.LevelCompleted, SoundEffects[Cue.LevelCompleted].CreateInstance() },
				{ Cue.GameOver, SoundEffects[Cue.GameOver].CreateInstance() },
				{ Cue.Start, SoundEffects[Cue.Start].CreateInstance() },
			};
		}

		public static void PauseAll()
		{
			foreach(var item in SoundEffectInstances)
			{
				if(item.Value.State == SoundState.Playing)
					item.Value.Pause();
			}
		}

		public static void ResumeAll()
		{
			foreach(var item in SoundEffectInstances)
			{
				if(item.Value.State == SoundState.Paused)
					item.Value.Resume();
			}
		}

		public static void StopAll()
		{
			foreach(var item in SoundEffectInstances)
				item.Value.Stop();
		}
	}
}
