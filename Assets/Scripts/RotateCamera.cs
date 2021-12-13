using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed = 10f; // скорость вращения
    private Transform _rotator; // объявляем имя для специального класса Юнити, предназначенногло для вращения, передвижения, масштабирования

    private void Start()
    {
        _rotator = GetComponent<Transform>(); // присваиваем переменной взятие компонента GameObject'а
    }

    private void Update()
    {
        _rotator.Rotate(0, speed * Time.deltaTime, 0); // задаём тип "движения" для нашего объекта, в скобках указываются скорости вращения по разным осям.
    }

}
