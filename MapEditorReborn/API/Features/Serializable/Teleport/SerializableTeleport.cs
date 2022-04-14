﻿namespace MapEditorReborn.API.Features.Serializable.Teleport
{
    using System.Collections.Generic;
    using Enums;

    public class SerializableTeleport : SchematicBlockData
    {
        public List<TargetTeleporter> TargetTeleporters { get; set; }

        public List<string> AllowedRoles { get; set; }

        public float Cooldown { get; set; }

        public TeleportFlags TeleportFlags { get; set; }

        public LockOnEvent LockOnEvent { get; set; }

        public float? PlayerRotationX { get; set; }

        public float? PlayerRotationY { get; set; }
    }
}
