using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour {
	public void AddSkill (Skill skill) {
		CharacterManager.instance.currentSkill = skill.action;
	}

	public void RemoveSkill () {
		CharacterManager.instance.currentSkill = null;
	}
}
