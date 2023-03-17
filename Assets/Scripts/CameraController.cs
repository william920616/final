using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target; // �l�ܪ��ؼС]�bUnity���즲���w�^
    private Vector3 offset; // �P�ؼЪ��y�Юt��

    void Start()
    {
        // �C���}�l�ɡA���p��ۤv�P�ؼЪ��y�Юt���A���x�s�_��
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        // �C������ɡA�@���N�ۤv�y�г]���G�ؼЮy�� + �t����
        transform.position = target.transform.position + offset;
    }
}
