using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdjustment : MonoBehaviour {

    // Take DamageCalculation class
    // Adjust Health of Player and Enemy

    public int playerHP = 100;  // Remove later
    public int enemyHP = 100;   // Remove later

    private int damageDone;

    private BaseAbilities usedAbility;

    private DamageCalculation damageCalc = new DamageCalculation();

    public int DamageEnemyHealth(BaseAbilities usedAbility)
    {
        damageDone = (int)damageCalc.DamageFormula(usedAbility);
        enemyHP -= damageDone;

        if(enemyHP < 0)
        {
            enemyHP = 0;
        }
        
        Debug.Log("Enemy Health: " + enemyHP);
        return enemyHP;
    }

    public int DamagePlayerHealth(BaseAbilities usedAbility)
    {
        damageDone = (int)damageCalc.DamageFormula(usedAbility);
        playerHP -= damageDone;

        if (playerHP < 0)
        {
            playerHP = 0;
        }

        Debug.Log("Player Health: " + playerHP);
        return playerHP;
    }
}
