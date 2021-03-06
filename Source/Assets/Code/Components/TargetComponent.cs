// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UnityEngine;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("b510e2c5-85e2-4b57-9df4-4b23ea50e7a7")]
    public partial class TargetComponent : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Int32 _Target;
        
        private Subject<PropertyChangedEvent<Int32>> _TargetObservable;
        
        private PropertyChangedEvent<Int32> _TargetEvent;
        
        public int ComponentID {
            get {
                return 4;
            }
        }
        
        public IObservable<PropertyChangedEvent<Int32>> TargetObservable {
            get {
                return _TargetObservable ?? (_TargetObservable = new Subject<PropertyChangedEvent<Int32>>());
            }
        }
        
        public Int32 Target {
            get {
                return _Target;
            }
            set {
                SetTarget(value);
            }
        }
        
        public virtual void SetTarget(Int32 value) {
            SetProperty(ref _Target, value, ref _TargetEvent, _TargetObservable);
        }
    }
}
