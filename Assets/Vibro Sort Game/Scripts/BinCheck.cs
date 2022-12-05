using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BinCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public ObjectCategory binCategory = ObjectCategory.Concrete;
    public Scoreboard sb;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            sb.DecreaseObjectsLeft();
            if (binCategory == ObjectCategory.Concrete) {
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                Console.WriteLine("entered concrete");
            }
            if (binCategory == ObjectCategory.Squishy) {
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                Console.WriteLine("entered squishy");
            }
            if (binCategory == ObjectCategory.Chalky) {
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                Console.WriteLine("entered chalky");
            }
            if (binCategory == ObjectCategory.Bruisy) {
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);

                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);

                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);

                Console.WriteLine("entered bruisy");
            }
            if (binCategory == ObjectCategory.Alien) {
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(0, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch); ;
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, .5f, OVRInput.Controller.LTouch);
                Console.WriteLine("entered alien");
            }
            if (other.gameObject.GetComponent<SortInteractable>().GetCategory() == binCategory) {
                sb.IncreaseCorrectScore();
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