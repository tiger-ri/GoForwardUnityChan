using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;
    
    // AudioClip�Đ��p
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        //AodioSource�R���|�[�l���g���擾
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    // �Ԃ��������ɉ���炷
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("CubeTag"))
        {
            audiosource.Play();
        }

        if (collision.gameObject.CompareTag ("GroundTag"))
        {
            audiosource.Play();
        }
    }
}
