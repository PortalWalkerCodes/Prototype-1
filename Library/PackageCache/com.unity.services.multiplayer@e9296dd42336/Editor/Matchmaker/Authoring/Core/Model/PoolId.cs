using System;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.Core.Model
{
    readonly struct PoolId
    {
        internal PoolId(Guid id)
        {
            Id = id;
        }

        internal Guid Id { get; }

        internal bool IsEmpty() => Id == Guid.Empty;

        public override string ToString() => Id.ToString();
    }
}
