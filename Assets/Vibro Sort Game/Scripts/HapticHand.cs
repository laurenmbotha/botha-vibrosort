using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticHand : MonoBehaviour
{

    public HapticsManager hM;
    public OVRInput.Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Haptic")) {
            HapticInteractable currentHapticObject = other.gameObject.GetComponent<HapticInteractable>();
            if (controller == OVRInput.Controller.LTouch) {
                hM.LeftHapticsBuffer_amp = currentHapticObject.GetHapticBufferAmplitudes();
                hM.LeftHapticsBuffer_freq = currentHapticObject.GetHapticBufferFrequencies();
                hM.leftHapticLoop = currentHapticObject.GetIsLoopable();
                hM.leftHapticStartTime = Time.time;
            } else if (controller == OVRInput.Controller.RTouch) {
                hM.RightHapticsBuffer_amp = currentHapticObject.GetHapticBufferAmplitudes();
                hM.RightHapticsBuffer_freq = currentHapticObject.GetHapticBufferFrequencies();
                hM.rightHapticLoop = currentHapticObject.GetIsLoopable();
                hM.rightHapticStartTime = Time.time;
            }
        }
        if (other.gameObject.tag == "bin0")
        {
            OVRInput.SetControllerVibration(.2f, .2f, OVRInput.Controller.RTouch);
        }
        if (other.gameObject.tag == "bin1")
        {
            OVRInput.SetControllerVibration(.4f, .4f, OVRInput.Controller.RTouch);
        }
        if (other.gameObject.tag == "bin2")
        {
            OVRInput.SetControllerVibration(.6f, .6f, OVRInput.Controller.RTouch);
        }
        if (other.gameObject.tag == "bin3")
        {
            OVRInput.SetControllerVibration(.8f, .8f, OVRInput.Controller.RTouch);
        }
        if (other.gameObject.tag == "bin4")
        {
            OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.RTouch);
        }
    }
    private void OnTriggerExit(Collider other) {
        hM.End(controller);
    }
}
