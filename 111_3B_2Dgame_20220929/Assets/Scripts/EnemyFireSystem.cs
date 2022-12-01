
using UnityEngine;

namespace yo
{
    /// <summary>
    /// �ĤH�o�g�t��
    /// </summary>
    public class EnemyFireSystem : FireSystem
    {
        [SerializeField, Header("�ͦ��l�u�ɶ�"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            //�I�s��k
            //SpawnBullet();


        }

        private void OnBecameVisible()
        {
            //���𭫽ƩI�s("��k�W��"�A����ɶ��A�����W�v)
            InvokeRepeating("SpawnBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
