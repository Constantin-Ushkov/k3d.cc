﻿
namespace k3d.CC.Data.Interface
{
    public interface IUserData
    {
        Guid ID { get; }
        string Name { get; set; }
        byte[] PasswordHash { get; set; }

        void Persist();
    }
}
