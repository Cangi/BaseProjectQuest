using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using Microsoft.MixedReality.Toolkit.UI;

public class ButtonEvents : MonoBehaviour, IMixedRealityInputActionHandler
{
    void Start()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityInputActionHandler>(this);
    }

    public void OnActionStarted(BaseInputEventData eventData)
    {
        Debug.Log(eventData.MixedRealityInputAction.Description);
        if(eventData.MixedRealityInputAction.Description == "Trigger")
        {
            Debug.Log("Yeeee you clicked the trigger");
        }
    }
    public void OnActionEnded(BaseInputEventData eventData)
    {

    }
}
