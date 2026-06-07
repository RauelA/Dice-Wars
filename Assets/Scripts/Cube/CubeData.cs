public class CubeData
{
    public string Name;

    public E.RACE Race;

    public E.RARY Rarity;

    public E.A[] Abilities;


    public CubeData (string name, E.RACE race, E.RARY rarity, E.A[] abilities)
    {
        Name = name;
        Race = race;
        Rarity = rarity;
        Abilities = new E.A[6];

        for (int i = 0; i < abilities.Length; i++)
        {
            if (i < abilities.Length)
            {
                Abilities[i] = abilities[i];
            }
            else
            {
                Abilities[i] = E.A.EMPTY;
            }
        }
    }
}
