using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchTo2D());
    }

    // Update is called once per frame
    IEnumerator SwitchTo2D() {
        string desiredDevice = "";
        if (string.Compare(XRSettings.loadedDeviceName, desiredDevice, true) != 0) {
            XRSettings.LoadDeviceByName(desiredDevice);
            yield return null;
        }
        XRSettings.enabled = false;
    }

    public void StartXR(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
