using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    // �v���C���[��Rigitbody
    private Rigidbody playerRigidbody;
    // �y���K���zfloat�^�̕ϐ�Speed��public�Œ�`����
    public float Speed = 1f;

    // GameState���Q�Ƃ���
    public GameState GameState;

    // GameResultViewer���Q�Ƃ���
    public GameResultViewer GameResultViewer;
       
    // Start is called before the first frame update
    void Start()
    {
        // �v���C���[��RigitBody���A�^�b�`����GameObject����擾���܂�
        playerRigidbody = GetComponent<Rigidbody>();
        // �y���K���zvoid Start �̒���Speed��2f��������
        // f�͕��������_�i�����ȊO�̎����j�^���������ߖ����ɕt���Ă���@
        // �Ⴆ��2.5���ƃh�b�g�Ə����_�̋�ʂ������G���[�ɂȂ�@������2.5f �Ɠ��͂��� Speed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        // ���̍�����艺�ɂȂ�����Q�[���I�[�o�[
        if (this.transform.position.y < -1)
        {
            GameState.SetGameProgressState( GameState.GameProgressStates.GameResult);
            GameResultViewer.ResultText.text = "Game Over";
            return;
        }


        // vector3�^�̕ϐ�move�Ɂi���E�L�[,0,�㉺�L�[�j�̒l�������܂�
        var move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        // playerRigidbody��move�����̗͂������܂�
        // �y���K���zmove��Speed���|����i���Z�q * �j
        playerRigidbody.AddForce(move * Speed);
    }
}
