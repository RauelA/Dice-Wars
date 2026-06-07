using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightGlowMain : MonoBehaviour
{
    public AnimationCurve HighlightEffectIntensityCurve;

    public AnimationCurve LightIntensityCurve;
    public float LightRangeFactor;

    public float AnimationSpeed = 0.5f;


    public GameObject HighlightMelee1;
    public GameObject HighlightMelee2;
    public GameObject HighlightMelee3;
    public GameObject HighlightRange1;
    public GameObject HighlightRange2;
    public GameObject HighlightRange3;
    public GameObject HighlightDestroy;
    public GameObject HighlightGuard;
    public GameObject HighlightHeal;
    public GameObject HighlightHolyPower;
    public GameObject HighlightResurrect;
    public GameObject HighlightHide;
    public GameObject HighlightScout;
    public GameObject HighlightKnowledge;
    public GameObject HighlightEarn;
    public GameObject HighlightSupply;
    public GameObject HighlightBanner;
    public GameObject HighlightLead;
    public GameObject HighlightFear;
    public GameObject HighlightAmbition;
    public GameObject HighlightFireStrike;
    public GameObject HighlightIceHail;
    public GameObject HighlightChainLightning;
    public GameObject HighlightFly;
    public GameObject HighlightSleep;
    public GameObject HighlightFormation;
    public GameObject HighlightTunnel;
    public GameObject HighlightAmbush;
    public GameObject HighlightChastise;
    public GameObject HighlightPackInstinct;
    public GameObject HighlightBloodSacrifice;
    public GameObject HighlightNecromancy;
    public GameObject HighlightIncubate;
    public GameObject HighlightPurify;


    public GameObject GetHighlightEffect(E.A name)
    {
        /*
        switch (name)
        {
            case E.A.EMPTY:
                break;
            case E.A.MELEE1:
                return HighlightMelee1;
            case E.A.MELEE2:
                return HighlightMelee2;
            case E.A.MELEE3:
                return HighlightMelee3;
            case E.A.RANGE1:
                return HighlightRange1;
            case E.A.RANGE2:
                return HighlightRange2;
            case E.A.RANGE3:
                return HighlightRange3;
            case E.A.DESTROY:
                return HighlightDestroy;
            case E.A.GUARD:
                return HighlightGuard;
            case E.A.HEAL:
                return HighlightHeal;
            case E.A.HOLYPOWER:
                return HighlightHolyPower;
            case E.A.RESURRECT:
                return HighlightResurrect;
            case E.A.HIDE:
                return HighlightHide;
            case E.A.SCOUT:
                return HighlightScout;
            case E.A.KNOWLEDGE:
                return HighlightKnowledge;
            case E.A.EARN:
                return HighlightEarn;
            case E.A.SUPPLY:
                return HighlightSupply;
            case E.A.BANNER:
                return HighlightBanner;
            case E.A.LEAD:
                return HighlightLead;
            case E.A.FEAR:
                return HighlightFear;
            case E.A.AMBITION:
                return HighlightAmbition;
            case E.A.FIRESTRIKE:
                return HighlightFireStrike;
            case E.A.ICEHAIL:
                return HighlightIceHail;
            case E.A.CHAINLIGHTNING:
                return HighlightChainLightning;
            case E.A.FLY:
                return HighlightFly;
            case E.A.SLEEP:
                return HighlightSleep;
            case E.A.FORMATION:
                return HighlightFormation;
            case E.A.TUNNEL:
                return HighlightTunnel;
            case E.A.AMBUSH:
                return HighlightAmbush;
            case E.A.CHASTISE:
                return HighlightChastise;
            case E.A.PACKINSTINCT:
                return HighlightPackInstinct;
            case E.A.BLOODSACRIFICE:
                return HighlightBloodSacrifice;
            case E.A.NECROMANCY:
                return HighlightNecromancy;
            case E.A.INCUBATE:
                return HighlightIncubate;
            case E.A.PURIFY:
                return HighlightPurify;


            case E.A.MELEE1_G:
                return HighlightMelee1;
            case E.A.MELEE2_G:
                return HighlightMelee2;
            case E.A.MELEE3_G:
                return HighlightMelee3;
            case E.A.RANGE1_G:
                return HighlightRange1;
            case E.A.RANGE2_G:
                return HighlightRange2;
            case E.A.RANGE3_G:
                return HighlightRange3;
            case E.A.DESTROY_G:
                return HighlightDestroy;
            case E.A.GUARD_G:
                return HighlightGuard;
            case E.A.HEAL_G:
                return HighlightHeal;
            case E.A.HOLYPOWER_G:
                return HighlightHolyPower;
            case E.A.RESURRECT_G:
                return HighlightResurrect;
            case E.A.HIDE_G:
                return HighlightHide;
            case E.A.SCOUT_G:
                return HighlightScout;
            case E.A.KNOWLEDGE_G:
                return HighlightKnowledge;
            case E.A.EARN_G:
                return HighlightEarn;
            case E.A.SUPPLY_G:
                return HighlightSupply;
            case E.A.BANNER_G:
                return HighlightBanner;
            case E.A.LEAD_G:
                return HighlightLead;
            case E.A.FEAR_G:
                return HighlightFear;
            case E.A.AMBITION_G:
                return HighlightAmbition;
            case E.A.FIRESTRIKE_G:
                return HighlightFireStrike;
            case E.A.ICEHAIL_G:
                return HighlightIceHail;
            case E.A.CHAINLIGHTNING_G:
                return HighlightChainLightning;
            case E.A.FLY_G:
                return HighlightFly;
            case E.A.SLEEP_G:
                return HighlightSleep;
            case E.A.FORMATION_G:
                return HighlightFormation;
            case E.A.TUNNEL_G:
                return HighlightTunnel;
            case E.A.AMBUSH_G:
                return HighlightAmbush;
            case E.A.CHASTISE_G:
                return HighlightChastise;
            case E.A.PACKINSTINCT_G:
                return HighlightPackInstinct;
            case E.A.BLOODSACRIFICE_G:
                return HighlightBloodSacrifice;
            case E.A.NECROMANCY_G:
                return HighlightNecromancy;
            case E.A.INCUBATE_G:
                return HighlightIncubate;
            case E.A.PURIFY_G:
                return HighlightPurify;
        }
        */

        return null;
    }
}
