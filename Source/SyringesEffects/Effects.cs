using System;
using Verse;
using RimWorld;

namespace SyringesEffects
{
	public class CompUseEffect_RefillPsyfocus : CompUseEffect
	{
		public override void DoEffect(Pawn usedBy)
		{
			Pawn_PsychicEntropyTracker psychicEntropy = usedBy.psychicEntropy;
			if (psychicEntropy == null)
			{
				return;
			}
			psychicEntropy.OffsetPsyfocusDirectly(1.0f);
		}
	}
}
