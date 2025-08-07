using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;

    public void Update()
    {
        // 获取摇杆输入
        float horizontalInput = variableJoystick.Horizontal;
        float verticalInput = variableJoystick.Vertical;

        // 创建移动方向向量
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // 应用移动
        transform.Translate(-movement, Space.World);
    }
}