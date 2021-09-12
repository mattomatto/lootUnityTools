using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootItemDataHolder : MonoBehaviour
{

    string[] nameSuffixes;
    string[] namePrefixes;
    string[] suffixes;
    string[] rings;
    string[] necklaces;
    string[] handArmor;
    string[] footArmor;
    string[] waistArmor;
    string[] headArmor;
    string[] chestArmor;
    string[] weapons;

    void InitWeapons()
    {
        weapons = new string[]
        {
            "Warhammer",            // 0
            "Quarterstaff",         // 1
            "Maul",                 // 2
            "Mace",                 // 3
            "Club",                 // 4
            "Katana",               // 5
            "Falchion",             // 6
            "Scimitar",             // 7
            "Long Sword",           // 8
            "Short Sword",          // 9
            "Ghost Wand",           // 10
            "Grave Wand",           // 11
            "Bone Wand",            // 12
            "Wand",                 // 13
            "Grimoire",             // 14
            "Chronicle",            // 15
            "Tome",                 // 16
            "Book"                  // 17
        };
    }


    void InitChestArmor()
    {
        chestArmor = new string[]
        {
            "Divine Robe",          // 0
            "Silk Robe",            // 1
            "Linen Robe",           // 2
            "Robe",                 // 3
            "Shirt",                // 4
            "Demon Husk",           // 5
            "Dragonskin Armor",     // 6
            "Studded Leather Armor",// 7
            "Hard Leather Armor",   // 8
            "Leather Armor",        // 9
            "Holy Chestplate",      // 10
            "Ornate Chestplate",    // 11
            "Plate Mail",           // 12
            "Chain Mail",           // 13
            "Ring Mail"             // 14
        };
    }

    void InitHeadArmor()
    {

        headArmor = new string[]
        {
        "Ancient Helm",         // 0
        "Ornate Helm",          // 1
        "Great Helm",           // 2
        "Full Helm",            // 3
        "Helm",                 // 4
        "Demon Crown",          // 5
        "Dragon's Crown",       // 6
        "War Cap",              // 7
        "Leather Cap",          // 8
        "Cap",                  // 9
        "Crown",                // 10
        "Divine Hood",          // 11
        "Silk Hood",            // 12
        "Linen Hood",           // 13
        "Hood"                  // 14
        };
    }

    void InitWaistArmor()
    {
        waistArmor = new string[]
        {
            "Ornate Belt",          // 0
            "War Belt",             // 1
            "Plated Belt",          // 2
            "Mesh Belt",            // 3
            "Heavy Belt",           // 4
            "Demonhide Belt",       // 5
            "Dragonskin Belt",      // 6
            "Studded Leather Belt", // 7
            "Hard Leather Belt",    // 8
            "Leather Belt",         // 9
            "Brightsilk Sash",      // 10
            "Silk Sash",            // 11
            "Wool Sash",            // 12
            "Linen Sash",           // 13
            "Sash"                  // 14
        };
    }

    void InitFootArmor()
    {
        footArmor = new string[]
        {
            "Holy Greaves",         // 0
            "Ornate Greaves",       // 1
            "Greaves",              // 2
            "Chain Boots",          // 3
            "Heavy Boots",          // 4
            "Demonhide Boots",      // 5
            "Dragonskin Boots",     // 6
            "Studded Leather Boots",// 7
            "Hard Leather Boots",   // 8
            "Leather Boots",        // 9
            "Divine Slippers",      // 10
            "Silk Slippers",        // 11
            "Wool Shoes",           // 12
            "Linen Shoes",          // 13
            "Shoes"                 // 14
        };
    }

    void InitHandArmor()
    {
        handArmor = new string[]
            {
                "Holy Gauntlets",       // 0
                "Ornate Gauntlets",     // 1
                "Gauntlets",            // 2
                "Chain Gloves",         // 3
                "Heavy Gloves",         // 4
                "Demon's Hands",        // 5
                "Dragonskin Gloves",    // 6
                "Studded Leather Gloves",// 7
                "Hard Leather Gloves",  // 8
                "Leather Gloves",       // 9
                "Divine Gloves",        // 10
                "Silk Gloves",          // 11
                "Wool Gloves",          // 12
                "Linen Gloves",         // 13
                "Gloves"                // 14
            };
    }

    void InitNecklaces()
    {
        necklaces = new string[]
        {
            "Necklace",             // 0
            "Amulet",               // 1
            "Pendant"               // 2
        };
    }

    void InitRings()
    {
        rings = new string[]
        {
        "Gold Ring",            // 0
        "Silver Ring",          // 1
        "Bronze Ring",          // 2
        "Platinum Ring",        // 3
        "Titanium Ring"         // 4
        };
    }

    void InitSuffixes()
    {
        suffixes = new string[]
        {
        //<no suffix>          // 0
        "",                      //0
        "of Power",             // 1
        "of Giants",            // 2
        "of Titans",            // 3
        "of Skill",             // 4
        "of Perfection",        // 5
        "of Brilliance",        // 6
        "of Enlightenment",     // 7
        "of Protection",        // 8
        "of Anger",             // 9
        "of Rage",              // 10
        "of Fury",              // 11
        "of Vitriol",           // 12
        "of the Fox",           // 13
        "of Detection",         // 14
        "of Reflection",        // 15
        "of the Twins"          // 16
        };
    }

    void InitNamePrefixes()
    {
        namePrefixes = new string[]
        {
        // <no name>            // 0
        "",                      //0
        "Agony",                // 1
        "Apocalypse",           // 2
        "Armageddon",           // 3
        "Beast",                // 4
        "Behemoth",             // 5
        "Blight",               // 6
        "Blood",                // 7
        "Bramble",              // 8
        "Brimstone",            // 9
        "Brood",                // 10
        "Carrion",              // 11
        "Cataclysm",            // 12
        "Chimeric",             // 13
        "Corpse",               // 14
        "Corruption",           // 15
        "Damnation",            // 16
        "Death",                // 17
        "Demon",                // 18
        "Dire",                 // 19
        "Dragon",               // 20
        "Dread",                // 21
        "Doom",                 // 22
        "Dusk",                 // 23
        "Eagle",                // 24
        "Empyrean",             // 25
        "Fate",                 // 26
        "Foe",                  // 27
        "Gale",                 // 28
        "Ghoul",                // 29
        "Gloom",                // 30
        "Glyph",                // 31
        "Golem",                // 32
        "Grim",                 // 33
        "Hate",                 // 34
        "Havoc",                // 35
        "Honour",               // 36
        "Horror",               // 37
        "Hypnotic",             // 38
        "Kraken",               // 39
        "Loath",                // 40
        "Maelstrom",            // 41
        "Mind",                 // 42
        "Miracle",              // 43
        "Morbid",               // 44
        "Oblivion",             // 45
        "Onslaught",            // 46
        "Pain",                 // 47
        "Pandemonium",          // 48
        "Phoenix",              // 49
        "Plague",               // 50
        "Rage",                 // 51
        "Rapture",              // 52
        "Rune",                 // 53
        "Skull",                // 54
        "Sol",                  // 55
        "Soul",                 // 56
        "Sorrow",               // 57
        "Spirit",               // 58
        "Storm",                // 59
        "Tempest",              // 60
        "Torment",              // 61
        "Vengeance",            // 62
        "Victory",              // 63
        "Viper",                // 64
        "Vortex",               // 65
        "Woe",                  // 66
        "Wrath",                // 67
        "Light's",              // 68
        "Shimmering"            // 69  
        };
    }


    void initNameSuffixes()
    {
        nameSuffixes = new string[]
        {
        "",                      //0
        "Bane",                 // 1
        "Root",                 // 2
        "Bite",                 // 3
        "Song",                 // 4
        "Roar",                 // 5
        "Grasp",                // 6
        "Instrument",           // 7
        "Glow",                 // 8
        "Bender",               // 9
        "Shadow",               // 10
        "Whisper",              // 11
        "Shout",                // 12
        "Growl",                // 13
        "Tear",                 // 14
        "Peak",                 // 15
        "Form",                 // 16
        "Sun",                  // 17
        "Moon"                  // 18
        };
    }

    int LootRandom(string input)
    {
        int randomValue = input.GetHashCode();

        return randomValue;
    }

    public int[] Pluck(int tokenId, string keyPrefix, string[] sourceArray)
    {
        int[] components = new int[5];

        //This is an approximation of the solidity code, just getting an int from combo of tokenID and keyprefix's hash
        int rand = Mathf.Abs(LootRandom(tokenId.ToString() + keyPrefix));

        Debug.Log("Rand is " + rand);

        for (int i = 0; i < components.Length; i++)
        {
            Debug.Log("components " + i + " is: " + components[i]);
        }

        components[0] = rand % sourceArray.Length;
        components[1] = 0;
        components[2] = 0;

        int greatness = rand % 21;

        if (greatness > 14)
        {
            components[1] = (rand % suffixes.Length) + 1;
        }
        if (greatness >= 19)
        {
            components[2] = (rand % namePrefixes.Length) + 1;
            components[3] = (rand % nameSuffixes.Length) + 1;
        }

        if (greatness == 19)
        {
            // ...
        }
        else
        {
            components[4] = 1;
        }

        return components;
    }


    void OnEnable()
    {
        InitWeapons();
        InitChestArmor();
        InitFootArmor();
        InitNamePrefixes();
        InitHandArmor();
        InitHeadArmor();
        InitNecklaces();
        InitSuffixes();
        InitRings();
        InitWaistArmor();
        initNameSuffixes();

        ExampleTestFunction();
    }

    public void ExampleTestFunction()
    {
        int randomizeFakeTokenID = Random.Range(0, 9999);

        string example = PluckAndBuildString(randomizeFakeTokenID, "test", weapons);
        Debug.Log("example weapon String is " + example);
    }

    public string PluckAndBuildString(int tokenID, string keyPrefix, string[] sourceArray)
    {
        int[] returnedIds = Pluck(tokenID, keyPrefix, sourceArray);
        string builtString = BuildItemFromReturnedInts(returnedIds, sourceArray);
        
        return builtString;
    }

    string BuildItemFromReturnedInts(int[] components, string[] mainItemComponents)
    {
        string outputString = "";

        if (components[2] != 0)
        {
            outputString = namePrefixes[components[2]];
        }

        outputString += " " + mainItemComponents[components[0]];

        if (components[1] != 0)
        {
            outputString += " " + suffixes[components[1]];
        }

        if (components[3] != 0)
        {
            outputString = namePrefixes[components[2]] + " " + mainItemComponents[components[0]] + " " + suffixes[components[1]];
        }

        return outputString;
    }

}
