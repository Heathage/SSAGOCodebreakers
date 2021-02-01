using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codenames : MonoBehaviour
{
    public List<string> words = new List<string> {"Chickpeas", "Pasties", "Scouts", "Guides", "Penny", "Patsy", "Necker", "Blue", "Discord", "Taskmaster", "Laughing", "Group", "Rally",
        "Crouching", "Memes", "Chaos", "Murderers", "Evil", "Chaotic", "Megalomaniac", "Dedicated", "Bickering", "Argumentative", "Distracted", "Fun", "Nerds", "Reading", "Adverts", "Media",
        "Plants", "Brands", "Quirky", "Questionable", "Closed", "Green", "Modern", "Concrete", "Mining", "Greenery", "History", "Brutalist", "Small", "Hilly", "Construction", "Steps", "Stairs", "Dogs",
        "Woods", "Hill", "Open", "Interconnected", "Fields", "Research", "Blocky", "Fish", "Creepers", "Flying", "Drowning", "Cornhole", "Lava", "Bees", "Diamonds", "Cantina", "Ewok", "Skywalker",
        "Mandalorian", "Vader", "Tatooine", "Lightsaber", "Jedi", "Sith", "Space", "Podracer", "Force", "Sand", "Yoda", "Incest", "Doctor", "Tardis", "Timelord", "Dalek", "Regeneration", "Cybermen",
        "Titanic", "Slitheen", "Torchwood", "Trenzalore", "Rose", "Master", "Forklift", "River", "Martha", "Ace", "Pandorica", "Vortex", "Gallifrey", "UNIT", "K9", "Whovians", "Exterminate",
        "Exterminatus", "James", "Painting", "D6", "Warhammer", "Terminator", "Captain", "Chaplain", "Lieutenant", "Orks", "Marines", "Emperor", "Pond", "Tadpole", "Poison", "Green", "Kermit", "Ribbit"
            , "Lilies", "Jam", "School", "Netball", "Round", "Fluffy", "Claws", "Murder", "Guts", "Catnip", "Cute", "Bitey", "Shoebox", "Precarious", "Edges", "Warm", "Purry", "Judgemental"};

    public List<string> wordChoosing = new List<string>();

    public int random;

    public int NumberOfWords = 25;

    private void Awake()
    {
        WordList();
    }

    public void WordList()
    {
        for (int i = 0; i < NumberOfWords; i++)
        {
            PickWord();
        }
    }

    public void PickWord()
    {
        random = Random.Range(0, words.Count);
        wordChoosing.Add(words[random]);
        words.RemoveAt(random);
    }

}
