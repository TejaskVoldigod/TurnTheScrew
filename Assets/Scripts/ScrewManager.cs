using UnityEngine;

namespace DefaultNamespace
{
    public class ScrewManager : MonoBehaviour
    {
        private Port previousPort;
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                
                RaycastHit2D hit =  Physics2D.Raycast(ray.origin, ray.direction);
                
                if(hit.collider == null) return;

                if (hit.transform.TryGetComponent(out Port port))
                {
                    if (port.HasScrew)
                    {
                        previousPort = port;
                    }
                    else
                    {
                        
                        port.AddScrew(previousPort.GetScrew);
                        previousPort.RemoveScrew();

                    }
                    
                }
                
            }
        }
    }
}