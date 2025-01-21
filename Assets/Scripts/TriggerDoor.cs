using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] GameObject _targetDoor;

    void OnTriggerEnter(Collider other)
    {
        _targetDoor.transform.localScale = new Vector3(1f, 0.3f, 1f);
    }
}