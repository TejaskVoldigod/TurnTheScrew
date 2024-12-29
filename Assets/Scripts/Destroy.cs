using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Method to be called by UnityEvent
    public void DestroyGameObject()
    {
        if(hingeJoint2D==null)
        {
            return;
        }
        Destroy(hingeJoint2D);
        if(hingeJoint2D2==null)
        {
            return;
        }
        Destroy(hingeJoint2D2);
    }

    public HingeJoint2D hingeJoint2D;
    public HingeJoint2D hingeJoint2D2;
}
