﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PKHeX.Core
{
    /// <summary>
    /// Event data for Generation 1
    /// </summary>
    /// <inheritdoc cref="EncounterStatic1"/>
    public sealed class EncounterStatic1E : EncounterStatic1, IFixedGBLanguage
    {
        public EncounterGBLanguage Language { get; set; } = EncounterGBLanguage.Japanese;

        /// <summary> Trainer name for the event. </summary>
        public string OT_Name { get; set; } = string.Empty;

        public IReadOnlyList<string> OT_Names { get; set; } = Array.Empty<string>();

        /// <summary> Trainer ID for the event. </summary>
        public int TID { get; set; } = -1;

        public EncounterStatic1E(int species, int level, GameVersion ver) : base(species, level, ver)
        {
        }

        public override bool IsMatch(PKM pkm, DexLevel evo)
        {
            if (!base.IsMatch(pkm, evo))
                return false;

            if (Language != EncounterGBLanguage.Any && pkm.Japanese != (Language == EncounterGBLanguage.Japanese))
                return false;

            // EC/PID check doesn't exist for these, so check Shiny state here.
            if (!IsShinyValid(pkm))
                return false;

            if (TID != -1 && pkm.TID != TID)
                return false;

            if (OT_Name.Length != 0)
            {
                if (pkm.OT_Name != OT_Name)
                    return false;
            }
            else if (OT_Names.Count != 0)
            {
                if (!OT_Names.Contains(pkm.OT_Name))
                    return false;
            }

            return true;
        }

        private bool IsShinyValid(PKM pkm) => Shiny switch
        {
            Shiny.Never => !pkm.IsShiny,
            Shiny.Always => pkm.IsShiny,
            _ => true
        };

        public override bool IsMatchDeferred(PKM pkm)
        {
            if (base.IsMatchDeferred(pkm))
                return true;
            return !ParseSettings.AllowGBCartEra;
        }

        protected override void ApplyDetails(ITrainerInfo sav, EncounterCriteria criteria, PKM pk)
        {
            base.ApplyDetails(sav, criteria, pk);

            if (TID != -1)
                pk.TID = TID;

            if (OT_Name.Length != 0)
                pk.OT_Name = OT_Name;
            else if (OT_Names.Count != 0)
                pk.OT_Name = OT_Names[Util.Rand.Next(OT_Names.Count)];
        }
    }

    public interface IFixedGBLanguage
    {
        EncounterGBLanguage Language { get; }
    }

    /// <summary>
    /// Generations 1 &amp; 2 cannot communicate between Japanese &amp; International versions.
    /// </summary>
    public enum EncounterGBLanguage
    {
        Japanese,
        International,
        Any,
    }
}
