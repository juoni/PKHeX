﻿using static PKHeX.Core.LegalityCheckStrings;

namespace PKHeX.Core
{
    /// <summary>
    /// Verifies the <see cref="RibbonIndex"/> values for markings.
    /// </summary>
    public sealed class MarkVerifier : Verifier
    {
        protected override CheckIdentifier Identifier => CheckIdentifier.RibbonMark;

        public override void Verify(LegalityAnalysis data)
        {
            var pkm = data.pkm;
            if (!(pkm is IRibbonIndex m))
                return;

            if (data.Info.Generation != 8)
                VerifyNoMarksPresent(data, m);
            else
                VerifyMarksPresent(data, m);

            VerifyAffixedRibbonMark(data, m);
        }

        private void VerifyNoMarksPresent(LegalityAnalysis data, IRibbonIndex m)
        {
            for (var x = RibbonIndex.MarkLunchtime; x <= RibbonIndex.MarkSlump; x++)
            {
                if (m.GetRibbon((int)x))
                    data.AddLine(GetInvalid(string.Format(LRibbonMarkingFInvalid_0, x)));
            }
        }

        private void VerifyMarksPresent(LegalityAnalysis data, IRibbonIndex m)
        {
            bool hasOne = false;
            for (var mark = RibbonIndex.MarkLunchtime; mark <= RibbonIndex.MarkSlump; mark++)
            {
                bool has = m.GetRibbon((int) mark);
                if (!has)
                    continue;

                if (hasOne)
                {
                    data.AddLine(GetInvalid(string.Format(LRibbonMarkingFInvalid_0, mark)));
                    return;
                }

                bool result = IsMarkValid(mark, data.pkm, data.EncounterMatch);
                if (!result)
                {
                    data.AddLine(GetInvalid(string.Format(LRibbonMarkingFInvalid_0, mark)));
                    return;
                }

                hasOne = true;
            }
        }

        public static bool IsMarkValid(RibbonIndex mark, PKM pk, IEncounterable enc)
        {
            return IsMarkAllowedAny(enc) && IsMarkAllowedSpecific(mark, pk, enc);
        }

        public static bool IsMarkAllowedSpecific(RibbonIndex mark, PKM pk, IEncounterable _)
        {
            return mark switch
            {
                RibbonIndex.MarkCurry when !IsMarkAllowedCurry(pk) => false,
                RibbonIndex.MarkDestiny => false,
                _ => true
            };
        }

        public static bool IsMarkAllowedAny(IEncounterable enc)
        {
            if (enc.Generation != 8)
                return false;

            switch (enc)
            {
                case WC8 _:
                case EncounterEgg _:
                case EncounterTrade _:
                case EncounterStatic8U _:
                case EncounterStatic8N _:
                case EncounterStatic8ND _:
                case EncounterStatic8NC _:
                case EncounterStatic8 s when s.Gift || s.ScriptedNoMarks:
                    return false;
            }

            return true;
        }

        public static bool IsMarkAllowedCurry(ILocation enc, int ball = (int)Ball.Poke) => IsMarkAllowedCurry(enc.Location, ball);
        public static bool IsMarkAllowedCurry(PKM pkm) => IsMarkAllowedCurry(pkm.Met_Location, pkm.Ball);

        public static bool IsMarkAllowedCurry(int met, int ball)
        {
            if (EncounterArea8.IsWildArea(met))
                return false;
            if ((uint) (ball - 2) > 2) // Poke,Great,Ultra only
                return false;
            return true;
        }

        private void VerifyAffixedRibbonMark(LegalityAnalysis data, IRibbonIndex m)
        {
            if (!(m is PK8 pk8))
                return;

            var affix = pk8.AffixedRibbon;
            if (affix == -1) // None
                return;

            if ((byte)affix > (int)RibbonIndex.MarkSlump)
                data.AddLine(GetInvalid(string.Format(LRibbonMarkingAffixedF_0, affix)));
            else if (!pk8.GetRibbonIndex((RibbonIndex)affix))
                data.AddLine(GetInvalid(string.Format(LRibbonMarkingAffixedF_0, (RibbonIndex)affix)));
        }
    }
}
