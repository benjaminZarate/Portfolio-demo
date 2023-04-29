using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowTargetCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _camera;
    private Transform _target;

    private void Awake()
    {
        CreateTarget();
    }

    public void CreateTarget() 
    {
        _target = Instantiate<Transform>(new GameObject().transform);
        _target.name = "target_camera";
        _target.position = this.transform.position;
        _camera.LookAt = _target;
        _camera.Follow = _target;
    }

    private void LateUpdate()
    {
        _target.position = this.transform.position;
    }
}
