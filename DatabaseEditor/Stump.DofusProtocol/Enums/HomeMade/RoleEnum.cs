using System;

namespace Stump.DofusProtocol.Enums
{
    [Flags]
    public enum RoleEnum
    {
        None,
        Player,
        Moderator,
        GameMaster = 3,
        Administrator
        //Administrator
    }
}