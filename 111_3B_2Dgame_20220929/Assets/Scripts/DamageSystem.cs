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

        //�I���}�l�ɰ���@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);

            //�p�G �I�쪺���~�W�� �]�t nameTarget �N�z���çR��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                // �ͦ��z���w�s�� �y�лP���� �򦹪��~�ۦP
                Instantiate(prefabExplosion, transform.position, transform.rotation);

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
