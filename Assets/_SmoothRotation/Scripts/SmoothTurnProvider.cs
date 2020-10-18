using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SmoothTurnProvider : LocomotionProvider
{
    // How much do we turn?

    // How long does it take to turn?

    // Basic input - I'd recommend replacing with an input solution.

    // List of the controllers we're going to use

    // The amount we're turning to

    private void Update()
    {
        // Let's ask the locomotion system if we can move
    }

    private void CheckForTurn()
    {
        // Go through the controllers

        // Check for input, return the segment with positive or negative 

        // If we actually got a value from input, try to turn
    }

    // Check for input, this can be done cleaner with a more robust input solution
    private float CheckForTurn(XRController controller)
    {
        // Check if we pressed right

        // Check if we pressed left

        // If we hit nothing return 0
        return 0.0f;
    }

    private void TrySmoothTurn()
    {
        // Let's stry turning with the amount we got

        // Since the value has been used, let's clear it out
    }

    private IEnumerator TurnRoutine(float turnAmount)
    {
        // We need to store this since we only want to pass the difference

        // Record the whole time of the loop for proper lerp

        // Let the motion begin

        // How far are we into the lerp?

        // Figure out the difference and apply it

        // Save the current amount we've moved, and add to elapsed time

        // Yield or we're crashing
        yield return null;

        // Let the motion end
    }
}
