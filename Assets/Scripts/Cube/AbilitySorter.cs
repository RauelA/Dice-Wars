using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySorter
{
    private List<E.A> AbilityRanking = new List<E.A>();

    public AbilitySorter ()
    {
        /*
        AbilityRanking.Add(E.A.DESTROY);
        AbilityRanking.Add(E.A.RANGE3);
        AbilityRanking.Add(E.A.MELEE3);
        AbilityRanking.Add(E.A.FLY);
        AbilityRanking.Add(E.A.RESURRECT);
        AbilityRanking.Add(E.A.CHAINLIGHTNING);
        AbilityRanking.Add(E.A.ICEHAIL);
        AbilityRanking.Add(E.A.FIRESTRIKE);
        AbilityRanking.Add(E.A.NECROMANCY);
        AbilityRanking.Add(E.A.RANGE2);
        AbilityRanking.Add(E.A.MELEE2);
        AbilityRanking.Add(E.A.LEAD);
        AbilityRanking.Add(E.A.HOLYPOWER);
        AbilityRanking.Add(E.A.GUARD);
        AbilityRanking.Add(E.A.KNOWLEDGE);
        AbilityRanking.Add(E.A.BANNER);
        AbilityRanking.Add(E.A.FEAR);
        AbilityRanking.Add(E.A.BLOODSACRIFICE);
        AbilityRanking.Add(E.A.INCUBATE);
        AbilityRanking.Add(E.A.PACKINSTINCT);
        AbilityRanking.Add(E.A.CHASTISE);
        AbilityRanking.Add(E.A.TUNNEL);
        AbilityRanking.Add(E.A.AMBUSH);
        AbilityRanking.Add(E.A.FORMATION);
        AbilityRanking.Add(E.A.HEAL);
        AbilityRanking.Add(E.A.SUPPLY);
        AbilityRanking.Add(E.A.RANGE1);
        AbilityRanking.Add(E.A.MELEE1);
        AbilityRanking.Add(E.A.HIDE);
        AbilityRanking.Add(E.A.SCOUT);
        AbilityRanking.Add(E.A.AMBITION);
        AbilityRanking.Add(E.A.EMPTY);
        */
    }


    
    public E.A[] SortAbilities(E.A[] abilities)
    {
        E.A[] finalAbilies = new E.A[6];

        bool[] abilityDone = new bool[6];

        E.A currentAbility = E.A.EMPTY;
        int currentRanking = 999;


        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < abilities.Length; j++)
            {
                foreach (var abilityRanked in AbilityRanking)
                {
                    if (!abilityDone[j]
                     && abilities[j] == abilityRanked
                     && currentRanking > AbilityRanking.IndexOf(abilityRanked))
                    {
                        currentRanking = AbilityRanking.IndexOf(abilityRanked);
                        currentAbility = abilities[j];
                        abilityDone[j] = true;
                    }
                }
            }
            finalAbilies[i] = currentAbility;
        }

        return finalAbilies;
    }

    
}