using UnityEngine;

namespace yo
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosion;
        [SerializeField, Header("�I��|�z�����W��")]
        private string nameTarget;
        [Header("���˻P�z������")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        //�I���}�l�ɰ���@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);

            //�p�G �I�쪺���~�W�� �]�t nameTarget �N�z���çR��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                // �ͦ��z���w�s�� �y�лP���� �򦹪��~�ۦP
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                // �R�� Destroy
                // ������ gameObject
                Destroy(gameObject);
            }
        }
        //�I�����}�ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        //�I���������
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}
