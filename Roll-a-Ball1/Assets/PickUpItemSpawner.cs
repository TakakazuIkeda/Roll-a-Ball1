using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItemSpawner : MonoBehaviour
{
    // ��������PickUpItem
    public GameObject PickUpItem;
    // ���������
    public int SpawnCount = 0;
    // ��������~�̔��a
    // public float SpawnCircleRadius = 3f;
    // Start is called before the first frame update
    public List<Transform> SpawnPositions = new List<Transform>();

    // PickUpItem�ɓn��SESoundManager
    public SESoundManager SESoundManager;

    public float SpawnCircleRadius { get; private set; }

    private void Awake()
    {
        for (int i = 0; i < SpawnPositions.Count; i++)
        {
            GameObject Pick = Instantiate(PickUpItem);

            Pick.GetComponent<PickUpItem>().SESoundManager = SESoundManager;
                
            Pick.transform.position = SpawnPositions[i].position;
            SpawnCount++;
        }


        // �~����SpawnCount�Ŋ������p�x
        // ���w�I�Ȍv�Z��p���ăQ�[���̕\�����������Ƃ���Mathf Unity�Ō�������Ƃ��������ł���
        float radian = Mathf.PI * 2 / SpawnCount;
        //  for(������,������)
        // �ui��0�Œ�`���āA0��SpawnCount�ɂȂ�܂�i�𑝂₵�Ă��������v
        for (int i = 0; i < SpawnCount; i++)
        {
            GameObject Pick = Instantiate(PickUpItem) ;
            // �V����Vector3���쐬���A��������PickUpItem��Position���� 
            Vector3 pos = Pick.transform.position;
            // Pos��z�̒l�ɉ~����y�̒l��SpawnCircleRadius�Ŋ|�����l����
            pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCircleRadius;
            // Pos��x�̒l�ɉ~����x�̒l��SpawnCircleRadius�Ŋ|�����l����
            pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCircleRadius;
            // ���߂�ꂽVector3�𐶐����ꂽPick��position�ɑ��
            Pick.transform.position = pos;
        }
    }
}
