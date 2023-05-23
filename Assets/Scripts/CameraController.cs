using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Isn't using currently
public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;

    public float pLerp = 1f;
    public float rLerp = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        offset = Player.transform.localPosition - transform.localPosition;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 targetPos = new Vector3(transform.localPosition.x, transform.localPosition.y, Player.transform.localPosition.z - offset.z);
        transform.localPosition = targetPos;

        /*Quaternion targetRoatiton = Quaternion.Euler(27f, Player.transform.eulerAngles.y, 0f);
        Debug.Log(targetRoatiton.eulerAngles.ToString());
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRoatiton, rLerp);*/

        /*transform.position = Player.transform.position + offset;
        transform.LookAt(Player.transform.position);*/
    }

    private void Update()
    {

    }
}