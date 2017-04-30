using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMenuGUI : MonoBehaviour {

    // DamageFormula variables -- ORGANIZE LATER
    private int totalDamageDone;
    private BaseAbilities usedAbility;


    void Start () {
		// Load Health

	}
	
	void Update () {
		// Update Health

	}

    // Battle Menu GUI
    // Hides Attack options when it is not the player's turn
    void OnGUI()
    {
        if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleState.PLAYERTURN)
        {
            DisplayPlayerChoice();
        }
    }

    // Attack Button
    private void DisplayPlayerChoice()
    {
        if (GUI.Button(new Rect(Screen.width - 250, Screen.height - 50, 100, 30), GameInformation.playerMoveOne.AbilityName))
        {
            PlayerAttack();
            TurnBasedCombatStateMachine.usedAbility = GameInformation.playerMoveOne;   
        }
    }

    // Function for: Player Attack - Sends to BattleState Damage Calculation to damage target
    void PlayerAttack()
    {       
        // Attack Animation here?
        TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleState.DAMAGECALCULATION;
    }
}
