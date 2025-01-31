using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MyGrabScript : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    void OnEnable()
    {
        grabInteractable.onSelectEntered.AddListener(GrabStart);
        grabInteractable.onSelectExited.AddListener(GrabEnd);
    }

    void GrabStart(XRBaseInteractor interactor)
    {
        // Handle grab start
    }

    void GrabEnd(XRBaseInteractor interactor)
    {
        // Handle grab end
    }

    void OnDisable()
    {
        grabInteractable.onSelectEntered.RemoveListener(GrabStart);
        grabInteractable.onSelectExited.RemoveListener(GrabEnd);
    }
}
