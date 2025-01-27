using UnityEngine;

public class ObjectCarry : MonoBehaviour {
    public GameObject objectToCarry;

    void Update() {
        if (objectToCarry == null) {
            return;
        }

        objectToCarry.transform.SetPositionAndRotation(transform.position, transform.rotation);
    }
}
