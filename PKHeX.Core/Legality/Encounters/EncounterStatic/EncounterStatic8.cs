﻿using System;
using System.Collections.Generic;

namespace PKHeX.Core
{
    /// <summary>
    /// Generation 8 Static Encounter
    /// </summary>
    /// <inheritdoc cref="EncounterStatic"/>
    public class EncounterStatic8 : EncounterStatic, IDynamaxLevel, IGigantamax, IRelearn
    {
        public sealed override int Generation => 8;
        public bool ScriptedNoMarks { get; set; }
        public bool CanGigantamax { get; set; }
        public byte DynamaxLevel { get; set; }

        protected override bool IsMatchLevel(PKM pkm, DexLevel evo)
        {
            var met = pkm.Met_Level;
            var lvl = Level;
            if (met == lvl)
                return true;
            if (lvl < 60 && EncounterArea8.IsBoostedArea60(Location))
                return met == 60;
            return false;
        }

        public override bool IsMatch(PKM pkm, DexLevel evo)
        {
            if (pkm is IDynamaxLevel d && d.DynamaxLevel < DynamaxLevel)
                return false;
            return base.IsMatch(pkm, evo);
        }

        public IReadOnlyList<int> Relearn { get; internal set; } = Array.Empty<int>();
    }
}
