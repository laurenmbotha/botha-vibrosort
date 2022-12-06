using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BinCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public ObjectCategory binCategory = ObjectCategory.Concrete;
    public Scoreboard sb;
    public HapticsManager hM;
    public OVRInput.Controller controller;
    

    private void OnTriggerEnter(Collider other) {
        HapticInteractable currentHapticObject = other.gameObject.GetComponent<HapticInteractable>();
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            sb.DecreaseObjectsLeft();
            if (other.gameObject.GetComponent<SortInteractable>().GetCategory() == binCategory) {
                sb.IncreaseCorrectScore();
                if (binCategory == ObjectCategory.Concrete)
                {
                    OVRInput.SetControllerVibration(.2f, .2f, OVRInput.Controller.LTouch);

                }
                if (binCategory == ObjectCategory.Alien)
                {
                    OVRInput.SetControllerVibration(.4f, .4f, OVRInput.Controller.LTouch);

                }
                if (binCategory == ObjectCategory.Squishy)
                {
                    OVRInput.SetControllerVibration(.6f, .6f, OVRInput.Controller.LTouch);
                }
                if (binCategory == ObjectCategory.Chalky)
                {
                    OVRInput.SetControllerVibration(.8f, .8f, OVRInput.Controller.LTouch);
                }
                if (binCategory == ObjectCategory.Bruisy)
                {
                    OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.LTouch);
                }
            }
        }
        else
        {
            if (binCategory == ObjectCategory.Concrete)
            {
                OVRInput.SetControllerVibration(.2f, .2f, OVRInput.Controller.LTouch);

            }
            if (binCategory == ObjectCategory.Alien)
            {
                OVRInput.SetControllerVibration(.4f, .4f, OVRInput.Controller.LTouch);

            }
            if (binCategory == ObjectCategory.Squishy)
            {
                OVRInput.SetControllerVibration(.6f, .6f, OVRInput.Controller.LTouch);
            }
            if (binCategory == ObjectCategory.Chalky)
            {
                OVRInput.SetControllerVibration(.8f, .8f, OVRInput.Controller.LTouch);
            }
            if (binCategory == ObjectCategory.Bruisy)
            {
                OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.LTouch);
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            sb.IncreaseObjectsLeft();
            if(other.gameObject.GetComponent<SortInteractable>().GetCategory() == binCategory) {
                sb.DecreaseCorrectScore();
            }
        }
    }

}