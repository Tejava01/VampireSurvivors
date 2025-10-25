using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    public GameObject Target;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (Target == null)
            return;

        transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y, -10);
    }
}
