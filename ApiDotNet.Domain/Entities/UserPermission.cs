﻿using ApiDotNet.Domain.Common;
using ApiDotNet.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Entities
{
    public sealed class UserPermission : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }

        public User User { get; set; }

        public Permission Permission { get; set; }

        public UserPermission(int userId, int permissionId)
        {
            Validation(userId, permissionId);
        }

        private void Validation(int userId, int permissionId)
        {
            DomainValidationException.When(userId == 0, "Id do usuário deve ser informado!");
            DomainValidationException.When(permissionId == 0, "Id da permissão deve ser informado!");
            UserId = userId;
            PermissionId = permissionId;
        }
    }
}