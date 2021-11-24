using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class climbInteractable : XRBaseInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)

    {

        XRBaseInteractor interactor = args.interactor;

        base.OnSelectEntered(args);



        if (interactor is XRDirectInteractor)

        {

            Climbing.climbingHand = interactor.GetComponent<ActionBasedController>();

        }

    }



    protected override void OnSelectExited(SelectExitEventArgs args)

    {

        XRBaseInteractor interactor = args.interactor;

        base.OnSelectExited(args);



        if (Climbing.climbingHand && Climbing.climbingHand.name == interactor.name)

        {

            Climbing.climbingHand = null;

        }

    }



}
