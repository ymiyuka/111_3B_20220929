using UnityEngine;

namespace yo
{
    /// <summary>
    /// �R������
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destryTime = 0.4f;

        private void Awake()
        {
            //gameObject ���}�����C������
            //�R��(����B�R���ɶ�)
            Destroy(gameObject, destryTime);
        }

        //�i���ƥ� : ���V���� (Randerer) �X�{�b Scene �� Game �ɰ���@��
        private void OnBecameVisible()
        {
            
        }

        //���i������ ���V���� (Randerer) �����b Scene �� Game �ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
