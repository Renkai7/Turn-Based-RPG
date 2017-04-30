using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    

    // DamageFormula variables -- REMOVE LATER
    public static BaseAbilities usedAbility;
    public string currentUser;
    private HealthAdjustment healthAdj = new HealthAdjustment();
    private static BaseAbilities playerMoveOne = new NormalAttack();
    private EnemyAI enemyAI = new EnemyAI();

    public enum BattleState
    {
        PLAYERTURN,
        ENEMYTURN,
        DAMAGECALCULATION,
        VICTORY,
        LOSE
    }

    public static BattleState currentState;

	// Use this for initialization
	void Start () {
        currentState = BattleState.PLAYERTURN;
	}
	
	
	void Update () {

        Debug.Log(currentState);

        switch (currentState)
        {
            case (BattleState.PLAYERTURN):  // Player chooses action
                currentUser = "player";

                break;

            case (BattleState.ENEMYTURN):   // Enemy chooses action
                // Enemy AI here
                currentUser = "enemy";

                // EnemyAI();
                enemyAI.EnemyAttack();
                break;

            case (BattleState.DAMAGECALCULATION):   // Calculate done to Enemy & Player

                // Check to see who is the current user (ie. Player or Enemy)
                // Calculate Damage done
                // Then change user and BattleState

                if(currentUser == "player")
                {
                    healthAdj.DamageEnemyHealth(usedAbility);
                    if (healthAdj.enemyHP == 0)
                    {
                        currentState = BattleState.VICTORY;
                    }
                    else
                    {
                        currentState = BattleState.ENEMYTURN;
                    }
                }

                if(currentUser == "enemy")
                {
                    healthAdj.DamagePlayerHealth(usedAbility);
                    if (healthAdj.playerHP == 0)
                    {
                        currentState = BattleState.LOSE;
                    }
                    else
                    {
                        currentState = BattleState.PLAYERTURN;
                    }
                }
                break;

            case (BattleState.VICTORY):
                // Reward EXP, Gold, etc.
                Debug.Log("You gain 100 exp!"); // Testing Victory message -- DELETE LATER
                break;

            case (BattleState.LOSE):
                // Game Over
                break;
        }    
    
	}

    

}
