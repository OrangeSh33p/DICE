using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPusher : MonoBehaviour {
	private List<Rock> rocks = new List<Rock>();
	private void OnTriggerEnter (Collider go) {
		if (go.GetComponent<Rock>()) rocks.Add(go.GetComponent<Rock>());
	}

	private void OnTriggerExit (Collider go) {
		if (go.GetComponent<Rock>()) rocks.Remove(go.GetComponent<Rock>());
	}

	public GameObject ClosestRock () {
		if (rocks.Count == 0) return null;
		return rocks[0].gameObject;
	}
}
