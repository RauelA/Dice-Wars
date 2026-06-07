using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QardInstantiator : MonoBehaviour
{
    public GameObject QardPrefab;

    public Color Gold;

    public Sprite RaceHuman;
    public Sprite RaceElf;
    public Sprite RaceGreenskin;
    public Sprite RaceDwarf;
    public Sprite RaceDragon;
    public Sprite RaceDemon;
    public Sprite RaceUndead;
    public Sprite RaceTroll;
    public Sprite RaceAnimal;

    public Sprite QualityWoodCorner;
    public Sprite QualityIronCorner;
    public Sprite QualitySilverCorner;
    public Sprite QualityGoldCorner;
    public Sprite QualityWoodEdgeSmall;
    public Sprite QualityIronEdgeSmall;
    public Sprite QualitySilverEdgeSmall;
    public Sprite QualityGoldEdgeSmall;
    public Sprite QualityWoodEdgeBig;
    public Sprite QualityIronEdgeBig;
    public Sprite QualitySilverEdgeBig;
    public Sprite QualityGoldEdgeBig;
    public Sprite QualityWoodOuterFrame;
    public Sprite QualityIronOuterFrame;
    public Sprite QualitySilverOuterFrame;
    public Sprite QualityGoldOuterFrame;


    public Sprite AbilityMelee1;
    public Sprite AbilityMelee2;
    public Sprite AbilityMelee3;
    public Sprite AbilityRange1;
    public Sprite AbilityRange2;
    public Sprite AbilityRange3;
    public Sprite AbilityDestroy;
    public Sprite AbilityGuard;
    public Sprite AbilityHeal;
    public Sprite AbilityHolyPower;
    public Sprite AbilityResurrect;
    public Sprite AbilityHide;
    public Sprite AbilityScout;
    public Sprite AbilityKnowledge;
    public Sprite AbilityEarn;
    public Sprite AbilitySupply;
    public Sprite AbilityBanner;
    public Sprite AbilityLead;
    public Sprite AbilityFear;
    public Sprite AbilityAmbition;
    public Sprite AbilityFireStrike;
    public Sprite AbilityIceHail;
    public Sprite AbilityChainLightning;
    public Sprite AbilityFly;
    public Sprite AbilitySleep;
    public Sprite AbilityFormation;
    public Sprite AbilityTunnel;
    public Sprite AbilityAmbush;
    public Sprite AbilityChastise;
    public Sprite AbilityPackInstinct;
    public Sprite AbilityBloodSacrifice;
    public Sprite AbilityNecromancy;
    public Sprite AbilityIncubate;
    public Sprite AbilityPurify;



    public GameObject CreateQardByName(string name, Vector3 position)
    {
        foreach (KeyValuePair<int, CubeData> cubeData in CubeLibrary.Lib)
        {
            if (cubeData.Value.Name.Equals(name))
            {
                GameObject newQard = Instantiate(QardPrefab, position, Quaternion.identity);

                newQard.transform.SetParent(GameObject.Find("CANVAS MAIN").transform);

                InitQardGO(newQard, cubeData.Value);

                return newQard;
            }
        }
        return null;
    }

    private void InitQardGO(GameObject newQard, CubeData cubeData)
    {
        CardGO qardGOScript = newQard.GetComponent<CardGO>();

        qardGOScript.CubeData = cubeData;

        SetTitle(qardGOScript, cubeData);
        SetRace(qardGOScript, cubeData);
        SetRarity(qardGOScript, cubeData);
        SetAbilies(qardGOScript, cubeData);
    }

    private void SetTitle(CardGO qardGOScript, CubeData cubeData)
    {
        qardGOScript.Title.text = cubeData.Name;
    }

    private void SetRace(CardGO qardGOScript, CubeData cubeData)
    {
        switch (cubeData.Race)
        {
            case E.RACE.HUMAN:
                qardGOScript.RaceBackground.sprite = RaceHuman;
                break;
            case E.RACE.ELF:
                qardGOScript.RaceBackground.sprite = RaceElf;
                break;
            case E.RACE.GREENSKIN:
                qardGOScript.RaceBackground.sprite = RaceGreenskin;
                break;
            case E.RACE.DWARF:
                qardGOScript.RaceBackground.sprite = RaceDwarf;
                break;
            case E.RACE.DRAGON:
                qardGOScript.RaceBackground.sprite = RaceDragon;
                break;
            case E.RACE.DEMON:
                qardGOScript.RaceBackground.sprite = RaceDemon;
                break;
            case E.RACE.UNDEAD:
                qardGOScript.RaceBackground.sprite = RaceUndead;
                break;
            case E.RACE.TROLL:
                qardGOScript.RaceBackground.sprite = RaceTroll;
                break;
            case E.RACE.ANIMAL:
                qardGOScript.RaceBackground.sprite = RaceAnimal;
                break;
            default:
                break;
        }




    }

    private void SetRarity(CardGO qardGOScript, CubeData cubeData)
    {
        Sprite cornerSprite;
        Sprite smallEdgeSprite;
        Sprite bigEdgeSprite;
        Sprite outerFrameSprite;

        switch (cubeData.Rarity)
        {
            case E.RARY.WOOD:
                cornerSprite = QualityWoodCorner;
                smallEdgeSprite = QualityWoodEdgeSmall;
                bigEdgeSprite = QualityWoodEdgeBig;
                outerFrameSprite = QualityWoodOuterFrame;
                break;
            case E.RARY.IRON:
                cornerSprite = QualityIronCorner;
                smallEdgeSprite = QualityIronEdgeSmall;
                bigEdgeSprite = QualityIronEdgeBig;
                outerFrameSprite = QualityIronOuterFrame;
                break;
            case E.RARY.SILVER:
                cornerSprite = QualitySilverCorner;
                smallEdgeSprite = QualitySilverEdgeSmall;
                bigEdgeSprite = QualitySilverEdgeBig;
                outerFrameSprite = QualitySilverOuterFrame;
                break;
            case E.RARY.GOLD:
                cornerSprite = QualityGoldCorner;
                smallEdgeSprite = QualityGoldEdgeSmall;
                bigEdgeSprite = QualityGoldEdgeBig;
                outerFrameSprite = QualityGoldOuterFrame;
                break;
            default:
                cornerSprite = null;
                smallEdgeSprite = null;
                bigEdgeSprite = null;
                outerFrameSprite = null;
                break;
        }

        foreach (Image corner in qardGOScript.AbilityFrameCorners)
        {
            corner.sprite = cornerSprite;
        }
        foreach (Image smallEdge in qardGOScript.AbilityFrameSmallEdges)
        {
            smallEdge.sprite = smallEdgeSprite;
        }
        foreach (Image bigEdge in qardGOScript.AbilityFrameBigEdges)
        {
            bigEdge.sprite = bigEdgeSprite;
        }
        foreach (Image outerFrame in qardGOScript.AbilityFrameOuterFrame)
        {
            outerFrame.sprite = outerFrameSprite;
        }
    }

    private void SetAbilies(CardGO qardGOScript, CubeData cubeData)
    {
        for (int i = 0; i < cubeData.Abilities.Length; i++)
        {
            /*
            switch (cubeData.Abilities[i])

            {
                case E.A.EMPTY:
                    break;
                case E.A.MELEE1:
                    qardGOScript.AbilityIcons[i].sprite = AbilityMelee1;
                    break;
                case E.A.MELEE2:
                    qardGOScript.AbilityIcons[i].sprite = AbilityMelee2;
                    break;
                case E.A.MELEE3:
                    qardGOScript.AbilityIcons[i].sprite = AbilityMelee3;
                    break;
                case E.A.RANGE1:
                    qardGOScript.AbilityIcons[i].sprite = AbilityRange1;
                    break;
                case E.A.RANGE2:
                    qardGOScript.AbilityIcons[i].sprite = AbilityRange2;
                    break;
                case E.A.RANGE3:
                    qardGOScript.AbilityIcons[i].sprite = AbilityRange3;
                    break;
                case E.A.DESTROY:
                    qardGOScript.AbilityIcons[i].sprite = AbilityDestroy;
                    break;
                case E.A.GUARD:
                    qardGOScript.AbilityIcons[i].sprite = AbilityGuard;
                    break;
                case E.A.HEAL:
                    qardGOScript.AbilityIcons[i].sprite = AbilityHeal;
                    break;
                case E.A.HOLYPOWER:
                    qardGOScript.AbilityIcons[i].sprite = AbilityHolyPower;
                    break;
                case E.A.RESURRECT:
                    qardGOScript.AbilityIcons[i].sprite = AbilityResurrect;
                    break;
                case E.A.HIDE:
                    qardGOScript.AbilityIcons[i].sprite = AbilityHide;
                    break;
                case E.A.SCOUT:
                    qardGOScript.AbilityIcons[i].sprite = AbilityScout;
                    break;
                case E.A.KNOWLEDGE:
                    qardGOScript.AbilityIcons[i].sprite = AbilityKnowledge;
                    break;
                case E.A.EARN:
                    qardGOScript.AbilityIcons[i].sprite = AbilityEarn;
                    break;
                case E.A.SUPPLY:
                    qardGOScript.AbilityIcons[i].sprite = AbilitySupply;
                    break;
                case E.A.BANNER:
                    qardGOScript.AbilityIcons[i].sprite = AbilityBanner;
                    break;
                case E.A.LEAD:
                    qardGOScript.AbilityIcons[i].sprite = AbilityLead;
                    break;
                case E.A.FEAR:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFear;
                    break;
                case E.A.AMBITION:
                    qardGOScript.AbilityIcons[i].sprite = AbilityAmbition;
                    break;
                case E.A.FIRESTRIKE:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFireStrike;
                    break;
                case E.A.ICEHAIL:
                    qardGOScript.AbilityIcons[i].sprite = AbilityIceHail;
                    break;
                case E.A.CHAINLIGHTNING:
                    qardGOScript.AbilityIcons[i].sprite = AbilityChainLightning;
                    break;
                case E.A.FLY:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFly;
                    break;
                case E.A.SLEEP:
                    qardGOScript.AbilityIcons[i].sprite = AbilitySleep;
                    break;
                case E.A.FORMATION:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFormation;
                    break;
                case E.A.TUNNEL:
                    qardGOScript.AbilityIcons[i].sprite = AbilityTunnel;
                    break;
                case E.A.AMBUSH:
                    qardGOScript.AbilityIcons[i].sprite = AbilityAmbush;
                    break;
                case E.A.CHASTISE:
                    qardGOScript.AbilityIcons[i].sprite = AbilityChastise;
                    break;
                case E.A.PACKINSTINCT:
                    qardGOScript.AbilityIcons[i].sprite = AbilityPackInstinct;
                    break;
                case E.A.BLOODSACRIFICE:
                    qardGOScript.AbilityIcons[i].sprite = AbilityBloodSacrifice;
                    break;
                case E.A.NECROMANCY:
                    qardGOScript.AbilityIcons[i].sprite = AbilityNecromancy;
                    break;
                case E.A.INCUBATE:
                    qardGOScript.AbilityIcons[i].sprite = AbilityIncubate;
                    break;
                case E.A.PURIFY:
                    qardGOScript.AbilityIcons[i].sprite = AbilityPurify;
                    break;


                case E.A.MELEE1_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityMelee1;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.MELEE2_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityMelee2;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.MELEE3_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityMelee3;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.RANGE1_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityRange1;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.RANGE2_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityRange2;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.RANGE3_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityRange3;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.DESTROY_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityDestroy;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.GUARD_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityGuard;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.HEAL_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityHeal;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.HOLYPOWER_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityHolyPower;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.RESURRECT_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityResurrect;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.HIDE_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityHide;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.SCOUT_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityScout;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.KNOWLEDGE_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityKnowledge;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.EARN_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityEarn;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.SUPPLY_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilitySupply;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.BANNER_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityBanner;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.LEAD_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityLead;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.FEAR_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFear;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.AMBITION_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityAmbition;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.FIRESTRIKE_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFireStrike;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.ICEHAIL_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityIceHail;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.CHAINLIGHTNING_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityChainLightning;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.FLY_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFly;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.SLEEP_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilitySleep;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.FORMATION_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityFormation;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.TUNNEL_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityTunnel;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.AMBUSH_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityAmbush;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.CHASTISE_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityChastise;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.PACKINSTINCT_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityPackInstinct;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.BLOODSACRIFICE_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityBloodSacrifice;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.NECROMANCY_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityNecromancy;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.INCUBATE_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityIncubate;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                case E.A.PURIFY_G:
                    qardGOScript.AbilityIcons[i].sprite = AbilityPurify;
                    qardGOScript.AbilityIcons[i].color = Gold;
                    break;
                default:
                    break;
            }
            */
        }

    }

}
