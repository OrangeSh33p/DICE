using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {
	public static CharacterManager instance;
	public float speed;
	public bool canMove;
	public SkillAction currentSkill;
	public SkillManager skillManager;

	public Dash dash;
	public GameObject dashIcon;

	public Push push;
	public GameObject pushIcon;

	public RockPusher rockPusher;
	
	private hGamepad gamepad { get { return hinput.gamepad[0]; } }

	private void Awake () {
		if (instance == null) instance = this;
		if (instance != this) Destroy(this);
	}

	private void Update () {
		if (canMove && !gamepad.leftStick.inDeadZone) Move ();

		if (gamepad.A.justPressed) UseSkill ();

		if (gamepad.B.justPressed) ChangeSkill ();

		if (transform.position.y < -0.5f) transform.position = Vector3.up;
	}

	private void Move () {
		transform.position += gamepad.leftStick.worldPositionFlat * Time.deltaTime * speed;
		transform.rotation = Quaternion.Euler(0, -gamepad.leftStick.angle + 90, 0);
	}

	private void UseSkill () {
		currentSkill.Use();
	}

	private void ChangeSkill () {
		if (currentSkill == dash) {
			currentSkill = push;
			dashIcon.SetActive(false);
			pushIcon.SetActive(true);
		}
		else {
			currentSkill = dash;
			pushIcon.SetActive(false);
			dashIcon.SetActive(true);
		}
	}
}
