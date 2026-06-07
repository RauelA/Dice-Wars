using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiator : MonoBehaviour
{
    public GameObject CubePrefab;

    public Material RaceMaterialHuman;
    public Material RaceMaterialElf;
    public Material RaceMaterialGreenskin;
    public Material RaceMaterialDwarf;
    public Material RaceMaterialDragon;
    public Material RaceMaterialDemon;
    public Material RaceMaterialUndead;
    public Material RaceMaterialTroll;
    public Material RaceMaterialAnimal;



    public GameObject CreateCubeByName(string name, Vector3 position)
    {
        foreach (KeyValuePair<int, CubeData> cubeData in CubeLibrary.Lib)
        {
            if (cubeData.Value.Name.Equals(name))
            {
                GameObject newCube = Instantiate(CubePrefab, position, Quaternion.identity);

                InitCubeGO(newCube, cubeData.Value);

                return newCube;
            }
        }
        return null;
    }

    public CubeData CreateCubeByID(int id, Vector3 position)
    {
        GameObject newCube = Instantiate(CubePrefab, position, Quaternion.identity);

        InitCubeGO(newCube, CubeLibrary.Lib[id]);

        return CubeLibrary.Lib[id];
    }

    private void InitCubeGO(GameObject cubeGO, CubeData cubeData)
    {
        Renderer renderer               = cubeGO.GetComponent<Renderer>();
        CubeGO cubeGOScript             = cubeGO.GetComponent<CubeGO>();
               cubeGOScript.CubeData    = cubeData;

        SetRace(renderer, cubeData);
        SetRarity(cubeGOScript, cubeData);
        SetAbilies(cubeGOScript, cubeData);
    }

    private void SetRace(Renderer renderer, CubeData cubeData)
    {
        switch (cubeData.Race)
        {
            case E.RACE.HUMAN:
                renderer.material = RaceMaterialHuman;
                break;
            case E.RACE.ELF:
                renderer.material = RaceMaterialElf;
                break;
            case E.RACE.GREENSKIN:
                renderer.material = RaceMaterialGreenskin;
                break;
            case E.RACE.DWARF:
                renderer.material = RaceMaterialDwarf;
                break;
            case E.RACE.DRAGON:
                renderer.material = RaceMaterialDragon;
                break;
            case E.RACE.DEMON:
                renderer.material = RaceMaterialDemon;
                break;
            case E.RACE.UNDEAD:
                renderer.material = RaceMaterialUndead;
                break;
            case E.RACE.TROLL:
                renderer.material = RaceMaterialTroll;
                break;
            case E.RACE.ANIMAL:
                renderer.material = RaceMaterialAnimal;
                break;
            default:
                break;
        }

    }

    private void SetRarity(CubeGO cubeGOScript, CubeData cubeData)
    {
        foreach (MeshRenderer frameRenderer in cubeGOScript.FrameRenderers)
        {
            switch (cubeData.Rarity)
            {                

                case E.RARY.WOOD:
                    frameRenderer.material.SetFloat("_Metallic", 0f);
                    break;
                case E.RARY.IRON:
                    frameRenderer.material.mainTextureOffset += new Vector2(0.25f, 0);
                    frameRenderer.material.SetFloat("_Metallic", 0f);
                    //frameRenderer.material.SetFloat("_Metallic", 0.5f);
                    break;
                case E.RARY.SILVER:
                    frameRenderer.material.mainTextureOffset += new Vector2(0.5f, 0);
                    frameRenderer.material.SetFloat("_Metallic", 0f);
                    //frameRenderer.material.SetFloat("_Metallic", 1f);
                    break;
                case E.RARY.GOLD:
                    frameRenderer.material.mainTextureOffset += new Vector2(0.75f, 0);
                    frameRenderer.material.SetFloat("_Metallic", 0f);
                    //frameRenderer.material.SetFloat("_Metallic", 1f);
                    break;
            }
        }
        

        /*
        switch (cubeData.Rarity)
        {
            case E.RARITY.WOOD:
                break;
            case E.RARITY.IRON:
                material.mainTextureOffset += new Vector2(0.125f, 0);
                break;
            case E.RARITY.SILVER:
                material.mainTextureOffset += new Vector2(0.25f, 0);
                break;
            case E.RARITY.GOLD:
                material.mainTextureOffset += new Vector2(0.375f, 0);
                break;
        }
        */
    }

    private void SetAbilies(CubeGO cubeGO, CubeData cubeData)
    {
        bool isGold = false;

        for (int i = 0; i < cubeGO.SideRenderers.Length; i++)
        {
            Material material = cubeGO.SideRenderers[i].material;
            /*
            switch (cubeData.Abilities[i])
            {
                case E.A.EMPTY:
                    material.mainTextureOffset = new Vector2(0.875f, 0.5f);
                    break;
                case E.A.MELEE1:
                    material.mainTextureOffset = new Vector2(0f, 0.875f);
                    break;
                case E.A.MELEE2:
                    material.mainTextureOffset = new Vector2(0.125f, 0.875f);
                    break;
                case E.A.MELEE3:
                    material.mainTextureOffset = new Vector2(0.25f, 0.875f);
                    break;
                case E.A.RANGE1:
                    material.mainTextureOffset = new Vector2(0.375f, 0.875f);
                    break;
                case E.A.RANGE2:
                    material.mainTextureOffset = new Vector2(0.5f, 0.875f);
                    break;
                case E.A.RANGE3:
                    material.mainTextureOffset = new Vector2(0.625f, 0.875f);
                    break;
                case E.A.DESTROY:
                    material.mainTextureOffset = new Vector2(0f, 0.75f);
                    break;
                case E.A.GUARD:
                    material.mainTextureOffset = new Vector2(0.125f, 0.75f);
                    break;
                case E.A.HEAL:
                    material.mainTextureOffset = new Vector2(0.25f, 0.75f);
                    break;
                case E.A.HOLYPOWER:
                    material.mainTextureOffset = new Vector2(0.375f, 0.75f);
                    break;
                case E.A.RESURRECT:
                    material.mainTextureOffset = new Vector2(0.5f, 0.75f);
                    break;
                case E.A.HIDE:
                    material.mainTextureOffset = new Vector2(0.625f, 0.75f);
                    break;
                case E.A.SCOUT:
                    material.mainTextureOffset = new Vector2(0f, 0.625f);
                    break;
                case E.A.KNOWLEDGE:
                    material.mainTextureOffset = new Vector2(0.125f, 0.625f);
                    break;
                case E.A.EARN:
                    material.mainTextureOffset = new Vector2(0.25f, 0.625f);
                    break;
                case E.A.SUPPLY:
                    material.mainTextureOffset = new Vector2(0.625f, 0.625f);
                    break;
                case E.A.BANNER:
                    material.mainTextureOffset = new Vector2(0.375f, 0.625f);
                    break;
                case E.A.LEAD:
                    material.mainTextureOffset = new Vector2(0.5f, 0.625f);
                    break;
                case E.A.FEAR:
                    material.mainTextureOffset = new Vector2(0.625f, 0.625f);
                    break;
                case E.A.AMBITION:
                    material.mainTextureOffset = new Vector2(0f, 0.5f);
                    break;
                case E.A.FIRESTRIKE:
                    material.mainTextureOffset = new Vector2(0.125f, 0.5f);
                    break;
                case E.A.ICEHAIL:
                    material.mainTextureOffset = new Vector2(0.25f, 0.5f);
                    break;
                case E.A.CHAINLIGHTNING:
                    material.mainTextureOffset = new Vector2(0.375f, 0.5f);
                    break;
                case E.A.FLY:
                    material.mainTextureOffset = new Vector2(0.5f, 0.5f);
                    break;
                case E.A.SLEEP:
                    material.mainTextureOffset = new Vector2(0.625f, 0.5f);
                    break;
                case E.A.FORMATION:
                    material.mainTextureOffset = new Vector2(0f, 0.375f);
                    break;
                case E.A.TUNNEL:
                    material.mainTextureOffset = new Vector2(0.125f, 0.375f);
                    break;
                case E.A.AMBUSH:
                    material.mainTextureOffset = new Vector2(0.25f, 0.375f);
                    break;
                case E.A.CHASTISE:
                    material.mainTextureOffset = new Vector2(0.375f, 0.375f);
                    break;
                case E.A.PACKINSTINCT:
                    material.mainTextureOffset = new Vector2(0.5f, 0.375f);
                    break;
                case E.A.BLOODSACRIFICE:
                    material.mainTextureOffset = new Vector2(0.625f, 0.375f);
                    break;
                case E.A.NECROMANCY:
                    material.mainTextureOffset = new Vector2(0f, 0.25f);
                    break;
                case E.A.INCUBATE:
                    material.mainTextureOffset = new Vector2(0.125f, 0.25f);
                    break;
                case E.A.PURIFY:
                    material.mainTextureOffset = new Vector2(0.25f, 0.25f);
                    break;

                
                case E.A.MELEE1_G:
                    material.mainTextureOffset = new Vector2(0f, 0.875f);
                    isGold = true;
                    break;
                case E.A.MELEE2_G:
                    material.mainTextureOffset = new Vector2(0.125f, 0.875f);
                    isGold = true;
                    break;
                case E.A.MELEE3_G:
                    material.mainTextureOffset = new Vector2(0.25f, 0.875f);
                    isGold = true;
                    break;
                case E.A.RANGE1_G:
                    material.mainTextureOffset = new Vector2(0.375f, 0.875f);
                    isGold = true;
                    break;
                case E.A.RANGE2_G:
                    material.mainTextureOffset = new Vector2(0.5f, 0.875f);
                    isGold = true;
                    break;
                case E.A.RANGE3_G:
                    material.mainTextureOffset = new Vector2(0.625f, 0.875f);
                    isGold = true;
                    break;
                case E.A.DESTROY_G:
                    material.mainTextureOffset = new Vector2(0f, 0.75f);
                    isGold = true;
                    break;
                case E.A.GUARD_G:
                    material.mainTextureOffset = new Vector2(0.125f, 0.75f);
                    isGold = true;
                    break;
                case E.A.HEAL_G:
                    material.mainTextureOffset = new Vector2(0.25f, 0.75f);
                    isGold = true;
                    break;
                case E.A.HOLYPOWER_G:
                    material.mainTextureOffset = new Vector2(0.375f, 0.75f);
                    isGold = true;
                    break;
                case E.A.RESURRECT_G:
                    material.mainTextureOffset = new Vector2(0.5f, 0.75f);
                    isGold = true;
                    break;
                case E.A.HIDE_G:
                    material.mainTextureOffset = new Vector2(0.625f, 0.75f);
                    isGold = true;
                    break;
                case E.A.SCOUT_G:
                    material.mainTextureOffset = new Vector2(0f, 0.625f);
                    isGold = true;
                    break;
                case E.A.KNOWLEDGE_G:
                    material.mainTextureOffset = new Vector2(0.125f, 0.625f);
                    isGold = true;
                    break;
                case E.A.EARN_G:
                    material.mainTextureOffset = new Vector2(0.25f, 0.625f);
                    isGold = true;
                    break;
                case E.A.SUPPLY_G:
                    material.mainTextureOffset = new Vector2(0.625f, 0.625f);
                    isGold = true;
                    break;
                case E.A.BANNER_G:
                    material.mainTextureOffset = new Vector2(0.375f, 0.625f);
                    isGold = true;
                    break;
                case E.A.LEAD_G:
                    material.mainTextureOffset = new Vector2(0.5f, 0.625f);
                    isGold = true;
                    break;
                case E.A.FEAR_G:
                    material.mainTextureOffset = new Vector2(0.625f, 0.625f);
                    isGold = true;
                    break;
                case E.A.AMBITION_G:
                    material.mainTextureOffset = new Vector2(0f, 0.5f);
                    isGold = true;
                    break;
                case E.A.FIRESTRIKE_G:
                    material.mainTextureOffset = new Vector2(0.125f, 0.5f);
                    isGold = true;
                    break;
                case E.A.ICEHAIL_G:
                    material.mainTextureOffset = new Vector2(0.25f, 0.5f);
                    isGold = true;
                    break;
                case E.A.CHAINLIGHTNING_G:
                    material.mainTextureOffset = new Vector2(0.375f, 0.5f);
                    isGold = true;
                    break;
                case E.A.FLY_G:
                    material.mainTextureOffset = new Vector2(0.5f, 0.5f);
                    isGold = true;
                    break;
                case E.A.SLEEP_G:
                    material.mainTextureOffset = new Vector2(0.625f, 0.5f);
                    isGold = true;
                    break;
                case E.A.FORMATION_G:
                    material.mainTextureOffset = new Vector2(0f, 0.375f);
                    isGold = true;
                    break;
                case E.A.TUNNEL_G:
                    material.mainTextureOffset = new Vector2(0.125f, 0.375f);
                    isGold = true;
                    break;
                case E.A.AMBUSH_G:
                    material.mainTextureOffset = new Vector2(0.25f, 0.375f);
                    isGold = true;
                    break;
                case E.A.CHASTISE_G:
                    material.mainTextureOffset = new Vector2(0.375f, 0.375f);
                    isGold = true;
                    break;
                case E.A.PACKINSTINCT_G:
                    material.mainTextureOffset = new Vector2(0.5f, 0.375f);
                    isGold = true;
                    break;
                case E.A.BLOODSACRIFICE_G:
                    material.mainTextureOffset = new Vector2(0.625f, 0.375f);
                    isGold = true;
                    break;
                case E.A.NECROMANCY_G:
                    material.mainTextureOffset = new Vector2(0f, 0.25f);
                    isGold = true;
                    break;
                case E.A.INCUBATE_G:
                    material.mainTextureOffset = new Vector2(0.125f, 0.25f);
                    isGold = true;
                    break;
                case E.A.PURIFY_G:
                    material.mainTextureOffset = new Vector2(0.25f, 0.25f);
                    isGold = true;
                    break;

                default:
                    material.mainTextureOffset = new Vector2(0.5f, 0.875f);
                    break;
            }
            */

            if (isGold)
            {
                material.color = Color.yellow;
                // Gold = new Color(1f, 0.843137255f, 0);
            }
        }
    }
}