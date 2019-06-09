using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : SkillAction {
	public float speed = 5;
	public float duration = 1;

	protected override void _Use() {
		StartCoroutine (_Dash());
	}

	private IEnumerator _Dash () {
		CharacterManager.instance.canMove = false;
		float timeLeft = duration;
		Vector3 direction = CharacterManager.instance.transform.forward;

		while (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			CharacterManager.instance.transform.position += direction*Time.deltaTime*speed;
			yield return new WaitForEndOfFrame();
		}

		CharacterManager.instance.canMove = true;
	}
}