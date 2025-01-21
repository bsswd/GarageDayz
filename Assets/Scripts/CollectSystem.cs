using UnityEngine;

public class CollectSystem : MonoBehaviour
{
    [SerializeField] private Camera characterCamera;
    [SerializeField] private Transform hand;
    
    private CollectableItem _itemInHand;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = characterCamera.ScreenPointToRay(Input.GetTouch(0).position);
            print("Hallo");
        }
    }
}
