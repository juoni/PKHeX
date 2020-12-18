﻿namespace PKHeX.Core
{
    // Dynamax Adventures
    internal static partial class Encounters8Nest
    {
        // These are encountered as never-shiny, but forced shiny (Star) if the 1:300 (1:100 w/charm) post-adventure roll activates.
        // The game does try to gate specific entries to Sword / Shield, but this restriction is ignored for online battles.
        // All captures share the same met location, so there is no way to distinguish an online-play result from a local-play result.

        #region Dynamax Adventures Encounters (ROM)
        internal static readonly EncounterStatic8U[] DynAdv_SWSH =
        {
            new EncounterStatic8U(002,0,65) { Ability = A2, Moves = new[] {520,235,076,188} }, // Ivysaur
            new EncounterStatic8U(005,0,65) { Ability = A2, Moves = new[] {519,406,203,517} }, // Charmeleon
            new EncounterStatic8U(008,0,65) { Ability = A2, Moves = new[] {518,058,396,056} }, // Wartortle
            new EncounterStatic8U(012,0,65) { Ability = A2, Moves = new[] {676,474,476,202}, CanGigantamax = true }, // Butterfree
            new EncounterStatic8U(026,0,65) { Ability = A2, Moves = new[] {804,683,113,411} }, // Raichu
            new EncounterStatic8U(026,1,65) { Ability = A0, Moves = new[] {085,604,094,496} }, // Raichu-1
            new EncounterStatic8U(028,0,65) { Ability = A0, Moves = new[] {306,707,444,141} }, // Sandslash
            new EncounterStatic8U(028,1,65) { Ability = A0, Moves = new[] {419,157,280,014} }, // Sandslash-1
            new EncounterStatic8U(031,0,65) { Ability = A0, Moves = new[] {815,474,204,247} }, // Nidoqueen
            new EncounterStatic8U(034,0,65) { Ability = A1, Moves = new[] {667,007,008,009} }, // Nidoking
            new EncounterStatic8U(035,0,65) { Ability = A2, Moves = new[] {791,595,345,115} }, // Clefairy
            new EncounterStatic8U(737,0,65) { Ability = A0, Moves = new[] {081,598,209,091} }, // Charjabug
            new EncounterStatic8U(743,0,65) { Ability = A2, Moves = new[] {676,577,312,313} }, // Ribombee
            new EncounterStatic8U(040,0,65) { Ability = A1, Moves = new[] {605,496,797,186} }, // Wigglytuff
            new EncounterStatic8U(553,0,65) { Ability = A2, Moves = new[] {414,207,663,201} }, // Krookodile
            new EncounterStatic8U(045,0,65) { Ability = A0, Moves = new[] {202,580,092,676} }, // Vileplume
            new EncounterStatic8U(051,0,65) { Ability = A2, Moves = new[] {667,164,189,157} }, // Dugtrio
            new EncounterStatic8U(051,1,65) { Ability = A0, Moves = new[] {442,667,389,103} }, // Dugtrio-1
            new EncounterStatic8U(053,0,65) { Ability = A1, Moves = new[] {263,583,364,496} }, // Persian
            new EncounterStatic8U(053,1,65) { Ability = A0, Moves = new[] {372,555,364,511} }, // Persian-1
            new EncounterStatic8U(055,0,65) { Ability = A2, Moves = new[] {453,103,025,362} }, // Golduck
            new EncounterStatic8U(062,0,65) { Ability = A0, Moves = new[] {409,034,811,710} }, // Poliwrath
            new EncounterStatic8U(064,0,65) { Ability = A2, Moves = new[] {473,496,203,605} }, // Kadabra
            new EncounterStatic8U(067,0,65) { Ability = A1, Moves = new[] {223,317,371,811} }, // Machoke
            new EncounterStatic8U(745,0,65) { Ability = A1, Moves = new[] {709,444,496,336} }, // Lycanroc
            new EncounterStatic8U(745,1,65) { Ability = A2, Moves = new[] {444,280,269,242} }, // Lycanroc-1
            new EncounterStatic8U(082,0,65) { Ability = A2, Moves = new[] {486,430,393,113} }, // Magneton
            new EncounterStatic8U(752,0,65) { Ability = A2, Moves = new[] {710,494,679,398} }, // Araquanid
            new EncounterStatic8U(754,0,65) { Ability = A2, Moves = new[] {437,311,404,496} }, // Lurantis
            new EncounterStatic8U(093,0,65) { Ability = A2, Moves = new[] {506,095,138,412} }, // Haunter
            new EncounterStatic8U(869,0,65) { Ability = A2, Moves = new[] {777,605,595,345}, CanGigantamax = true }, // Alcremie
            new EncounterStatic8U(099,0,65) { Ability = A0, Moves = new[] {152,469,091,276}, CanGigantamax = true }, // Kingler
            new EncounterStatic8U(105,0,65) { Ability = A2, Moves = new[] {155,675,442,103} }, // Marowak
            new EncounterStatic8U(105,1,65) { Ability = A2, Moves = new[] {394,708,261,442} }, // Marowak-1
            new EncounterStatic8U(106,0,65) { Ability = A0, Moves = new[] {370,469,299,490} }, // Hitmonlee
            new EncounterStatic8U(107,0,65) { Ability = A1, Moves = new[] {612,007,009,008} }, // Hitmonchan
            new EncounterStatic8U(108,0,65) { Ability = A1, Moves = new[] {496,059,087,330} }, // Lickitung
            new EncounterStatic8U(110,0,65) { Ability = A1, Moves = new[] {499,257,188,399} }, // Weezing
            new EncounterStatic8U(110,1,65) { Ability = A2, Moves = new[] {790,499,053,269} }, // Weezing-1
            new EncounterStatic8U(112,0,65) { Ability = A1, Moves = new[] {529,479,684,184} }, // Rhydon
            new EncounterStatic8U(113,0,65) { Ability = A2, Moves = new[] {496,505,270,113} }, // Chansey
            new EncounterStatic8U(114,0,65) { Ability = A1, Moves = new[] {438,078,803,034} }, // Tangela
            new EncounterStatic8U(115,0,65) { Ability = A0, Moves = new[] {034,389,091,200} }, // Kangaskhan
            new EncounterStatic8U(117,0,65) { Ability = A1, Moves = new[] {503,406,164,496} }, // Seadra
            new EncounterStatic8U(119,0,65) { Ability = A1, Moves = new[] {127,340,398,529} }, // Seaking
            new EncounterStatic8U(122,0,65) { Ability = A1, Moves = new[] {113,115,270,094} }, // Mr. Mime
            new EncounterStatic8U(122,1,65) { Ability = A2, Moves = new[] {113,115,196,094} }, // Mr. Mime-1
            new EncounterStatic8U(123,0,65) { Ability = A1, Moves = new[] {210,098,372,017} }, // Scyther
            new EncounterStatic8U(124,0,65) { Ability = A2, Moves = new[] {577,142,058,496} }, // Jynx
            new EncounterStatic8U(125,0,65) { Ability = A2, Moves = new[] {804,527,270,496} }, // Electabuzz
            new EncounterStatic8U(126,0,65) { Ability = A2, Moves = new[] {126,807,499,496} }, // Magmar
            new EncounterStatic8U(756,0,65) { Ability = A2, Moves = new[] {668,585,240,311} }, // Shiinotic
            new EncounterStatic8U(128,0,65) { Ability = A1, Moves = new[] {263,667,370,372} }, // Tauros
            new EncounterStatic8U(148,0,65) { Ability = A0, Moves = new[] {059,784,799,087} }, // Dragonair
            new EncounterStatic8U(164,0,65) { Ability = A2, Moves = new[] {497,115,143,095} }, // Noctowl
            new EncounterStatic8U(171,0,65) { Ability = A0, Moves = new[] {352,056,085,109} }, // Lanturn
            new EncounterStatic8U(176,0,65) { Ability = A1, Moves = new[] {791,266,583,595} }, // Togetic
            new EncounterStatic8U(178,0,65) { Ability = A2, Moves = new[] {094,493,403,109} }, // Xatu
            new EncounterStatic8U(182,0,65) { Ability = A2, Moves = new[] {580,202,270,605} }, // Bellossom
            new EncounterStatic8U(184,0,65) { Ability = A2, Moves = new[] {453,583,401,340} }, // Azumarill
            new EncounterStatic8U(185,0,65) { Ability = A0, Moves = new[] {707,444,334,776} }, // Sudowoodo
            new EncounterStatic8U(186,0,65) { Ability = A2, Moves = new[] {710,496,414,270} }, // Politoed
            new EncounterStatic8U(195,0,65) { Ability = A2, Moves = new[] {411,503,092,133} }, // Quagsire
            new EncounterStatic8U(206,0,65) { Ability = A0, Moves = new[] {806,814,247,058} }, // Dunsparce
            new EncounterStatic8U(211,0,65) { Ability = A2, Moves = new[] {014,398,710,798} }, // Qwilfish
            new EncounterStatic8U(758,0,65) { Ability = A0, Moves = new[] {092,053,440,599} }, // Salazzle
            new EncounterStatic8U(215,0,65) { Ability = A1, Moves = new[] {813,808,675,555} }, // Sneasel
            new EncounterStatic8U(221,0,65) { Ability = A2, Moves = new[] {059,317,420,276} }, // Piloswine
            new EncounterStatic8U(760,0,65) { Ability = A1, Moves = new[] {038,608,371,416} }, // Bewear
            new EncounterStatic8U(763,0,65) { Ability = A1, Moves = new[] {312,688,512,207} }, // Tsareena
            new EncounterStatic8U(224,0,65) { Ability = A1, Moves = new[] {806,430,503,491} }, // Octillery
            new EncounterStatic8U(226,0,65) { Ability = A1, Moves = new[] {403,291,469,352} }, // Mantine
            new EncounterStatic8U(227,0,65) { Ability = A2, Moves = new[] {372,211,404,019} }, // Skarmory
            new EncounterStatic8U(237,0,65) { Ability = A0, Moves = new[] {529,813,280,811} }, // Hitmontop
            new EncounterStatic8U(241,0,65) { Ability = A1, Moves = new[] {025,208,086,583} }, // Miltank
            new EncounterStatic8U(764,0,65) { Ability = A1, Moves = new[] {666,577,495,412} }, // Comfey
            new EncounterStatic8U(264,0,65) { Ability = A0, Moves = new[] {163,042,608,421} }, // Linoone
            new EncounterStatic8U(264,1,65) { Ability = A0, Moves = new[] {675,555,269,164} }, // Linoone-1
            new EncounterStatic8U(103,0,65) { Ability = A2, Moves = new[] {427,076,707,805} }, // Exeggutor
            new EncounterStatic8U(405,0,65) { Ability = A2, Moves = new[] {263,113,804,604} }, // Luxray
            new EncounterStatic8U(279,0,65) { Ability = A1, Moves = new[] {814,311,469,098} }, // Pelipper
            new EncounterStatic8U(291,0,65) { Ability = A0, Moves = new[] {210,164,189,806} }, // Ninjask
            new EncounterStatic8U(295,0,65) { Ability = A2, Moves = new[] {805,063,411,059} }, // Exploud
            new EncounterStatic8U(770,0,65) { Ability = A2, Moves = new[] {805,815,659,247} }, // Palossand
            new EncounterStatic8U(771,0,65) { Ability = A0, Moves = new[] {092,269,599,068} }, // Pyukumuku
            new EncounterStatic8U(305,0,65) { Ability = A0, Moves = new[] {798,231,157,319} }, // Lairon
            new EncounterStatic8U(310,0,65) { Ability = A1, Moves = new[] {804,129,315,706} }, // Manectric
            new EncounterStatic8U(315,0,65) { Ability = A1, Moves = new[] {437,326,311,791} }, // Roselia
            new EncounterStatic8U(319,0,65) { Ability = A2, Moves = new[] {453,372,207,799} }, // Sharpedo
            new EncounterStatic8U(320,0,65) { Ability = A0, Moves = new[] {362,798,340,203} }, // Wailmer
            new EncounterStatic8U(324,0,65) { Ability = A1, Moves = new[] {807,517,229,108} }, // Torkoal
            new EncounterStatic8U(862,0,65) { Ability = A0, Moves = new[] {808,085,263,103} }, // Obstagoon
            new EncounterStatic8U(334,0,65) { Ability = A2, Moves = new[] {605,257,538,406} }, // Altaria
            new EncounterStatic8U(844,0,65) { Ability = A0, Moves = new[] {815,799,806,137}, CanGigantamax = true }, // Sandaconda
            new EncounterStatic8U(858,0,65) { Ability = A1, Moves = new[] {797,583,791,219}, CanGigantamax = true }, // Hatterene
            new EncounterStatic8U(340,0,65) { Ability = A2, Moves = new[] {340,562,330,428} }, // Whiscash
            new EncounterStatic8U(342,0,65) { Ability = A2, Moves = new[] {808,263,330,014} }, // Crawdaunt
            new EncounterStatic8U(344,0,65) { Ability = A0, Moves = new[] {433,094,246,063} }, // Claydol
            new EncounterStatic8U(356,0,65) { Ability = A0, Moves = new[] {425,506,356,806} }, // Dusclops
            new EncounterStatic8U(359,0,65) { Ability = A0, Moves = new[] {059,400,163,126} }, // Absol
            new EncounterStatic8U(362,0,65) { Ability = A1, Moves = new[] {798,242,423,313} }, // Glalie
            new EncounterStatic8U(364,0,65) { Ability = A0, Moves = new[] {058,362,291,207} }, // Sealeo
            new EncounterStatic8U(369,0,65) { Ability = A1, Moves = new[] {710,457,175,799} }, // Relicanth
            new EncounterStatic8U(132,0,65) { Ability = A2, Moves = new[] {144,000,000,000} }, // Ditto
            new EncounterStatic8U(375,0,65) { Ability = A0, Moves = new[] {309,009,427,115} }, // Metang
            new EncounterStatic8U(416,0,65) { Ability = A0, Moves = new[] {454,207,814,279} }, // Vespiquen
            new EncounterStatic8U(421,0,65) { Ability = A0, Moves = new[] {076,388,241,311} }, // Cherrim
            new EncounterStatic8U(423,1,65) { Ability = A2, Moves = new[] {034,806,317,127} }, // Gastrodon-1
            new EncounterStatic8U(426,0,65) { Ability = A0, Moves = new[] {261,094,366,085} }, // Drifblim
            new EncounterStatic8U(428,0,65) { Ability = A0, Moves = new[] {409,025,204,340} }, // Lopunny
            new EncounterStatic8U(435,0,65) { Ability = A1, Moves = new[] {808,807,491,389} }, // Skuntank
            new EncounterStatic8U(537,0,65) { Ability = A0, Moves = new[] {497,048,188,103} }, // Seismitoad
            new EncounterStatic8U(452,0,65) { Ability = A0, Moves = new[] {808,404,367,231} }, // Drapion
            new EncounterStatic8U(777,0,65) { Ability = A2, Moves = new[] {609,398,527,442} }, // Togedemaru
            new EncounterStatic8U(460,0,65) { Ability = A2, Moves = new[] {419,694,496,803} }, // Abomasnow
            new EncounterStatic8U(478,0,65) { Ability = A0, Moves = new[] {813,524,694,247} }, // Froslass
            new EncounterStatic8U(479,0,65) { Ability = A0, Moves = new[] {486,261,417,506} }, // Rotom
            new EncounterStatic8U(508,0,65) { Ability = A2, Moves = new[] {416,263,496,608} }, // Stoutland
            new EncounterStatic8U(510,0,65) { Ability = A0, Moves = new[] {372,583,259,103} }, // Liepard
            new EncounterStatic8U(518,0,65) { Ability = A0, Moves = new[] {797,473,281,412} }, // Musharna
            new EncounterStatic8U(521,0,65) { Ability = A0, Moves = new[] {814,269,297,366} }, // Unfezant
            new EncounterStatic8U(528,0,65) { Ability = A2, Moves = new[] {493,683,094,403} }, // Swoobat
            new EncounterStatic8U(531,0,65) { Ability = A0, Moves = new[] {791,577,304,053} }, // Audino
            new EncounterStatic8U(533,0,65) { Ability = A0, Moves = new[] {264,811,280,667} }, // Gurdurr
            new EncounterStatic8U(536,0,65) { Ability = A0, Moves = new[] {497,503,414,340} }, // Palpitoad
            new EncounterStatic8U(778,0,65) { Ability = A0, Moves = new[] {421,163,608,174} }, // Mimikyu
            new EncounterStatic8U(884,0,65) { Ability = A0, Moves = new[] {784,086,442,085}, CanGigantamax = true }, // Duraludon
            new EncounterStatic8U(545,0,65) { Ability = A1, Moves = new[] {798,092,675,224} }, // Scolipede
            new EncounterStatic8U(547,0,65) { Ability = A0, Moves = new[] {542,269,412,583} }, // Whimsicott
            new EncounterStatic8U(549,0,65) { Ability = A1, Moves = new[] {080,483,113,676} }, // Lilligant
            new EncounterStatic8U(550,0,65) { Ability = A1, Moves = new[] {710,291,706,423} }, // Basculin
            new EncounterStatic8U(550,1,65) { Ability = A1, Moves = new[] {503,291,242,164} }, // Basculin-1
            new EncounterStatic8U(828,0,65) { Ability = A1, Moves = new[] {492,555,269,807} }, // Thievul
            new EncounterStatic8U(834,0,65) { Ability = A0, Moves = new[] {534,806,684,157} }, // Drednaw
            new EncounterStatic8U(556,0,65) { Ability = A2, Moves = new[] {437,412,389,367} }, // Maractus
            new EncounterStatic8U(558,0,65) { Ability = A1, Moves = new[] {504,404,317,776} }, // Crustle
            new EncounterStatic8U(830,0,65) { Ability = A2, Moves = new[] {113,311,538,437} }, // Eldegoss
            new EncounterStatic8U(561,0,65) { Ability = A0, Moves = new[] {094,240,403,430} }, // Sigilyph
            new EncounterStatic8U(446,0,65) { Ability = A1, Moves = new[] {009,007,034,441} }, // Munchlax
            new EncounterStatic8U(855,0,65) { Ability = A0, Moves = new[] {312,389,473,202} }, // Polteageist
            new EncounterStatic8U(569,0,65) { Ability = A2, Moves = new[] {441,188,409,599}, CanGigantamax = true }, // Garbodor
            new EncounterStatic8U(573,0,65) { Ability = A1, Moves = new[] {497,541,113,813} }, // Cinccino
            new EncounterStatic8U(836,0,65) { Ability = A0, Moves = new[] {804,242,204,270} }, // Boltund
            new EncounterStatic8U(820,0,65) { Ability = A0, Moves = new[] {360,706,014,034} }, // Greedent
            new EncounterStatic8U(583,0,65) { Ability = A0, Moves = new[] {054,058,059,304} }, // Vanillish
            new EncounterStatic8U(587,0,65) { Ability = A0, Moves = new[] {512,804,203,527} }, // Emolga
            new EncounterStatic8U(589,0,65) { Ability = A1, Moves = new[] {529,534,210,269} }, // Escavalier
            new EncounterStatic8U(591,0,65) { Ability = A0, Moves = new[] {499,476,202,474} }, // Amoonguss
            new EncounterStatic8U(593,0,65) { Ability = A0, Moves = new[] {605,291,433,196} }, // Jellicent
            new EncounterStatic8U(596,0,65) { Ability = A0, Moves = new[] {087,405,486,527} }, // Galvantula
            new EncounterStatic8U(601,0,65) { Ability = A0, Moves = new[] {544,508,416,319} }, // Klinklang
            new EncounterStatic8U(606,0,65) { Ability = A1, Moves = new[] {797,800,399,496} }, // Beheeyem
            new EncounterStatic8U(608,0,65) { Ability = A0, Moves = new[] {807,806,517,433} }, // Lampent
            new EncounterStatic8U(611,0,65) { Ability = A0, Moves = new[] {416,200,784,404} }, // Fraxure
            new EncounterStatic8U(614,0,65) { Ability = A1, Moves = new[] {776,059,524,362} }, // Beartic
            new EncounterStatic8U(615,0,65) { Ability = A0, Moves = new[] {059,058,115,076} }, // Cryogonal
            new EncounterStatic8U(617,0,65) { Ability = A0, Moves = new[] {522,491,240,405} }, // Accelgor
            new EncounterStatic8U(618,0,65) { Ability = A0, Moves = new[] {604,085,414,330} }, // Stunfisk
            new EncounterStatic8U(618,1,65) { Ability = A0, Moves = new[] {319,805,492,414} }, // Stunfisk-1
            new EncounterStatic8U(621,0,65) { Ability = A1, Moves = new[] {808,814,442,091} }, // Druddigon
            new EncounterStatic8U(623,0,65) { Ability = A0, Moves = new[] {264,325,815,219} }, // Golurk
            new EncounterStatic8U(625,0,65) { Ability = A1, Moves = new[] {400,398,427,319} }, // Bisharp
            new EncounterStatic8U(626,0,65) { Ability = A1, Moves = new[] {034,808,684,276} }, // Bouffalant
            new EncounterStatic8U(631,0,65) { Ability = A1, Moves = new[] {680,315,241,076} }, // Heatmor
            new EncounterStatic8U(632,0,65) { Ability = A0, Moves = new[] {422,404,319,232} }, // Durant
            new EncounterStatic8U(832,0,65) { Ability = A0, Moves = new[] {803,025,776,164} }, // Dubwool
            new EncounterStatic8U(660,0,65) { Ability = A2, Moves = new[] {444,707,091,098} }, // Diggersby
            new EncounterStatic8U(663,0,65) { Ability = A2, Moves = new[] {366,542,211,053} }, // Talonflame
            new EncounterStatic8U(675,0,65) { Ability = A0, Moves = new[] {418,359,663,811} }, // Pangoro
            new EncounterStatic8U(039,0,65) { Ability = A2, Moves = new[] {164,113,313,577} }, // Jigglypuff
            new EncounterStatic8U(525,0,65) { Ability = A0, Moves = new[] {444,334,776,707} }, // Boldore
            new EncounterStatic8U(680,0,65) { Ability = A0, Moves = new[] {442,014,533,332} }, // Doublade
            new EncounterStatic8U(687,0,65) { Ability = A0, Moves = new[] {576,797,400,085} }, // Malamar
            new EncounterStatic8U(689,0,65) { Ability = A0, Moves = new[] {534,059,130,398} }, // Barbaracle
            new EncounterStatic8U(695,0,65) { Ability = A0, Moves = new[] {486,097,496,189} }, // Heliolisk
            new EncounterStatic8U(702,0,65) { Ability = A2, Moves = new[] {494,087,605,164} }, // Dedenne
            new EncounterStatic8U(851,0,65) { Ability = A1, Moves = new[] {053,815,474,021}, CanGigantamax = true }, // Centiskorch
            new EncounterStatic8U(707,0,65) { Ability = A0, Moves = new[] {113,578,430,583} }, // Klefki
            new EncounterStatic8U(709,0,65) { Ability = A2, Moves = new[] {532,115,409,433} }, // Trevenant
            new EncounterStatic8U(711,0,65) { Ability = A0, Moves = new[] {595,425,388,184} }, // Gourgeist
            new EncounterStatic8U(847,0,65) { Ability = A0, Moves = new[] {453,799,372,203} }, // Barraskewda
            new EncounterStatic8U(845,0,65) { Ability = A0, Moves = new[] {291,203,133,675} }, // Cramorant
            new EncounterStatic8U(620,0,65) { Ability = A0, Moves = new[] {396,469,317,025} }, // Mienshao
            new EncounterStatic8U(870,0,65) { Ability = A0, Moves = new[] {660,014,684,280} }, // Falinks
            new EncounterStatic8U(701,0,65) { Ability = A0, Moves = new[] {269,398,675,490} }, // Hawlucha
            new EncounterStatic8U(879,0,65) { Ability = A0, Moves = new[] {334,776,430,798} }, // Copperajah
            new EncounterStatic8U(826,0,65) { Ability = A0, Moves = new[] {495,094,060,522}, CanGigantamax = true }, // Orbeetle
            new EncounterStatic8U(838,0,65) { Ability = A2, Moves = new[] {315,083,115,157} }, // Carkol
            new EncounterStatic8U(877,0,65) { Ability = A0, Moves = new[] {783,399,085,423} }, // Morpeko
            new EncounterStatic8U(563,0,65) { Ability = A0, Moves = new[] {247,114,094,472} }, // Cofagrigus
            new EncounterStatic8U(750,0,65) { Ability = A0, Moves = new[] {808,276,328,249} }, // Mudsdale
            new EncounterStatic8U(863,0,65) { Ability = A2, Moves = new[] {232,133,808,087} }, // Perrserker
            new EncounterStatic8U(871,0,65) { Ability = A2, Moves = new[] {056,087,367,599} }, // Pincurchin
            new EncounterStatic8U(873,0,65) { Ability = A2, Moves = new[] {311,366,522,542} }, // Frosmoth
            new EncounterStatic8U(839,0,65) { Ability = A0, Moves = new[] {108,800,053,503}, CanGigantamax = true }, // Coalossal
            new EncounterStatic8U(853,0,65) { Ability = A0, Moves = new[] {576,409,330,411} }, // Grapploct
            new EncounterStatic8U(861,0,65) { Ability = A0, Moves = new[] {612,399,384,590}, CanGigantamax = true }, // Grimmsnarl
            new EncounterStatic8U(886,0,65) { Ability = A0, Moves = new[] {407,372,261,247} }, // Drakloak
            new EncounterStatic8U(036,0,65) { Ability = A1, Moves = new[] {800,605,266,322} }, // Clefable
            new EncounterStatic8U(044,0,65) { Ability = A0, Moves = new[] {474,092,585,078} }, // Gloom
            new EncounterStatic8U(137,0,65) { Ability = A1, Moves = new[] {492,058,085,063} }, // Porygon
            new EncounterStatic8U(600,0,65) { Ability = A1, Moves = new[] {451,804,430,408} }, // Klang
            new EncounterStatic8U(738,0,65) { Ability = A0, Moves = new[] {209,189,398,405} }, // Vikavolt
            new EncounterStatic8U(254,0,65) { Ability = A2, Moves = new[] {520,784,437,404} }, // Sceptile
            new EncounterStatic8U(257,0,65) { Ability = A2, Moves = new[] {519,299,370,811} }, // Blaziken
            new EncounterStatic8U(260,0,65) { Ability = A2, Moves = new[] {518,059,414,133} }, // Swampert
            new EncounterStatic8U(073,0,65) { Ability = A0, Moves = new[] {352,056,398,014} }, // Tentacruel
            new EncounterStatic8U(080,0,65) { Ability = A1, Moves = new[] {797,244,053,473} }, // Slowbro
            new EncounterStatic8U(121,0,65) { Ability = A2, Moves = new[] {408,605,427,196} }, // Starmie
            new EncounterStatic8U(849,0,65) { Ability = A1, Moves = new[] {804,086,304,715}, CanGigantamax = true }, // Toxtricity
            new EncounterStatic8U(134,0,65) { Ability = A0, Moves = new[] {352,204,311,114} }, // Vaporeon
            new EncounterStatic8U(135,0,65) { Ability = A0, Moves = new[] {085,129,247,270} }, // Jolteon
            new EncounterStatic8U(136,0,65) { Ability = A0, Moves = new[] {807,247,608,387} }, // Flareon
            new EncounterStatic8U(199,0,65) { Ability = A1, Moves = new[] {248,417,534,008} }, // Slowking
            new EncounterStatic8U(330,0,65) { Ability = A0, Moves = new[] {211,337,405,189} }, // Flygon
            new EncounterStatic8U(346,0,65) { Ability = A0, Moves = new[] {412,246,380,188} }, // Cradily
            new EncounterStatic8U(348,0,65) { Ability = A0, Moves = new[] {404,479,707,201} }, // Armaldo
            new EncounterStatic8U(437,0,65) { Ability = A0, Moves = new[] {428,319,798,285} }, // Bronzong
            new EncounterStatic8U(697,0,65) { Ability = A0, Moves = new[] {799,350,276,034} }, // Tyrantrum
            new EncounterStatic8U(253,0,65) { Ability = A0, Moves = new[] {520,103,280,203} }, // Grovyle
            new EncounterStatic8U(256,0,65) { Ability = A0, Moves = new[] {519,411,297,490} }, // Combusken
            new EncounterStatic8U(259,0,65) { Ability = A0, Moves = new[] {518,127,091,008} }, // Marshtomp
            new EncounterStatic8U(699,0,65) { Ability = A0, Moves = new[] {034,087,246,086} }, // Aurorus
            new EncounterStatic8U(765,0,65) { Ability = A2, Moves = new[] {689,113,094,473} }, // Oranguru
            new EncounterStatic8U(766,0,65) { Ability = A0, Moves = new[] {280,317,164,512} }, // Passimian
            new EncounterStatic8U(876,0,65) { Ability = A1, Moves = new[] {595,797,347,247} }, // Indeedee
            new EncounterStatic8U(145,0,70) { Ability = A0, Moves = new[] {087,065,413,097} }, // Zapdos
            new EncounterStatic8U(146,0,70) { Ability = A0, Moves = new[] {257,017,043,083} }, // Moltres
            new EncounterStatic8U(144,0,70) { Ability = A0, Moves = new[] {058,573,542,054} }, // Articuno
            new EncounterStatic8U(150,0,70) { Ability = A0, Moves = new[] {094,050,105,059} }, // Mewtwo
            new EncounterStatic8U(245,0,70) { Ability = A0, Moves = new[] {710,326,245,347} }, // Suicune
            new EncounterStatic8U(244,0,70) { Ability = A0, Moves = new[] {053,184,245,242} }, // Entei
            new EncounterStatic8U(243,0,70) { Ability = A0, Moves = new[] {085,336,245,311} }, // Raikou
            new EncounterStatic8U(249,0,70) { Ability = A0, Moves = new[] {406,326,250,246} }, // (SH) Lugia
            new EncounterStatic8U(250,0,70) { Ability = A0, Moves = new[] {394,326,241,246} }, // (SW) Ho-Oh
            new EncounterStatic8U(380,0,70) { Ability = A0, Moves = new[] {513,225,428,057} }, // (SH) Latias
            new EncounterStatic8U(381,0,70) { Ability = A0, Moves = new[] {349,406,428,396} }, // (SW) Latios
            new EncounterStatic8U(383,0,70) { Ability = A0, Moves = new[] {089,184,436,359} }, // (SW) Groudon
            new EncounterStatic8U(382,0,70) { Ability = A0, Moves = new[] {057,034,392,087} }, // (SH) Kyogre
            new EncounterStatic8U(384,0,70) { Ability = A0, Moves = new[] {620,693,245,239} }, // Rayquaza
            new EncounterStatic8U(480,0,70) { Ability = A0, Moves = new[] {094,248,478,247} }, // Uxie
            new EncounterStatic8U(482,0,70) { Ability = A0, Moves = new[] {094,605,417,263} }, // Azelf
            new EncounterStatic8U(481,0,70) { Ability = A0, Moves = new[] {094,204,577,161} }, // Mesprit
            new EncounterStatic8U(483,0,70) { Ability = A0, Moves = new[] {163,246,430,337} }, // (SW) Dialga
            new EncounterStatic8U(484,0,70) { Ability = A0, Moves = new[] {163,057,246,337} }, // (SH) Palkia
            new EncounterStatic8U(487,0,70) { Ability = A0, Moves = new[] {337,184,247,246} }, // Giratina
            new EncounterStatic8U(485,0,70) { Ability = A0, Moves = new[] {319,436,242,442} }, // Heatran
            new EncounterStatic8U(488,0,70) { Ability = A0, Moves = new[] {196,585,427,473} }, // Cresselia
            new EncounterStatic8U(641,0,70) { Ability = A0, Moves = new[] {542,097,196,257} }, // (SW) Tornadus
            new EncounterStatic8U(642,0,70) { Ability = A0, Moves = new[] {087,240,311,482} }, // (SH) Thundurus
            new EncounterStatic8U(645,0,70) { Ability = A0, Moves = new[] {328,157,523,411} }, // Landorus
            new EncounterStatic8U(643,0,70) { Ability = A0, Moves = new[] {568,326,558,406} }, // (SW) Reshiram
            new EncounterStatic8U(644,0,70) { Ability = A0, Moves = new[] {568,163,559,337} }, // (SH) Zekrom
            new EncounterStatic8U(646,0,70) { Ability = A0, Moves = new[] {058,304,247,184} }, // Kyurem
            new EncounterStatic8U(716,0,70) { Ability = A0, Moves = new[] {275,605,585,532} }, // (SW) Xerneas
            new EncounterStatic8U(717,0,70) { Ability = A0, Moves = new[] {269,613,407,389} }, // (SH) Yveltal
            new EncounterStatic8U(718,3,70) { Ability = A0, Moves = new[] {614,616,406,020} }, // Zygarde-3
            new EncounterStatic8U(785,0,70) { Ability = A0, Moves = new[] {085,098,413,269} }, // Tapu Koko
            new EncounterStatic8U(786,0,70) { Ability = A0, Moves = new[] {094,583,478,204} }, // Tapu Lele
            new EncounterStatic8U(787,0,70) { Ability = A0, Moves = new[] {276,224,452,184} }, // Tapu Bulu
            new EncounterStatic8U(788,0,70) { Ability = A0, Moves = new[] {250,352,362,585} }, // Tapu Fini
            new EncounterStatic8U(791,0,70) { Ability = A0, Moves = new[] {428,083,231,568} }, // (SW) Solgaleo
            new EncounterStatic8U(792,0,70) { Ability = A0, Moves = new[] {247,585,277,129} }, // (SH) Lunala
            new EncounterStatic8U(800,0,70) { Ability = A0, Moves = new[] {427,451,408,475} }, // Necrozma
            new EncounterStatic8U(793,0,70) { Ability = A0, Moves = new[] {472,482,693,491} }, // Nihilego
            new EncounterStatic8U(794,0,70) { Ability = A0, Moves = new[] {612,269,141,223} }, // Buzzwole
            new EncounterStatic8U(795,0,70) { Ability = A0, Moves = new[] {136,129,675,679} }, // Pheromosa
            new EncounterStatic8U(796,0,70) { Ability = A0, Moves = new[] {438,435,598,693} }, // Xurkitree
            new EncounterStatic8U(798,0,70) { Ability = A0, Moves = new[] {410,314,348,014} }, // Kartana
            new EncounterStatic8U(797,0,70) { Ability = A0, Moves = new[] {073,479,360,089} }, // Celesteela
            new EncounterStatic8U(799,0,70) { Ability = A0, Moves = new[] {407,707,693,005} }, // Guzzlord
            new EncounterStatic8U(806,0,70) { Ability = A0, Moves = new[] {421,269,126,428} }, // Blacephalon
            new EncounterStatic8U(805,0,70) { Ability = A0, Moves = new[] {157,038,693,475} }, // Stakataka
        };
        #endregion
    }
}
