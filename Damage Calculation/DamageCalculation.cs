using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculation : MonoBehaviour {

    // Handles Damage formula, Damage Calculation

    private int totalDamageDone;

    public float DamageFormula(BaseAbilities usedAbility)
    {
        // Formula: totalDamageDone = weapon power + stats + ability power       
        totalDamageDone = usedAbility.AbilityDamage;        
        return totalDamageDone;
    }
   
}
