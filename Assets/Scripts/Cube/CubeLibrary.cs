using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CubeLibrary
{
    public static Dictionary<int, CubeData> Lib;

    /*
    public static void Init()
    {
        Lib = new Dictionary<int, CubeData>();
        int id = 0;

        Lib.Add(id, new CubeData(

        "Peasant Militia",          E.RACE.HUMAN,       E.RARY.WOOD,    new E.A[]{  E.A.MELEE1,         E.A.MELEE1,         E.A.MELEE1,         E.A.MELEE1                                              })); id++; Lib.Add(id, new CubeData(
        "Iron Orc",                 E.RACE.GREENSKIN,   E.RARY.IRON,    new E.A[]{  E.A.DESTROY,        E.A.MELEE3,         E.A.MELEE2,         E.A.GUARD,      E.A.LEAD,       E.A.FLY                 })); id++; Lib.Add(id, new CubeData(
        "Silver Elf",               E.RACE.ELF,         E.RARY.SILVER,  new E.A[]{  E.A.INCUBATE,       E.A.PURIFY,         E.A.EMPTY,                                                                  })); id++; Lib.Add(id, new CubeData(
        "Silver Demon",             E.RACE.DEMON,       E.RARY.SILVER,  new E.A[]{  E.A.DESTROY,        E.A.MELEE3,         E.A.MELEE2,         E.A.FEAR,       E.A.LEAD,       E.A.FLY                 })); id++; Lib.Add(id, new CubeData(
        "Golden Bear",              E.RACE.ANIMAL,      E.RARY.GOLD,    new E.A[]{  E.A.DESTROY,        E.A.MELEE3,         E.A.MELEE2,         E.A.FEAR,       E.A.LEAD,       E.A.FLY                 })); id++; Lib.Add(id, new CubeData(
        "Blackdragon of Death",     E.RACE.DRAGON,      E.RARY.GOLD,    new E.A[]{  E.A.DESTROY_G,      E.A.MELEE2_G,       E.A.MELEE2_G,       E.A.FLY_G,      E.A.SLEEP_G,    E.A.SLEEP               }
        
        ));


        AbilitySorter abilitySorter = new AbilitySorter();
        foreach (KeyValuePair<int, CubeData> cube in Lib)
        {
            abilitySorter.SortAbilities(cube.Value.Abilities);
        }
    }
    */




    #region Alter Stuff
    /*
    public static List<Würfel> AlleWürfel = new List<Würfel>();



    public static void ErstelleAlleWürfel()
    {
        Würfel würfel; würfel = new Würfel(

        "Bauernheer", Tribe.Mensch, K.Billig, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Packesel", Tribe.Tier, K.Billig, S.Stationieren, S.Stationieren, S.Stationieren, S.LEER, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(

        "Bogenschützen", Tribe.Mensch, K.Wenig, S.Formation, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Flaggenträger", Tribe.Mensch, K.Wenig, S.Formation, S.Stationieren, S.Banner, S.Banner, S.Banner, S.Banner);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Speerträger", Tribe.Mensch, K.Wenig, S.Banner, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Schutz, S.Formation);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwertkämpfer", Tribe.Mensch, K.Wenig, S.Formation, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Schutz, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Späher", Tribe.Mensch, K.Wenig, S.Umschwärmen, S.Aufklären, S.Aufklären, S.Aufklären, S.Verbergen, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Mönch", Tribe.Mensch, K.Wenig, S.Wiederbeleben, S.Heilen, S.Heilen, S.Heilen, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Wachhunde", Tribe.Tier, K.Wenig, S.RudelInstinkt, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(

        "Meuchelmörder", Tribe.Mensch, K.Mittel, S.BVernichten, S.BVernichten, S.Verbergen, S.Verbergen, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(

        "Der König", Tribe.Mensch, K.Hoch, S.Stationieren, S.Stationieren, S.Stationieren, S.Anführen, S.Anführen, S.Anführen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Kavallerie", Tribe.Mensch, K.Hoch, S.Formation, S.Aufklären, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Vernichten); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Hauptmann", Tribe.Mensch, K.Hoch, S.Formation, S.Anführen, S.Anführen, S.Stationieren, S.Aufklären, S.Banner); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Königswache", Tribe.Mensch, K.Hoch, S.Formation, S.Vernichten, S.Vernichten, S.Schutz, S.Banner, S.Schutz);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Ritter", Tribe.Mensch, K.Hoch, S.Formation, S.Banner, S.BUmschwärmen, S.Anführen, S.Schutz, S.BVernichten);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "General", Tribe.Mensch, K.Hoch, S.Formation, S.Banner, S.Vernichten, S.Anführen, S.Anführen, S.BVernichten);  AlleWürfel.Add(würfel); würfel = new Würfel(



        "Bogenschützinnen", Tribe.Elf, K.Billig, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Dryade", Tribe.Elf, K.Wenig, S.ÜMoment, S.Umschwärmen, S.Aufklären, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Kommandantin", Tribe.Elf, K.Wenig, S.ÜMoment, S.Stationieren, S.Stationieren, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Falke", Tribe.Tier, K.Wenig, S.Fliegen, S.Aufklären, S.Aufklären, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Einhorn", Tribe.Tier, K.Wenig, S.Wiederbeleben, S.Heilen, S.Verbergen, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Glevenkrieger", Tribe.Elf, K.Mittel, S.ÜMoment, S.Vernichten, S.Vernichten, S.Schutz, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Sucherinnen", Tribe.Elf, K.Mittel, S.ÜMoment, S.Aufklären, S.Aufklären, S.Aufklären, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Waldläufer", Tribe.Elf, K.Mittel, S.ÜMoment, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Verbergen, S.Verbergen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Heilerin", Tribe.Elf, K.Mittel, S.Heilen, S.Heilen, S.Heilen, S.Heilen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Zauberin", Tribe.Elf, K.Mittel, S.BVernichten, S.BVernichten, S.Heilen, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Fürstin", Tribe.Elf, K.Mittel, S.Stationieren, S.Stationieren, S.Stationieren, S.Stationieren, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Greif", Tribe.Tier, K.Mittel, S.Fliegen, S.Fliegen, S.Vernichten, S.Schutz, S.Aufklären, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Druidin", Tribe.Elf, K.Hoch, S.RudelInstinkt, S.Vernichten, S.Heilen, S.Schutz, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schattentiger", Tribe.Tier, K.Hoch, S.RudelInstinkt, S.BVernichten, S.Vernichten, S.Umschwärmen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Schattenklingen", Tribe.Elf, K.Teuer, S.ÜMoment, S.BVernichten, S.Vernichten, S.Verbergen, S.Verbergen, S.Verbergen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Hohepriesterin", Tribe.Elf, K.Teuer, S.Wiederbeleben, S.Heilen, S.Stationieren, S.Verbergen, S.Verbergen, S.Verbergen); AlleWürfel.Add(würfel); würfel = new Würfel(



        "Goblin-Horde", Tribe.Grünhaut, K.Billig, S.BUmschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Giftspuck-Goblins", Tribe.Grünhaut, K.Billig, S.BUmschwärmen, S.BUmschwärmen, S.BUmschwärmen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Sklavenabschaum", Tribe.Grünhaut, K.Billig, S.Umschwärmen, S.Umschwärmen, S.Stationieren, S.Stationieren, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Vorstürmer", Tribe.Grünhaut, K.Wenig, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Armbrüste", Tribe.Grünhaut, K.Wenig, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Brüllende Äxte", Tribe.Grünhaut, K.Wenig, S.Exempel, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Drill-Mentor", Tribe.Grünhaut, K.Wenig, S.Exempel, S.Exempel, S.Anführen, S.Anführen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Schattengoblins", Tribe.Grünhaut, K.Mittel, S.BVernichten, S.Vernichten, S.Umschwärmen, S.Verbergen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Wildäxte", Tribe.Grünhaut, K.Mittel, S.Exempel, S.Vernichten, S.Vernichten, S.Vernichten, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Berserker", Tribe.Grünhaut, K.Mittel, S.Exempel, S.BVernichten, S.BVernichten, S.Angst, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Warg-Rudel", Tribe.Tier, K.Mittel, S.RudelInstinkt, S.Vernichten, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Angst); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Schlacht-Vorsteher", Tribe.Grünhaut, K.Hoch, S.Exempel, S.Exempel, S.Anführen, S.Anführen, S.Stationieren, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Riesenork", Tribe.Grünhaut, K.Hoch, S.BVernichten, S.BVernichten, S.Vernichten, S.Angst, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwarzorks", Tribe.Grünhaut, K.Hoch, S.Exempel, S.BVernichten, S.Vernichten, S.Vernichten, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schamane", Tribe.Grünhaut, K.Hoch, S.Exempel, S.BVernichten, S.Anführen, S.Angst, S.Angst, S.Angst); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Häuptling", Tribe.Grünhaut, K.Hoch, S.Exempel, S.Vernichten, S.Anführen, S.Anführen, S.Stationieren, S.Stationieren); AlleWürfel.Add(würfel); würfel = new Würfel(







        "Grüne Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Fliegen, S.Fliegen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Goldene Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Fliegen, S.Schutz, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Blaue Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Fliegen, S.Heilen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Rote Drachlinge", Tribe.Drache, K.Wenig, S.FeuerSpeien, S.Fliegen, S.LEER, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwarze Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Vernichten, S.Angst, S.Angst, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Matriarchin", Tribe.Drache, K.Mittel, S.FeuerSpeien, S.Schwingenflug, S.Stationieren, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Jungdrachen", Tribe.Drache, K.Hoch, S.FeuerSpeien, S.Schwingenflug, S.Fliegen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Augendrache", Tribe.Drache, K.Hoch, S.FeuerSpeien, S.Fliegen, S.Aufklären, S.Aufklären, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Brutmutter", Tribe.Drache, K.Hoch, S.FeuerSpeien, S.Schwingenflug, S.Stationieren, S.Stationieren, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Höllendämon", Tribe.Dämon, K.Hoch, S.FeuerSpeien, S.FeuerSpeien, S.Angst, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Feuerwaran", Tribe.Tier, K.Hoch, S.FeuerSpeien, S.FeuerSpeien, S.Schutz, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Grüner Walddrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.Schwingenflug, S.Vernichten, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Goldener Wüstendrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.BVernichten, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Blauer Meeresdrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.Wiederbeleben, S.Heilen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Roter Vulkandrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.FeuerSpeien, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwarzer Todesdrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Vernichten, S.Schutz, S.Angst, S.Angst, S.Schwingenflug); AlleWürfel.Add(würfel); würfel = new Würfel(




        "Buddler", Tribe.Zwerg, K.Billig, S.Tunnel, S.Tunnel, S.Umschwärmen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Fledermaus-Schwarm", Tribe.Tier, K.Billig, S.Tunnel, S.Fliegen, S.Fliegen, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Ingenieur", Tribe.Zwerg, K.Wenig, S.Tunnel, S.Stationieren, S.Stationieren, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Braumeister", Tribe.Zwerg, K.Wenig, S.Tunnel, S.Anführen, S.Anführen, S.Anführen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Ahnenhüter", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Wiederbeleben, S.Wiederbeleben, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schildträger", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Umschwärmen, S.Schutz, S.Schutz, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Kumpel-Bande", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Tunnel, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Initiator", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Anführen, S.Anführen, S.Stationieren, S.Stationieren, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Büchsen-Schützen", Tribe.Zwerg, K.Mittel, S.Tunnel, S.BVernichten, S.Vernichten, S.Aufklären, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Runenschnitzer", Tribe.Zwerg, K.Hoch, S.Tunnel, S.Vernichten, S.Wiederbeleben, S.Heilen, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Champion", Tribe.Zwerg, K.Hoch, S.Tunnel, S.BVernichten, S.Vernichten, S.Schutz, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Höhlenbär", Tribe.Tier, K.Hoch, S.Tunnel, S.Vernichten, S.Vernichten, S.Vernichten, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Höhlentroll", Tribe.Troll, K.Hoch, S.Tunnel, S.Steinhaut, S.BVernichten, S.Vernichten, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Ober-Boss", Tribe.Zwerg, K.Teuer, S.BVernichten, S.BVernichten, S.Stationieren, S.Stationieren, S.Anführen, S.Anführen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Paladin", Tribe.Zwerg, K.Teuer, S.Tunnel, S.Vernichten, S.Vernichten, S.Heilen, S.Schutz, S.Schutz); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Minenmeister", Tribe.Zwerg, K.Teuer, S.Tunnel, S.Stationieren, S.Vernichten, S.Schutz, S.Stationieren, S.Tunnel); AlleWürfel.Add(würfel); würfel = new Würfel(





"", Tribe.Tier, K.Billig, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "", Tribe.Tier, K.Billig, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER);  AlleWürfel.Add(würfel);





        
    }
    
    
    
    
    public static void ErstelleAlleWürfelFürTabelle()
    {
        Würfel würfel; würfel = new Würfel(

        "Bauernheer", Tribe.Mensch, K.Billig, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Packesel", Tribe.Tier, K.Billig, S.Stationieren, S.Stationieren, S.Stationieren, S.LEER, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(

        "Bogenschützen", Tribe.Mensch, K.Wenig, S.Formation, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Flaggenträger", Tribe.Mensch, K.Wenig, S.Formation, S.Stationieren, S.Banner, S.Banner, S.Banner, S.Banner);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Speerträger", Tribe.Mensch, K.Wenig, S.Formation, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Schutz, S.Banner);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwertkämpfer", Tribe.Mensch, K.Wenig, S.Formation, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Schutz, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Späher", Tribe.Mensch, K.Wenig, S.Umschwärmen, S.Aufklären, S.Aufklären, S.Aufklären, S.Verbergen, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Mönch", Tribe.Mensch, K.Wenig, S.Wiederbeleben, S.Heilen, S.Heilen, S.Heilen, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Wachhunde", Tribe.Tier, K.Wenig, S.RudelInstinkt, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(

        "Meuchelmörder", Tribe.Mensch, K.Mittel, S.BVernichten, S.BVernichten, S.Verbergen, S.Verbergen, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(

        "Der König", Tribe.Mensch, K.Hoch, S.Anführen, S.Anführen, S.Anführen, S.Stationieren, S.Stationieren, S.Stationieren); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Kavallerie", Tribe.Mensch, K.Hoch, S.Formation, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Hauptmann", Tribe.Mensch, K.Hoch, S.Formation, S.Anführen, S.Anführen, S.Stationieren, S.Aufklären, S.Banner); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Königswache", Tribe.Mensch, K.Hoch, S.Formation, S.Vernichten, S.Vernichten, S.Schutz, S.Schutz, S.Banner);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "Ritter", Tribe.Mensch, K.Hoch, S.Formation, S.BVernichten, S.BUmschwärmen, S.Anführen, S.Schutz, S.Banner);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "General", Tribe.Mensch, K.Hoch, S.Formation, S.BVernichten, S.Vernichten, S.Anführen, S.Anführen, S.Banner);  AlleWürfel.Add(würfel); würfel = new Würfel(



        "Bogenschützinnen", Tribe.Elf, K.Billig, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Dryade", Tribe.Elf, K.Wenig, S.ÜMoment, S.Umschwärmen, S.Aufklären, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Kommandantin", Tribe.Elf, K.Wenig, S.ÜMoment, S.Stationieren, S.Stationieren, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Falke", Tribe.Tier, K.Wenig, S.Fliegen, S.Aufklären, S.Aufklären, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Einhorn", Tribe.Tier, K.Wenig, S.Wiederbeleben, S.Heilen, S.Verbergen, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Glevenkrieger", Tribe.Elf, K.Mittel, S.ÜMoment, S.Vernichten, S.Vernichten, S.Schutz, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Sucherinnen", Tribe.Elf, K.Mittel, S.ÜMoment, S.Aufklären, S.Aufklären, S.Aufklären, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Waldläufer", Tribe.Elf, K.Mittel, S.ÜMoment, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Verbergen, S.Verbergen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Heilerin", Tribe.Elf, K.Mittel, S.Heilen, S.Heilen, S.Heilen, S.Heilen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Zauberin", Tribe.Elf, K.Mittel, S.BVernichten, S.BVernichten, S.Heilen, S.Verbergen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Fürstin", Tribe.Elf, K.Mittel, S.Stationieren, S.Stationieren, S.Stationieren, S.Stationieren, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Greif", Tribe.Tier, K.Mittel, S.Fliegen, S.Fliegen, S.Vernichten, S.Schutz, S.Aufklären, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Druidin", Tribe.Elf, K.Hoch, S.RudelInstinkt, S.Vernichten, S.Heilen, S.Schutz, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schattentiger", Tribe.Tier, K.Hoch, S.RudelInstinkt, S.BVernichten, S.Vernichten, S.Umschwärmen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Schattenklingen", Tribe.Elf, K.Teuer, S.ÜMoment, S.BVernichten, S.Vernichten, S.Verbergen, S.Verbergen, S.Verbergen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Hohepriesterin", Tribe.Elf, K.Teuer, S.Wiederbeleben, S.Heilen, S.Stationieren, S.Verbergen, S.Verbergen, S.Verbergen); AlleWürfel.Add(würfel); würfel = new Würfel(



        "Goblin-Horde", Tribe.Grünhaut, K.Billig, S.BUmschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Giftspuck-Goblins", Tribe.Grünhaut, K.Billig, S.BUmschwärmen, S.BUmschwärmen, S.BUmschwärmen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Sklavenabschaum", Tribe.Grünhaut, K.Billig, S.Umschwärmen, S.Umschwärmen, S.Stationieren, S.Stationieren, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Vorstürmer", Tribe.Grünhaut, K.Wenig, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Armbrüste", Tribe.Grünhaut, K.Wenig, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.Aufklären); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Brüllende Äxte", Tribe.Grünhaut, K.Wenig, S.Exempel, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Drill-Mentor", Tribe.Grünhaut, K.Wenig, S.Exempel, S.Exempel, S.Anführen, S.Anführen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Schattengoblins", Tribe.Grünhaut, K.Mittel, S.BVernichten, S.Vernichten, S.Umschwärmen, S.Verbergen, S.Verbergen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Wildäxte", Tribe.Grünhaut, K.Mittel, S.Exempel, S.Vernichten, S.Vernichten, S.Vernichten, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Berserker", Tribe.Grünhaut, K.Mittel, S.Exempel, S.BVernichten, S.BVernichten, S.Angst, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Warg-Rudel", Tribe.Tier, K.Mittel, S.RudelInstinkt, S.Vernichten, S.Vernichten, S.Umschwärmen, S.Umschwärmen, S.Angst); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Schlacht-Vorsteher", Tribe.Grünhaut, K.Hoch, S.Exempel, S.Exempel, S.Anführen, S.Anführen, S.Stationieren, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Riesenork", Tribe.Grünhaut, K.Hoch, S.BVernichten, S.BVernichten, S.Vernichten, S.Angst, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwarzorks", Tribe.Grünhaut, K.Hoch, S.Exempel, S.BVernichten, S.Vernichten, S.Vernichten, S.Angst, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schamane", Tribe.Grünhaut, K.Hoch, S.Exempel, S.BVernichten, S.Anführen, S.Angst, S.Angst, S.Angst); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Häuptling", Tribe.Grünhaut, K.Hoch, S.Exempel, S.Vernichten, S.Anführen, S.Anführen, S.Stationieren, S.Stationieren); AlleWürfel.Add(würfel); würfel = new Würfel(







        "Grüne Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Fliegen, S.Fliegen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Goldene Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Fliegen, S.Schutz, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Blaue Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Fliegen, S.Heilen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Rote Drachlinge", Tribe.Drache, K.Wenig, S.FeuerSpeien, S.Fliegen, S.LEER, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwarze Drachlinge", Tribe.Drache, K.Wenig, S.Fliegen, S.Vernichten, S.Angst, S.Angst, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Matriarchin", Tribe.Drache, K.Mittel, S.FeuerSpeien, S.Schwingenflug, S.Stationieren, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Jungdrachen", Tribe.Drache, K.Hoch, S.FeuerSpeien, S.Schwingenflug, S.Fliegen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Augendrache", Tribe.Drache, K.Hoch, S.FeuerSpeien, S.Fliegen, S.Aufklären, S.Aufklären, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Brutmutter", Tribe.Drache, K.Hoch, S.FeuerSpeien, S.Schwingenflug, S.Stationieren, S.Stationieren, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Höllendämon", Tribe.Dämon, K.Hoch, S.FeuerSpeien, S.FeuerSpeien, S.Angst, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Feuerwaran", Tribe.Tier, K.Hoch, S.FeuerSpeien, S.FeuerSpeien, S.Schutz, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Grüner Walddrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.Schwingenflug, S.Vernichten, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Goldener Wüstendrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.BVernichten, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Blauer Meeresdrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.Wiederbeleben, S.Heilen, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Roter Vulkandrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Schwingenflug, S.Schutz, S.FeuerSpeien, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schwarzer Todesdrache", Tribe.Drache, K.Teuer, S.FeuerSpeien, S.Vernichten, S.Schutz, S.Angst, S.Angst, S.Schwingenflug); AlleWürfel.Add(würfel); würfel = new Würfel(




        "Buddler", Tribe.Zwerg, K.Billig, S.Tunnel, S.Tunnel, S.Umschwärmen, S.Umschwärmen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Fledermaus-Schwarm", Tribe.Tier, K.Billig, S.Tunnel, S.Fliegen, S.Fliegen, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Ingenieur", Tribe.Zwerg, K.Wenig, S.Tunnel, S.Stationieren, S.Stationieren, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Braumeister", Tribe.Zwerg, K.Wenig, S.Tunnel, S.Anführen, S.Anführen, S.Anführen, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Ahnenhüter", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Wiederbeleben, S.Wiederbeleben, S.LEER, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Schildträger", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Umschwärmen, S.Schutz, S.Schutz, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Kumpel-Bande", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Tunnel, S.Umschwärmen, S.Umschwärmen, S.Aufklären, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Initiator", Tribe.Zwerg, K.Mittel, S.Tunnel, S.Anführen, S.Anführen, S.Stationieren, S.Stationieren, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Büchsen-Schützen", Tribe.Zwerg, K.Mittel, S.Tunnel, S.BVernichten, S.Vernichten, S.Aufklären, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Runenschnitzer", Tribe.Zwerg, K.Hoch, S.Tunnel, S.Vernichten, S.Wiederbeleben, S.Heilen, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Champion", Tribe.Zwerg, K.Hoch, S.Tunnel, S.BVernichten, S.Vernichten, S.Schutz, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Höhlenbär", Tribe.Tier, K.Hoch, S.Tunnel, S.Vernichten, S.Vernichten, S.Vernichten, S.Schutz, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Höhlentroll", Tribe.Troll, K.Hoch, S.Tunnel, S.Steinhaut, S.BVernichten, S.Vernichten, S.LEER, S.LEER); AlleWürfel.Add(würfel); würfel = new Würfel(

        "Ober-Boss", Tribe.Zwerg, K.Teuer, S.BVernichten, S.BVernichten, S.Stationieren, S.Stationieren, S.Anführen, S.Anführen); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Paladin", Tribe.Zwerg, K.Teuer, S.Tunnel, S.Vernichten, S.Vernichten, S.Heilen, S.Schutz, S.Schutz); AlleWürfel.Add(würfel); würfel = new Würfel(
        "Minenmeister", Tribe.Zwerg, K.Teuer, S.Tunnel, S.Stationieren, S.Vernichten, S.Schutz, S.Stationieren, S.Tunnel); AlleWürfel.Add(würfel); würfel = new Würfel(





"", Tribe.Tier, K.Billig, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER);  AlleWürfel.Add(würfel); würfel = new Würfel(
        "", Tribe.Tier, K.Billig, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER, S.LEER);  AlleWürfel.Add(würfel);





        
    }

    */


    #endregion
}
