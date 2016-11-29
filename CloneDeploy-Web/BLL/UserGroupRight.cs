﻿using System.Collections.Generic;

namespace BLL
{
    public static class UserGroupRight
    {
        //moved
        public static bool AddUserGroupRights(List<CloneDeploy_Web.Models.UserGroupRight> listOfRights)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                foreach (var right in listOfRights)
                    uow.UserGroupRightRepository.Insert(right);

                return uow.Save();
            }
        }

        //moved
        public static bool DeleteUserGroupRights(int userGroupId)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                uow.UserGroupRightRepository.DeleteRange(x => x.UserGroupId == userGroupId);
                return uow.Save();
            }
        }

        //moved
        public static List<CloneDeploy_Web.Models.UserGroupRight> Get(int userGroupId)
        {
            using (var uow = new DAL.UnitOfWork())
            {
                return uow.UserGroupRightRepository.Get(x => x.UserGroupId == userGroupId);
            }
        }
    }
}