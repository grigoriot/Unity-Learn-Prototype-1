using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public string switchKey;
    
    public GameObject player;
    
    
    [SerializeField]
    private Vector3 offset1 = new Vector3(0f, 5f, -7f);
    [SerializeField]
    private Vector3 rotation1 = new Vector3(21.3f, 0f, 0f);
    
    [SerializeField]
    private Vector3 offset2 = new Vector3(0f, 2f, 1.34f);

    private Vector3 offset = new Vector3(0f, 0f, 0f);

    private bool firstPerson = false;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = offset1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
            firstPerson = !firstPerson;

        if (firstPerson)
        {
            offset = offset2;
        }
        else
        {
            offset = offset1;
        }
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (firstPerson)
            transform.rotation = player.transform.rotation;
        else
            transform.rotation = Quaternion.Euler(rotation1);
    }
}
