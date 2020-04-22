// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/SB_Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e756cfdf-ad41-4d4b-881e-2a5f02d575a4"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ee283171-00eb-4a13-8e0a-e3b1605799ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""bcff62cd-6c3f-44d6-b4cf-7fdfba428abc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""3ec60f1f-4996-4180-81a6-aafc4be05885"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""9c6880b8-3ce3-4242-8b37-c782d8a20018"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriangleorY"",
                    ""type"": ""Button"",
                    ""id"": ""89329ad7-ec88-4cb5-966a-eab4fa1f634a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftStickPress"",
                    ""type"": ""Button"",
                    ""id"": ""1b5424db-6ed4-4b7a-b984-b01350989993"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftStickRelease"",
                    ""type"": ""Button"",
                    ""id"": ""53d94038-a388-44f4-bc16-bbae2aa8059c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ZoomIn"",
                    ""type"": ""Button"",
                    ""id"": ""e6da43fa-c174-4978-9c77-ddbec6fe99b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ZoomOut"",
                    ""type"": ""Button"",
                    ""id"": ""29947564-19b6-4529-82a5-ea33558f6cfe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""RightStickPress"",
                    ""type"": ""Button"",
                    ""id"": ""376e6faa-c008-468f-b1a1-aceaa0523745"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightStickRelease"",
                    ""type"": ""Button"",
                    ""id"": ""1114a8be-c4f7-49e0-844d-4de21905e28d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ShootIn"",
                    ""type"": ""Button"",
                    ""id"": ""d52dfb12-a90e-4ec6-a125-22ce7792281b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ShootOut"",
                    ""type"": ""Button"",
                    ""id"": ""63a7d865-b044-47b3-a1e5-828d092fbefc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""SendFollowerAway"",
                    ""type"": ""Button"",
                    ""id"": ""66dc79e7-6929-4d83-840f-a46ca597683c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SendFollowerAttack"",
                    ""type"": ""Button"",
                    ""id"": ""333a71ff-cca0-4d11-b118-4547427d77f8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ScrollWeaponUp"",
                    ""type"": ""Button"",
                    ""id"": ""6c26f30d-e17a-432f-90b9-45d47bcea497"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ScrollWeaponDown"",
                    ""type"": ""Button"",
                    ""id"": ""7f22ea9e-49e5-42f5-8298-b09eafe84194"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9c4a24df-6a1d-424a-bf2c-66f111aef332"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0610c1bb-1a9f-401e-8f11-7502359c8830"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e10030-0259-4cc4-a0d8-1bc3e3cad3bd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""899ef907-0bb8-4244-9ead-ee81cecf9a43"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23d305dd-a5da-4224-abfa-35766d688697"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51124947-cc57-45c3-b21a-1708313f1a02"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b6a294d-ee8c-4ada-a634-3dfc6865abe3"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriangleorY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fdb909c-4a9b-44e6-b534-bfc82b61ddab"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriangleorY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19855d96-1ecf-4c41-894f-b84f931657c5"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7bf6cac-ead9-4b3a-8bd6-d48ef33f5814"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ea05b549-599c-453f-b804-bc56f389e7a7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d3c6e5c0-8bf1-467a-b63a-e1520a56c547"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c82e7d64-73c3-489c-977c-1aa62c0e9a41"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e569dc1d-4ec6-4f21-bfa2-76cc7e935db8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""641f39d2-e315-470d-94c2-d7f17304ab1b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""73af686a-d3a2-40f4-8822-00c698b15b55"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a8b761d-ad6b-4955-aaa1-e8b98179ba65"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5636b621-a925-4e7b-9c09-12125990f2b1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16cb38de-4ccc-4c1d-a91d-e6c049ae936a"",
                    ""path"": ""<DualShockGamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3861a7b3-9039-4e39-93cb-1e25f41bfa8e"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f16b21ec-7a48-44ef-b380-e8fb49a0233b"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b68ae31d-b856-4363-a3cd-af6890902eda"",
                    ""path"": ""<DualShockGamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32d638fa-c830-42c1-809c-80e157087198"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0c29169-0190-4dcf-961b-e9c048365db1"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bb8fcac-b26c-4bca-b06d-1cd1fff8892c"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25e90e18-9d17-4915-9fdf-0b37fb53f951"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74f80750-effd-4cda-82be-d1d6d6d6146d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7b0a838-015b-474e-a706-f391320a65c1"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca8c1654-c640-4010-b234-7b115eb25579"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d4ab44d-3880-45f5-9a16-6f3695f62728"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e87bdc67-0964-425c-ab4c-cd1226e9980e"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebce9f87-edab-4ff1-89a1-6afa64e4cbfe"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""365ba84f-5432-4f42-b4c3-565fda2170a8"",
                    ""path"": ""<DualShockGamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""539dc77d-af9f-46b0-a199-62f8964604bf"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad362e06-1dc0-47e7-90bb-7aafe86baa3a"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d51b7d4-cf75-4e2f-b8a4-cb203da5653e"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5bd8360-30c3-4fe5-9477-b95750dec9e4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a8ceb29-7e6f-4c23-a859-3f9929c1b92d"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""872145b7-cd13-4ba6-a917-1b6dcfc1c0a4"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c94a9da-5f1f-4729-8e17-1c3b18960a0e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ef78542-47ec-4070-8478-852732431e2f"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendFollowerAway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06b92435-19da-4a1d-9278-36385b415d76"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendFollowerAway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb07ebf7-9552-4a7a-8cc9-64bad822dbe8"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendFollowerAway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4513531-d1a1-44f4-9f80-80b9ad93c3a6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendFollowerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""149e88b4-77ce-4c67-b029-15775ced107c"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendFollowerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a85cc363-a0ca-4f56-84f5-ab89b215f763"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendFollowerAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d228151-984c-4288-8a78-ea4b5e0056c3"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWeaponUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4d512ef-3174-4ced-a5d2-aebb25f5c4aa"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWeaponUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d2a9793-458b-4055-9202-92d69bc898b8"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWeaponDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a333e7d-fcb0-4821-bd30-93ca388db4d9"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWeaponDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd330e40-115f-4170-bac5-2242ce097cf4"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWeaponDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Rotation = m_Player.FindAction("Rotation", throwIfNotFound: true);
        m_Player_Interaction = m_Player.FindAction("Interaction", throwIfNotFound: true);
        m_Player_TriangleorY = m_Player.FindAction("TriangleorY", throwIfNotFound: true);
        m_Player_LeftStickPress = m_Player.FindAction("LeftStickPress", throwIfNotFound: true);
        m_Player_LeftStickRelease = m_Player.FindAction("LeftStickRelease", throwIfNotFound: true);
        m_Player_ZoomIn = m_Player.FindAction("ZoomIn", throwIfNotFound: true);
        m_Player_ZoomOut = m_Player.FindAction("ZoomOut", throwIfNotFound: true);
        m_Player_RightStickPress = m_Player.FindAction("RightStickPress", throwIfNotFound: true);
        m_Player_RightStickRelease = m_Player.FindAction("RightStickRelease", throwIfNotFound: true);
        m_Player_ShootIn = m_Player.FindAction("ShootIn", throwIfNotFound: true);
        m_Player_ShootOut = m_Player.FindAction("ShootOut", throwIfNotFound: true);
        m_Player_SendFollowerAway = m_Player.FindAction("SendFollowerAway", throwIfNotFound: true);
        m_Player_SendFollowerAttack = m_Player.FindAction("SendFollowerAttack", throwIfNotFound: true);
        m_Player_ScrollWeaponUp = m_Player.FindAction("ScrollWeaponUp", throwIfNotFound: true);
        m_Player_ScrollWeaponDown = m_Player.FindAction("ScrollWeaponDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Rotation;
    private readonly InputAction m_Player_Interaction;
    private readonly InputAction m_Player_TriangleorY;
    private readonly InputAction m_Player_LeftStickPress;
    private readonly InputAction m_Player_LeftStickRelease;
    private readonly InputAction m_Player_ZoomIn;
    private readonly InputAction m_Player_ZoomOut;
    private readonly InputAction m_Player_RightStickPress;
    private readonly InputAction m_Player_RightStickRelease;
    private readonly InputAction m_Player_ShootIn;
    private readonly InputAction m_Player_ShootOut;
    private readonly InputAction m_Player_SendFollowerAway;
    private readonly InputAction m_Player_SendFollowerAttack;
    private readonly InputAction m_Player_ScrollWeaponUp;
    private readonly InputAction m_Player_ScrollWeaponDown;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Rotation => m_Wrapper.m_Player_Rotation;
        public InputAction @Interaction => m_Wrapper.m_Player_Interaction;
        public InputAction @TriangleorY => m_Wrapper.m_Player_TriangleorY;
        public InputAction @LeftStickPress => m_Wrapper.m_Player_LeftStickPress;
        public InputAction @LeftStickRelease => m_Wrapper.m_Player_LeftStickRelease;
        public InputAction @ZoomIn => m_Wrapper.m_Player_ZoomIn;
        public InputAction @ZoomOut => m_Wrapper.m_Player_ZoomOut;
        public InputAction @RightStickPress => m_Wrapper.m_Player_RightStickPress;
        public InputAction @RightStickRelease => m_Wrapper.m_Player_RightStickRelease;
        public InputAction @ShootIn => m_Wrapper.m_Player_ShootIn;
        public InputAction @ShootOut => m_Wrapper.m_Player_ShootOut;
        public InputAction @SendFollowerAway => m_Wrapper.m_Player_SendFollowerAway;
        public InputAction @SendFollowerAttack => m_Wrapper.m_Player_SendFollowerAttack;
        public InputAction @ScrollWeaponUp => m_Wrapper.m_Player_ScrollWeaponUp;
        public InputAction @ScrollWeaponDown => m_Wrapper.m_Player_ScrollWeaponDown;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Interaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @TriangleorY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriangleorY;
                @TriangleorY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriangleorY;
                @TriangleorY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTriangleorY;
                @LeftStickPress.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStickPress;
                @LeftStickPress.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStickPress;
                @LeftStickPress.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStickPress;
                @LeftStickRelease.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStickRelease;
                @LeftStickRelease.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStickRelease;
                @LeftStickRelease.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftStickRelease;
                @ZoomIn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomIn;
                @ZoomIn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomIn;
                @ZoomIn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomIn;
                @ZoomOut.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomOut;
                @ZoomOut.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomOut;
                @ZoomOut.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoomOut;
                @RightStickPress.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightStickPress;
                @RightStickRelease.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightStickRelease;
                @RightStickRelease.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightStickRelease;
                @RightStickRelease.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightStickRelease;
                @ShootIn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootIn;
                @ShootIn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootIn;
                @ShootIn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootIn;
                @ShootOut.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootOut;
                @ShootOut.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootOut;
                @ShootOut.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootOut;
                @SendFollowerAway.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSendFollowerAway;
                @SendFollowerAway.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSendFollowerAway;
                @SendFollowerAway.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSendFollowerAway;
                @SendFollowerAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSendFollowerAttack;
                @SendFollowerAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSendFollowerAttack;
                @SendFollowerAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSendFollowerAttack;
                @ScrollWeaponUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeaponUp;
                @ScrollWeaponUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeaponUp;
                @ScrollWeaponUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeaponUp;
                @ScrollWeaponDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeaponDown;
                @ScrollWeaponDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeaponDown;
                @ScrollWeaponDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWeaponDown;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @TriangleorY.started += instance.OnTriangleorY;
                @TriangleorY.performed += instance.OnTriangleorY;
                @TriangleorY.canceled += instance.OnTriangleorY;
                @LeftStickPress.started += instance.OnLeftStickPress;
                @LeftStickPress.performed += instance.OnLeftStickPress;
                @LeftStickPress.canceled += instance.OnLeftStickPress;
                @LeftStickRelease.started += instance.OnLeftStickRelease;
                @LeftStickRelease.performed += instance.OnLeftStickRelease;
                @LeftStickRelease.canceled += instance.OnLeftStickRelease;
                @ZoomIn.started += instance.OnZoomIn;
                @ZoomIn.performed += instance.OnZoomIn;
                @ZoomIn.canceled += instance.OnZoomIn;
                @ZoomOut.started += instance.OnZoomOut;
                @ZoomOut.performed += instance.OnZoomOut;
                @ZoomOut.canceled += instance.OnZoomOut;
                @RightStickPress.started += instance.OnRightStickPress;
                @RightStickPress.performed += instance.OnRightStickPress;
                @RightStickPress.canceled += instance.OnRightStickPress;
                @RightStickRelease.started += instance.OnRightStickRelease;
                @RightStickRelease.performed += instance.OnRightStickRelease;
                @RightStickRelease.canceled += instance.OnRightStickRelease;
                @ShootIn.started += instance.OnShootIn;
                @ShootIn.performed += instance.OnShootIn;
                @ShootIn.canceled += instance.OnShootIn;
                @ShootOut.started += instance.OnShootOut;
                @ShootOut.performed += instance.OnShootOut;
                @ShootOut.canceled += instance.OnShootOut;
                @SendFollowerAway.started += instance.OnSendFollowerAway;
                @SendFollowerAway.performed += instance.OnSendFollowerAway;
                @SendFollowerAway.canceled += instance.OnSendFollowerAway;
                @SendFollowerAttack.started += instance.OnSendFollowerAttack;
                @SendFollowerAttack.performed += instance.OnSendFollowerAttack;
                @SendFollowerAttack.canceled += instance.OnSendFollowerAttack;
                @ScrollWeaponUp.started += instance.OnScrollWeaponUp;
                @ScrollWeaponUp.performed += instance.OnScrollWeaponUp;
                @ScrollWeaponUp.canceled += instance.OnScrollWeaponUp;
                @ScrollWeaponDown.started += instance.OnScrollWeaponDown;
                @ScrollWeaponDown.performed += instance.OnScrollWeaponDown;
                @ScrollWeaponDown.canceled += instance.OnScrollWeaponDown;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnTriangleorY(InputAction.CallbackContext context);
        void OnLeftStickPress(InputAction.CallbackContext context);
        void OnLeftStickRelease(InputAction.CallbackContext context);
        void OnZoomIn(InputAction.CallbackContext context);
        void OnZoomOut(InputAction.CallbackContext context);
        void OnRightStickPress(InputAction.CallbackContext context);
        void OnRightStickRelease(InputAction.CallbackContext context);
        void OnShootIn(InputAction.CallbackContext context);
        void OnShootOut(InputAction.CallbackContext context);
        void OnSendFollowerAway(InputAction.CallbackContext context);
        void OnSendFollowerAttack(InputAction.CallbackContext context);
        void OnScrollWeaponUp(InputAction.CallbackContext context);
        void OnScrollWeaponDown(InputAction.CallbackContext context);
    }
}
