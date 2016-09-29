using UnityEngine;
using System.Collections;

public class MeleeMovement : MonoBehaviour 
{
	public Animation anim;

	void Start () 
	{
		anim = GetComponent<Animation>();
		foreach (AnimationState state in anim) 
		{
			state.speed = 0.5F;
		}
	}

	void Update ()
	{
		if(Input.GetKeyDown("+"))
    	{
       		anim.Play("standing_melee_attack_downward", PlayMode.StopAll);
     	}
	}
}
