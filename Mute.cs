using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Mute : MonoBehaviour
{public bool muted = false;

  public void mute ()
	{
	 muted = !muted;
	 if (muted){
 	 AudioListener.volume = 0;
 }
 else if (!muted)
 {
 AudioListener.volume = 1;
 
	}
	
}
}
