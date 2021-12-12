using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Unity.Burst;
using Unity.Collections;
using UnityEngine.InputSystem;

    /*public class Player_Drive_System : SystemBase
    {
        Player_Controls pc;
        protected override void OnCreate()
        {
            pc = new Player_Controls();
            pc.VehicleMovement.Enable();
        }
        protected override void OnUpdate()
        {
            float hAxis = pc.VehicleMovement.CarMovement.ReadValue<Vector2>().x;
            float vAxis = pc.VehicleMovement.CarMovement.ReadValue<Vector2>().y;
            float spaceKey = pc.VehicleMovement.HandBreak.ReadValue<float>();
            float deltaTime = Time.DeltaTime;

            Entities.ForEach((ref Player_Drive_Component pdc) =>
            {
                pdc.currentSpeed = math.length(pdc.currentVelocity);
                pdc.speedParameter = pdc.maxMotorTorque * pdc.maxAcceleration * vAxis * (1 - (pdc.currentSpeed / pdc.maxSpeed));
                pdc.steerParameter = math.lerp(pdc.steerParameter, pdc.maxSteerAngle * hAxis, deltaTime*10);
                pdc.breakParameter = pdc.maxBreakTorque * spaceKey; 
            }).ScheduleParallel();
        }
    }*/












    public struct Player_Drive_System : ISystemBase, Player_Controls.IVehicleMovementActions
    {
        EntityQuery pdcQuery;
        static float2 player_Inputs;
        static float player_spaceKey;

        public void OnCreate(ref SystemState state)
        {
            Player_Controls pc = new Player_Controls();
            pc.Enable();
            pc.VehicleMovement.SetCallbacks(this);
            pdcQuery = state.GetEntityQuery(typeof(Player_Drive_Component));
        }

        public void OnUpdate(ref SystemState state)
        {
            ComponentTypeHandle<Player_Drive_Component> pdcHandle = state.GetComponentTypeHandle<Player_Drive_Component>();
            DriveJob dj = new DriveJob
            {
                pdc = pdcHandle,
                deltaTime = state.Time.DeltaTime,
                playerInputs = player_Inputs,
                playerSpaceKey = player_spaceKey
            };
            state.Dependency = dj.ScheduleParallel(pdcQuery, state.Dependency);
        }
        public void OnDestroy(ref SystemState state){}

        public void OnCarMovement(InputAction.CallbackContext context)
        {
            player_Inputs = context.ReadValue<Vector2>();
        }

        public void OnHandBreak(InputAction.CallbackContext context)
        {
            player_spaceKey = context.ReadValue<float>();
        }

        [BurstCompile]
        struct DriveJob : IJobChunk
        {
            public ComponentTypeHandle<Player_Drive_Component> pdc;
            public float deltaTime;
            public float2 playerInputs;
            public float playerSpaceKey;
            Player_Drive_Component pdcnew;

            public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
            {
                NativeArray<Player_Drive_Component> chunkDJ = chunk.GetNativeArray(pdc);
                for (int i = 0; i < chunk.Count; i++)
                {
                    pdcnew = new Player_Drive_Component();
                    pdcnew = chunkDJ[i];
                    pdcnew.currentSpeed = math.length(pdcnew.currentVelocity);
                    pdcnew.speedParameter = pdcnew.maxMotorTorque * pdcnew.maxAcceleration * playerInputs.y * (1 - (pdcnew.currentSpeed / pdcnew.maxSpeed));
                    pdcnew.steerParameter = math.lerp(pdcnew.steerParameter, pdcnew.maxSteerAngle * playerInputs.x, deltaTime * 10);
                    pdcnew.breakParameter = pdcnew.maxBreakTorque * playerSpaceKey;
                    chunkDJ[i] = pdcnew;
                }
            }
        }
    }

