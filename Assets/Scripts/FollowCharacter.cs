using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour {
	public CharacterManager characterManager;

	private Vector3 positionOffset;

	private void Start () {
		positionOffset = transform.position - characterManager.transform.position;
	}

	private void Update () {
		transform.position = characterManager.transform.position + positionOffset;
	}
}