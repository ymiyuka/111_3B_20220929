using UnityEngine;

namespace YO
{
    /// <summary>
    /// �ǲ���� Learn Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // ��� Field�G�x�s���
        // �y�k
        // �׹��� ������� ���W�١F
        // �׹����G�]�w����v��
        // �p�H�Gprivate�A�Ȧb�����O������s��
        private int lv;

        // ���� ���w�Ÿ��G�N����k�䪺���G���w������
        // ���}�Gpublic�A�Ҧ����O������s���A���
        public int enemy = 5;
        //��� int 
        public int hp = 100;
        //�B�I�� float
        public float speed = 3.5f;
        //�r�� string
        public string nameplayer = "�U�w";
        public string content = "���o";
        //���L��
        public bool isPass = true;
        public bool isDead = false;
    }
}