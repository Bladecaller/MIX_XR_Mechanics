using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandedGrab : XRGrabInteractable
{
    public XRSimpleInteractable handle;

    private XRBaseInteractor secondInteractor;

    private Quaternion attachIntialRoation;

    void Start()
    {
        handle.selectEntered.AddListener(OnSecondHandGrab);

        handle.selectExited.AddListener(OnSecondHandRelease);
    }
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if (secondInteractor && selectingInteractor)
        {
            selectingInteractor.attachTransform.rotation = Quaternion.LookRotation(secondInteractor.attachTransform.position - selectingInteractor.attachTransform.position);
        }
        base.ProcessInteractable(updatePhase);
    }


    public void OnSecondHandGrab(SelectEnterEventArgs args)
    {
        secondInteractor = args.interactor;

    }

    public void OnSecondHandRelease(SelectExitEventArgs args)
    {
        secondInteractor = null;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {

        base.OnSelectEntered(args);
        attachIntialRoation = args.interactor.attachTransform.localRotation;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        secondInteractor = null;
        args.interactor.attachTransform.localRotation = attachIntialRoation;
    }

    public override bool IsSelectableBy(XRBaseInteractor interactor)
    {
        bool isalreadygrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
        return base.IsSelectableBy(interactor) && !isalreadygrabbed;
    }
}
