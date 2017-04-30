using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {


	void Update ()
    {
		
	}

    public static BaseAbilities playerMoveOne = new NormalAttack();
    public static BaseAbilities enemyMoveOne = new EnemyAttack();

}
