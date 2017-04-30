using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour {
    // Note: SP is energy needed for spells and special attacks

    // Health and SP properties
    

    // Stat properties
    public static int Strength { get; set; }
    public int Magic { get; set; }
    public int Endurance { get; set; }
    public int Agility { get; set; }
    public int Luck { get; set; }
}
