using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {


	void Update () {
        
	}

    // This function will allow the enemy to decide what action to take
    public void DecideWhatToDo()
    {
        /* if (enemyHP > 50%) {
        *       EnemyAttac();
        *   }
        *   else {
        *       EnemyDefend();
        *   }
        */
    }

    public void EnemyAttack()
    {
        TurnBasedCombatStateMachine.usedAbility = GameInformation.enemyMoveOne;
        TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.DAMAGECALCULATION;
    }
}
