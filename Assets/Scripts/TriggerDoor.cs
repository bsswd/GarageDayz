using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] GameObject _targetDoor;

    void OnTriggerEnter(Collider other)
    {
        _targetDoor.transform.localRotation = new Quaternion(-90,0,0,0);
    }
}
