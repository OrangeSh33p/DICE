using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that represents the action a skill allows the player to do
public abstract class SkillAction : MonoBehaviour {
	public void Use () {
		_Use ();
	}

	protected abstract void _Use ();
}