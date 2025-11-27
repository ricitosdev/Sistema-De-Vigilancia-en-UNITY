using UnityEngine;

public class SecutiryCamera_cntrl : MonoBehaviour
{
    [Header("Referencias")]
    public Transform player;
    public bool sinRaycast;

    [Header("Parámetros de visión")]
    public float visionRange = 10f;
    public float rotationSpeed = 2f;

    [Header("Extras (opcional)")]
    public Light alertLigth;
    public Color normalColor = Color.green;
    public Color alerColor = Color.red;

    private bool playerDetect = false;
    void Update()
    {
        detectPlayer();
        updateCameraRotation();
    }

    private void detectPlayer()
    {
        Vector3 direction = player.position - transform.position;
        
        if(direction.magnitude <= visionRange)
        {
            if (sinRaycast)
            {
                playerDetect = true;
                return;
            }
            RaycastHit hit;

            if(Physics.Raycast(transform.position, direction.normalized, out hit, visionRange))
            {
                Debug.DrawRay(transform.position, direction);
                if (hit.transform.CompareTag("Player"))
                {
                    playerDetect = true;
                    Debug.DrawRay(transform.position, direction, Color.red);
                    return;
                }
            }
        }

        playerDetect = false;
    }

    private void updateCameraRotation()
    {
        if (playerDetect)
        {
            Vector3 direction = player.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction + new Vector3(0, 90, 0));
            /*Quaternion lookrotation = Quaternion.LookRotation(direction + new Vector3(0,90,0));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * rotationSpeed);*/

            if (alertLigth != null)
            {
                alertLigth.color = alerColor;
            }
        }
        else
        {
            alertLigth.color = normalColor;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRange);
    }
}
