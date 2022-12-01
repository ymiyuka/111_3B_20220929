
using UnityEngine;

namespace yo
{
    /// <summary>
    /// �o�g�t�ΰ�
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField,Header("�l�u�w�s��")]
        private GameObject prefaBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;
        [SerializeField, Header("�o�g����")]
        private AudioClip soundFire;

        // �ۭq��k
        // �ͦ��l�u
        // �O�@�ŧO : ���\�l���O�s��
        protected void SpawnBullet()
        {
            // ��Ҥ�(�l�u�ͦ��I�A�y�СB����)
            // �ͦ� �l�u�w�s�� �y�лP���׸�ͦ��I�ۦP
            Instantiate(prefaBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }

    }
}
