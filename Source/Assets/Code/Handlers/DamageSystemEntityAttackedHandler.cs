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
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class DamageSystemEntityAttackedHandler {
        
        public AttackingEntity Attacker;
        
        public DefendingEntity Defender;
        
        private ECSDemo.EntityAttacked _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private int ActionNode6_a = default( System.Int32 );
        
        private int ActionNode6_b = default( System.Int32 );
        
        private int ActionNode6_Result = default( System.Int32 );
        
        private object ActionNode7_message = default( System.Object );
        
        private string StringNode8 = "DamageSystem - Entity health changed.";
        
        private ECSDemo.HealthChanged PublishEventNode9_Result = default( ECSDemo.HealthChanged );
        
        public ECSDemo.EntityAttacked Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode6_a = Defender.HealthComponent.Health;
            ActionNode6_b = Attacker.AttackComponent.Damage;
            // ActionNode
            while (this.DebugInfo("c3a09036-50e1-4ac7-a9d4-a7834ee5ec37","a010da49-1016-4be7-af66-635fb9568f51", this) == 1) yield return null;
            // Visit uFrame.Actions.IntLibrary.Subtract
            ActionNode6_Result = uFrame.Actions.IntLibrary.Subtract(ActionNode6_a, ActionNode6_b);
            // SetVariableNode
            while (this.DebugInfo("a010da49-1016-4be7-af66-635fb9568f51","16b8d1d5-e7f3-4b3c-82c0-ffdb0700577a", this) == 1) yield return null;
            Defender.HealthComponent.Health = (System.Int32)ActionNode6_Result;
            ActionNode7_message = StringNode8;
            // ActionNode
            while (this.DebugInfo("16b8d1d5-e7f3-4b3c-82c0-ffdb0700577a","ac96668a-7e2c-476d-afa5-b264faa1e1cf", this) == 1) yield return null;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode7_message);
            // PublishEventNode
            while (this.DebugInfo("ac96668a-7e2c-476d-afa5-b264faa1e1cf","bd50d6fa-13a8-4a2a-bfa2-e0edc11d9af1", this) == 1) yield return null;
            var PublishEventNode9_Event = new HealthChanged();
            PublishEventNode9_Event.Health = Defender.HealthComponent.Health;
            PublishEventNode9_Event.Entity = Event.Defender;
            System.Publish(PublishEventNode9_Event);
            PublishEventNode9_Event = PublishEventNode9_Result;
            yield break;
        }
    }
}
