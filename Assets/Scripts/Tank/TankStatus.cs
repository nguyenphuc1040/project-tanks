using UnityEngine;
using System;

public class TankStatus : MonoBehaviour {
    [SerializeField] private TankComponent _tankComponent;
    public TankComponent TankComponent {get{return _tankComponent;}}
    
    public bool isRoot;
    public bool isStun;
    public bool isTimeStop;
    
    public void OnStun(){
        isStun = true;
        _tankComponent.TankShooting.enabled = false;
        _tankComponent.TankMovement.enabled = false;
        _tankComponent.TankWeapon.ResetWeapon();
    }
    public void OffStun(){
        isStun = false;
        _tankComponent.TankShooting.enabled = true;
        _tankComponent.TankMovement.enabled = true;
    }
    public void OffStunOnRoot(){
        isStun = false;
        _tankComponent.TankShooting.enabled = true;
    }
}