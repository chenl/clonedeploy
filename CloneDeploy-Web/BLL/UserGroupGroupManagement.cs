﻿using System.Collections.Generic;

namespace BLL
{
    public static class UserGroupGroupManagement
    {
        //moved
        public static bool AddUserGroupGroupManagements(List<CloneDeploy_Web.Models.UserGroupGroupManagement> listOfGroups)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                foreach (var group in listOfGroups)
                    uow.UserGroupGroupManagementRepository.Insert(group);

                return uow.Save();
            }
        }

        //moved
        public static bool DeleteUserGroupGroupManagements(int userGroupId)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                uow.UserGroupGroupManagementRepository.DeleteRange(x => x.UserGroupId == userGroupId);
                return uow.Save();
            }
        }

        //move not needed
        public static bool DeleteGroup(int groupId)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                uow.UserGroupGroupManagementRepository.DeleteRange(x => x.GroupId == groupId);
                return uow.Save();
            }
        }

        //moved
        public static List<CloneDeploy_Web.Models.UserGroupGroupManagement> Get(int userGroupId)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                return uow.UserGroupGroupManagementRepository.Get(x => x.UserGroupId == userGroupId);
            }
        }
    }
}