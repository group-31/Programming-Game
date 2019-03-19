using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funtionFile : MonoBehaviour
{

    // -- Basic movement functions --

    public void wait()
    {
        // function to allow entity to wait a given time

    }

    // -- Attack functions --

    public void silentTakedown()
    {
        // function to allow a silent takedown
        /*
         * Check if killable entity is in front of current entity
         * If not display hint that action cant be taken (speech bubble with ooops)
         * Check if killable entity can be taken out with this action
         * If not run failedKill function
         * Perform action on entity
         * Display kill animation with a death animation
         * Limited noise on this kill
         * Display dead corpse on floor
         * End of function
        */ 
    }

    public void swordTakedown()
    {
        // function to allow a sword takedown
        /*
         * Check if killable entity is in front of current entity
         * If not display hint that action cant be taken (speech bubble with ooops)
         * Check if killable entity can be taken out with this action
         * If not run failedKill function
         * Perform action on entity
         * Display kill animation with a death animation
         * Output noise for this kill
         * Display dead corpse on floor
         * End of function
         */
    }

    public void failedKill()
    {
        // function to allow a failed kill to be ran

    }

    // -- Ai functions --

    public void eyeSight()
    {
        // function to set vision distance

    }

}
