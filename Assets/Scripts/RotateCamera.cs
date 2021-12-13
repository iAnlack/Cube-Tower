using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed = 10f; // �������� ��������
    private Transform _rotator; // ��������� ��� ��� ������������ ������ �����, ����������������� ��� ��������, ������������, ���������������

    private void Start()
    {
        _rotator = GetComponent<Transform>(); // ����������� ���������� ������ ���������� GameObject'�
    }

    private void Update()
    {
        _rotator.Rotate(0, speed * Time.deltaTime, 0); // ����� ��� "��������" ��� ������ �������, � ������� ����������� �������� �������� �� ������ ����.
    }

}
