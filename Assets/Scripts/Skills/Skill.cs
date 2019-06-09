using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that represents every data about a skill
[CreateAssetMenu(fileName = "New", menuName = "New", order = 1)]
public class Skill : ScriptableObject {
	public GameObject uiIcon;

	public SkillAction action;
}
