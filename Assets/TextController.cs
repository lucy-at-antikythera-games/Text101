using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {begin, cell, sheets_0, lock_0, mirror, cell_mirror, sheets_1, lock_1,
						corridor_0, stairs_0, closet_door, floor, corridor_1, stairs_1, in_closet,
						corridor_2, stairs_2, corridor_3, courtyard};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.begin;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.begin) {
			state_begin ();
		}
		else if (myState == States.cell) {
			state_cell ();
		}
		else if (myState == States.sheets_0) {
			state_sheets_0 ();
		}
		else if (myState == States.lock_0) {
			state_lock_0 ();
		}
		else if (myState == States.mirror) {
			state_mirror ();
		}
		else if (myState == States.cell_mirror) {
			state_cell_mirror ();
		}
		else if (myState == States.sheets_1) {
			state_sheets_1 ();
		}
		else if (myState == States.lock_1) {
			state_lock_1 ();
		}
		else if (myState == States.corridor_0) {
			state_corridor_0 ();
		}
		else if (myState == States.stairs_0) {
			state_stairs_0 ();
		}
		else if (myState == States.closet_door) {
			state_closet_door ();
		}
		else if (myState == States.floor) {
			state_floor ();
		}
		else if (myState == States.corridor_1) {
			state_corridor_1 ();
		}
		else if (myState == States.stairs_1) {
			state_stairs_1 ();
		}
		else if (myState == States.in_closet) {
			state_in_closet ();
		}
		else if (myState == States.corridor_2) {
			state_corridor_2 ();
		}
		else if (myState == States.stairs_2) {
			state_stairs_2 ();
		}
		else if (myState == States.corridor_3) {
			state_corridor_3 ();
		}
		else if (myState == States.courtyard) {
			state_courtyard ();
		}

	}

	void state_begin () {
		text.text = "A text adventure game coded by Lucy for a Udemy course\n\n" +
					"Release 0 | Unity 5.6.4f1\n\n" +
					"Press SPACE to begin";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.cell;
		}

	}

	void state_cell () {
		text.text = "Congratulations! Through a series of misadventures, bad luck, and even " +
		"worse decisions, you find yourself on the wrong side of some jail bars. " +
		"Like a bad chick flick cliche, you're staring at the mirror. " +
		"Your ugly mug stares back. Behind her, a messy pile of dirty sheets " +
		"engulfs the cot. Behind that, the door, locked from the outside, mocks you.\n\n" +
		"Examine the [S]heets, the [M]irror, or the [L]ock on the door?\n\n" +
		"(Press the letter in [brackets] to make your choice.)";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		}
		else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}
		else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		}

	}

	void state_sheets_0 () {
		text.text = "While the hourly patrol has come and gone, the daily room inspection " +
					"is not for several hours. You sigh at the state of your bed and make " +
					"a mental note to do it before inspection...until you remember you're " +
					"getting the hell out of Dodge before then. Suck it, prison!\n\n" +
					"You riff through the sheets. Only thing underneath is the cot. [R]eturn " +
					"to the cell proper.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}

	}

	void state_lock_0 () {
		text.text = "You slow your breathing and try to get a good listen of your environment. " +
					"The cat's away, it seems, leaving the mouse to stride swiftly and silently " +
					"to the door. A gentle tug, and the door resists your wishes. Locked. What'd you " +
					"expect? To find greasy prints all over the keypad lock? ...wait, a sec. " +
					"Perhaps if you [R]eturn to inspect your cell more closely, you may find " +
					"something to help you with that...";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}

	}

	void state_mirror () {
		text.text = "Look, it's not like you're carrying anything. And this thing isn't exactly " +
					"glued to the wall. Worst comes to worst, you can shove it at the guard. " +
					"Maybe seeing his own reflection will scare him enough for him to, well, " +
					"forget that you're on the other side of the bars. At least, [T]aking it " +
					"won't make you any more of a criminal than you already are, haha. Or just " +
					"leave it and [R]eturn to your cell";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}

	}

	void state_cell_mirror () {
		text.text = "You're standing in your cell like an idiot with a mirror in your hands. " +
					"What now? Examine the [S]heets again? Or maybe the [L]ock?";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		}
		else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}

	}

	void state_sheets_1 () {
		text.text = "...dang, how'd you sleep in this garbage fire without getting a bad rash? " +
					"Anyway, you're determined not to waste the eve of your escape tucking this " +
					"mirror in. It doesn't need sleep. Or it might get a rash, and that wouldn't " +
					"do. No, not at all. Perhaps you should [R]eturn to plotting your escape.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}

	}

	void state_lock_1 () {
		text.text = "If you really, absolutely, assuredly feel that you've missed something, " +
					"you could always [R]eturn to your cell to check. But who're you kidding? " +
					"The mirror's reflecting a little circle of light on the lock's keypad " +
					"Luckily, you're not a cat, so you don't get so distracted that you miss " +
					"the fingerprints. A few tries later, you've managed to guess the combo. " +
					"[O]pen sesame, baby!";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.corridor_0;
		}

	}

	void state_corridor_0 () {
		text.text = "You leave the mirror behind and sneak out. The gate clicks shut behind you. " +
					"Heart thudding in chest, you realize there's no going back now. At the end of " +
					"the corridor are two doors. The one to the left bears a placard marked " +
					"\"[S]TAIRS\". The other is unadorned - probably a [C]loset. You know, the " +
					"[F]loor looks unusually shiny, too, for that matter.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		}
		else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.closet_door;
		}
		else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.floor;
		}

	}

	void state_stairs_0 () {
		text.text = "You're desperate, but not that desperate. You go up the stairs now, looking " +
					"like...well, an escaped inmate, you're going right back where you belong. " +
					"No dice. [R]eturning to the corridor is your best bet for now.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}

	}

	void state_closet_door () {
		text.text = "You stride up to the unlabeled door and twist the knob, only to hear the click, " +
					"click of futility in your palm. You kneel down, knob at eye level. " +
					"Normal lock with a key. Pickable...if only you had the right tools. No choice but " +
					"to [R]eturn to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}

	}

	void state_floor () {
		text.text = "In contrast to your old bed sheets (good riddance!), the corridor floor " +
					"is impeccable. But the real reasons it's shiny is becaue there's a nice " +
					"bobby pin [H]airclip on the floor you can take. Or, if you think that's not " +
					"worth your kleptomania, you can [R]eturn to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
		else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.corridor_1;
		}

	}

	void state_corridor_1 () {
		text.text = "You're standing in the corridor like an idiot with a hairclip in your hands. " +
					"What now? Try the [S]tairs again? Or [P]ick the closet door?";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		}
		else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.in_closet;
		}

	}

	void state_stairs_1 () {
		text.text = "You're neither an idiot, nor blind, nor a blind idiot. You still look like " +
					"24601. And if Javert's not patrolling the stairs, he's damned close. Or " +
					"she. Or they. Plenty of women and non-binary folk working in corrective " +
					"services nowadays. You'd cheer for gender equality if you weren't currently " +
					"on the wrong end of justice. Anyway, stop wasting time and [R]eturn to finding " +
					"a way out undetected.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_1;
		}

	}

	void state_in_closet () {
		text.text = "You (mentally, or else the guards will hear) hum the Mission Impossible " +
					"as you open the door duck inside. On a hook on the far wall is a cleaner's " +
					"uniform in just your size. [D]ress yourself in it or [R]eturn outside.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}
		else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.corridor_3;
		}

	}

	void state_corridor_2 () {
		text.text = "You abandon the uniform and step outside...but the siren call of the " +
					"uniform still beckons you. Heed it and go [B]ack into the closet? Or " +
					"make a break for the [S]tairs?";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_2;
		}
		else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.in_closet;
		}

	}

	void state_stairs_2 () {
		text.text = "You look back, one last time, on the eve of your escape.\n\n" +
					"...blast. You've left the closet door open. Not exactly the picture " +
					"of inconspicuous escape, are you? Your brain must be as dry as the " +
					"remainder biscuit after voyage. You know what? Just [R]eturn to " +
					"the damned corridor before you do something even more stupid.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}

	}

	void state_corridor_3 () {
		text.text = "You don the uniform and step outside...but you look ridiculous. You're " +
					"not a cleaner. Mopping up barf and sweeping floors is beneath you! Plus, the " +
					"uniform makes you look fat. Go back into the closet and [U]ndress? Or " +
					"make a break for the [S]tairs?";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.courtyard;
		}
		else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.in_closet;
		}

	}

	void state_courtyard () {
		text.text = "After a quick trip to the closet to grab a push broom, you whistle " +
					"and take a few swipes at the stairs in case any guards around are " +
					"on high alert. You make it up to the open courtyard undisturbed. " +
					"No gates, no guards, just freedom.\n\n" +
					"Congrats! You've successfully escaped! [P]lay again?";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}

	}


}
