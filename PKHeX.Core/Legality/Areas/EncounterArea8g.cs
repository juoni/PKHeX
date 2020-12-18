﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PKHeX.Core
{
    /// <inheritdoc cref="EncounterArea" />
    /// <summary>
    /// <see cref="GameVersion.GO"/> encounter area for direct-to-HOME transfers.
    /// </summary>
    public sealed class EncounterArea8g : EncounterArea, ISpeciesForm
    {
        /// <summary> Species for the area </summary>
        /// <remarks> Due to how the encounter data is packaged by PKHeX, each species-form is grouped together. </remarks>
        public int Species { get; }
        /// <summary> Form of the Species </summary>
        public int Form { get; }

        private EncounterArea8g(int species, int form) : base(GameVersion.GO)
        {
            Species = species;
            Form = form;
            Location = Locations.GO8;
        }

        internal static EncounterArea8g[] GetArea(byte[][] data)
        {
            var areas = new EncounterArea8g[data.Length];
            for (int i = 0; i < areas.Length; i++)
                areas[i] = GetArea(data[i]);
            return areas;
        }

        private const int entrySize = (2 * sizeof(int)) + 2;

        private static EncounterArea8g GetArea(byte[] data)
        {
            var sf = BitConverter.ToInt16(data, 0);
            int species = sf & 0x7FF;
            int form = sf >> 11;

            var group = GetGroup(species, form);

            var result = new EncounterSlot8GO[(data.Length - 2) / entrySize];
            var area = new EncounterArea8g(species, form) {Slots = result};
            for (int i = 0; i < result.Length; i++)
            {
                var offset = (i * entrySize) + 2;
                result[i] = ReadSlot(data, offset, area, species, form, group);
            }

            return area;
        }

        private static EncounterSlot8GO ReadSlot(byte[] data, int offset, EncounterArea8g area, int species, int form, GameVersion group)
        {
            int start = BitConverter.ToInt32(data, offset);
            int end = BitConverter.ToInt32(data, offset + 4);
            var shiny = (Shiny)data[offset + 8];
            var type = (PogoType)data[offset + 9];
            return new EncounterSlot8GO(area, species, form, start, end, shiny, type, group);
        }

        private static GameVersion GetGroup(int species, int form)
        {
            // Transfer Rules:
            // If it can exist in LGP/E, it uses LGP/E's move data for the initial moves.
            // Else, if it can exist in SW/SH, it uses SW/SH's move data for the initial moves.
            // Else, it must exist in US/UM, thus it uses US/UM's moves.

            var pt8 = PersonalTable.SWSH;
            var ptGG = PersonalTable.GG;

            var pi8 = (PersonalInfoSWSH)pt8[species];
            if (pi8.IsPresentInGame)
            {
                bool lgpe = (species <= 151 || species == 808 || species == 809) && (form == 0 || ptGG[species].HasForm(form));
                return lgpe ? GameVersion.GG : GameVersion.SWSH;
            }
            if (species <= Legal.MaxSpeciesID_7_USUM)
            {
                bool lgpe = species <= 151 && (form == 0 || ptGG[species].HasForm(form));
                return lgpe ? GameVersion.GG : GameVersion.USUM;
            }

            throw new ArgumentOutOfRangeException(nameof(species));
        }

        public override IEnumerable<EncounterSlot> GetMatchingSlots(PKM pkm, IReadOnlyList<EvoCriteria> chain)
        {
            if (pkm.TSV == 0) // HOME doesn't assign TSV=0 to accounts.
                yield break;

            var sf = chain.FirstOrDefault(z => z.Species == Species && (z.Form == Form || FormInfo.IsFormChangeable(Species, Form, z.Form, pkm.Format)));
            if (sf == null)
                yield break;

            var ball = (Ball)pkm.Ball;
            var stamp = EncounterSlotGO.GetTimeStamp(pkm.Met_Year + 2000, pkm.Met_Month, pkm.Met_Day);
            var met = Math.Max(sf.MinLevel, pkm.Met_Level);
            foreach (var s in Slots)
            {
                var slot = (EncounterSlot8GO)s;
                if (!slot.IsLevelWithinRange(met))
                    continue;
                if (!slot.IsBallValid(ball))
                    continue;
                if (!slot.Shiny.IsValid(pkm))
                    continue;
                if (!slot.IsWithinStartEnd(stamp))
                    continue;

                if (IsDeferredSlot(slot, pkm))
                    continue;

                yield return slot;
            }
        }

        private static bool IsDeferredSlot(IEncounterable slot, PKM pk)
        {
            if (slot.Species == (int) Core.Species.Wurmple)
                return !WurmpleUtil.IsWurmpleEvoValid(pk);

            return slot.Species switch
            {
                (int) Core.Species.Yamask when pk.Species != slot.Species && slot.Form == 1 && pk is IFormArgument f => f.FormArgument == 0,
                (int) Core.Species.Milcery when pk.Species != slot.Species && pk is IFormArgument f => f.FormArgument == 0,

                (int) Core.Species.Runerigus when pk is IFormArgument f && f.FormArgument != 0 => true,
                (int) Core.Species.Alcremie when pk is IFormArgument f && f.FormArgument != 0 => true,

                _ => false,
            };
        }
    }
}
