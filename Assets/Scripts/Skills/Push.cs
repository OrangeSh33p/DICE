using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : SkillAction {
	public float speed = 50;
	public float duration = 0.1f;
	protected override void _Use() {

		GameObject rock = CharacterManager.instance.rockPusher.ClosestRock();
		if (rock) StartCoroutine(MoveRock (rock));
	}

	private IEnumerator MoveRock (GameObject go) {
		CharacterManager.instance.canMove = false;
		float timeLeft = duration;
		Vector3 direction = go.transform.position - CharacterManager.instance.transform.position;

		while (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			go.transform.position += direction*Time.deltaTime*speed;
			yield return new WaitForEndOfFrame();
		}

		CharacterManager.instance.canMove = true;
	}
}
